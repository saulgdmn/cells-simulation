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
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Controls.Add(this.simulationPanel, 0, 0);
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
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        
        private System.Windows.Forms.Panel simulationPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
    }
}