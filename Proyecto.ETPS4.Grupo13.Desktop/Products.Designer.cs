namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class Products
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
            groupBox1 = new GroupBox();
            lblStock = new Label();
            label6 = new Label();
            lblAverageCost = new Label();
            label5 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            lblId = new Label();
            label1 = new Label();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblAverageCost);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 366);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.Fixed3D;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(6, 306);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(303, 23);
            lblStock.TabIndex = 9;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 283);
            label6.Name = "label6";
            label6.Size = new Size(303, 23);
            label6.TabIndex = 8;
            label6.Text = "Existencias:";
            // 
            // lblAverageCost
            // 
            lblAverageCost.BorderStyle = BorderStyle.Fixed3D;
            lblAverageCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAverageCost.Location = new Point(6, 243);
            lblAverageCost.Name = "lblAverageCost";
            lblAverageCost.Size = new Size(303, 23);
            lblAverageCost.TabIndex = 7;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 220);
            label5.Name = "label5";
            label5.Size = new Size(303, 23);
            label5.TabIndex = 6;
            label5.Text = "Costo Promedio:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(6, 185);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(303, 23);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 159);
            label3.Name = "label3";
            label3.Size = new Size(303, 23);
            label3.TabIndex = 4;
            label3.Text = "Precio Venta:";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(303, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(6, 54);
            lblId.Name = "lblId";
            lblId.Size = new Size(303, 23);
            lblId.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(303, 23);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(333, 22);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(439, 427);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 400);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(252, 400);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 34);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnNew;
        private Label lblId;
        private Label label1;
        private Label lblStock;
        private Label label6;
        private Label lblAverageCost;
        private Label label5;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtName;
        private Label label2;
    }
}