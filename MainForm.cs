using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace LifeProj{
    
    public partial class MainForm : Form {
        
        public readonly Field Field;
        public double NextIterElapsed;
        public double LoopIterElapsed;
        
        public MainForm(){
            
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer, 
                true);
            
            Field = new Field();
            Field.Init();
            
            var thread = new Thread(ThreadFunc){IsBackground = true};
            thread.Start();
        }
        
        private void ThreadFunc(){
            while (true){
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
        
        
        private static void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius){
            g.FillEllipse(brush, centerX - radius, centerY - radius,radius + radius, radius + radius);
        }
        
        private static void FillRectangle( Graphics g, Brush brush, float centerX, float centerY, float radius){
            g.FillRectangle(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }

        protected override void OnPaint(PaintEventArgs e){
            
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Black), 1.0f, 1.0f, Simulation.FieldWidth, Simulation.FieldHeight);
            
            foreach (var cell in Field.Cells.ToArray()){
                if (cell == null){
                    continue;
                }
                var brush = cell.State switch {
                    CellState.Healthy => Simulation.HealthyBrush,
                    CellState.Incubation => Simulation.IncubationBrush,
                    CellState.Infected => Simulation.InfectedBrush,
                    CellState.Recovered => Simulation.RecoveredBrush,
                    _ => Simulation.HealthyBrush
                };
                FillCircle(e.Graphics, brush, cell.Position.X, cell.Position.Y, (float)cell.Radius);
            }
            DrawSimulationInformation(e.Graphics);
        }

        private void DrawSimulationInformation(Graphics graphics)
        {
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl | StringFormatFlags.FitBlackBox;
             
            // Draw string to screen.
            graphics.DrawString(
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