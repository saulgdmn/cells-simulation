using System;
using System.Drawing;
using System.Numerics;



namespace LifeProj
{
    public class ThreadSafeRandom
    {
        private static readonly Random _global = new Random();
        [ThreadStatic] private static Random _local;

        public int Next()
        {
            if (_local == null)
            {
                int seed;
                lock (_global)
                {
                    seed = _global.Next();
                }
                _local = new Random(seed);
            }

            return _local.Next();
        }
        
        public int Next(int min, int max)
        {
            if (_local == null)
            {
                int seed;
                lock (_global)
                {
                    seed = _global.Next();
                }
                _local = new Random(seed);
            }

            return _local.Next(min, max);
        }
        
        public double NextDouble()
        {
            if (_local == null)
            {
                int seed;
                lock (_global)
                {
                    seed = _global.Next();
                }
                _local = new Random(seed);
            }

            return _local.NextDouble();
        }
    }
    public static class Simulation
    {
        public static ThreadSafeRandom Rand = new ThreadSafeRandom();

        public static double SimulationTick = 10.0;
        public static int FieldWidth = 1500;                   // pixels
        public static int FieldHeight = 900;                  // poxels
        public static int OnInitCellsCount = 300;             // count
        public static int OnInitInfectedCellsCount = 5;     // count
        public static double CellRadiusMin = 1.0;             // distance
        public static double CellRadiusMax = 8.0;             // distance
        
        public static int AgeMin = 0;                      // iterations
        public static int AgeMax = 2000;                       // iterations
        public static int LifespanMin = 5000;                 // iterations
        public static int LifespanMax = 12000;                 // iterations

        public static int CoitusRelaxationMin = 400;            // iterations
        public static int CoitusRelaxationMax = 3000;            // iterations
        
        public static double ImmunityMin = 0.0;              // coefficient
        public static double ImmunityMax = 0.3;              // coefficient
        
        public static double VelocityMin = 0.5;              // distance
        public static double VelocityMax = 3.0;              // distance   

        public static double Visibility = 10.0;               // distance
        public static int InfectedAgeDecrementer = 1;      // iterations
        
        public static double ChanceOfBirth = 0.1;            // coefficient
        public static double ChanceOfDeathMin = 0.5;              // coefficient
        public static double ChanceOfDeathMax = 0.7;              // coefficient
        public static double ChanceOfInfectingMin = 0.1;     // coefficient
        public static double ChanceOfInfectingMax = 0.2;     // coefficient
        
        public static double DistanceOfInfectingPow = 20.0 * 20.0;   // distance
        public static double DistanceOfCoitusPow = 20.0 * 20.0;
        
        public static int IncubationPeriodMin = 400;         // iterations
        public static int IncubationPeriodMax = 800;         // iterations
        public static int InfectionPeriodMin = 1000;
        public static int InfectionPeriodMax = 2000;
        
        public static double LockdownInfectedRate = 0.1;      // coefficient
        public static double LockdownSlowdown = 0.9;          // coefficient
        public static int LockdownDuration = 3000;             // iterations
        public static double VaccinationBoost = 0.3;    // coefficient
        public static int MedicinePlacesCount = 250;          // count
        public static double MedicineEfficiency = 0.1;        // coefficient

        public static SolidBrush HealthyBrush = new SolidBrush(Color.DarkGreen);
        public static SolidBrush InfectedBrush = new SolidBrush(Color.DarkRed);
        public static SolidBrush IncubationBrush = new SolidBrush(Color.Yellow);
        public static SolidBrush RecoveredBrush = new SolidBrush(Color.DarkBlue);
        
        public static Font MetricsFont = new Font("Consolas", 8);
        public static SolidBrush MetricsBrush = new SolidBrush(Color.Black);

        public static int GenAge()
        {
            return NextInt(AgeMin, AgeMax);
        }
        
        public static int GenLifespan()
        {
            return NextInt(LifespanMin, LifespanMax);
        }
        
        public static double GenImmunity()
        {
            return NextDouble(ImmunityMin, ImmunityMax);
        }
        
        public static CellSex GenSex()
        {
            return NextDouble(0.0, 1.0) < 0.5 ? CellSex.Male : CellSex.Female;
        }
        public static double CalcRadiusByAge(int age, int lifespan)
        {
            return CellRadiusMax - age * (CellRadiusMax - CellRadiusMin) / lifespan;
        }

        public static double CalcVelocityByAge(int age, int lifespan)
        {
            return VelocityMax - age * (VelocityMax - VelocityMin) / lifespan;
        }

        public static double CalcChanceOfInfectingByAge(int age, int lifespan)
        {
            return ChanceOfInfectingMin +
                   age * (ChanceOfInfectingMax - ChanceOfInfectingMin) / lifespan;
        }
        
        public static double CalcChanceOfDeathByAge(int age, int lifespan)
        {
            return ChanceOfDeathMin -
                   age * (ChanceOfDeathMax - ChanceOfDeathMin) / lifespan;
        }

        public static double NextDouble(double min, double max)
        {
            return Rand.NextDouble() * (max - min) + min;
        }

        public static int NextInt(int min, int max)
        {
            return Rand.Next(min, max);
        }

        public static Vector2 GenDirection()
        {
            return Vector2.Normalize(new Vector2((float)Simulation.NextDouble(-100.0, 100.0),
                (float)Simulation.NextDouble(-100.0, 100.0)));
        }
    }
}