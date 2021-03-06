using System;
using System.Numerics;
using System.Drawing;
using System.Windows.Forms;

namespace LifeProj
{
    public enum  CellState
    {
        Healthy,
        Incubation,
        Infected,
        Recovered,
        Isolated,
        DeathByInfection,
        DeathByAge
    }

    public enum CellSex
    {
        Male,
        Female
    }
    public class Cell
    {
        public int Age;
        public int Lifespan;
        public int IncubationPeriod;
        public int InfectionPeriod;
        public double Immunity;
        public CellSex Sex;
        public CellState State;
        public int LastCoitus;
        public int CoitusRelaxation;
        public Cell LastCoitusCell;
        
        public Vector2 Position;
        public Vector2 Direction;
        public double Velocity;
        public double Radius;
        public Cell LastCollided;

        public Field Parent;

        public Cell(int age, int lifespan, double immunity, CellState state, CellSex sex,
            Vector2 position, Vector2 direction, Field parent)
        {
            Parent = parent;
            
            Age = age;
            Lifespan = lifespan;
            Immunity = immunity;
            IncubationPeriod = 0;
            InfectionPeriod = 0;
            Sex = sex;
            State = state;
            LastCoitus = 0;
            CoitusRelaxation = Simulation.NextInt(Simulation.CoitusRelaxationMin, Simulation.CoitusRelaxationMax);

            LastCoitusCell = null;

            Position = position;
            Direction = direction;
            Velocity = CalcVelocity();
            Radius = Simulation.CalcRadiusByAge(Age, Lifespan);
            LastCollided = null;
        }
        public double CalcVelocity()
        {
            if (State == CellState.Infected)
                return Simulation.VelocityMin;
            
            if (Parent.IsLockdown)
                return Simulation.CalcVelocityByAge(Age, Lifespan) * (1.0 - Simulation.LockdownSlowdown);
            else
                return Simulation.CalcVelocityByAge(Age, Lifespan);
        }

        public void NextIter()
        {
            Age++;

            if (Age >= Lifespan)
            {
                State = CellState.DeathByAge;
                return;
            }

            if (State == CellState.Incubation && --IncubationPeriod == 0)
            {
                State = CellState.Infected;
                InfectionPeriod = Simulation.NextInt(Simulation.InfectionPeriodMin, Simulation.InfectionPeriodMax);
            } else if ((State == CellState.Infected || State == CellState.Isolated) && --InfectionPeriod == 0)
            {
                Lifespan -= Simulation.InfectedAgeDecrementer;
                if (Simulation.NextDouble(0.0, 1.0) < Simulation.CalcChanceOfDeathByAge(Age, Lifespan) * 
                    (State == CellState.Isolated ? (1.0 - Simulation.MedicineEfficiency) : 1.0))
                {
                    State = CellState.DeathByInfection;
                    return;
                }

                State = CellState.Recovered;
            }
            
            Radius = Simulation.CalcRadiusByAge(Age, Lifespan);
            
            if (State == CellState.Isolated)
                return;
            
            Velocity = CalcVelocity();
            Position += Direction * (float)Velocity;
            
            if (Position.X + Radius > Simulation.FieldWidth)
                Direction.X = -Math.Abs(Direction.X);
            else if (Position.X - Radius < 0)
                Direction.X = Math.Abs(Direction.X);

            if (Position.Y + Radius > Simulation.FieldHeight)
                Direction.Y = -Math.Abs(Direction.Y);
            else if (Position.Y - Radius < 0)
                Direction.Y = Math.Abs(Direction.Y);
        }

        public void ReflectDirection(Vector2 normal, Cell collidedCell)
        {
            Position -= Direction * (float)Velocity;
            Direction = Vector2.Normalize(Vector2.Reflect(Direction, normal));
            LastCollided = collidedCell;
        }

        public void ProcessInfecting(Cell cell)
        {
            if (cell.State != CellState.Infected || cell.State == CellState.Incubation)
                return;
            
            if (State != CellState.Healthy)
                return;

            if (Simulation.NextDouble(0.0, 1.0) * (1.0 - Immunity + (Parent.IsLockdown ? Simulation.VaccinationBoost : 0.0))
                < Simulation.CalcChanceOfInfectingByAge(Age, Lifespan))
            {
                State = CellState.Incubation;
                IncubationPeriod = Simulation.NextInt(Simulation.IncubationPeriodMin, Simulation.IncubationPeriodMax);
            }
        }

        public bool ProcessCoitus(Cell cell)
        {
            if (Sex == cell.Sex)
                return false;

            if (LastCoitusCell == cell)
                return false;

            if (Age - LastCoitus < CoitusRelaxation || cell.Age - cell.LastCoitus < cell.CoitusRelaxation)
                return false;

            if (Simulation.NextDouble(0.0, 1.0) < Simulation.ChanceOfBirth *
                (1.0 - (double)Parent.Cells.Count / Simulation.CellsCountMax))
            {
                LastCoitus = Age;
                CoitusRelaxation = Simulation.NextInt(Simulation.CoitusRelaxationMin, Simulation.CoitusRelaxationMax);
                LastCoitusCell = cell;
            
                cell.LastCoitus = cell.Age;
                cell.CoitusRelaxation = Simulation.NextInt(Simulation.CoitusRelaxationMin, Simulation.CoitusRelaxationMax);
                cell.LastCoitusCell = this;
                return true;
            }

            return false;
        }
    }
}