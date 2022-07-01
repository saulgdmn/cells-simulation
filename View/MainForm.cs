using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace LifeProj.View {
    
    public partial class MainForm : Form {
        
        private readonly Field _field;
        private double _nextIterElapsed;
        private double _loopIterElapsed;
        
        public MainForm(){
            
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer, 
                true);
            
            _field = new Field();
            _field.Init();

            SetupRenderingThread();
        }
        
        private void SetupRenderingThread(){
            var thread = new Thread(() => {
                while (true){
                    var loopIterWatch = new Stopwatch();
                    var nextIterWatch = new Stopwatch();

                    loopIterWatch.Start();
                    nextIterWatch.Start();
                
                    _field.NextIter();
                
                    nextIterWatch.Stop();
                    _nextIterElapsed = nextIterWatch.Elapsed.TotalMilliseconds;
                
                    simulationPanel.Invoke((MethodInvoker) delegate { simulationPanel.Refresh(); });
                    while (loopIterWatch.Elapsed.TotalMilliseconds < Simulation.SimulationTick) { }

                    loopIterWatch.Stop();
                    _loopIterElapsed = loopIterWatch.Elapsed.TotalMilliseconds;
                }
            }){IsBackground = true};
            thread.Start();
        }

        private void simulationPanel_Paint(object sender, PaintEventArgs e) {
            
            // TODO will be set just once on start
            Simulation.FieldWidth = simulationPanel.Width - 2;
            Simulation.FieldHeight = simulationPanel.Height - 2;
            
            e.Graphics.DrawRectangle(new Pen(Color.Black), 1.0f, 1.0f, Simulation.FieldWidth, Simulation.FieldHeight);
            
            foreach (var cell in _field.Cells.ToArray()){
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
                Utils.FillCircle(e.Graphics, brush, cell.Position.X, cell.Position.Y, (float)cell.Radius);
            }
            DrawSimulationInformation(e.Graphics);
        }

        private void DrawSimulationInformation(Graphics graphics)
        {
            // Set format of string.
            var drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl | StringFormatFlags.FitBlackBox;
             
            // Draw string to screen.
            graphics.DrawString(
                "NextIterElapsed: " + _nextIterElapsed + "\n" + 
                "LoopIterElapsed: " + _loopIterElapsed + "\n" + 
                "ItersPerSecond: " + Math.Round(1000.0 / _loopIterElapsed) + "\n" +
                "IterationsCount: " + _field.IterationsCount + "\n" +
                "CellsCount: " + _field.GetCellsCount() + "\n" + 
                "MaleCellsCount: " + _field.GetMaleCellsCount() + "\n" + 
                "FemaleCellsCount: " + _field.GetFemaleCellsCount() + "\n" + 
                "HealthyCellsCount: " + _field.GetHealthyCellsCount() + "\n" + 
                "InfectedCellsCount: " + _field.GetInfectedCellsCount() + "\n" + 
                "IncubationCellsCount: " + _field.GetIncubationCellsCount() + "\n" + 
                "RecoveredCellsCount: " + _field.GetRecoveredCellsCount() + "\n" +
                "DeathByAgeCellsCount: " + _field.GetDeathByAgeCellsCount() + "\n" +
                "DeathByInfectionCellsCount: " + _field.GetDeathByInfectionCellsCount(),
                Simulation.MetricsFont, Simulation.MetricsBrush, 2, 2, drawFormat);
        }

        private void startButton_Click(object sender, EventArgs e){
            resetButton.Enabled = true;
            pauseButton.Enabled = true;
            startButton.Enabled = false;
            continueButton.Enabled = false;
            
        }

        private void resetButton_Click(object sender, EventArgs e) {
            startButton.Enabled = true;
            resetButton.Enabled = false;
            pauseButton.Enabled = false;
            continueButton.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e) {
            pauseButton.Enabled = false;
            continueButton.Enabled = true;
        }

        private void continueButton_Click(object sender, EventArgs e) {
            pauseButton.Enabled = true;
            continueButton.Enabled = false;
        }
    }
}