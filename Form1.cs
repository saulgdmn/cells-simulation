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
                while (loopIterWatch.Elapsed.TotalMilliseconds < 50.0);
                
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
            
            g.DrawRectangle(pen, 0.0f, 0.0f, Simulation.FieldWidth, Simulation.FieldHeight);
            foreach (var cell in Field.Cells.ToArray())
            {
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
            
            Font drawFont = new Font("Consolas", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl;
             
            // Draw string to screen.
            e.Graphics.DrawString(
                "NextIterElapsed: " + NextIterElapsed + "\n" + 
                "LoopIterElapsed: " + LoopIterElapsed + "\n" + 
                "ItersPerSecond: " + Math.Round(1000.0 / LoopIterElapsed) + "\n" +
                "IterationsCount: " + Field.IterationsCount,
                drawFont, drawBrush, 0, 0, drawFormat);
        }
    }
}