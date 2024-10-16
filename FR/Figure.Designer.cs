namespace FR
{
    partial class Figure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.Draw = new System.ComponentModel.BackgroundWorker();
            this.Count = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(12, 12);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(778, 428);
            this.plotView2.TabIndex = 0;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Draw
            // 
            this.Draw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Draw_DoWork);
            // 
            // Count
            // 
            this.Count.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Count_DoWork);
            // 
            // Figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 593);
            this.Controls.Add(this.plotView2);
            this.Name = "Figure";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Figure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.ComponentModel.BackgroundWorker Draw;
        private System.ComponentModel.BackgroundWorker Count;
    }
}