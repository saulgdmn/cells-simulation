using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace LifeProj.View {
    
    public partial class MainForm : Form {
        
        private readonly Field _field;
        private double _nextIterElapsed;
        private double _loopIterElapsed;

        private Thread _renderingThread;

        private volatile bool _simulationRunning;
        private volatile bool _simulationPaused;

        
        public MainForm(){
            
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | 
                ControlStyles.DoubleBuffer, 
                true);
            
            Simulation.FieldWidth = SimulationPanel.Width - 2;
            Simulation.FieldHeight = SimulationPanel.Height - 2;
            FieldHeightInput.Text = (SimulationPanel.Height - 2).ToString();
            FieldWidthInput.Text = (SimulationPanel.Width - 2).ToString();
            _field = new Field();
            _simulationRunning = false;

            CellsOnStartInput.Text = Simulation.OnInitCellsCount.ToString();
            InfectedCellsInput.Value = Simulation.OnInitInfectedCellsCount;

            SetupInputs();
        }
        
        private void SetupRenderingThread()
        {
            _simulationPaused = false;
            _simulationRunning = true;
            _renderingThread = new Thread(() => {
                while (_simulationRunning){
                    
                    while (_simulationPaused){
                        Thread.Sleep(50);
                    }
                    var loopIterWatch = new Stopwatch();
                    var nextIterWatch = new Stopwatch();

                    loopIterWatch.Start();
                    nextIterWatch.Start();
                
                    _field.NextIter();
                
                    nextIterWatch.Stop();
                    _nextIterElapsed = nextIterWatch.Elapsed.TotalMilliseconds;
                
                    SimulationPanel.Invoke((MethodInvoker) delegate { SimulationPanel.Refresh(); });
                    while (loopIterWatch.Elapsed.TotalMilliseconds < Simulation.SimulationTick) { }

                    loopIterWatch.Stop();
                    _loopIterElapsed = loopIterWatch.Elapsed.TotalMilliseconds;
                }
            }){IsBackground = true};
            _renderingThread.Start();
        }

        private void simulationPanel_Paint(object sender, PaintEventArgs e) {

            e.Graphics.DrawRectangle(new Pen(Color.Black), 1.0f, 1.0f, Simulation.FieldWidth, Simulation.FieldHeight);
            
            if (!_simulationRunning) return;
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

            if (_simulationRunning){
                _simulationRunning = false;
                _renderingThread.Abort();
                _field.Reset();
                SimulationPanel.Refresh();
                FormBorderStyle = FormBorderStyle.Sizable;
                StartButton.Text = "Start";
                PauseButton.Enabled = false;
                _simulationPaused = false;
                PauseButton.Text = "Pause";
            }else{
                SetupSimulationProperties();
                _field.Init();
                FormBorderStyle = FormBorderStyle.FixedSingle;
                SetupRenderingThread();
                StartButton.Text = "Reset";
                PauseButton.Enabled = true;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e) {
            PauseButton.Text = _simulationPaused ? "Pause" : "Continue";
            _simulationPaused = !_simulationPaused;
        }

        private void MainForm_Resize(object sender, EventArgs e){
            Simulation.FieldWidth = SimulationPanel.Width - 2;
            Simulation.FieldHeight = SimulationPanel.Height - 2;

            FieldHeightInput.Text = (SimulationPanel.Height - 2).ToString();
            FieldWidthInput.Text = (SimulationPanel.Width - 2).ToString();
            SimulationPanel.Refresh();
        }

        // TODO add validation ?
        private void SetupSimulationProperties()
        {
            Simulation.OnInitCellsCount =  decimal.ToInt32(CellsOnStartInput.Value);
            Simulation.OnInitInfectedCellsCount = decimal.ToInt32(InfectedCellsInput.Value);
         
            Simulation.ChanceOfBirth = decimal.ToDouble(ChanceOfBirthInput.Value);
            
            Simulation.AgeMin = decimal.ToInt32(AgeMinInput.Value);
            Simulation.AgeMax = decimal.ToInt32(AgeMaxInput.Value);
            
            Simulation.LifespanMin = decimal.ToInt32(LifespanMinInput.Value);
            Simulation.LifespanMax = decimal.ToInt32(LifespanMaxInput.Value);
            
            Simulation.CoitusRelaxationMin = decimal.ToInt32(CoitusRelaxationMinInput.Value); 
            Simulation.CoitusRelaxationMax = decimal.ToInt32(CoitusRelaxationMaxInput.Value);
            
            Simulation.CellRadiusMin = decimal.ToDouble(CellRadiusMinInput.Value);
            Simulation.CellRadiusMax = decimal.ToDouble(CellRadiusMaxInput.Value);
            
            Simulation.ChanceOfDeathMin = decimal.ToDouble(DeathMinInput.Value); 
            Simulation.ChanceOfDeathMax = decimal.ToDouble(DeathMaxInput.Value); 
            
            Simulation.ImmunityMin = decimal.ToDouble(ImmunityMinInput.Value); 
            Simulation.ImmunityMax = decimal.ToDouble(ImmunityMaxInput.Value); 
            
        }
        
        private void SetupInputs() {
            
            CellsOnStartInput.Value = Simulation.OnInitCellsCount;
            InfectedCellsInput.Value = Simulation.OnInitInfectedCellsCount;

            ChanceOfBirthInput.Value = Convert.ToDecimal(Simulation.ChanceOfBirth);
            
            AgeMinInput.Value = Simulation.AgeMin;
            AgeMaxInput.Value = Simulation.AgeMax;

            LifespanMinInput.Value = Simulation.LifespanMin;
            LifespanMaxInput.Value = Simulation.LifespanMax;

            CoitusRelaxationMinInput.Value = Simulation.CoitusRelaxationMin;
            CoitusRelaxationMaxInput.Value = Simulation.CoitusRelaxationMax;
            
            CellRadiusMinInput.Value = Convert.ToDecimal(Simulation.CellRadiusMin); 
            CellRadiusMaxInput.Value = Convert.ToDecimal(Simulation.CellRadiusMax); 

            DeathMinInput.Value = Convert.ToDecimal(Simulation.ChanceOfDeathMin); 
            DeathMaxInput.Value = Convert.ToDecimal(Simulation.ChanceOfDeathMax);

            ImmunityMinInput.Value = Convert.ToDecimal(Simulation.ImmunityMin);
            ImmunityMaxInput.Value = Convert.ToDecimal(Simulation.ImmunityMax);
        }
    }
}