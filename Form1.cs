using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace LifeProj
{
    public partial class Form1 : Form
    {
        public Field Field;
        public double NextIterElapsed;
        public double LoopIterElapsed;
        public Form1()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer, 
                true);
            
            Field = new Field();
            Field.Init();
            Thread thr = new Thread(ThreadFunc);
            thr.Start();
        }

        public void ThreadFunc()
        {
            while (true)
            {
                Stopwatch loopIterWatch = new Stopwatch();
                Stopwatch nextIterWatch = new Stopwatch();

                loopIterWatch.Start();
                nextIterWatch.Start();
                
                Field.NextIter();
                
                nextIterWatch.Stop();
                NextIterElapsed = nextIterWatch.Elapsed.TotalMilliseconds;
                
                Invalidate();
                while (loopIterWatch.Elapsed.TotalMilliseconds < Simulation.SimulationTick);
                
                loopIterWatch.Stop();
                LoopIterElapsed = loopIterWatch.Elapsed.TotalMilliseconds;
            }
        }
        
        public static void FillCircle(Graphics g, Brush brush,
            float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                radius + radius, radius + radius);
        }
        
        public static void FillRectangle(Graphics g, Brush brush,
            float centerX, float centerY, float radius)
                {
                    g.FillRectangle(brush, centerX - radius, centerY - radius,
                        radius + radius, radius + radius);
                }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            
            Pen pen = new Pen(Color.Black);
            
            g.DrawRectangle(pen, 1.0f, 1.0f, Simulation.FieldWidth, Simulation.FieldHeight);
            foreach (var cell in Field.Cells.ToArray())
            {
                if(cell == null)
                    continue;
                
                SolidBrush brush;
                switch (cell.State)
                {
                    case CellState.Healthy:
                        brush = Simulation.HealthyBrush;
                        break;
                    case CellState.Incubation:
                        brush = Simulation.IncubationBrush;
                        break;
                    case CellState.Infected:
                        brush = Simulation.InfectedBrush;
                        break;
                    case CellState.Recovered:
                        brush = Simulation.RecoveredBrush;
                        break;
                    default:
                        brush = Simulation.HealthyBrush;
                        break;
                }
                FillCircle(g, brush, cell.Position.X, cell.Position.Y, (float)cell.Radius);
            }
            
           
            
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl | StringFormatFlags.FitBlackBox;
             
            // Draw string to screen.
            e.Graphics.DrawString(
                "NextIterElapsed: " + NextIterElapsed + "\n" + 
                "LoopIterElapsed: " + LoopIterElapsed + "\n" + 
                "ItersPerSecond: " + Math.Round(1000.0 / LoopIterElapsed) + "\n" +
                "IterationsCount: " + Field.IterationsCount + "\n" +
                "CellsCount: " + Field.GetCellsCount() + "\n" + 
                "MaleCellsCount: " + Field.GetMaleCellsCount() + "\n" + 
                "FemaleCellsCount: " + Field.GetFemaleCellsCount() + "\n" + 
                "HealthyCellsCount: " + Field.GetHealthyCellsCount() + "\n" + 
                "InfectedCellsCount: " + Field.GetInfectedCellsCount() + "\n" + 
                "IncubationCellsCount: " + Field.GetIncubationCellsCount() + "\n" + 
                "RecoveredCellsCount: " + Field.GetRecoveredCellsCount() + "\n" +
                "DeathByAgeCellsCount: " + Field.GetDeathByAgeCellsCount() + "\n" +
                "DeathByInfectionCellsCount: " + Field.GetDeathByInfectionCellsCount(),
                Simulation.MetricsFont, Simulation.MetricsBrush, 2, 2, drawFormat);
        }
    }
}