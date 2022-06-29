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
        Died,
        Isolated
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
        public int Incubation;
        public double Immunity;
        public CellSex Sex;
        public CellState State;
        public Cell LastPartner;
        public int LastCoitus;
        public bool IsIsolated;
        public bool IsRestricted;

        public Vector2 Position;
        public Vector2 Direction;
        public double Velocity;
        public double Radius;
        public Cell LastCollided;

        public Cell(int age, int lifespan, double immunity, CellState state, CellSex sex, Vector2 position, Vector2 direction)
        {
            Age = age;
            Lifespan = lifespan;
            Immunity = immunity;
            Incubation = 0;
            Sex = sex;
            State = state;
            LastPartner = null;
            LastCoitus = 0;
            IsRestricted = false;

            Position = position;
            Direction = direction;
            Velocity = CalcVelocity();
            Radius = Simulation.CalcRadiusByAge(Age);
            LastCollided = null;
        }
        public double CalcVelocity()
        {
            if (State == CellState.Infected)
                return Simulation.VelocityMin;
            
            if (IsRestricted)
                return Simulation.CalcVelocityByAge(Age) * Simulation.LockdownSlowdown;
            else
                return Simulation.CalcVelocityByAge(Age);
        }

        public void NextIter()
        {
            Age++;

            if (Age >= Lifespan)
            {
                State = CellState.Died;
                return;
            }

            if (State == CellState.Incubation)
            {
                Incubation--;
                if(Incubation == 0)
                    State = CellState.Infected;
            }

            if (State == CellState.Incubation || State == CellState.Infected)
            {
                if(Simulation.NextDouble(0.0, 1.0) < Simulation.ChanceOfRecovering)
                    State = CellState.Recovered;
            }
            

            if (State == CellState.Infected)
            {
                Velocity = Simulation.VelocityMin;
                Lifespan -= Simulation.InfectedAgeDecrementer;
                if (Simulation.NextDouble(0.0, 1.0) < Simulation.ChanceOfDeath)
                {
                    State = CellState.Died;
                    return;
                }
            }
            else
                Velocity = CalcVelocity();

            if (IsRestricted)
                Velocity *= Simulation.LockdownSlowdown;
            
            Radius = Simulation.CalcRadiusByAge(Age);
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

            if (Simulation.NextDouble(0.0, 1.0) * (1.0 - Immunity) < Simulation.CalcChanceOfInfectingByAge(Age))
            {
                State = CellState.Incubation;
                Incubation = Simulation.NextInt(Simulation.IncubationPeriodMin, Simulation.IncubationPeriodMax);
            }
        }

        public bool ProcessCoitus(Cell cell)
        {
            if (Sex == cell.Sex)
                return false;

            if (Age - LastCoitus < Simulation.CoitusRelaxation ||
                cell.Age - cell.LastCoitus < Simulation.CoitusRelaxation)
                return false;

            if (Simulation.NextDouble(0.0, 1.0) > Simulation.ChanceOfBirth)
                return false;
            
            LastCoitus = Age;
            cell.LastCoitus = cell.Age; 
            return true;
        }
    }
}