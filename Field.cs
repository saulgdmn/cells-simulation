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
        public int IterationsCount;

        public Field()
        {
            Cells = new List<Cell>();
            IterationsCount = 0;
            GenCellsPositions();
        }

        void GenCellsPositions()
        {
            Cells.Clear();
            
            List<Vector2> positions = new List<Vector2>();
            foreach (var x in Enumerable.Range(0, Simulation.FieldWidth))
            {
                foreach (var y in Enumerable.Range(0, Simulation.FieldHeight))
                    positions.Add(new Vector2(x,y));
            }
            
            foreach (var position in positions.OrderBy(x => Simulation.Rand.Next()).Take(Simulation.OnInitCellsCount))
            {
                Cells.Add(new Cell(
                    Simulation.GenAge(),
                    Simulation.GenLifespan(),
                    Simulation.GenImmunity(),
                    CellState.Healthy,
                    Simulation.GenSex(),
                    position,
                    Vector2.Normalize(new Vector2((float)Simulation.NextDouble(-100.0, 100.0), (float)Simulation.NextDouble(-100.0, 100.0)))
                ));
            }

            foreach (var cell in Cells.OrderBy(x => Simulation.Rand.Next()).Take(Simulation.OnInitInfectedCellsCount))
                cell.State = CellState.Infected;
        }

        void SpawnCell()
        {
            
        }

        public void NextIter()
        {
            IterationsCount += 1;

            //foreach (var cell in Cells.ToArray())
                //cell.NextIter();

            //foreach(var cell in Cells.ToArray())
            //    IterCell(cell);

            Parallel.ForEach(Cells, IterCell);

            foreach (var cell in Cells.ToArray())
            {
                if(cell.State == CellState.Died)
                    Cells.Remove(cell);
            }
        }
        
        private void IterCell(Cell cell)
        {
            if(cell.State == CellState.Died)
                return;
            
            cell.NextIter();

            if (cell.State == CellState.Isolated)
            {
                
            }

            foreach (var otherCell in Cells)
            {
                if (otherCell == cell)
                    continue;
                
                if(otherCell.State == CellState.Died)
                    continue;
                
                if(Math.Abs(cell.Position.X - otherCell.Position.X) >= cell.Radius + otherCell.Radius)
                    continue;
                    
                if(Math.Abs(cell.Position.Y - otherCell.Position.Y) >= cell.Radius + otherCell.Radius)
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
                
                if(distSquared < Simulation.DistanceOfInfectingPow)
                    cell.ProcessInfecting(otherCell);

                if (distSquared - lenPow < 0)
                {
                    cell.ReflectDirection(normal, otherCell);
                    cell.ProcessInfecting(otherCell);
                    if(cell.ProcessCoitus(otherCell))
                        SpawnCell();

                }
            }
        }
    }
}