using System.Collections.Generic;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace LifeProj
{
    public class Field
    {
        public List<Cell> Cells;
        public List<Vector2> CellsPositions;
        public int IterationsCount;
        public bool IsLockdown;
        public int LockdownDuration;
        public int DeathByAgeCellsCount;
        public int DeathByInfectionCellsCount;

        public Field()
        {
            Cells = new List<Cell>();
            CellsPositions = new List<Vector2>();
            IterationsCount = 0;
            IsLockdown = false;
            LockdownDuration = 0;
            DeathByAgeCellsCount = 0;
            DeathByInfectionCellsCount = 0;
        }

        public void Reset()
        {
            Cells.Clear();
            CellsPositions.Clear();
            IterationsCount = 0;
            IsLockdown = false;
            LockdownDuration = 0;
            DeathByAgeCellsCount = 0;
            DeathByInfectionCellsCount = 0;
        }

        public void Init()
        {
            foreach (var x in Enumerable.Range(0, Simulation.FieldWidth))
            {
                foreach (var y in Enumerable.Range(0, Simulation.FieldHeight))
                    CellsPositions.Add(new Vector2(x,y));
            }
            
            foreach (var position in CellsPositions.OrderBy(x => ThreadSafeRandom.Next()).Take(Simulation.OnInitCellsCount))
                Cells.Add(new Cell(
                    Simulation.GenAge(),
                    Simulation.GenLifespan(),
                    Simulation.GenImmunity(),
                    CellState.Healthy,
                    Simulation.GenSex(),
                    position,
                    Simulation.GenDirection(),
                    this));

            foreach (var cell in Cells.OrderBy(x => ThreadSafeRandom.Next()).Take(Simulation.OnInitInfectedCellsCount))
                cell.State = CellState.Infected;
        }

        public int GetInfectedCellsCount()
        {
            return Cells.FindAll(x => x.State == CellState.Infected).Count;
        }

        public int GetIncubationCellsCount()
        {
            return Cells.FindAll(x => x.State == CellState.Incubation).Count;
        }
        
        public int GetRecoveredCellsCount()
        {
            return Cells.FindAll(x => x.State == CellState.Recovered).Count;
        }
        
        public int GetHealthyCellsCount()
        {
            return Cells.FindAll(x => x.State == CellState.Healthy).Count;
        }

        public int GetCellsCount()
        {
            return Cells.Count;
        }

        public int GetMaleCellsCount()
        {
            return Cells.FindAll(x => x.Sex == CellSex.Male).Count;
        }
        
        public int GetFemaleCellsCount()
        {
            return Cells.FindAll(x => x.Sex == CellSex.Female).Count;
        }

        public int GetDeathByAgeCellsCount()
        {
            return DeathByAgeCellsCount;
        }
        
        public int GetDeathByInfectionCellsCount()
        {
            return DeathByInfectionCellsCount;
        }
        
        public int GetIsolatedCellsCount()
        {
            return Cells.FindAll(x => x.State == CellState.Isolated).Count;
        }
        

        void SpawnCell()
        {
            Cells.Add(new Cell(
                0,
                Simulation.GenLifespan(),
                Simulation.GenImmunity(),
                CellState.Healthy,
                Simulation.GenSex(),
                CellsPositions[Simulation.NextInt(0, CellsPositions.Count)],
                Simulation.GenDirection(),
                this));
        }

        public void NextIter()
        {
            IterationsCount += 1;
            Parallel.ForEach(Cells.ToArray(), IterCell);

            foreach (var cell in Cells.ToArray())
            {
                if (cell.State == CellState.DeathByInfection)
                {
                    Cells.Remove(cell);
                    DeathByInfectionCellsCount++;
                }

                if (cell.State == CellState.DeathByAge)
                {
                    Cells.Remove(cell);
                    DeathByAgeCellsCount++;
                }
            }

            if (IsLockdown == false)
            {
                if ((double)GetInfectedCellsCount() / Cells.Count > Simulation.LockdownInfectedRate)
                {
                    IsLockdown = true;
                    LockdownDuration = Simulation.LockdownDuration;
                }
            }
            else
            {
                foreach (var cell in Cells.FindAll(x => x.State == CellState.Infected).Take(Simulation.MedicinePlacesCount - GetIsolatedCellsCount()))
                    cell.State = CellState.Isolated;
                
                if (--LockdownDuration == 0)
                    IsLockdown = false;
            }
        }

        private void IterCell(Cell cell)
        {
            if(cell.State == CellState.DeathByInfection || cell.State == CellState.DeathByAge)
                return;
            
            cell.NextIter();

            if (cell.State == CellState.Isolated)
                return;

            foreach (var otherCell in Cells.ToArray())
            {
                if (otherCell == cell)
                    continue;

                if (otherCell == null)
                    continue;

                if (otherCell.State == CellState.Isolated)
                    continue;

                if(cell.State == CellState.DeathByInfection || cell.State == CellState.DeathByAge)
                    continue;

                if (Math.Abs(cell.Position.X - otherCell.Position.X) >= cell.Radius + otherCell.Radius)
                    continue;

                if (Math.Abs(cell.Position.Y - otherCell.Position.Y) >= cell.Radius + otherCell.Radius)
                    continue;

                var normal = cell.Position - otherCell.Position;
                var distSquared = normal.LengthSquared();
                var lenPow = (cell.Radius + otherCell.Radius) * (cell.Radius + otherCell.Radius);

                if (cell.LastCollided == otherCell)
                {
                    if (distSquared - lenPow < 0)
                        continue;

                    cell.LastCollided = null;
                }

                if (distSquared < Simulation.DistanceOfInfectingPow)
                    cell.ProcessInfecting(otherCell);

                if (distSquared < Simulation.DistanceOfCoitusPow)
                {
                    if(cell.ProcessCoitus(otherCell))
                        SpawnCell();
                }

                if (distSquared - lenPow < 0)
                    cell.ReflectDirection(normal, otherCell);
            }
        }
    }
}