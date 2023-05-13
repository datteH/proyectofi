namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            groupBox1 = new GroupBox();
            btnReloadProducts = new Button();
            btnReloadSupplier = new Button();
            txtCost = new TextBox();
            txtQuantity = new TextBox();
            cbProducts = new ComboBox();
            cbSuppliers = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReloadProducts);
            groupBox1.Controls.Add(btnReloadSupplier);
            groupBox1.Controls.Add(txtCost);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(cbProducts);
            groupBox1.Controls.Add(cbSuppliers);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnReloadProducts
            // 
            btnReloadProducts.Image = (Image)resources.GetObject("btnReloadProducts.Image");
            btnReloadProducts.Location = new Point(523, 76);
            btnReloadProducts.Name = "btnReloadProducts";
            btnReloadProducts.Size = new Size(24, 24);
            btnReloadProducts.TabIndex = 9;
            btnReloadProducts.UseVisualStyleBackColor = true;
            btnReloadProducts.Click += btnReloadProducts_Click;
            // 
            // btnReloadSupplier
            // 
            btnReloadSupplier.Image = (Image)resources.GetObject("btnReloadSupplier.Image");
            btnReloadSupplier.Location = new Point(523, 29);
            btnReloadSupplier.Name = "btnReloadSupplier";
            btnReloadSupplier.Size = new Size(24, 24);
            btnReloadSupplier.TabIndex = 8;
            btnReloadSupplier.UseVisualStyleBackColor = true;
            btnReloadSupplier.Click += btnReloadProvider_Click;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(454, 120);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(157, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 6;
            // 
            // cbProducts
            // 
            cbProducts.DisplayMember = "Text";
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(157, 76);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(360, 23);
            cbProducts.TabIndex = 5;
            cbProducts.ValueMember = "Value";
            // 
            // cbSuppliers
            // 
            cbSuppliers.DisplayMember = "Text";
            cbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(157, 29);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(360, 23);
            cbSuppliers.TabIndex = 4;
            cbSuppliers.ValueMember = "Value";
            // 
            // label4
            // 
            label4.Location = new Point(324, 120);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Costo";
            // 
            // label3
            // 
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label1
            // 
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(444, 207);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 42);
            btnSave.TabIndex = 1;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(600, 300);
            MinimizeBox = false;
            MinimumSize = new Size(600, 300);
            Name = "Purchases";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Purchases";
            Load += Purchases_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCost;
        private TextBox txtQuantity;
        private ComboBox cbProducts;
        private ComboBox cbSuppliers;
        private Button btnReloadSupplier;
        private Button btnReloadProducts;
    }
}