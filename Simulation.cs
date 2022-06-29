using System;
using System.ComponentModel;
using System.Drawing;


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

        public static int FieldWidth = 1900;                   // pixels
        public static int FieldHeight = 1000;                  // poxels
        public static int OnInitCellsCount = 3000;             // count
        public static int OnInitInfectedCellsCount = 5;     // count
        public static double CellRadiusMin = 5.0;             // distance
        public static double CellRadiusMax = 10.0;             // distance
        
        public static int AgeMin = 0;                      // iterations
        public static int AgeMax = 1;                       // iterations
        public static int LifespanMin = 10000;                 // iterations
        public static int LifespanMax = 20000;                 // iterations

        public static double ChanceOfBirth = 0.1;            // coefficient
        public static int CoitusRelaxation = 5000;            // iterations
        
        public static double ImmunityMin = 0.0;              // coefficient
        public static double ImmunityMax = 0.1;              // coefficient
        
        public static double VelocityMin = 0.8;              // distance
        public static double VelocityMax = 2.0;              // distance   

        public static double Visibility = 10.0;               // distance
        public static int InfectedAgeDecrementer = 1;      // iterations
        public static double ChanceOfDeath = 0.00001;              // coefficient
        public static double ChanceOfRecovering = 0.00001;       // coefficient
        public static double ChanceOfInfectingMin = 0.4;     // coefficient
        public static double ChanceOfInfectingMax = 0.6;     // coefficient
        public static double DistanceOfInfectingPow = 20.0 * 20.0;   // distance
        public static int IncubationPeriodMin = 500;         // iterations
        public static int IncubationPeriodMax = 2000;         // iterations

        public static double LockdownInfectedRate = 0.5;      // coefficient
        public static double LockdownSlowdown = 0.5;          // coefficient
        public static int LockdownDuration = 10000;             // iterations
        public static double VaccinationIncrementer = 0.3;    // coefficient
        public static int MedicinePlacesCount = 250;          // count
        public static double MedicineEfficiency = 0.1;        // coefficient

        public static SolidBrush HealthyBrush = new SolidBrush(Color.DarkGreen);
        public static SolidBrush InfectedBrush = new SolidBrush(Color.DarkRed);
        public static SolidBrush IncubationBrush = new SolidBrush(Color.Yellow);
        public static SolidBrush RecoveredBrush = new SolidBrush(Color.DarkBlue);

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
            return NextInt(0, 1) == 0 ? CellSex.Male : CellSex.Female;
        }
        public static double CalcRadiusByAge(int age)
        {
            return CellRadiusMin + age * (CellRadiusMax - CellRadiusMin) / LifespanMax;
        }

        public static double CalcVelocityByAge(int age)
        {
            return VelocityMax - age * (VelocityMax - VelocityMin) / LifespanMax;
        }

        public static double CalcChanceOfInfectingByAge(int age)
        {
            return ChanceOfInfectingMin +
                   age * (ChanceOfInfectingMax - ChanceOfInfectingMin) / LifespanMax;
        }
        
        private static uint x = 548787455, y = 842502087, z = 3579807591, w = 273326509;

        public static uint XORShift()
        {
            uint t = x ^ (x << 11);
            x = y; y = z; z = w;
            return w = w ^ (w >> 19) ^ t ^ (t >> 8);
        }

        public static double NextDouble(double min, double max)
        {
            return Rand.NextDouble() * (max - min) + min;
        }

        public static int NextInt(int min, int max)
        {
            return Rand.Next(min, max);
        } 
    }
}