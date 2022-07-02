namespace LifeProj.View{
    
    partial class MainForm{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SimulationPanel = new LifeProj.View.SimulationPanel();
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PropertiesTabControl = new System.Windows.Forms.TabControl();
            this.FieldTabPage = new System.Windows.Forms.TabPage();
            this.FieldPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.FieldPropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CellsOnStartInput = new System.Windows.Forms.NumericUpDown();
            this.InfectedCellsInput = new System.Windows.Forms.NumericUpDown();
            this.FieldSizeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FieldHeightInput = new System.Windows.Forms.TextBox();
            this.FieldWidthLabel = new System.Windows.Forms.Label();
            this.FieldHeightLabel = new System.Windows.Forms.Label();
            this.FieldWidthInput = new System.Windows.Forms.TextBox();
            this.InfectedCellsLabel = new System.Windows.Forms.Label();
            this.CellsOnStartLabel = new System.Windows.Forms.Label();
            this.CellsTabPage = new System.Windows.Forms.TabPage();
            this.CellsPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CellsPropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CellRadiusMaxInput = new System.Windows.Forms.NumericUpDown();
            this.CellRadiusMinInput = new System.Windows.Forms.NumericUpDown();
            this.CoitusRelaxationMaxInput = new System.Windows.Forms.NumericUpDown();
            this.CoitusRelaxationMinInput = new System.Windows.Forms.NumericUpDown();
            this.ImmunityMaxInput = new System.Windows.Forms.NumericUpDown();
            this.ImmunityMinInput = new System.Windows.Forms.NumericUpDown();
            this.LifespanMaxInput = new System.Windows.Forms.NumericUpDown();
            this.LifespanMinInput = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxInput = new System.Windows.Forms.NumericUpDown();
            this.AgeMinInput = new System.Windows.Forms.NumericUpDown();
            this.DeathMinInput = new System.Windows.Forms.NumericUpDown();
            this.ImmunityMaxLabel = new System.Windows.Forms.Label();
            this.ChanceOfDeathMaxLabel = new System.Windows.Forms.Label();
            this.ImmunityMinLabel = new System.Windows.Forms.Label();
            this.ImmunityLabel = new System.Windows.Forms.Label();
            this.AgeMaxLabel = new System.Windows.Forms.Label();
            this.ChanceOfDeathMinLabel = new System.Windows.Forms.Label();
            this.ChanceOfDeathLabel = new System.Windows.Forms.Label();
            this.LifespanMaxLabel = new System.Windows.Forms.Label();
            this.AgeMinLabel = new System.Windows.Forms.Label();
            this.LifespanMinLabel = new System.Windows.Forms.Label();
            this.LifespanLabel = new System.Windows.Forms.Label();
            this.ChanceOfBirthLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CellRadiusMinLabel = new System.Windows.Forms.Label();
            this.CellRadiusMaxLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationMaxLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationMinLabel = new System.Windows.Forms.Label();
            this.CellRadiusLabel = new System.Windows.Forms.Label();
            this.ChanceOfBirthInput = new System.Windows.Forms.NumericUpDown();
            this.DeathMaxInput = new System.Windows.Forms.NumericUpDown();
            this.VirusTabPage = new System.Windows.Forms.TabPage();
            this.VirusLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InfectedAgeDecrementerInput = new System.Windows.Forms.NumericUpDown();
            this.InfectedAgeDecrementerLabel = new System.Windows.Forms.Label();
            this.MedicineEfficiencyInput = new System.Windows.Forms.NumericUpDown();
            this.MedicinePlacesCountInput = new System.Windows.Forms.NumericUpDown();
            this.MedicinePlacesCountLabel = new System.Windows.Forms.Label();
            this.MedicineEfficiencyLabel = new System.Windows.Forms.Label();
            this.DistanceOfInfectingInput = new System.Windows.Forms.NumericUpDown();
            this.DistanceOfInfectingLabel = new System.Windows.Forms.Label();
            this.LockdownDurationInput = new System.Windows.Forms.NumericUpDown();
            this.VaccinationBoostInput = new System.Windows.Forms.NumericUpDown();
            this.LockdownDurationLabel = new System.Windows.Forms.Label();
            this.LockdownSlowdownInput = new System.Windows.Forms.NumericUpDown();
            this.LockdownSlowdownLabel = new System.Windows.Forms.Label();
            this.ChanceOfInfectingMinLabel = new System.Windows.Forms.Label();
            this.InfectionPeriodLabel = new System.Windows.Forms.Label();
            this.IncubationPeriodMaxInput = new System.Windows.Forms.NumericUpDown();
            this.IncubationPeriodMinInput = new System.Windows.Forms.NumericUpDown();
            this.IncubationPeriodMinLabel = new System.Windows.Forms.Label();
            this.IncubationPeriodLabel = new System.Windows.Forms.Label();
            this.IncubationPeriodMaxLabel = new System.Windows.Forms.Label();
            this.InfectionPeriodMinLabel = new System.Windows.Forms.Label();
            this.InfectionPeriodMaxLabel = new System.Windows.Forms.Label();
            this.ChanceOfInfectingMaxLabel = new System.Windows.Forms.Label();
            this.InfectionPeriodMinInput = new System.Windows.Forms.NumericUpDown();
            this.InfectionPeriodMaxInput = new System.Windows.Forms.NumericUpDown();
            this.InfectingMaxInput = new System.Windows.Forms.NumericUpDown();
            this.ChanceOfInfectingLabel = new System.Windows.Forms.Label();
            this.InfectingMinInput = new System.Windows.Forms.NumericUpDown();
            this.LockdownInfectedRateLabel = new System.Windows.Forms.Label();
            this.LockdownInfectedRateInput = new System.Windows.Forms.NumericUpDown();
            this.VaccinationBoostLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.ControlsLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.PropertiesTabControl.SuspendLayout();
            this.FieldTabPage.SuspendLayout();
            this.FieldPropertiesGroupBox.SuspendLayout();
            this.FieldPropertiesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CellsOnStartInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectedCellsInput)).BeginInit();
            this.FieldSizeLayout.SuspendLayout();
            this.CellsTabPage.SuspendLayout();
            this.CellsPropertiesGroupBox.SuspendLayout();
            this.CellsPropertiesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CellRadiusMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.CellRadiusMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.CoitusRelaxationMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.CoitusRelaxationMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ImmunityMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ImmunityMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LifespanMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LifespanMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AgeMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AgeMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.DeathMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ChanceOfBirthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.DeathMaxInput)).BeginInit();
            this.VirusTabPage.SuspendLayout();
            this.VirusLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.InfectedAgeDecrementerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MedicineEfficiencyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MedicinePlacesCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.DistanceOfInfectingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownDurationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.VaccinationBoostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownSlowdownInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.IncubationPeriodMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.IncubationPeriodMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectionPeriodMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectionPeriodMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectingMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectingMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownInfectedRateInput)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainLayout.Controls.Add(this.SimulationPanel, 0, 0);
            this.MainLayout.Controls.Add(this.ControlsLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1119, 620);
            this.MainLayout.TabIndex = 0;
            // 
            // SimulationPanel
            // 
            this.SimulationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationPanel.Location = new System.Drawing.Point(5, 5);
            this.SimulationPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SimulationPanel.Name = "SimulationPanel";
            this.SimulationPanel.Size = new System.Drawing.Size(773, 610);
            this.SimulationPanel.TabIndex = 0;
            this.SimulationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationPanel_Paint);
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 1;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.Controls.Add(this.ButtonsLayout, 0, 1);
            this.ControlsLayout.Controls.Add(this.PropertiesTabControl, 0, 0);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(786, 3);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 2;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ControlsLayout.Size = new System.Drawing.Size(330, 614);
            this.ControlsLayout.TabIndex = 1;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 2;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.StartButton, 0, 0);
            this.ButtonsLayout.Controls.Add(this.PauseButton, 1, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(5, 526);
            this.ButtonsLayout.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.Padding = new System.Windows.Forms.Padding(2);
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsLayout.Size = new System.Drawing.Size(320, 83);
            this.ButtonsLayout.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(5, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 73);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(163, 5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(152, 73);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // PropertiesTabControl
            // 
            this.PropertiesTabControl.Controls.Add(this.FieldTabPage);
            this.PropertiesTabControl.Controls.Add(this.CellsTabPage);
            this.PropertiesTabControl.Controls.Add(this.VirusTabPage);
            this.PropertiesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesTabControl.Location = new System.Drawing.Point(3, 3);
            this.PropertiesTabControl.Name = "PropertiesTabControl";
            this.PropertiesTabControl.SelectedIndex = 0;
            this.PropertiesTabControl.Size = new System.Drawing.Size(324, 515);
            this.PropertiesTabControl.TabIndex = 1;
            // 
            // FieldTabPage
            // 
            this.FieldTabPage.Controls.Add(this.FieldPropertiesGroupBox);
            this.FieldTabPage.Location = new System.Drawing.Point(4, 25);
            this.FieldTabPage.Name = "FieldTabPage";
            this.FieldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FieldTabPage.Size = new System.Drawing.Size(316, 486);
            this.FieldTabPage.TabIndex = 0;
            this.FieldTabPage.Text = "Field";
            this.FieldTabPage.UseVisualStyleBackColor = true;
            // 
            // FieldPropertiesGroupBox
            // 
            this.FieldPropertiesGroupBox.Controls.Add(this.FieldPropertiesLayout);
            this.FieldPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPropertiesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FieldPropertiesGroupBox.Name = "FieldPropertiesGroupBox";
            this.FieldPropertiesGroupBox.Size = new System.Drawing.Size(310, 480);
            this.FieldPropertiesGroupBox.TabIndex = 1;
            this.FieldPropertiesGroupBox.TabStop = false;
            this.FieldPropertiesGroupBox.Text = "Field properties";
            // 
            // FieldPropertiesLayout
            // 
            this.FieldPropertiesLayout.ColumnCount = 1;
            this.FieldPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FieldPropertiesLayout.Controls.Add(this.CellsOnStartInput, 0, 2);
            this.FieldPropertiesLayout.Controls.Add(this.InfectedCellsInput, 0, 4);
            this.FieldPropertiesLayout.Controls.Add(this.FieldSizeLayout, 0, 0);
            this.FieldPropertiesLayout.Controls.Add(this.InfectedCellsLabel, 0, 3);
            this.FieldPropertiesLayout.Controls.Add(this.CellsOnStartLabel, 0, 1);
            this.FieldPropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPropertiesLayout.Location = new System.Drawing.Point(3, 18);
            this.FieldPropertiesLayout.Margin = new System.Windows.Forms.Padding(5);
            this.FieldPropertiesLayout.Name = "FieldPropertiesLayout";
            this.FieldPropertiesLayout.RowCount = 5;
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FieldPropertiesLayout.Size = new System.Drawing.Size(304, 459);
            this.FieldPropertiesLayout.TabIndex = 1;
            // 
            // CellsOnStartInput
            // 
            this.CellsOnStartInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartInput.Increment = new decimal(new int[] {10, 0, 0, 0});
            this.CellsOnStartInput.Location = new System.Drawing.Point(35, 185);
            this.CellsOnStartInput.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.CellsOnStartInput.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            this.CellsOnStartInput.Minimum = new decimal(new int[] {10, 0, 0, 0});
            this.CellsOnStartInput.Name = "CellsOnStartInput";
            this.CellsOnStartInput.Size = new System.Drawing.Size(234, 22);
            this.CellsOnStartInput.TabIndex = 3;
            this.CellsOnStartInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CellsOnStartInput.Value = new decimal(new int[] {10, 0, 0, 0});
            // 
            // InfectedCellsInput
            // 
            this.InfectedCellsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsInput.Increment = new decimal(new int[] {10, 0, 0, 0});
            this.InfectedCellsInput.Location = new System.Drawing.Point(35, 367);
            this.InfectedCellsInput.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.InfectedCellsInput.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            this.InfectedCellsInput.Minimum = new decimal(new int[] {10, 0, 0, 0});
            this.InfectedCellsInput.Name = "InfectedCellsInput";
            this.InfectedCellsInput.Size = new System.Drawing.Size(234, 22);
            this.InfectedCellsInput.TabIndex = 0;
            this.InfectedCellsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfectedCellsInput.Value = new decimal(new int[] {10, 0, 0, 0});
            // 
            // FieldSizeLayout
            // 
            this.FieldSizeLayout.ColumnCount = 2;
            this.FieldSizeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldSizeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldSizeLayout.Controls.Add(this.FieldHeightInput, 1, 1);
            this.FieldSizeLayout.Controls.Add(this.FieldWidthLabel, 0, 0);
            this.FieldSizeLayout.Controls.Add(this.FieldHeightLabel, 0, 1);
            this.FieldSizeLayout.Controls.Add(this.FieldWidthInput, 1, 0);
            this.FieldSizeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldSizeLayout.Location = new System.Drawing.Point(3, 3);
            this.FieldSizeLayout.MinimumSize = new System.Drawing.Size(0, 55);
            this.FieldSizeLayout.Name = "FieldSizeLayout";
            this.FieldSizeLayout.RowCount = 2;
            this.FieldSizeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldSizeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FieldSizeLayout.Size = new System.Drawing.Size(298, 85);
            this.FieldSizeLayout.TabIndex = 0;
            // 
            // FieldHeightInput
            // 
            this.FieldHeightInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldHeightInput.Enabled = false;
            this.FieldHeightInput.Location = new System.Drawing.Point(152, 52);
            this.FieldHeightInput.Name = "FieldHeightInput";
            this.FieldHeightInput.Size = new System.Drawing.Size(143, 22);
            this.FieldHeightInput.TabIndex = 3;
            // 
            // FieldWidthLabel
            // 
            this.FieldWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldWidthLabel.Location = new System.Drawing.Point(5, 10);
            this.FieldWidthLabel.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.FieldWidthLabel.Name = "FieldWidthLabel";
            this.FieldWidthLabel.Size = new System.Drawing.Size(144, 22);
            this.FieldWidthLabel.TabIndex = 0;
            this.FieldWidthLabel.Text = "Field width";
            this.FieldWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldHeightLabel
            // 
            this.FieldHeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldHeightLabel.Location = new System.Drawing.Point(5, 52);
            this.FieldHeightLabel.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.FieldHeightLabel.Name = "FieldHeightLabel";
            this.FieldHeightLabel.Size = new System.Drawing.Size(144, 23);
            this.FieldHeightLabel.TabIndex = 1;
            this.FieldHeightLabel.Text = "Field height";
            this.FieldHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldWidthInput
            // 
            this.FieldWidthInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldWidthInput.Enabled = false;
            this.FieldWidthInput.Location = new System.Drawing.Point(152, 10);
            this.FieldWidthInput.Name = "FieldWidthInput";
            this.FieldWidthInput.Size = new System.Drawing.Size(143, 22);
            this.FieldWidthInput.TabIndex = 2;
            // 
            // InfectedCellsLabel
            // 
            this.InfectedCellsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsLabel.Location = new System.Drawing.Point(20, 276);
            this.InfectedCellsLabel.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.InfectedCellsLabel.Name = "InfectedCellsLabel";
            this.InfectedCellsLabel.Size = new System.Drawing.Size(264, 88);
            this.InfectedCellsLabel.TabIndex = 2;
            this.InfectedCellsLabel.Text = "Infected cells count\r\nmin - 10, max - 2000";
            this.InfectedCellsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellsOnStartLabel
            // 
            this.CellsOnStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartLabel.Location = new System.Drawing.Point(20, 94);
            this.CellsOnStartLabel.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.CellsOnStartLabel.Name = "CellsOnStartLabel";
            this.CellsOnStartLabel.Size = new System.Drawing.Size(264, 88);
            this.CellsOnStartLabel.TabIndex = 2;
            this.CellsOnStartLabel.Text = "Cells on start (in total)\r\nmin - 10, max - 2000";
            this.CellsOnStartLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellsTabPage
            // 
            this.CellsTabPage.Controls.Add(this.CellsPropertiesGroupBox);
            this.CellsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CellsTabPage.Name = "CellsTabPage";
            this.CellsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CellsTabPage.Size = new System.Drawing.Size(316, 489);
            this.CellsTabPage.TabIndex = 1;
            this.CellsTabPage.Text = "Cells";
            this.CellsTabPage.UseVisualStyleBackColor = true;
            // 
            // CellsPropertiesGroupBox
            // 
            this.CellsPropertiesGroupBox.Controls.Add(this.CellsPropertiesLayout);
            this.CellsPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsPropertiesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CellsPropertiesGroupBox.Name = "CellsPropertiesGroupBox";
            this.CellsPropertiesGroupBox.Size = new System.Drawing.Size(310, 483);
            this.CellsPropertiesGroupBox.TabIndex = 0;
            this.CellsPropertiesGroupBox.TabStop = false;
            this.CellsPropertiesGroupBox.Text = "Cells properties";
            // 
            // CellsPropertiesLayout
            // 
            this.CellsPropertiesLayout.ColumnCount = 4;
            this.CellsPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellsPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellsPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellsPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusMaxInput, 3, 13);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusMinInput, 1, 13);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationMaxInput, 3, 11);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationMinInput, 1, 11);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityMaxInput, 3, 9);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityMinInput, 1, 9);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanMaxInput, 3, 7);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanMinInput, 1, 7);
            this.CellsPropertiesLayout.Controls.Add(this.AgeMaxInput, 3, 5);
            this.CellsPropertiesLayout.Controls.Add(this.AgeMinInput, 1, 5);
            this.CellsPropertiesLayout.Controls.Add(this.DeathMinInput, 1, 3);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityMaxLabel, 2, 9);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfDeathMaxLabel, 2, 3);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityMinLabel, 0, 9);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityLabel, 0, 8);
            this.CellsPropertiesLayout.Controls.Add(this.AgeMaxLabel, 2, 5);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfDeathMinLabel, 0, 3);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfDeathLabel, 0, 2);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanMaxLabel, 2, 7);
            this.CellsPropertiesLayout.Controls.Add(this.AgeMinLabel, 0, 5);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanMinLabel, 0, 7);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanLabel, 0, 6);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfBirthLabel, 0, 0);
            this.CellsPropertiesLayout.Controls.Add(this.AgeLabel, 0, 4);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusMinLabel, 0, 13);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusMaxLabel, 2, 13);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationLabel, 0, 10);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationMaxLabel, 2, 11);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationMinLabel, 0, 11);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusLabel, 0, 12);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfBirthInput, 1, 1);
            this.CellsPropertiesLayout.Controls.Add(this.DeathMaxInput, 3, 3);
            this.CellsPropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsPropertiesLayout.Location = new System.Drawing.Point(3, 18);
            this.CellsPropertiesLayout.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CellsPropertiesLayout.Name = "CellsPropertiesLayout";
            this.CellsPropertiesLayout.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CellsPropertiesLayout.RowCount = 14;
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CellsPropertiesLayout.Size = new System.Drawing.Size(304, 462);
            this.CellsPropertiesLayout.TabIndex = 0;
            // 
            // CellRadiusMaxInput
            // 
            this.CellRadiusMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CellRadiusMaxInput.DecimalPlaces = 1;
            this.CellRadiusMaxInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.CellRadiusMaxInput.Location = new System.Drawing.Point(225, 428);
            this.CellRadiusMaxInput.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.CellRadiusMaxInput.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.CellRadiusMaxInput.Name = "CellRadiusMaxInput";
            this.CellRadiusMaxInput.Size = new System.Drawing.Size(71, 22);
            this.CellRadiusMaxInput.TabIndex = 19;
            this.CellRadiusMaxInput.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // CellRadiusMinInput
            // 
            this.CellRadiusMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CellRadiusMinInput.DecimalPlaces = 1;
            this.CellRadiusMinInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.CellRadiusMinInput.Location = new System.Drawing.Point(77, 428);
            this.CellRadiusMinInput.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.CellRadiusMinInput.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.CellRadiusMinInput.Name = "CellRadiusMinInput";
            this.CellRadiusMinInput.Size = new System.Drawing.Size(68, 22);
            this.CellRadiusMinInput.TabIndex = 18;
            this.CellRadiusMinInput.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // CoitusRelaxationMaxInput
            // 
            this.CoitusRelaxationMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CoitusRelaxationMaxInput.Increment = new decimal(new int[] {50, 0, 0, 0});
            this.CoitusRelaxationMaxInput.Location = new System.Drawing.Point(225, 357);
            this.CoitusRelaxationMaxInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.CoitusRelaxationMaxInput.Name = "CoitusRelaxationMaxInput";
            this.CoitusRelaxationMaxInput.Size = new System.Drawing.Size(71, 22);
            this.CoitusRelaxationMaxInput.TabIndex = 18;
            // 
            // CoitusRelaxationMinInput
            // 
            this.CoitusRelaxationMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CoitusRelaxationMinInput.Increment = new decimal(new int[] {50, 0, 0, 0});
            this.CoitusRelaxationMinInput.Location = new System.Drawing.Point(77, 357);
            this.CoitusRelaxationMinInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.CoitusRelaxationMinInput.Name = "CoitusRelaxationMinInput";
            this.CoitusRelaxationMinInput.Size = new System.Drawing.Size(68, 22);
            this.CoitusRelaxationMinInput.TabIndex = 17;
            // 
            // ImmunityMaxInput
            // 
            this.ImmunityMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImmunityMaxInput.DecimalPlaces = 1;
            this.ImmunityMaxInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.ImmunityMaxInput.Location = new System.Drawing.Point(225, 293);
            this.ImmunityMaxInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.ImmunityMaxInput.Name = "ImmunityMaxInput";
            this.ImmunityMaxInput.Size = new System.Drawing.Size(71, 22);
            this.ImmunityMaxInput.TabIndex = 18;
            // 
            // ImmunityMinInput
            // 
            this.ImmunityMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImmunityMinInput.DecimalPlaces = 1;
            this.ImmunityMinInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.ImmunityMinInput.Location = new System.Drawing.Point(77, 293);
            this.ImmunityMinInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.ImmunityMinInput.Name = "ImmunityMinInput";
            this.ImmunityMinInput.Size = new System.Drawing.Size(68, 22);
            this.ImmunityMinInput.TabIndex = 17;
            // 
            // LifespanMaxInput
            // 
            this.LifespanMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LifespanMaxInput.Increment = new decimal(new int[] {500, 0, 0, 0});
            this.LifespanMaxInput.Location = new System.Drawing.Point(225, 229);
            this.LifespanMaxInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.LifespanMaxInput.Name = "LifespanMaxInput";
            this.LifespanMaxInput.Size = new System.Drawing.Size(71, 22);
            this.LifespanMaxInput.TabIndex = 17;
            // 
            // LifespanMinInput
            // 
            this.LifespanMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LifespanMinInput.Increment = new decimal(new int[] {500, 0, 0, 0});
            this.LifespanMinInput.Location = new System.Drawing.Point(77, 229);
            this.LifespanMinInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.LifespanMinInput.Name = "LifespanMinInput";
            this.LifespanMinInput.Size = new System.Drawing.Size(68, 22);
            this.LifespanMinInput.TabIndex = 16;
            // 
            // AgeMaxInput
            // 
            this.AgeMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeMaxInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.AgeMaxInput.Location = new System.Drawing.Point(225, 165);
            this.AgeMaxInput.Maximum = new decimal(new int[] {5000, 0, 0, 0});
            this.AgeMaxInput.Name = "AgeMaxInput";
            this.AgeMaxInput.Size = new System.Drawing.Size(71, 22);
            this.AgeMaxInput.TabIndex = 16;
            // 
            // AgeMinInput
            // 
            this.AgeMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeMinInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.AgeMinInput.Location = new System.Drawing.Point(77, 165);
            this.AgeMinInput.Maximum = new decimal(new int[] {5000, 0, 0, 0});
            this.AgeMinInput.Name = "AgeMinInput";
            this.AgeMinInput.Size = new System.Drawing.Size(68, 22);
            this.AgeMinInput.TabIndex = 15;
            // 
            // DeathMinInput
            // 
            this.DeathMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathMinInput.DecimalPlaces = 1;
            this.DeathMinInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.DeathMinInput.Location = new System.Drawing.Point(77, 101);
            this.DeathMinInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.DeathMinInput.Name = "DeathMinInput";
            this.DeathMinInput.Size = new System.Drawing.Size(68, 22);
            this.DeathMinInput.TabIndex = 14;
            // 
            // ImmunityMaxLabel
            // 
            this.ImmunityMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityMaxLabel.Location = new System.Drawing.Point(151, 288);
            this.ImmunityMaxLabel.Name = "ImmunityMaxLabel";
            this.ImmunityMaxLabel.Size = new System.Drawing.Size(68, 32);
            this.ImmunityMaxLabel.TabIndex = 3;
            this.ImmunityMaxLabel.Text = "Max";
            this.ImmunityMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChanceOfDeathMaxLabel
            // 
            this.ChanceOfDeathMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathMaxLabel.Location = new System.Drawing.Point(151, 96);
            this.ChanceOfDeathMaxLabel.Name = "ChanceOfDeathMaxLabel";
            this.ChanceOfDeathMaxLabel.Size = new System.Drawing.Size(68, 32);
            this.ChanceOfDeathMaxLabel.TabIndex = 3;
            this.ChanceOfDeathMaxLabel.Text = "Max";
            this.ChanceOfDeathMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImmunityMinLabel
            // 
            this.ImmunityMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityMinLabel.Location = new System.Drawing.Point(3, 288);
            this.ImmunityMinLabel.Name = "ImmunityMinLabel";
            this.ImmunityMinLabel.Size = new System.Drawing.Size(68, 32);
            this.ImmunityMinLabel.TabIndex = 0;
            this.ImmunityMinLabel.Text = "Min";
            this.ImmunityMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImmunityLabel
            // 
            this.CellsPropertiesLayout.SetColumnSpan(this.ImmunityLabel, 4);
            this.ImmunityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityLabel.Location = new System.Drawing.Point(10, 259);
            this.ImmunityLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ImmunityLabel.Name = "ImmunityLabel";
            this.ImmunityLabel.Size = new System.Drawing.Size(279, 26);
            this.ImmunityLabel.TabIndex = 4;
            this.ImmunityLabel.Text = "Immunity ( 0-1 )";
            this.ImmunityLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AgeMaxLabel
            // 
            this.AgeMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeMaxLabel.Location = new System.Drawing.Point(151, 160);
            this.AgeMaxLabel.Name = "AgeMaxLabel";
            this.AgeMaxLabel.Size = new System.Drawing.Size(68, 32);
            this.AgeMaxLabel.TabIndex = 3;
            this.AgeMaxLabel.Text = "Max";
            this.AgeMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChanceOfDeathMinLabel
            // 
            this.ChanceOfDeathMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathMinLabel.Location = new System.Drawing.Point(3, 96);
            this.ChanceOfDeathMinLabel.Name = "ChanceOfDeathMinLabel";
            this.ChanceOfDeathMinLabel.Size = new System.Drawing.Size(68, 32);
            this.ChanceOfDeathMinLabel.TabIndex = 0;
            this.ChanceOfDeathMinLabel.Text = "Min";
            this.ChanceOfDeathMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChanceOfDeathLabel
            // 
            this.CellsPropertiesLayout.SetColumnSpan(this.ChanceOfDeathLabel, 4);
            this.ChanceOfDeathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathLabel.Location = new System.Drawing.Point(3, 67);
            this.ChanceOfDeathLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.ChanceOfDeathLabel.Name = "ChanceOfDeathLabel";
            this.ChanceOfDeathLabel.Size = new System.Drawing.Size(293, 28);
            this.ChanceOfDeathLabel.TabIndex = 2;
            this.ChanceOfDeathLabel.Text = "chance of death ( 0-1 )";
            this.ChanceOfDeathLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LifespanMaxLabel
            // 
            this.LifespanMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanMaxLabel.Location = new System.Drawing.Point(151, 227);
            this.LifespanMaxLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.LifespanMaxLabel.Name = "LifespanMaxLabel";
            this.LifespanMaxLabel.Size = new System.Drawing.Size(70, 26);
            this.LifespanMaxLabel.TabIndex = 3;
            this.LifespanMaxLabel.Text = "Max";
            this.LifespanMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AgeMinLabel
            // 
            this.AgeMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeMinLabel.Location = new System.Drawing.Point(3, 160);
            this.AgeMinLabel.Name = "AgeMinLabel";
            this.AgeMinLabel.Size = new System.Drawing.Size(68, 32);
            this.AgeMinLabel.TabIndex = 0;
            this.AgeMinLabel.Text = "Min";
            this.AgeMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LifespanMinLabel
            // 
            this.LifespanMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanMinLabel.Location = new System.Drawing.Point(3, 227);
            this.LifespanMinLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.LifespanMinLabel.Name = "LifespanMinLabel";
            this.LifespanMinLabel.Size = new System.Drawing.Size(70, 26);
            this.LifespanMinLabel.TabIndex = 0;
            this.LifespanMinLabel.Text = "Min";
            this.LifespanMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LifespanLabel
            // 
            this.LifespanLabel.BackColor = System.Drawing.Color.Transparent;
            this.CellsPropertiesLayout.SetColumnSpan(this.LifespanLabel, 4);
            this.LifespanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanLabel.Location = new System.Drawing.Point(10, 195);
            this.LifespanLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 1);
            this.LifespanLabel.Name = "LifespanLabel";
            this.LifespanLabel.Size = new System.Drawing.Size(279, 28);
            this.LifespanLabel.TabIndex = 8;
            this.LifespanLabel.Text = "lifespan (iterations)";
            this.LifespanLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ChanceOfBirthLabel
            // 
            this.ChanceOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.CellsPropertiesLayout.SetColumnSpan(this.ChanceOfBirthLabel, 4);
            this.ChanceOfBirthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfBirthLabel.Location = new System.Drawing.Point(10, 0);
            this.ChanceOfBirthLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ChanceOfBirthLabel.Name = "ChanceOfBirthLabel";
            this.ChanceOfBirthLabel.Size = new System.Drawing.Size(279, 32);
            this.ChanceOfBirthLabel.TabIndex = 1;
            this.ChanceOfBirthLabel.Text = "chance of birth ( 0-1 )";
            this.ChanceOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AgeLabel
            // 
            this.CellsPropertiesLayout.SetColumnSpan(this.AgeLabel, 4);
            this.AgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeLabel.Location = new System.Drawing.Point(10, 131);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 1);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(279, 28);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "age (iterations)";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellRadiusMinLabel
            // 
            this.CellRadiusMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusMinLabel.Location = new System.Drawing.Point(3, 419);
            this.CellRadiusMinLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.CellRadiusMinLabel.Name = "CellRadiusMinLabel";
            this.CellRadiusMinLabel.Size = new System.Drawing.Size(70, 40);
            this.CellRadiusMinLabel.TabIndex = 0;
            this.CellRadiusMinLabel.Text = "Min";
            this.CellRadiusMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellRadiusMaxLabel
            // 
            this.CellRadiusMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusMaxLabel.Location = new System.Drawing.Point(151, 419);
            this.CellRadiusMaxLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.CellRadiusMaxLabel.Name = "CellRadiusMaxLabel";
            this.CellRadiusMaxLabel.Size = new System.Drawing.Size(70, 40);
            this.CellRadiusMaxLabel.TabIndex = 3;
            this.CellRadiusMaxLabel.Text = "Max";
            this.CellRadiusMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoitusRelaxationLabel
            // 
            this.CoitusRelaxationLabel.BackColor = System.Drawing.Color.Transparent;
            this.CellsPropertiesLayout.SetColumnSpan(this.CoitusRelaxationLabel, 4);
            this.CoitusRelaxationLabel.Location = new System.Drawing.Point(10, 323);
            this.CoitusRelaxationLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 1);
            this.CoitusRelaxationLabel.Name = "CoitusRelaxationLabel";
            this.CoitusRelaxationLabel.Size = new System.Drawing.Size(213, 28);
            this.CoitusRelaxationLabel.TabIndex = 12;
            this.CoitusRelaxationLabel.Text = "coitus relaxation";
            this.CoitusRelaxationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CoitusRelaxationMaxLabel
            // 
            this.CoitusRelaxationMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationMaxLabel.Location = new System.Drawing.Point(151, 355);
            this.CoitusRelaxationMaxLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.CoitusRelaxationMaxLabel.Name = "CoitusRelaxationMaxLabel";
            this.CoitusRelaxationMaxLabel.Size = new System.Drawing.Size(70, 26);
            this.CoitusRelaxationMaxLabel.TabIndex = 3;
            this.CoitusRelaxationMaxLabel.Text = "Max";
            this.CoitusRelaxationMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoitusRelaxationMinLabel
            // 
            this.CoitusRelaxationMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationMinLabel.Location = new System.Drawing.Point(3, 355);
            this.CoitusRelaxationMinLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.CoitusRelaxationMinLabel.Name = "CoitusRelaxationMinLabel";
            this.CoitusRelaxationMinLabel.Size = new System.Drawing.Size(70, 26);
            this.CoitusRelaxationMinLabel.TabIndex = 0;
            this.CoitusRelaxationMinLabel.Text = "Min";
            this.CoitusRelaxationMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellRadiusLabel
            // 
            this.CellRadiusLabel.BackColor = System.Drawing.Color.Transparent;
            this.CellsPropertiesLayout.SetColumnSpan(this.CellRadiusLabel, 4);
            this.CellRadiusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusLabel.Location = new System.Drawing.Point(10, 387);
            this.CellRadiusLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 1);
            this.CellRadiusLabel.Name = "CellRadiusLabel";
            this.CellRadiusLabel.Size = new System.Drawing.Size(279, 28);
            this.CellRadiusLabel.TabIndex = 10;
            this.CellRadiusLabel.Text = "cell radius  ( 1-10 )";
            this.CellRadiusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ChanceOfBirthInput
            // 
            this.ChanceOfBirthInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CellsPropertiesLayout.SetColumnSpan(this.ChanceOfBirthInput, 2);
            this.ChanceOfBirthInput.DecimalPlaces = 1;
            this.ChanceOfBirthInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.ChanceOfBirthInput.Location = new System.Drawing.Point(84, 35);
            this.ChanceOfBirthInput.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ChanceOfBirthInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.ChanceOfBirthInput.Name = "ChanceOfBirthInput";
            this.ChanceOfBirthInput.Size = new System.Drawing.Size(128, 22);
            this.ChanceOfBirthInput.TabIndex = 13;
            // 
            // DeathMaxInput
            // 
            this.DeathMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathMaxInput.DecimalPlaces = 1;
            this.DeathMaxInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.DeathMaxInput.Location = new System.Drawing.Point(225, 101);
            this.DeathMaxInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.DeathMaxInput.Name = "DeathMaxInput";
            this.DeathMaxInput.Size = new System.Drawing.Size(71, 22);
            this.DeathMaxInput.TabIndex = 15;
            // 
            // VirusTabPage
            // 
            this.VirusTabPage.AutoScroll = true;
            this.VirusTabPage.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.VirusTabPage.Controls.Add(this.VirusLayout);
            this.VirusTabPage.Location = new System.Drawing.Point(4, 22);
            this.VirusTabPage.Name = "VirusTabPage";
            this.VirusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VirusTabPage.Size = new System.Drawing.Size(316, 489);
            this.VirusTabPage.TabIndex = 2;
            this.VirusTabPage.Text = "Virus/Lockdown";
            this.VirusTabPage.UseVisualStyleBackColor = true;
            // 
            // VirusLayout
            // 
            this.VirusLayout.ColumnCount = 4;
            this.VirusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.VirusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.VirusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.VirusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.VirusLayout.Controls.Add(this.InfectedAgeDecrementerInput, 2, 13);
            this.VirusLayout.Controls.Add(this.InfectedAgeDecrementerLabel, 0, 13);
            this.VirusLayout.Controls.Add(this.MedicineEfficiencyInput, 2, 12);
            this.VirusLayout.Controls.Add(this.MedicinePlacesCountInput, 2, 11);
            this.VirusLayout.Controls.Add(this.MedicinePlacesCountLabel, 0, 11);
            this.VirusLayout.Controls.Add(this.MedicineEfficiencyLabel, 0, 12);
            this.VirusLayout.Controls.Add(this.DistanceOfInfectingInput, 2, 10);
            this.VirusLayout.Controls.Add(this.DistanceOfInfectingLabel, 0, 10);
            this.VirusLayout.Controls.Add(this.LockdownDurationInput, 2, 9);
            this.VirusLayout.Controls.Add(this.VaccinationBoostInput, 2, 8);
            this.VirusLayout.Controls.Add(this.LockdownDurationLabel, 0, 9);
            this.VirusLayout.Controls.Add(this.LockdownSlowdownInput, 2, 7);
            this.VirusLayout.Controls.Add(this.LockdownSlowdownLabel, 0, 7);
            this.VirusLayout.Controls.Add(this.ChanceOfInfectingMinLabel, 0, 5);
            this.VirusLayout.Controls.Add(this.InfectionPeriodLabel, 0, 2);
            this.VirusLayout.Controls.Add(this.IncubationPeriodMaxInput, 3, 1);
            this.VirusLayout.Controls.Add(this.IncubationPeriodMinInput, 1, 1);
            this.VirusLayout.Controls.Add(this.IncubationPeriodMinLabel, 0, 1);
            this.VirusLayout.Controls.Add(this.IncubationPeriodLabel, 0, 0);
            this.VirusLayout.Controls.Add(this.IncubationPeriodMaxLabel, 2, 1);
            this.VirusLayout.Controls.Add(this.InfectionPeriodMinLabel, 0, 3);
            this.VirusLayout.Controls.Add(this.InfectionPeriodMaxLabel, 2, 3);
            this.VirusLayout.Controls.Add(this.ChanceOfInfectingMaxLabel, 2, 5);
            this.VirusLayout.Controls.Add(this.InfectionPeriodMinInput, 1, 3);
            this.VirusLayout.Controls.Add(this.InfectionPeriodMaxInput, 3, 3);
            this.VirusLayout.Controls.Add(this.InfectingMaxInput, 3, 5);
            this.VirusLayout.Controls.Add(this.ChanceOfInfectingLabel, 0, 4);
            this.VirusLayout.Controls.Add(this.InfectingMinInput, 1, 5);
            this.VirusLayout.Controls.Add(this.LockdownInfectedRateLabel, 0, 6);
            this.VirusLayout.Controls.Add(this.LockdownInfectedRateInput, 2, 6);
            this.VirusLayout.Controls.Add(this.VaccinationBoostLabel, 0, 8);
            this.VirusLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.VirusLayout.Location = new System.Drawing.Point(3, 3);
            this.VirusLayout.Margin = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.VirusLayout.MinimumSize = new System.Drawing.Size(0, 700);
            this.VirusLayout.Name = "VirusLayout";
            this.VirusLayout.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.VirusLayout.RowCount = 14;
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.VirusLayout.Size = new System.Drawing.Size(293, 700);
            this.VirusLayout.TabIndex = 0;
            // 
            // InfectedAgeDecrementerInput
            // 
            this.InfectedAgeDecrementerInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.InfectedAgeDecrementerInput, 2);
            this.InfectedAgeDecrementerInput.Location = new System.Drawing.Point(147, 657);
            this.InfectedAgeDecrementerInput.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.InfectedAgeDecrementerInput.Name = "InfectedAgeDecrementerInput";
            this.InfectedAgeDecrementerInput.Size = new System.Drawing.Size(138, 22);
            this.InfectedAgeDecrementerInput.TabIndex = 23;
            // 
            // InfectedAgeDecrementerLabel
            // 
            this.VirusLayout.SetColumnSpan(this.InfectedAgeDecrementerLabel, 2);
            this.InfectedAgeDecrementerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedAgeDecrementerLabel.Location = new System.Drawing.Point(3, 637);
            this.InfectedAgeDecrementerLabel.Name = "InfectedAgeDecrementerLabel";
            this.InfectedAgeDecrementerLabel.Size = new System.Drawing.Size(138, 63);
            this.InfectedAgeDecrementerLabel.TabIndex = 33;
            this.InfectedAgeDecrementerLabel.Text = "Infected age decrementer";
            this.InfectedAgeDecrementerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineEfficiencyInput
            // 
            this.MedicineEfficiencyInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.MedicineEfficiencyInput, 2);
            this.MedicineEfficiencyInput.DecimalPlaces = 1;
            this.MedicineEfficiencyInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.MedicineEfficiencyInput.Location = new System.Drawing.Point(147, 601);
            this.MedicineEfficiencyInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.MedicineEfficiencyInput.Name = "MedicineEfficiencyInput";
            this.MedicineEfficiencyInput.Size = new System.Drawing.Size(138, 22);
            this.MedicineEfficiencyInput.TabIndex = 29;
            // 
            // MedicinePlacesCountInput
            // 
            this.MedicinePlacesCountInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.MedicinePlacesCountInput, 2);
            this.MedicinePlacesCountInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.MedicinePlacesCountInput.Location = new System.Drawing.Point(147, 552);
            this.MedicinePlacesCountInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.MedicinePlacesCountInput.Name = "MedicinePlacesCountInput";
            this.MedicinePlacesCountInput.Size = new System.Drawing.Size(138, 22);
            this.MedicinePlacesCountInput.TabIndex = 22;
            // 
            // MedicinePlacesCountLabel
            // 
            this.VirusLayout.SetColumnSpan(this.MedicinePlacesCountLabel, 2);
            this.MedicinePlacesCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicinePlacesCountLabel.Location = new System.Drawing.Point(3, 539);
            this.MedicinePlacesCountLabel.Name = "MedicinePlacesCountLabel";
            this.MedicinePlacesCountLabel.Size = new System.Drawing.Size(138, 49);
            this.MedicinePlacesCountLabel.TabIndex = 32;
            this.MedicinePlacesCountLabel.Text = "medicine places";
            this.MedicinePlacesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineEfficiencyLabel
            // 
            this.VirusLayout.SetColumnSpan(this.MedicineEfficiencyLabel, 2);
            this.MedicineEfficiencyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineEfficiencyLabel.Location = new System.Drawing.Point(3, 588);
            this.MedicineEfficiencyLabel.Name = "MedicineEfficiencyLabel";
            this.MedicineEfficiencyLabel.Size = new System.Drawing.Size(138, 49);
            this.MedicineEfficiencyLabel.TabIndex = 31;
            this.MedicineEfficiencyLabel.Text = "medicine efficiency";
            this.MedicineEfficiencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistanceOfInfectingInput
            // 
            this.DistanceOfInfectingInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.DistanceOfInfectingInput, 2);
            this.DistanceOfInfectingInput.DecimalPlaces = 2;
            this.DistanceOfInfectingInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.DistanceOfInfectingInput.Location = new System.Drawing.Point(147, 503);
            this.DistanceOfInfectingInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.DistanceOfInfectingInput.Name = "DistanceOfInfectingInput";
            this.DistanceOfInfectingInput.Size = new System.Drawing.Size(138, 22);
            this.DistanceOfInfectingInput.TabIndex = 22;
            // 
            // DistanceOfInfectingLabel
            // 
            this.VirusLayout.SetColumnSpan(this.DistanceOfInfectingLabel, 2);
            this.DistanceOfInfectingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistanceOfInfectingLabel.Location = new System.Drawing.Point(3, 490);
            this.DistanceOfInfectingLabel.Name = "DistanceOfInfectingLabel";
            this.DistanceOfInfectingLabel.Size = new System.Drawing.Size(138, 49);
            this.DistanceOfInfectingLabel.TabIndex = 30;
            this.DistanceOfInfectingLabel.Text = "distance of infecting";
            this.DistanceOfInfectingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LockdownDurationInput
            // 
            this.LockdownDurationInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.LockdownDurationInput, 2);
            this.LockdownDurationInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.LockdownDurationInput.Location = new System.Drawing.Point(147, 454);
            this.LockdownDurationInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.LockdownDurationInput.Name = "LockdownDurationInput";
            this.LockdownDurationInput.Size = new System.Drawing.Size(138, 22);
            this.LockdownDurationInput.TabIndex = 21;
            // 
            // VaccinationBoostInput
            // 
            this.VaccinationBoostInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.VaccinationBoostInput, 2);
            this.VaccinationBoostInput.DecimalPlaces = 1;
            this.VaccinationBoostInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.VaccinationBoostInput.Location = new System.Drawing.Point(147, 405);
            this.VaccinationBoostInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.VaccinationBoostInput.Name = "VaccinationBoostInput";
            this.VaccinationBoostInput.Size = new System.Drawing.Size(138, 22);
            this.VaccinationBoostInput.TabIndex = 28;
            // 
            // LockdownDurationLabel
            // 
            this.VirusLayout.SetColumnSpan(this.LockdownDurationLabel, 2);
            this.LockdownDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockdownDurationLabel.Location = new System.Drawing.Point(3, 441);
            this.LockdownDurationLabel.Name = "LockdownDurationLabel";
            this.LockdownDurationLabel.Size = new System.Drawing.Size(138, 49);
            this.LockdownDurationLabel.TabIndex = 29;
            this.LockdownDurationLabel.Text = "lockdown duration";
            this.LockdownDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LockdownSlowdownInput
            // 
            this.LockdownSlowdownInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.LockdownSlowdownInput, 2);
            this.LockdownSlowdownInput.DecimalPlaces = 1;
            this.LockdownSlowdownInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.LockdownSlowdownInput.Location = new System.Drawing.Point(147, 356);
            this.LockdownSlowdownInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.LockdownSlowdownInput.Name = "LockdownSlowdownInput";
            this.LockdownSlowdownInput.Size = new System.Drawing.Size(138, 22);
            this.LockdownSlowdownInput.TabIndex = 27;
            // 
            // LockdownSlowdownLabel
            // 
            this.VirusLayout.SetColumnSpan(this.LockdownSlowdownLabel, 2);
            this.LockdownSlowdownLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockdownSlowdownLabel.Location = new System.Drawing.Point(3, 343);
            this.LockdownSlowdownLabel.Name = "LockdownSlowdownLabel";
            this.LockdownSlowdownLabel.Size = new System.Drawing.Size(138, 49);
            this.LockdownSlowdownLabel.TabIndex = 27;
            this.LockdownSlowdownLabel.Text = "lockdown slowdown ( 0-1 )";
            this.LockdownSlowdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChanceOfInfectingMinLabel
            // 
            this.ChanceOfInfectingMinLabel.Location = new System.Drawing.Point(3, 245);
            this.ChanceOfInfectingMinLabel.Name = "ChanceOfInfectingMinLabel";
            this.ChanceOfInfectingMinLabel.Size = new System.Drawing.Size(55, 34);
            this.ChanceOfInfectingMinLabel.TabIndex = 17;
            this.ChanceOfInfectingMinLabel.Text = "Min";
            this.ChanceOfInfectingMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfectionPeriodLabel
            // 
            this.VirusLayout.SetColumnSpan(this.InfectionPeriodLabel, 4);
            this.InfectionPeriodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectionPeriodLabel.Location = new System.Drawing.Point(3, 98);
            this.InfectionPeriodLabel.Name = "InfectionPeriodLabel";
            this.InfectionPeriodLabel.Size = new System.Drawing.Size(282, 49);
            this.InfectionPeriodLabel.TabIndex = 1;
            this.InfectionPeriodLabel.Text = "infection period";
            this.InfectionPeriodLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // IncubationPeriodMaxInput
            // 
            this.IncubationPeriodMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IncubationPeriodMaxInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.IncubationPeriodMaxInput.Location = new System.Drawing.Point(219, 62);
            this.IncubationPeriodMaxInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.IncubationPeriodMaxInput.Name = "IncubationPeriodMaxInput";
            this.IncubationPeriodMaxInput.Size = new System.Drawing.Size(66, 22);
            this.IncubationPeriodMaxInput.TabIndex = 15;
            // 
            // IncubationPeriodMinInput
            // 
            this.IncubationPeriodMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IncubationPeriodMinInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.IncubationPeriodMinInput.Location = new System.Drawing.Point(75, 62);
            this.IncubationPeriodMinInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.IncubationPeriodMinInput.Name = "IncubationPeriodMinInput";
            this.IncubationPeriodMinInput.Size = new System.Drawing.Size(66, 22);
            this.IncubationPeriodMinInput.TabIndex = 15;
            // 
            // IncubationPeriodMinLabel
            // 
            this.IncubationPeriodMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncubationPeriodMinLabel.Location = new System.Drawing.Point(3, 49);
            this.IncubationPeriodMinLabel.Name = "IncubationPeriodMinLabel";
            this.IncubationPeriodMinLabel.Size = new System.Drawing.Size(66, 49);
            this.IncubationPeriodMinLabel.TabIndex = 1;
            this.IncubationPeriodMinLabel.Text = "Min";
            this.IncubationPeriodMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IncubationPeriodLabel
            // 
            this.VirusLayout.SetColumnSpan(this.IncubationPeriodLabel, 4);
            this.IncubationPeriodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncubationPeriodLabel.Location = new System.Drawing.Point(10, 3);
            this.IncubationPeriodLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.IncubationPeriodLabel.Name = "IncubationPeriodLabel";
            this.IncubationPeriodLabel.Size = new System.Drawing.Size(268, 46);
            this.IncubationPeriodLabel.TabIndex = 0;
            this.IncubationPeriodLabel.Text = "incubation period";
            this.IncubationPeriodLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // IncubationPeriodMaxLabel
            // 
            this.IncubationPeriodMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncubationPeriodMaxLabel.Location = new System.Drawing.Point(147, 49);
            this.IncubationPeriodMaxLabel.Name = "IncubationPeriodMaxLabel";
            this.IncubationPeriodMaxLabel.Size = new System.Drawing.Size(66, 49);
            this.IncubationPeriodMaxLabel.TabIndex = 4;
            this.IncubationPeriodMaxLabel.Text = "Max";
            this.IncubationPeriodMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfectionPeriodMinLabel
            // 
            this.InfectionPeriodMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectionPeriodMinLabel.Location = new System.Drawing.Point(3, 147);
            this.InfectionPeriodMinLabel.Name = "InfectionPeriodMinLabel";
            this.InfectionPeriodMinLabel.Size = new System.Drawing.Size(66, 49);
            this.InfectionPeriodMinLabel.TabIndex = 16;
            this.InfectionPeriodMinLabel.Text = "Min";
            this.InfectionPeriodMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfectionPeriodMaxLabel
            // 
            this.InfectionPeriodMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectionPeriodMaxLabel.Location = new System.Drawing.Point(147, 147);
            this.InfectionPeriodMaxLabel.Name = "InfectionPeriodMaxLabel";
            this.InfectionPeriodMaxLabel.Size = new System.Drawing.Size(66, 49);
            this.InfectionPeriodMaxLabel.TabIndex = 18;
            this.InfectionPeriodMaxLabel.Text = "Max";
            this.InfectionPeriodMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChanceOfInfectingMaxLabel
            // 
            this.ChanceOfInfectingMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfInfectingMaxLabel.Location = new System.Drawing.Point(147, 245);
            this.ChanceOfInfectingMaxLabel.Name = "ChanceOfInfectingMaxLabel";
            this.ChanceOfInfectingMaxLabel.Size = new System.Drawing.Size(66, 49);
            this.ChanceOfInfectingMaxLabel.TabIndex = 19;
            this.ChanceOfInfectingMaxLabel.Text = "Max";
            this.ChanceOfInfectingMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfectionPeriodMinInput
            // 
            this.InfectionPeriodMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfectionPeriodMinInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.InfectionPeriodMinInput.Location = new System.Drawing.Point(75, 160);
            this.InfectionPeriodMinInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.InfectionPeriodMinInput.Name = "InfectionPeriodMinInput";
            this.InfectionPeriodMinInput.Size = new System.Drawing.Size(66, 22);
            this.InfectionPeriodMinInput.TabIndex = 20;
            // 
            // InfectionPeriodMaxInput
            // 
            this.InfectionPeriodMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfectionPeriodMaxInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.InfectionPeriodMaxInput.Location = new System.Drawing.Point(219, 160);
            this.InfectionPeriodMaxInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.InfectionPeriodMaxInput.Name = "InfectionPeriodMaxInput";
            this.InfectionPeriodMaxInput.Size = new System.Drawing.Size(66, 22);
            this.InfectionPeriodMaxInput.TabIndex = 21;
            // 
            // InfectingMaxInput
            // 
            this.InfectingMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfectingMaxInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.InfectingMaxInput.Location = new System.Drawing.Point(219, 258);
            this.InfectingMaxInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.InfectingMaxInput.Name = "InfectingMaxInput";
            this.InfectingMaxInput.Size = new System.Drawing.Size(66, 22);
            this.InfectingMaxInput.TabIndex = 22;
            // 
            // ChanceOfInfectingLabel
            // 
            this.VirusLayout.SetColumnSpan(this.ChanceOfInfectingLabel, 4);
            this.ChanceOfInfectingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfInfectingLabel.Location = new System.Drawing.Point(3, 196);
            this.ChanceOfInfectingLabel.Name = "ChanceOfInfectingLabel";
            this.ChanceOfInfectingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChanceOfInfectingLabel.Size = new System.Drawing.Size(282, 49);
            this.ChanceOfInfectingLabel.TabIndex = 24;
            this.ChanceOfInfectingLabel.Text = "chance of infecting";
            this.ChanceOfInfectingLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // InfectingMinInput
            // 
            this.InfectingMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InfectingMinInput.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.InfectingMinInput.Location = new System.Drawing.Point(75, 258);
            this.InfectingMinInput.Maximum = new decimal(new int[] {20000, 0, 0, 0});
            this.InfectingMinInput.Name = "InfectingMinInput";
            this.InfectingMinInput.Size = new System.Drawing.Size(66, 22);
            this.InfectingMinInput.TabIndex = 23;
            // 
            // LockdownInfectedRateLabel
            // 
            this.VirusLayout.SetColumnSpan(this.LockdownInfectedRateLabel, 2);
            this.LockdownInfectedRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockdownInfectedRateLabel.Location = new System.Drawing.Point(3, 294);
            this.LockdownInfectedRateLabel.Name = "LockdownInfectedRateLabel";
            this.LockdownInfectedRateLabel.Size = new System.Drawing.Size(138, 49);
            this.LockdownInfectedRateLabel.TabIndex = 25;
            this.LockdownInfectedRateLabel.Text = "lockdown infected rate ( 0-1 )";
            this.LockdownInfectedRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LockdownInfectedRateInput
            // 
            this.LockdownInfectedRateInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VirusLayout.SetColumnSpan(this.LockdownInfectedRateInput, 2);
            this.LockdownInfectedRateInput.DecimalPlaces = 1;
            this.LockdownInfectedRateInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.LockdownInfectedRateInput.Location = new System.Drawing.Point(147, 307);
            this.LockdownInfectedRateInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.LockdownInfectedRateInput.Name = "LockdownInfectedRateInput";
            this.LockdownInfectedRateInput.Size = new System.Drawing.Size(138, 22);
            this.LockdownInfectedRateInput.TabIndex = 26;
            // 
            // VaccinationBoostLabel
            // 
            this.VirusLayout.SetColumnSpan(this.VaccinationBoostLabel, 2);
            this.VaccinationBoostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VaccinationBoostLabel.Location = new System.Drawing.Point(3, 392);
            this.VaccinationBoostLabel.Name = "VaccinationBoostLabel";
            this.VaccinationBoostLabel.Size = new System.Drawing.Size(138, 49);
            this.VaccinationBoostLabel.TabIndex = 28;
            this.VaccinationBoostLabel.Text = "vaccination boost ( 0-1 )";
            this.VaccinationBoostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VaccinationBoostLabel.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1119, 620);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "MainForm";
            this.Text = "Life simulation";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainLayout.ResumeLayout(false);
            this.ControlsLayout.ResumeLayout(false);
            this.ButtonsLayout.ResumeLayout(false);
            this.PropertiesTabControl.ResumeLayout(false);
            this.FieldTabPage.ResumeLayout(false);
            this.FieldPropertiesGroupBox.ResumeLayout(false);
            this.FieldPropertiesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CellsOnStartInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectedCellsInput)).EndInit();
            this.FieldSizeLayout.ResumeLayout(false);
            this.FieldSizeLayout.PerformLayout();
            this.CellsTabPage.ResumeLayout(false);
            this.CellsPropertiesGroupBox.ResumeLayout(false);
            this.CellsPropertiesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CellRadiusMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.CellRadiusMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.CoitusRelaxationMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.CoitusRelaxationMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ImmunityMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ImmunityMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LifespanMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LifespanMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AgeMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AgeMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.DeathMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ChanceOfBirthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.DeathMaxInput)).EndInit();
            this.VirusTabPage.ResumeLayout(false);
            this.VirusLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.InfectedAgeDecrementerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MedicineEfficiencyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MedicinePlacesCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.DistanceOfInfectingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownDurationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.VaccinationBoostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownSlowdownInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.IncubationPeriodMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.IncubationPeriodMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectionPeriodMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectionPeriodMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectingMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.InfectingMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LockdownInfectedRateInput)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label InfectedAgeDecrementerLabel;
        private System.Windows.Forms.NumericUpDown InfectedAgeDecrementerInput;

        private System.Windows.Forms.Label MedicineEfficiencyLabel;
        private System.Windows.Forms.Label MedicinePlacesCountLabel;
        private System.Windows.Forms.NumericUpDown MedicinePlacesCountInput;
        private System.Windows.Forms.NumericUpDown MedicineEfficiencyInput;

        private System.Windows.Forms.Label DistanceOfInfectingLabel;
        private System.Windows.Forms.Label LockdownSlowdownLabel;
        private System.Windows.Forms.Label LockdownDurationLabel;
        private System.Windows.Forms.Label VaccinationBoostLabel;
        private System.Windows.Forms.Label LockdownInfectedRateLabel;
        
        private System.Windows.Forms.NumericUpDown DistanceOfInfectingInput;
        private System.Windows.Forms.NumericUpDown LockdownDurationInput;
        private System.Windows.Forms.NumericUpDown VaccinationBoostInput;
        private System.Windows.Forms.NumericUpDown LockdownSlowdownInput;
        private System.Windows.Forms.NumericUpDown LockdownInfectedRateInput;


        private System.Windows.Forms.NumericUpDown InfectingMaxInput;
        private System.Windows.Forms.NumericUpDown InfectingMinInput;
        
        private System.Windows.Forms.Label ChanceOfInfectingMinLabel;
        private System.Windows.Forms.Label ChanceOfInfectingMaxLabel;
        private System.Windows.Forms.Label ChanceOfInfectingLabel;
        
        private System.Windows.Forms.Label InfectionPeriodLabel;
        private System.Windows.Forms.NumericUpDown InfectionPeriodMinInput;
        private System.Windows.Forms.NumericUpDown InfectionPeriodMaxInput;
        private System.Windows.Forms.Label InfectionPeriodMaxLabel;
        private System.Windows.Forms.Label InfectionPeriodMinLabel;
        
        private System.Windows.Forms.Label IncubationPeriodMinLabel;
        private System.Windows.Forms.Label IncubationPeriodMaxLabel;
        private System.Windows.Forms.Label IncubationPeriodLabel;
        
        private System.Windows.Forms.NumericUpDown IncubationPeriodMinInput;
        private System.Windows.Forms.NumericUpDown IncubationPeriodMaxInput;

        private System.Windows.Forms.TableLayoutPanel VirusLayout;
        
        private System.Windows.Forms.TabPage VirusTabPage;

        private System.Windows.Forms.NumericUpDown CoitusRelaxationMaxInput;
        private System.Windows.Forms.NumericUpDown CoitusRelaxationMinInput;
        private System.Windows.Forms.Label CoitusRelaxationMinLabel;
        private System.Windows.Forms.Label CoitusRelaxationMaxLabel;
        private System.Windows.Forms.Label CoitusRelaxationLabel;


        private System.Windows.Forms.NumericUpDown CellRadiusMinInput;
        private System.Windows.Forms.NumericUpDown CellRadiusMaxInput;
        private System.Windows.Forms.Label CellRadiusMaxLabel;
        private System.Windows.Forms.Label CellRadiusMinLabel;
        private System.Windows.Forms.Label CellRadiusLabel;


        private System.Windows.Forms.NumericUpDown LifespanMinInput;
        private System.Windows.Forms.NumericUpDown LifespanMaxInput;
        private System.Windows.Forms.Label LifespanMaxLabel;
        private System.Windows.Forms.Label LifespanMinLabel;
        private System.Windows.Forms.Label LifespanLabel;

        private System.Windows.Forms.NumericUpDown AgeMinInput;
        private System.Windows.Forms.NumericUpDown AgeMaxInput;
        private System.Windows.Forms.Label AgeMaxLabel;
        private System.Windows.Forms.Label AgeMinLabel;
        private System.Windows.Forms.Label AgeLabel;


        private System.Windows.Forms.NumericUpDown ImmunityMinInput;
        private System.Windows.Forms.NumericUpDown ImmunityMaxInput;
        private System.Windows.Forms.Label ImmunityMinLabel;
        private System.Windows.Forms.Label ImmunityMaxLabel;
        private System.Windows.Forms.Label ImmunityLabel;

        private System.Windows.Forms.Label ChanceOfDeathMaxLabel;
        private System.Windows.Forms.Label ChanceOfDeathMinLabel;
        private System.Windows.Forms.Label ChanceOfDeathLabel;
        private System.Windows.Forms.NumericUpDown DeathMinInput;
        private System.Windows.Forms.NumericUpDown DeathMaxInput;
        
        
        private System.Windows.Forms.Label ChanceOfBirthLabel;
        private System.Windows.Forms.NumericUpDown ChanceOfBirthInput;
        private System.Windows.Forms.TableLayoutPanel CellsPropertiesLayout;
        private System.Windows.Forms.GroupBox CellsPropertiesGroupBox;


        private System.Windows.Forms.Label InfectedCellsLabel;
        private System.Windows.Forms.Label CellsOnStartLabel;
        private System.Windows.Forms.NumericUpDown CellsOnStartInput;
        private System.Windows.Forms.NumericUpDown InfectedCellsInput;
        
        private System.Windows.Forms.Label FieldHeightLabel;
        private System.Windows.Forms.Label FieldWidthLabel;
        private System.Windows.Forms.TextBox FieldWidthInput;
        private System.Windows.Forms.TextBox FieldHeightInput;
        
        private System.Windows.Forms.TableLayoutPanel FieldSizeLayout;
        private System.Windows.Forms.TableLayoutPanel FieldPropertiesLayout;
        private System.Windows.Forms.GroupBox FieldPropertiesGroupBox;

        private System.Windows.Forms.TabPage CellsTabPage;
        private System.Windows.Forms.TabPage FieldTabPage;
        private System.Windows.Forms.TabControl PropertiesTabControl;
        
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private LifeProj.View.SimulationPanel SimulationPanel;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        
        #endregion
        
    }
}