namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class PurchasesReportViewer
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
            rvPurchases = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvPurchases
            // 
            rvPurchases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvPurchases.Location = new Point(0, 0);
            rvPurchases.MaximumSize = new Size(780, 460);
            rvPurchases.MinimumSize = new Size(780, 460);
            rvPurchases.Name = "ReportViewer";
            rvPurchases.ServerReport.BearerToken = null;
            rvPurchases.Size = new Size(780, 460);
            rvPurchases.TabIndex = 0;
            // 
            // PurchasesReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(rvPurchases);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "PurchasesReportViewer";
            Text = "PurchasesReportViewer";
            Load += PurchasesReportViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPurchases;
    }
}