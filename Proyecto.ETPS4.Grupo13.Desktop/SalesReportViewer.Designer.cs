namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class SalesReportViewer
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
            rvSales = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvSales
            // 
            rvSales.Location = new Point(0, 0);
            rvSales.MaximumSize = new Size(780, 460);
            rvSales.MinimumSize = new Size(780, 460);
            rvSales.Name = "ReportViewer";
            rvSales.ServerReport.BearerToken = null;
            rvSales.Size = new Size(780, 460);
            rvSales.TabIndex = 0;
            // 
            // SalesReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(rvSales);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "SalesReportViewer";
            Text = "SalesReportViewer";
            Load += SalesReportViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvSales;
    }
}