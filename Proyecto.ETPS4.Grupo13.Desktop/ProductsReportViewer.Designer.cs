﻿namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class ProductsReportViewer
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
            rvProducts = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvProducts
            // 
            rvProducts.Location = new Point(0, 0);
            rvProducts.MaximumSize = new Size(780, 460);
            rvProducts.MinimumSize = new Size(780, 460);
            rvProducts.Name = "ReportViewer";
            rvProducts.ServerReport.BearerToken = null;
            rvProducts.Size = new Size(780, 460);
            rvProducts.TabIndex = 0;
            // 
            // ProductsReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(rvProducts);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "ProductsReportViewer";
            Text = "ProductsReportViewer";
            Load += ProductsReportViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProducts;
    }
}