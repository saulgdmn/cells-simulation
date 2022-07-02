using System;
using System.Drawing;
using System.Numerics;



namespace LifeProj
{
    public static class ThreadSafeRandom
    {
        private static readonly Random Global = new Random();
        [ThreadStatic] private static Random _local;

        public static int Next() {
            
            if (_local != null) {
                return _local.Next();
            }
            lock (Global) {
                _local = new Random(Global.Next());
            }
            return _local.Next();
        }
        
        public static int Next(int min, int max) {
            
            if (_local != null) {
                return _local.Next(min, max);
            }
            lock (Global) {
                _local = new Random(Global.Next());
            }
            return _local.Next(min, max);
        }
        
        public static double NextDouble() {
            
            if (_local != null) {
                return _local.NextDouble();
            }
            lock (Global) {
                _local = new Random(Global.Next());
            }
            return _local.NextDouble();
        }
    }

    public static class Simulation{
        
        public const double SimulationTick = 10.0;
        
        public static int FieldWidth = 0;               // pixels (or abstract unit in auto mode )
        public static int FieldHeight = 0;              // pixels (or abstract unit in auto mode )
        public static int OnInitCellsCount = 300;           // count
        public static int OnInitInfectedCellsCount = 10;    // count
        public static double CellRadiusMin = 1.0;           // distance
        public static double CellRadiusMax = 8.0;           // distance
        
        public static int AgeMin = 0;                   // iterations
        public static int AgeMax = 2000;                // iterations
        public static int LifespanMin = 5000;           // iterations
        public static int LifespanMax = 12000;          // iterations

        public static int CoitusRelaxationMin = 400;    // iterations
        public static int CoitusRelaxationMax = 3000;   // iterations
        
        public static double ImmunityMin = 0.0;         // coefficient
        public static double ImmunityMax = 0.3;         // coefficient
        
        public static double VelocityMin = 0.5;         // distance
        public static double VelocityMax = 3.0;         // distance   
        
        public static int InfectedAgeDecrementer = 2;      // iterations

        public static int CellsCountMax = 1000;
        public static double ChanceOfBirth = 0.5;            // coefficient
        public static double ChanceOfDeathMin = 0.5;              // coefficient
        public static double ChanceOfDeathMax = 0.7;              // coefficient
        public static double ChanceOfInfectingMin = 0.1;     // coefficient
        public static double ChanceOfInfectingMax = 0.2;     // coefficient

        public static double DistanceOfInfectingPow = 20.0 * 20.0;   // distance
        public static double DistanceOfCoitusPow = 20.0 * 20.0;

        public static int IncubationPeriodMin = 400;        // iterations
        public static int IncubationPeriodMax = 800;        // iterations
        public static int InfectionPeriodMin = 1000;        // iterations
        public static int InfectionPeriodMax = 2000;        // iterations

        public static double LockdownInfectedRate = 0.1;    // coefficient
        public static double LockdownSlowdown = 0.9;        // coefficient
        public static int LockdownDuration = 3000;          // iterations
        public static double VaccinationBoost = 0.3;        // coefficient
        public static int MedicinePlacesCount = 250;        // count
        public static double MedicineEfficiency = 0.1;      // coefficient

        public static readonly SolidBrush HealthyBrush = new SolidBrush(Color.DarkGreen);
        public static readonly SolidBrush InfectedBrush = new SolidBrush(Color.DarkRed);
        public static readonly SolidBrush IncubationBrush = new SolidBrush(Color.Yellow);
        public static readonly SolidBrush RecoveredBrush = new SolidBrush(Color.DarkBlue);
        
        public static readonly Font MetricsFont = new Font("Consolas", 8);
        public static readonly SolidBrush MetricsBrush = new SolidBrush(Color.Black);
        
        
        public static double NextDouble(double min, double max) => ThreadSafeRandom.NextDouble() * (max - min) + min;
        public static int NextInt(int min, int max) => ThreadSafeRandom.Next(min, max);
        
        public static int GenAge() => NextInt(AgeMin, AgeMax);
        public static int GenLifespan() => NextInt(LifespanMin, LifespanMax);
        public static double GenImmunity() => NextDouble(ImmunityMin, ImmunityMax);
        
        public static CellSex GenSex() => NextDouble(0.0, 1.0) < 0.5 ? CellSex.Male : CellSex.Female;
        
        public static double CalcRadiusByAge(int age, int lifespan) => 
            CellRadiusMax - age * (CellRadiusMax - CellRadiusMin) / lifespan;
        public static double CalcVelocityByAge(int age, int lifespan) => 
            VelocityMax - age * (VelocityMax - VelocityMin) / lifespan;

        public static double CalcChanceOfInfectingByAge(int age, int lifespan) =>
            ChanceOfInfectingMin + age * (ChanceOfInfectingMax - ChanceOfInfectingMin) / lifespan;
        public static double CalcChanceOfDeathByAge(int age, int lifespan) =>
            ChanceOfDeathMin - age * (ChanceOfDeathMax - ChanceOfDeathMin) / lifespan;
        
        public static Vector2 GenDirection() => Vector2.Normalize(
                new Vector2((float)NextDouble(-100.0, 100.0),(float)NextDouble(-100.0, 100.0))
            );
    }
}