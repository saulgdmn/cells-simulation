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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.simulationPanel = new LifeProj.View.SimulationPanel();
            this.controlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.PropertiesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FieldPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.fieldPropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InfectedCellsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InfectedCellsTextBox = new System.Windows.Forms.TextBox();
            this.InfectedCellsLabel = new System.Windows.Forms.Label();
            this.InfectedCellsOnStartConstraintLabel = new System.Windows.Forms.Label();
            this.fieldSizePropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FieldHeightTextBox = new System.Windows.Forms.TextBox();
            this.FieldWidthLabel = new System.Windows.Forms.Label();
            this.FieldHeight = new System.Windows.Forms.Label();
            this.FieldWidthTextBox = new System.Windows.Forms.TextBox();
            this.CellsOnStartLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CellsOnStartTextBox = new System.Windows.Forms.TextBox();
            this.CellsOnStartLabel = new System.Windows.Forms.Label();
            this.CellsOnStartConstraintLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.controlsLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
            this.PropertiesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FieldPropertiesGroupBox.SuspendLayout();
            this.fieldPropertiesLayout.SuspendLayout();
            this.InfectedCellsLayout.SuspendLayout();
            this.fieldSizePropertiesLayout.SuspendLayout();
            this.CellsOnStartLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Controls.Add(this.simulationPanel, 0, 0);
            this.mainLayout.Controls.Add(this.controlsLayout, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1083, 620);
            this.mainLayout.TabIndex = 0;
            // 
            // simulationPanel
            // 
            this.simulationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulationPanel.Location = new System.Drawing.Point(5, 5);
            this.simulationPanel.Margin = new System.Windows.Forms.Padding(5);
            this.simulationPanel.Name = "simulationPanel";
            this.simulationPanel.Size = new System.Drawing.Size(802, 610);
            this.simulationPanel.TabIndex = 0;
            this.simulationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationPanel_Paint);
            // 
            // controlsLayout
            // 
            this.controlsLayout.ColumnCount = 1;
            this.controlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlsLayout.Controls.Add(this.buttonsLayout, 0, 1);
            this.controlsLayout.Controls.Add(this.PropertiesTabControl, 0, 0);
            this.controlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLayout.Location = new System.Drawing.Point(815, 3);
            this.controlsLayout.Name = "controlsLayout";
            this.controlsLayout.RowCount = 2;
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.controlsLayout.Size = new System.Drawing.Size(265, 614);
            this.controlsLayout.TabIndex = 1;
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.ColumnCount = 2;
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.Controls.Add(this.startButton, 0, 0);
            this.buttonsLayout.Controls.Add(this.pauseButton, 1, 0);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayout.Location = new System.Drawing.Point(5, 526);
            this.buttonsLayout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Padding = new System.Windows.Forms.Padding(2);
            this.buttonsLayout.RowCount = 1;
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsLayout.Size = new System.Drawing.Size(255, 83);
            this.buttonsLayout.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Location = new System.Drawing.Point(5, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 73);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(130, 5);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 73);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // PropertiesTabControl
            // 
            this.PropertiesTabControl.Controls.Add(this.tabPage1);
            this.PropertiesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesTabControl.Location = new System.Drawing.Point(3, 3);
            this.PropertiesTabControl.Name = "PropertiesTabControl";
            this.PropertiesTabControl.SelectedIndex = 0;
            this.PropertiesTabControl.Size = new System.Drawing.Size(259, 515);
            this.PropertiesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FieldPropertiesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Field and cells";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FieldPropertiesGroupBox
            // 
            this.FieldPropertiesGroupBox.Controls.Add(this.fieldPropertiesLayout);
            this.FieldPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPropertiesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FieldPropertiesGroupBox.Name = "FieldPropertiesGroupBox";
            this.FieldPropertiesGroupBox.Size = new System.Drawing.Size(245, 480);
            this.FieldPropertiesGroupBox.TabIndex = 1;
            this.FieldPropertiesGroupBox.TabStop = false;
            this.FieldPropertiesGroupBox.Text = "Field properties";
            // 
            // fieldPropertiesLayout
            // 
            this.fieldPropertiesLayout.ColumnCount = 1;
            this.fieldPropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fieldPropertiesLayout.Controls.Add(this.InfectedCellsLayout, 0, 2);
            this.fieldPropertiesLayout.Controls.Add(this.fieldSizePropertiesLayout, 0, 0);
            this.fieldPropertiesLayout.Controls.Add(this.CellsOnStartLayout, 0, 1);
            this.fieldPropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPropertiesLayout.Location = new System.Drawing.Point(3, 18);
            this.fieldPropertiesLayout.Margin = new System.Windows.Forms.Padding(5);
            this.fieldPropertiesLayout.Name = "fieldPropertiesLayout";
            this.fieldPropertiesLayout.RowCount = 3;
            this.fieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPropertiesLayout.Size = new System.Drawing.Size(239, 459);
            this.fieldPropertiesLayout.TabIndex = 1;
            // 
            // InfectedCellsLayout
            // 
            this.InfectedCellsLayout.ColumnCount = 1;
            this.InfectedCellsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfectedCellsLayout.Controls.Add(this.InfectedCellsTextBox, 0, 1);
            this.InfectedCellsLayout.Controls.Add(this.InfectedCellsLabel, 0, 0);
            this.InfectedCellsLayout.Controls.Add(this.InfectedCellsOnStartConstraintLabel, 0, 2);
            this.InfectedCellsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsLayout.Location = new System.Drawing.Point(5, 309);
            this.InfectedCellsLayout.Margin = new System.Windows.Forms.Padding(5);
            this.InfectedCellsLayout.MinimumSize = new System.Drawing.Size(0, 70);
            this.InfectedCellsLayout.Name = "InfectedCellsLayout";
            this.InfectedCellsLayout.RowCount = 3;
            this.InfectedCellsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfectedCellsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.InfectedCellsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfectedCellsLayout.Size = new System.Drawing.Size(229, 145);
            this.InfectedCellsLayout.TabIndex = 3;
            // 
            // InfectedCellsTextBox
            // 
            this.InfectedCellsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsTextBox.Location = new System.Drawing.Point(35, 64);
            this.InfectedCellsTextBox.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.InfectedCellsTextBox.Name = "InfectedCellsTextBox";
            this.InfectedCellsTextBox.Size = new System.Drawing.Size(159, 22);
            this.InfectedCellsTextBox.TabIndex = 1;
            this.InfectedCellsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfectedCellsLabel
            // 
            this.InfectedCellsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsLabel.Location = new System.Drawing.Point(3, 0);
            this.InfectedCellsLabel.Name = "InfectedCellsLabel";
            this.InfectedCellsLabel.Size = new System.Drawing.Size(223, 61);
            this.InfectedCellsLabel.TabIndex = 2;
            this.InfectedCellsLabel.Text = "Infected cells count";
            this.InfectedCellsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // InfectedCellsOnStartConstraintLabel
            // 
            this.InfectedCellsOnStartConstraintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfectedCellsOnStartConstraintLabel.Location = new System.Drawing.Point(3, 84);
            this.InfectedCellsOnStartConstraintLabel.Name = "InfectedCellsOnStartConstraintLabel";
            this.InfectedCellsOnStartConstraintLabel.Size = new System.Drawing.Size(223, 61);
            this.InfectedCellsOnStartConstraintLabel.TabIndex = 3;
            this.InfectedCellsOnStartConstraintLabel.Text = "min - 10, max - 2000";
            this.InfectedCellsOnStartConstraintLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldSizePropertiesLayout
            // 
            this.fieldSizePropertiesLayout.ColumnCount = 2;
            this.fieldSizePropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldSizePropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldSizePropertiesLayout.Controls.Add(this.FieldHeightTextBox, 1, 1);
            this.fieldSizePropertiesLayout.Controls.Add(this.FieldWidthLabel, 0, 0);
            this.fieldSizePropertiesLayout.Controls.Add(this.FieldHeight, 0, 1);
            this.fieldSizePropertiesLayout.Controls.Add(this.FieldWidthTextBox, 1, 0);
            this.fieldSizePropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldSizePropertiesLayout.Location = new System.Drawing.Point(3, 3);
            this.fieldSizePropertiesLayout.MinimumSize = new System.Drawing.Size(0, 55);
            this.fieldSizePropertiesLayout.Name = "fieldSizePropertiesLayout";
            this.fieldSizePropertiesLayout.RowCount = 2;
            this.fieldSizePropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldSizePropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldSizePropertiesLayout.Size = new System.Drawing.Size(233, 146);
            this.fieldSizePropertiesLayout.TabIndex = 0;
            // 
            // FieldHeightTextBox
            // 
            this.FieldHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FieldHeightTextBox.Enabled = false;
            this.FieldHeightTextBox.Location = new System.Drawing.Point(119, 98);
            this.FieldHeightTextBox.Name = "FieldHeightTextBox";
            this.FieldHeightTextBox.Size = new System.Drawing.Size(108, 22);
            this.FieldHeightTextBox.TabIndex = 3;
            // 
            // FieldWidthLabel
            // 
            this.FieldWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldWidthLabel.Location = new System.Drawing.Point(3, 3);
            this.FieldWidthLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FieldWidthLabel.Name = "FieldWidthLabel";
            this.FieldWidthLabel.Size = new System.Drawing.Size(110, 67);
            this.FieldWidthLabel.TabIndex = 0;
            this.FieldWidthLabel.Text = "Field width";
            this.FieldWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldHeight
            // 
            this.FieldHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldHeight.Location = new System.Drawing.Point(3, 76);
            this.FieldHeight.Margin = new System.Windows.Forms.Padding(3);
            this.FieldHeight.Name = "FieldHeight";
            this.FieldHeight.Size = new System.Drawing.Size(110, 67);
            this.FieldHeight.TabIndex = 1;
            this.FieldHeight.Text = "Field height";
            this.FieldHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FieldWidthTextBox
            // 
            this.FieldWidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FieldWidthTextBox.Enabled = false;
            this.FieldWidthTextBox.Location = new System.Drawing.Point(119, 25);
            this.FieldWidthTextBox.Name = "FieldWidthTextBox";
            this.FieldWidthTextBox.Size = new System.Drawing.Size(108, 22);
            this.FieldWidthTextBox.TabIndex = 2;
            // 
            // CellsOnStartLayout
            // 
            this.CellsOnStartLayout.ColumnCount = 1;
            this.CellsOnStartLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CellsOnStartLayout.Controls.Add(this.CellsOnStartTextBox, 0, 1);
            this.CellsOnStartLayout.Controls.Add(this.CellsOnStartLabel, 0, 0);
            this.CellsOnStartLayout.Controls.Add(this.CellsOnStartConstraintLabel, 0, 2);
            this.CellsOnStartLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartLayout.Location = new System.Drawing.Point(5, 157);
            this.CellsOnStartLayout.Margin = new System.Windows.Forms.Padding(5);
            this.CellsOnStartLayout.MinimumSize = new System.Drawing.Size(0, 70);
            this.CellsOnStartLayout.Name = "CellsOnStartLayout";
            this.CellsOnStartLayout.RowCount = 3;
            this.CellsOnStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CellsOnStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.CellsOnStartLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CellsOnStartLayout.Size = new System.Drawing.Size(229, 142);
            this.CellsOnStartLayout.TabIndex = 2;
            // 
            // CellsOnStartTextBox
            // 
            this.CellsOnStartTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartTextBox.Location = new System.Drawing.Point(35, 62);
            this.CellsOnStartTextBox.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.CellsOnStartTextBox.Name = "CellsOnStartTextBox";
            this.CellsOnStartTextBox.Size = new System.Drawing.Size(159, 22);
            this.CellsOnStartTextBox.TabIndex = 1;
            this.CellsOnStartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CellsOnStartLabel
            // 
            this.CellsOnStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartLabel.Location = new System.Drawing.Point(3, 0);
            this.CellsOnStartLabel.Name = "CellsOnStartLabel";
            this.CellsOnStartLabel.Size = new System.Drawing.Size(223, 59);
            this.CellsOnStartLabel.TabIndex = 2;
            this.CellsOnStartLabel.Text = "Cells on start (in total)";
            this.CellsOnStartLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CellsOnStartConstraintLabel
            // 
            this.CellsOnStartConstraintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsOnStartConstraintLabel.Location = new System.Drawing.Point(3, 82);
            this.CellsOnStartConstraintLabel.Name = "CellsOnStartConstraintLabel";
            this.CellsOnStartConstraintLabel.Size = new System.Drawing.Size(223, 60);
            this.CellsOnStartConstraintLabel.TabIndex = 3;
            this.CellsOnStartConstraintLabel.Text = "min - 10, max - 2000";
            this.CellsOnStartConstraintLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(35, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Infected cells count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "min - 10, max - 2000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "MainForm";
            this.Text = "Life simulation";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainLayout.ResumeLayout(false);
            this.controlsLayout.ResumeLayout(false);
            this.buttonsLayout.ResumeLayout(false);
            this.PropertiesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.FieldPropertiesGroupBox.ResumeLayout(false);
            this.fieldPropertiesLayout.ResumeLayout(false);
            this.InfectedCellsLayout.ResumeLayout(false);
            this.InfectedCellsLayout.PerformLayout();
            this.fieldSizePropertiesLayout.ResumeLayout(false);
            this.fieldSizePropertiesLayout.PerformLayout();
            this.CellsOnStartLayout.ResumeLayout(false);
            this.CellsOnStartLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label InfectedCellsLabel;
        private System.Windows.Forms.TextBox InfectedCellsTextBox;
        
        private System.Windows.Forms.TableLayoutPanel InfectedCellsLayout;
        private System.Windows.Forms.TableLayoutPanel CellsOnStartLayout;
        
        private System.Windows.Forms.Label InfectedCellsOnStartConstraintLabel;

        private System.Windows.Forms.Label CellsOnStartConstraintLabel;

        private System.Windows.Forms.TextBox CellsOnStartTextBox;
        private System.Windows.Forms.Label CellsOnStartLabel;

        private System.Windows.Forms.TableLayoutPanel fieldSizePropertiesLayout;

        private System.Windows.Forms.GroupBox FieldPropertiesGroupBox;

        private System.Windows.Forms.TabControl PropertiesTabControl;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Label FieldHeight;
        private System.Windows.Forms.Label FieldWidthLabel;

        private System.Windows.Forms.TextBox FieldWidthTextBox;
        private System.Windows.Forms.TextBox FieldHeightTextBox;

        private System.Windows.Forms.TableLayoutPanel fieldPropertiesLayout;

        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel controlsLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsLayout;
        
        private LifeProj.View.SimulationPanel simulationPanel;

        #endregion
        
    }
}