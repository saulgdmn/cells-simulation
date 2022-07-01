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
            this.continueButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.controlsLayout.SuspendLayout();
            this.buttonsLayout.SuspendLayout();
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
            this.controlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayout.Controls.Add(this.buttonsLayout, 0, 1);
            this.controlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLayout.Location = new System.Drawing.Point(815, 3);
            this.controlsLayout.Name = "controlsLayout";
            this.controlsLayout.RowCount = 2;
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.controlsLayout.Size = new System.Drawing.Size(265, 614);
            this.controlsLayout.TabIndex = 1;
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.ColumnCount = 2;
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.Controls.Add(this.continueButton, 1, 1);
            this.buttonsLayout.Controls.Add(this.pauseButton, 0, 1);
            this.buttonsLayout.Controls.Add(this.resetButton, 1, 0);
            this.buttonsLayout.Controls.Add(this.startButton, 0, 0);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayout.Location = new System.Drawing.Point(5, 496);
            this.buttonsLayout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.Padding = new System.Windows.Forms.Padding(2);
            this.buttonsLayout.RowCount = 2;
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayout.Size = new System.Drawing.Size(255, 113);
            this.buttonsLayout.TabIndex = 0;
            // 
            // continueButton
            // 
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(130, 59);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(120, 49);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(5, 59);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(119, 49);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.resetButton.Location = new System.Drawing.Point(130, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 48);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Location = new System.Drawing.Point(5, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel controlsLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsLayout;
        
        private System.Windows.Forms.Panel simulationPanel;

        #endregion
        
    }
}