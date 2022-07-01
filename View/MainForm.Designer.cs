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
            this.CellsOnStartInput = new System.Windows.Forms.TextBox();
            this.FieldSizeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FieldHeightInput = new System.Windows.Forms.TextBox();
            this.FieldWidthLabel = new System.Windows.Forms.Label();
            this.FieldHeightLabel = new System.Windows.Forms.Label();
            this.FieldWidthInput = new System.Windows.Forms.TextBox();
            this.InfectedCellsInput = new System.Windows.Forms.TextBox();
            this.InfectedCellsLabel = new System.Windows.Forms.Label();
            this.CellsOnStartLabel = new System.Windows.Forms.Label();
            this.CellsTabPage = new System.Windows.Forms.TabPage();
            this.CellsPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CellsPropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CellRadiusLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CellRadiusMaxLabel = new System.Windows.Forms.Label();
            this.CellRadiusMinInput = new System.Windows.Forms.TextBox();
            this.CellRadiusMinLabel = new System.Windows.Forms.Label();
            this.CellRadiusMaxInput = new System.Windows.Forms.TextBox();
            this.LifespanLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LifespanMaxLabel = new System.Windows.Forms.Label();
            this.LifespanMinInput = new System.Windows.Forms.TextBox();
            this.LifespanMinLabel = new System.Windows.Forms.Label();
            this.LifespanMaxInput = new System.Windows.Forms.TextBox();
            this.AgeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AgeMaxLabel = new System.Windows.Forms.Label();
            this.AgeMinInput = new System.Windows.Forms.TextBox();
            this.AgeMinLabel = new System.Windows.Forms.Label();
            this.AgeMaxInput = new System.Windows.Forms.TextBox();
            this.ImmunityLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ImmunityMaxLabel = new System.Windows.Forms.Label();
            this.ImmunityMinInput = new System.Windows.Forms.TextBox();
            this.ImmunityMinLabel = new System.Windows.Forms.Label();
            this.ImmunityMaxInput = new System.Windows.Forms.TextBox();
            this.ChanceOfDeathLabel = new System.Windows.Forms.Label();
            this.ChanceOfBirthLabel = new System.Windows.Forms.Label();
            this.ChanceOfBirthInput = new System.Windows.Forms.TextBox();
            this.ChanceOfDeathLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ChanceOfDeathMaxLabel = new System.Windows.Forms.Label();
            this.DeathMinInput = new System.Windows.Forms.TextBox();
            this.ChanceOfDeathMinLabel = new System.Windows.Forms.Label();
            this.DeathMaxInput = new System.Windows.Forms.TextBox();
            this.ImmunityLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.LifespanLabel = new System.Windows.Forms.Label();
            this.CellRadiusLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CoitusRelaxationMaxLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationMinInput = new System.Windows.Forms.TextBox();
            this.CoitusRelaxationMinLabel = new System.Windows.Forms.Label();
            this.CoitusRelaxationMaxInput = new System.Windows.Forms.TextBox();
            this.MainLayout.SuspendLayout();
            this.ControlsLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.PropertiesTabControl.SuspendLayout();
            this.FieldTabPage.SuspendLayout();
            this.FieldPropertiesGroupBox.SuspendLayout();
            this.FieldPropertiesLayout.SuspendLayout();
            this.FieldSizeLayout.SuspendLayout();
            this.CellsTabPage.SuspendLayout();
            this.CellsPropertiesGroupBox.SuspendLayout();
            this.CellsPropertiesLayout.SuspendLayout();
            this.CellRadiusLayout.SuspendLayout();
            this.LifespanLayout.SuspendLayout();
            this.AgeLayout.SuspendLayout();
            this.ImmunityLayout.SuspendLayout();
            this.ChanceOfDeathLayout.SuspendLayout();
            this.CoitusRelaxationLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.Controls.Add(this.SimulationPanel, 0, 0);
            this.MainLayout.Controls.Add(this.ControlsLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1083, 620);
            this.MainLayout.TabIndex = 0;
            // 
            // SimulationPanel
            // 
            this.SimulationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationPanel.Location = new System.Drawing.Point(5, 5);
            this.SimulationPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SimulationPanel.Name = "SimulationPanel";
            this.SimulationPanel.Size = new System.Drawing.Size(802, 610);
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
            this.ControlsLayout.Location = new System.Drawing.Point(815, 3);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 2;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ControlsLayout.Size = new System.Drawing.Size(265, 614);
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
            this.ButtonsLayout.Size = new System.Drawing.Size(255, 83);
            this.ButtonsLayout.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(5, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 73);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(130, 5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(120, 73);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // PropertiesTabControl
            // 
            this.PropertiesTabControl.Controls.Add(this.FieldTabPage);
            this.PropertiesTabControl.Controls.Add(this.CellsTabPage);
            this.PropertiesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesTabControl.Location = new System.Drawing.Point(3, 3);
            this.PropertiesTabControl.Name = "PropertiesTabControl";
            this.PropertiesTabControl.SelectedIndex = 0;
            this.PropertiesTabControl.Size = new System.Drawing.Size(259, 515);
            this.PropertiesTabControl.TabIndex = 1;
            // 
            // FieldTabPage
            // 
            this.FieldTabPage.Controls.Add(this.FieldPropertiesGroupBox);
            this.FieldTabPage.Location = new System.Drawing.Point(4, 25);
            this.FieldTabPage.Name = "FieldTabPage";
            this.FieldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FieldTabPage.Size = new System.Drawing.Size(251, 486);
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
            this.FieldPropertiesGroupBox.Size = new System.Drawing.Size(245, 480);
            this.FieldPropertiesGroupBox.TabIndex = 1;
            this.FieldPropertiesGroupBox.TabStop = false;
            this.FieldPropertiesGroupBox.Text = "Field properties";
            // 
            // FieldPropertiesLayout
            // 
            this.FieldPropertiesLayout.ColumnCount = 1;
            this.FieldPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FieldPropertiesLayout.Controls.Add(this.CellsOnStartInput, 0, 2);
            this.FieldPropertiesLayout.Controls.Add(this.FieldSizeLayout, 0, 0);
            this.FieldPropertiesLayout.Controls.Add(this.InfectedCellsInput, 0, 4);
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
            this.FieldPropertiesLayout.Size = new System.Drawing.Size(239, 459);
            this.FieldPropertiesLayout.TabIndex = 1;
            // 
            // CellsOnStartInput
            // 
            this.CellsOnStartInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartInput.Location = new System.Drawing.Point(35, 185);
            this.CellsOnStartInput.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.CellsOnStartInput.Name = "CellsOnStartInput";
            this.CellsOnStartInput.Size = new System.Drawing.Size(169, 22);
            this.CellsOnStartInput.TabIndex = 1;
            this.CellsOnStartInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.FieldSizeLayout.Size = new System.Drawing.Size(233, 85);
            this.FieldSizeLayout.TabIndex = 0;
            // 
            // FieldHeightInput
            // 
            this.FieldHeightInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FieldHeightInput.Enabled = false;
            this.FieldHeightInput.Location = new System.Drawing.Point(119, 52);
            this.FieldHeightInput.Name = "FieldHeightInput";
            this.FieldHeightInput.Size = new System.Drawing.Size(108, 22);
            this.FieldHeightInput.TabIndex = 3;
            // 
            // FieldWidthLabel
            // 
            this.FieldWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldWidthLabel.Location = new System.Drawing.Point(5, 10);
            this.FieldWidthLabel.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.FieldWidthLabel.Name = "FieldWidthLabel";
            this.FieldWidthLabel.Size = new System.Drawing.Size(111, 22);
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
            this.FieldHeightLabel.Size = new System.Drawing.Size(111, 23);
            this.FieldHeightLabel.TabIndex = 1;
            this.FieldHeightLabel.Text = "Field height";
            this.FieldHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldWidthInput
            // 
            this.FieldWidthInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FieldWidthInput.Enabled = false;
            this.FieldWidthInput.Location = new System.Drawing.Point(119, 10);
            this.FieldWidthInput.Name = "FieldWidthInput";
            this.FieldWidthInput.Size = new System.Drawing.Size(108, 22);
            this.FieldWidthInput.TabIndex = 2;
            // 
            // InfectedCellsInput
            // 
            this.InfectedCellsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsInput.Location = new System.Drawing.Point(35, 367);
            this.InfectedCellsInput.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.InfectedCellsInput.Name = "InfectedCellsInput";
            this.InfectedCellsInput.Size = new System.Drawing.Size(169, 22);
            this.InfectedCellsInput.TabIndex = 1;
            this.InfectedCellsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfectedCellsLabel
            // 
            this.InfectedCellsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsLabel.Location = new System.Drawing.Point(20, 276);
            this.InfectedCellsLabel.Margin = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.InfectedCellsLabel.Name = "InfectedCellsLabel";
            this.InfectedCellsLabel.Size = new System.Drawing.Size(199, 88);
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
            this.CellsOnStartLabel.Size = new System.Drawing.Size(199, 88);
            this.CellsOnStartLabel.TabIndex = 2;
            this.CellsOnStartLabel.Text = "Cells on start (in total)\r\nmin - 10, max - 2000";
            this.CellsOnStartLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellsTabPage
            // 
            this.CellsTabPage.Controls.Add(this.CellsPropertiesGroupBox);
            this.CellsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CellsTabPage.Name = "CellsTabPage";
            this.CellsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CellsTabPage.Size = new System.Drawing.Size(251, 486);
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
            this.CellsPropertiesGroupBox.Size = new System.Drawing.Size(245, 480);
            this.CellsPropertiesGroupBox.TabIndex = 0;
            this.CellsPropertiesGroupBox.TabStop = false;
            this.CellsPropertiesGroupBox.Text = "Cells properties";
            // 
            // CellsPropertiesLayout
            // 
            this.CellsPropertiesLayout.ColumnCount = 1;
            this.CellsPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationLayout, 0, 13);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusLayout, 0, 11);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanLayout, 0, 5);
            this.CellsPropertiesLayout.Controls.Add(this.AgeLayout, 0, 3);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityLayout, 0, 9);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfDeathLabel, 0, 6);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfBirthLabel, 0, 0);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfBirthInput, 0, 1);
            this.CellsPropertiesLayout.Controls.Add(this.ChanceOfDeathLayout, 0, 7);
            this.CellsPropertiesLayout.Controls.Add(this.ImmunityLabel, 0, 8);
            this.CellsPropertiesLayout.Controls.Add(this.AgeLabel, 0, 2);
            this.CellsPropertiesLayout.Controls.Add(this.LifespanLabel, 0, 4);
            this.CellsPropertiesLayout.Controls.Add(this.CellRadiusLabel, 0, 10);
            this.CellsPropertiesLayout.Controls.Add(this.CoitusRelaxationLabel, 0, 12);
            this.CellsPropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsPropertiesLayout.Location = new System.Drawing.Point(3, 18);
            this.CellsPropertiesLayout.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.CellsPropertiesLayout.Name = "CellsPropertiesLayout";
            this.CellsPropertiesLayout.RowCount = 14;
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.278867F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.664488F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.843137F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.100218F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.753813F));
            this.CellsPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45752F));
            this.CellsPropertiesLayout.Size = new System.Drawing.Size(239, 459);
            this.CellsPropertiesLayout.TabIndex = 0;
            // 
            // CellRadiusLayout
            // 
            this.CellRadiusLayout.ColumnCount = 4;
            this.CellRadiusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellRadiusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellRadiusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellRadiusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CellRadiusLayout.Controls.Add(this.CellRadiusMaxLabel, 2, 0);
            this.CellRadiusLayout.Controls.Add(this.CellRadiusMinInput, 1, 0);
            this.CellRadiusLayout.Controls.Add(this.CellRadiusMinLabel, 0, 0);
            this.CellRadiusLayout.Controls.Add(this.CellRadiusMaxInput, 3, 0);
            this.CellRadiusLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusLayout.Location = new System.Drawing.Point(3, 351);
            this.CellRadiusLayout.Name = "CellRadiusLayout";
            this.CellRadiusLayout.RowCount = 1;
            this.CellRadiusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CellRadiusLayout.Size = new System.Drawing.Size(233, 26);
            this.CellRadiusLayout.TabIndex = 11;
            // 
            // CellRadiusMaxLabel
            // 
            this.CellRadiusMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusMaxLabel.Location = new System.Drawing.Point(119, 0);
            this.CellRadiusMaxLabel.Name = "CellRadiusMaxLabel";
            this.CellRadiusMaxLabel.Size = new System.Drawing.Size(52, 26);
            this.CellRadiusMaxLabel.TabIndex = 3;
            this.CellRadiusMaxLabel.Text = "Max";
            this.CellRadiusMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellRadiusMinInput
            // 
            this.CellRadiusMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CellRadiusMinInput.Location = new System.Drawing.Point(61, 3);
            this.CellRadiusMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CellRadiusMinInput.Name = "CellRadiusMinInput";
            this.CellRadiusMinInput.Size = new System.Drawing.Size(45, 22);
            this.CellRadiusMinInput.TabIndex = 1;
            // 
            // CellRadiusMinLabel
            // 
            this.CellRadiusMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusMinLabel.Location = new System.Drawing.Point(3, 0);
            this.CellRadiusMinLabel.Name = "CellRadiusMinLabel";
            this.CellRadiusMinLabel.Size = new System.Drawing.Size(52, 26);
            this.CellRadiusMinLabel.TabIndex = 0;
            this.CellRadiusMinLabel.Text = "Min";
            this.CellRadiusMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CellRadiusMaxInput
            // 
            this.CellRadiusMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CellRadiusMaxInput.Location = new System.Drawing.Point(177, 3);
            this.CellRadiusMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CellRadiusMaxInput.Name = "CellRadiusMaxInput";
            this.CellRadiusMaxInput.Size = new System.Drawing.Size(46, 22);
            this.CellRadiusMaxInput.TabIndex = 2;
            // 
            // LifespanLayout
            // 
            this.LifespanLayout.ColumnCount = 4;
            this.LifespanLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LifespanLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LifespanLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LifespanLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LifespanLayout.Controls.Add(this.LifespanMaxLabel, 2, 0);
            this.LifespanLayout.Controls.Add(this.LifespanMinInput, 1, 0);
            this.LifespanLayout.Controls.Add(this.LifespanMinLabel, 0, 0);
            this.LifespanLayout.Controls.Add(this.LifespanMaxInput, 3, 0);
            this.LifespanLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanLayout.Location = new System.Drawing.Point(3, 163);
            this.LifespanLayout.Name = "LifespanLayout";
            this.LifespanLayout.RowCount = 1;
            this.LifespanLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LifespanLayout.Size = new System.Drawing.Size(233, 26);
            this.LifespanLayout.TabIndex = 9;
            // 
            // LifespanMaxLabel
            // 
            this.LifespanMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanMaxLabel.Location = new System.Drawing.Point(119, 0);
            this.LifespanMaxLabel.Name = "LifespanMaxLabel";
            this.LifespanMaxLabel.Size = new System.Drawing.Size(52, 26);
            this.LifespanMaxLabel.TabIndex = 3;
            this.LifespanMaxLabel.Text = "Max";
            this.LifespanMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LifespanMinInput
            // 
            this.LifespanMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LifespanMinInput.Location = new System.Drawing.Point(61, 3);
            this.LifespanMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.LifespanMinInput.Name = "LifespanMinInput";
            this.LifespanMinInput.Size = new System.Drawing.Size(45, 22);
            this.LifespanMinInput.TabIndex = 1;
            // 
            // LifespanMinLabel
            // 
            this.LifespanMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanMinLabel.Location = new System.Drawing.Point(3, 0);
            this.LifespanMinLabel.Name = "LifespanMinLabel";
            this.LifespanMinLabel.Size = new System.Drawing.Size(52, 26);
            this.LifespanMinLabel.TabIndex = 0;
            this.LifespanMinLabel.Text = "Min";
            this.LifespanMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LifespanMaxInput
            // 
            this.LifespanMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LifespanMaxInput.Location = new System.Drawing.Point(177, 3);
            this.LifespanMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.LifespanMaxInput.Name = "LifespanMaxInput";
            this.LifespanMaxInput.Size = new System.Drawing.Size(46, 22);
            this.LifespanMaxInput.TabIndex = 2;
            // 
            // AgeLayout
            // 
            this.AgeLayout.ColumnCount = 4;
            this.AgeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AgeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AgeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AgeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AgeLayout.Controls.Add(this.AgeMaxLabel, 2, 0);
            this.AgeLayout.Controls.Add(this.AgeMinInput, 1, 0);
            this.AgeLayout.Controls.Add(this.AgeMinLabel, 0, 0);
            this.AgeLayout.Controls.Add(this.AgeMaxInput, 3, 0);
            this.AgeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeLayout.Location = new System.Drawing.Point(3, 99);
            this.AgeLayout.Name = "AgeLayout";
            this.AgeLayout.RowCount = 1;
            this.AgeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AgeLayout.Size = new System.Drawing.Size(233, 26);
            this.AgeLayout.TabIndex = 7;
            // 
            // AgeMaxLabel
            // 
            this.AgeMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeMaxLabel.Location = new System.Drawing.Point(119, 0);
            this.AgeMaxLabel.Name = "AgeMaxLabel";
            this.AgeMaxLabel.Size = new System.Drawing.Size(52, 26);
            this.AgeMaxLabel.TabIndex = 3;
            this.AgeMaxLabel.Text = "Max";
            this.AgeMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AgeMinInput
            // 
            this.AgeMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeMinInput.Location = new System.Drawing.Point(61, 3);
            this.AgeMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AgeMinInput.Name = "AgeMinInput";
            this.AgeMinInput.Size = new System.Drawing.Size(45, 22);
            this.AgeMinInput.TabIndex = 1;
            // 
            // AgeMinLabel
            // 
            this.AgeMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeMinLabel.Location = new System.Drawing.Point(3, 0);
            this.AgeMinLabel.Name = "AgeMinLabel";
            this.AgeMinLabel.Size = new System.Drawing.Size(52, 26);
            this.AgeMinLabel.TabIndex = 0;
            this.AgeMinLabel.Text = "Min";
            this.AgeMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AgeMaxInput
            // 
            this.AgeMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeMaxInput.Location = new System.Drawing.Point(177, 3);
            this.AgeMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AgeMaxInput.Name = "AgeMaxInput";
            this.AgeMaxInput.Size = new System.Drawing.Size(46, 22);
            this.AgeMaxInput.TabIndex = 2;
            // 
            // ImmunityLayout
            // 
            this.ImmunityLayout.ColumnCount = 4;
            this.ImmunityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImmunityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImmunityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImmunityLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImmunityLayout.Controls.Add(this.ImmunityMaxLabel, 2, 0);
            this.ImmunityLayout.Controls.Add(this.ImmunityMinInput, 1, 0);
            this.ImmunityLayout.Controls.Add(this.ImmunityMinLabel, 0, 0);
            this.ImmunityLayout.Controls.Add(this.ImmunityMaxInput, 3, 0);
            this.ImmunityLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityLayout.Location = new System.Drawing.Point(3, 289);
            this.ImmunityLayout.Name = "ImmunityLayout";
            this.ImmunityLayout.RowCount = 1;
            this.ImmunityLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImmunityLayout.Size = new System.Drawing.Size(233, 29);
            this.ImmunityLayout.TabIndex = 5;
            // 
            // ImmunityMaxLabel
            // 
            this.ImmunityMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityMaxLabel.Location = new System.Drawing.Point(119, 0);
            this.ImmunityMaxLabel.Name = "ImmunityMaxLabel";
            this.ImmunityMaxLabel.Size = new System.Drawing.Size(52, 29);
            this.ImmunityMaxLabel.TabIndex = 3;
            this.ImmunityMaxLabel.Text = "Max";
            this.ImmunityMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImmunityMinInput
            // 
            this.ImmunityMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImmunityMinInput.Location = new System.Drawing.Point(61, 3);
            this.ImmunityMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ImmunityMinInput.Name = "ImmunityMinInput";
            this.ImmunityMinInput.Size = new System.Drawing.Size(45, 22);
            this.ImmunityMinInput.TabIndex = 1;
            // 
            // ImmunityMinLabel
            // 
            this.ImmunityMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityMinLabel.Location = new System.Drawing.Point(3, 0);
            this.ImmunityMinLabel.Name = "ImmunityMinLabel";
            this.ImmunityMinLabel.Size = new System.Drawing.Size(52, 29);
            this.ImmunityMinLabel.TabIndex = 0;
            this.ImmunityMinLabel.Text = "Min";
            this.ImmunityMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImmunityMaxInput
            // 
            this.ImmunityMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImmunityMaxInput.Location = new System.Drawing.Point(177, 3);
            this.ImmunityMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ImmunityMaxInput.Name = "ImmunityMaxInput";
            this.ImmunityMaxInput.Size = new System.Drawing.Size(46, 22);
            this.ImmunityMaxInput.TabIndex = 2;
            // 
            // ChanceOfDeathLabel
            // 
            this.ChanceOfDeathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathLabel.Location = new System.Drawing.Point(10, 202);
            this.ChanceOfDeathLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ChanceOfDeathLabel.Name = "ChanceOfDeathLabel";
            this.ChanceOfDeathLabel.Size = new System.Drawing.Size(219, 22);
            this.ChanceOfDeathLabel.TabIndex = 2;
            this.ChanceOfDeathLabel.Text = "chance of death ( 0-1 )";
            this.ChanceOfDeathLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ChanceOfBirthLabel
            // 
            this.ChanceOfBirthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfBirthLabel.Location = new System.Drawing.Point(10, 10);
            this.ChanceOfBirthLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ChanceOfBirthLabel.Name = "ChanceOfBirthLabel";
            this.ChanceOfBirthLabel.Size = new System.Drawing.Size(219, 22);
            this.ChanceOfBirthLabel.TabIndex = 1;
            this.ChanceOfBirthLabel.Text = "chance of birth ( 0-1 )";
            this.ChanceOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ChanceOfBirthInput
            // 
            this.ChanceOfBirthInput.Location = new System.Drawing.Point(35, 34);
            this.ChanceOfBirthInput.Margin = new System.Windows.Forms.Padding(35, 2, 35, 2);
            this.ChanceOfBirthInput.Name = "ChanceOfBirthInput";
            this.ChanceOfBirthInput.Size = new System.Drawing.Size(163, 22);
            this.ChanceOfBirthInput.TabIndex = 0;
            // 
            // ChanceOfDeathLayout
            // 
            this.ChanceOfDeathLayout.ColumnCount = 4;
            this.ChanceOfDeathLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChanceOfDeathLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChanceOfDeathLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChanceOfDeathLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChanceOfDeathLayout.Controls.Add(this.ChanceOfDeathMaxLabel, 2, 0);
            this.ChanceOfDeathLayout.Controls.Add(this.DeathMinInput, 1, 0);
            this.ChanceOfDeathLayout.Controls.Add(this.ChanceOfDeathMinLabel, 0, 0);
            this.ChanceOfDeathLayout.Controls.Add(this.DeathMaxInput, 3, 0);
            this.ChanceOfDeathLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathLayout.Location = new System.Drawing.Point(5, 229);
            this.ChanceOfDeathLayout.Margin = new System.Windows.Forms.Padding(5);
            this.ChanceOfDeathLayout.Name = "ChanceOfDeathLayout";
            this.ChanceOfDeathLayout.RowCount = 1;
            this.ChanceOfDeathLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChanceOfDeathLayout.Size = new System.Drawing.Size(229, 27);
            this.ChanceOfDeathLayout.TabIndex = 3;
            // 
            // ChanceOfDeathMaxLabel
            // 
            this.ChanceOfDeathMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathMaxLabel.Location = new System.Drawing.Point(117, 0);
            this.ChanceOfDeathMaxLabel.Name = "ChanceOfDeathMaxLabel";
            this.ChanceOfDeathMaxLabel.Size = new System.Drawing.Size(51, 27);
            this.ChanceOfDeathMaxLabel.TabIndex = 3;
            this.ChanceOfDeathMaxLabel.Text = "Max";
            this.ChanceOfDeathMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeathMinInput
            // 
            this.DeathMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathMinInput.Location = new System.Drawing.Point(60, 3);
            this.DeathMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DeathMinInput.Name = "DeathMinInput";
            this.DeathMinInput.Size = new System.Drawing.Size(44, 22);
            this.DeathMinInput.TabIndex = 1;
            // 
            // ChanceOfDeathMinLabel
            // 
            this.ChanceOfDeathMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChanceOfDeathMinLabel.Location = new System.Drawing.Point(3, 0);
            this.ChanceOfDeathMinLabel.Name = "ChanceOfDeathMinLabel";
            this.ChanceOfDeathMinLabel.Size = new System.Drawing.Size(51, 27);
            this.ChanceOfDeathMinLabel.TabIndex = 0;
            this.ChanceOfDeathMinLabel.Text = "Min";
            this.ChanceOfDeathMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeathMaxInput
            // 
            this.DeathMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathMaxInput.Location = new System.Drawing.Point(174, 3);
            this.DeathMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DeathMaxInput.Name = "DeathMaxInput";
            this.DeathMaxInput.Size = new System.Drawing.Size(45, 22);
            this.DeathMaxInput.TabIndex = 2;
            // 
            // ImmunityLabel
            // 
            this.ImmunityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImmunityLabel.Location = new System.Drawing.Point(10, 264);
            this.ImmunityLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ImmunityLabel.Name = "ImmunityLabel";
            this.ImmunityLabel.Size = new System.Drawing.Size(219, 19);
            this.ImmunityLabel.TabIndex = 4;
            this.ImmunityLabel.Text = "Immunity ( 0-1 )";
            this.ImmunityLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AgeLabel
            // 
            this.AgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeLabel.Location = new System.Drawing.Point(10, 67);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(219, 29);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "age (iterations)";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LifespanLabel
            // 
            this.LifespanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifespanLabel.Location = new System.Drawing.Point(3, 128);
            this.LifespanLabel.Name = "LifespanLabel";
            this.LifespanLabel.Size = new System.Drawing.Size(233, 32);
            this.LifespanLabel.TabIndex = 8;
            this.LifespanLabel.Text = "lifespan (iterations)";
            this.LifespanLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellRadiusLabel
            // 
            this.CellRadiusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellRadiusLabel.Location = new System.Drawing.Point(3, 321);
            this.CellRadiusLabel.Name = "CellRadiusLabel";
            this.CellRadiusLabel.Size = new System.Drawing.Size(233, 27);
            this.CellRadiusLabel.TabIndex = 10;
            this.CellRadiusLabel.Text = "cell radius  ( 1-10 )";
            this.CellRadiusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CoitusRelaxationLabel
            // 
            this.CoitusRelaxationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationLabel.Location = new System.Drawing.Point(3, 380);
            this.CoitusRelaxationLabel.Name = "CoitusRelaxationLabel";
            this.CoitusRelaxationLabel.Size = new System.Drawing.Size(233, 30);
            this.CoitusRelaxationLabel.TabIndex = 12;
            this.CoitusRelaxationLabel.Text = "coitus relaxation";
            this.CoitusRelaxationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CoitusRelaxationLayout
            // 
            this.CoitusRelaxationLayout.ColumnCount = 4;
            this.CoitusRelaxationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CoitusRelaxationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CoitusRelaxationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CoitusRelaxationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CoitusRelaxationLayout.Controls.Add(this.CoitusRelaxationMaxLabel, 2, 0);
            this.CoitusRelaxationLayout.Controls.Add(this.CoitusRelaxationMinInput, 1, 0);
            this.CoitusRelaxationLayout.Controls.Add(this.CoitusRelaxationMinLabel, 0, 0);
            this.CoitusRelaxationLayout.Controls.Add(this.CoitusRelaxationMaxInput, 3, 0);
            this.CoitusRelaxationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationLayout.Location = new System.Drawing.Point(3, 413);
            this.CoitusRelaxationLayout.Name = "CoitusRelaxationLayout";
            this.CoitusRelaxationLayout.RowCount = 1;
            this.CoitusRelaxationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CoitusRelaxationLayout.Size = new System.Drawing.Size(233, 43);
            this.CoitusRelaxationLayout.TabIndex = 13;
            // 
            // CoitusRelaxationMaxLabel
            // 
            this.CoitusRelaxationMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationMaxLabel.Location = new System.Drawing.Point(119, 0);
            this.CoitusRelaxationMaxLabel.Name = "CoitusRelaxationMaxLabel";
            this.CoitusRelaxationMaxLabel.Size = new System.Drawing.Size(52, 43);
            this.CoitusRelaxationMaxLabel.TabIndex = 3;
            this.CoitusRelaxationMaxLabel.Text = "Max";
            this.CoitusRelaxationMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoitusRelaxationMinInput
            // 
            this.CoitusRelaxationMinInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CoitusRelaxationMinInput.Location = new System.Drawing.Point(61, 10);
            this.CoitusRelaxationMinInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CoitusRelaxationMinInput.Name = "CoitusRelaxationMinInput";
            this.CoitusRelaxationMinInput.Size = new System.Drawing.Size(45, 22);
            this.CoitusRelaxationMinInput.TabIndex = 1;
            // 
            // CoitusRelaxationMinLabel
            // 
            this.CoitusRelaxationMinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoitusRelaxationMinLabel.Location = new System.Drawing.Point(3, 0);
            this.CoitusRelaxationMinLabel.Name = "CoitusRelaxationMinLabel";
            this.CoitusRelaxationMinLabel.Size = new System.Drawing.Size(52, 43);
            this.CoitusRelaxationMinLabel.TabIndex = 0;
            this.CoitusRelaxationMinLabel.Text = "Min";
            this.CoitusRelaxationMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoitusRelaxationMaxInput
            // 
            this.CoitusRelaxationMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CoitusRelaxationMaxInput.Location = new System.Drawing.Point(177, 10);
            this.CoitusRelaxationMaxInput.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.CoitusRelaxationMaxInput.Name = "CoitusRelaxationMaxInput";
            this.CoitusRelaxationMaxInput.Size = new System.Drawing.Size(46, 22);
            this.CoitusRelaxationMaxInput.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1083, 620);
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
            this.FieldPropertiesLayout.PerformLayout();
            this.FieldSizeLayout.ResumeLayout(false);
            this.FieldSizeLayout.PerformLayout();
            this.CellsTabPage.ResumeLayout(false);
            this.CellsPropertiesGroupBox.ResumeLayout(false);
            this.CellsPropertiesLayout.ResumeLayout(false);
            this.CellsPropertiesLayout.PerformLayout();
            this.CellRadiusLayout.ResumeLayout(false);
            this.CellRadiusLayout.PerformLayout();
            this.LifespanLayout.ResumeLayout(false);
            this.LifespanLayout.PerformLayout();
            this.AgeLayout.ResumeLayout(false);
            this.AgeLayout.PerformLayout();
            this.ImmunityLayout.ResumeLayout(false);
            this.ImmunityLayout.PerformLayout();
            this.ChanceOfDeathLayout.ResumeLayout(false);
            this.ChanceOfDeathLayout.PerformLayout();
            this.CoitusRelaxationLayout.ResumeLayout(false);
            this.CoitusRelaxationLayout.PerformLayout();
            this.ResumeLayout(false);
        }


        
        private System.Windows.Forms.TableLayoutPanel CoitusRelaxationLayout;
        private System.Windows.Forms.TextBox CoitusRelaxationMaxInput;
        private System.Windows.Forms.TextBox CoitusRelaxationMinInput;
        private System.Windows.Forms.Label CoitusRelaxationMinLabel;
        private System.Windows.Forms.Label CoitusRelaxationMaxLabel;
        private System.Windows.Forms.Label CoitusRelaxationLabel;


        private System.Windows.Forms.TableLayoutPanel CellRadiusLayout;
        private System.Windows.Forms.TextBox CellRadiusMinInput;
        private System.Windows.Forms.TextBox CellRadiusMaxInput;
        private System.Windows.Forms.Label CellRadiusMaxLabel;
        private System.Windows.Forms.Label CellRadiusMinLabel;
        private System.Windows.Forms.Label CellRadiusLabel;


        private System.Windows.Forms.TableLayoutPanel LifespanLayout;
        private System.Windows.Forms.TextBox LifespanMinInput;
        private System.Windows.Forms.TextBox LifespanMaxInput;
        private System.Windows.Forms.Label LifespanMaxLabel;
        private System.Windows.Forms.Label LifespanMinLabel;
        private System.Windows.Forms.Label LifespanLabel;

        private System.Windows.Forms.TableLayoutPanel AgeLayout;
        private System.Windows.Forms.TextBox AgeMinInput;
        private System.Windows.Forms.TextBox AgeMaxInput;
        private System.Windows.Forms.Label AgeMaxLabel;
        private System.Windows.Forms.Label AgeMinLabel;
        private System.Windows.Forms.Label AgeLabel;
        
        
        private System.Windows.Forms.TableLayoutPanel ImmunityLayout;
        private System.Windows.Forms.TextBox ImmunityMinInput;
        private System.Windows.Forms.TextBox ImmunityMaxInput;
        private System.Windows.Forms.Label ImmunityMinLabel;
        private System.Windows.Forms.Label ImmunityMaxLabel;
        private System.Windows.Forms.Label ImmunityLabel;
        
        private System.Windows.Forms.TableLayoutPanel ChanceOfDeathLayout;
        private System.Windows.Forms.Label ChanceOfDeathMaxLabel;
        private System.Windows.Forms.Label ChanceOfDeathMinLabel;
        private System.Windows.Forms.Label ChanceOfDeathLabel;
        private System.Windows.Forms.TextBox DeathMinInput;
        private System.Windows.Forms.TextBox DeathMaxInput;
        
        
        private System.Windows.Forms.Label ChanceOfBirthLabel;
        private System.Windows.Forms.TextBox ChanceOfBirthInput;
        private System.Windows.Forms.TableLayoutPanel CellsPropertiesLayout;
        private System.Windows.Forms.GroupBox CellsPropertiesGroupBox;


        private System.Windows.Forms.Label InfectedCellsLabel;
        private System.Windows.Forms.Label CellsOnStartLabel;
        private System.Windows.Forms.TextBox CellsOnStartInput;
        private System.Windows.Forms.TextBox InfectedCellsInput;
        
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