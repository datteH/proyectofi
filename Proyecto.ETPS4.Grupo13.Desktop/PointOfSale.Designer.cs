namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class PointOfSale
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
            dgProducts = new DataGridView();
            btnAddNewSale = new Button();
            btnSaveHeader = new Button();
            btnFinish = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnAddProduct = new Button();
            txtQuantity = new TextBox();
            label2 = new Label();
            cbProducts = new ComboBox();
            groupBox2 = new GroupBox();
            cbSaleType = new ComboBox();
            label6 = new Label();
            cbSaleReceiptType = new ComboBox();
            label5 = new Label();
            lblUser = new Label();
            label4 = new Label();
            cbCustomer = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lblUserId = new Label();
            lblHeaderId = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            label12 = new Label();
            lblTax = new Label();
            label10 = new Label();
            lblSubTotal = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(12, 144);
            dgProducts.Name = "dgProducts";
            dgProducts.RowTemplate.Height = 25;
            dgProducts.Size = new Size(372, 290);
            dgProducts.TabIndex = 0;
            // 
            // btnAddNewSale
            // 
            btnAddNewSale.BackColor = Color.PaleTurquoise;
            btnAddNewSale.Location = new Point(390, 373);
            btnAddNewSale.Name = "btnAddNewSale";
            btnAddNewSale.Size = new Size(119, 61);
            btnAddNewSale.TabIndex = 2;
            btnAddNewSale.Text = "Compra";
            btnAddNewSale.UseVisualStyleBackColor = false;
            btnAddNewSale.Click += btnAddNewSale_Click;
            // 
            // btnSaveHeader
            // 
            btnSaveHeader.BackColor = Color.Gold;
            btnSaveHeader.Location = new Point(521, 373);
            btnSaveHeader.Name = "btnSaveHeader";
            btnSaveHeader.Size = new Size(119, 61);
            btnSaveHeader.TabIndex = 3;
            btnSaveHeader.Text = "Guardar";
            btnSaveHeader.UseVisualStyleBackColor = false;
            btnSaveHeader.Click += btnSaveHeader_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.PaleGreen;
            btnFinish.Location = new Point(652, 373);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(119, 61);
            btnFinish.TabIndex = 4;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbProducts);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(372, 126);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // label3
            // 
            label3.Location = new Point(13, 22);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 4;
            label3.Text = "Listado";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.BurlyWood;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Location = new Point(210, 87);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(149, 33);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Agregar";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(112, 58);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(247, 23);
            txtQuantity.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(13, 61);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // cbProducts
            // 
            cbProducts.DisplayMember = "Text";
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(112, 22);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(247, 23);
            cbProducts.TabIndex = 0;
            cbProducts.ValueMember = "Value";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSaleType);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbSaleReceiptType);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblUser);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbCustomer);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(390, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 200);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Comprobante";
            // 
            // cbSaleType
            // 
            cbSaleType.DisplayMember = "Text";
            cbSaleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSaleType.FormattingEnabled = true;
            cbSaleType.Location = new Point(134, 145);
            cbSaleType.Name = "cbSaleType";
            cbSaleType.Size = new Size(241, 23);
            cbSaleType.TabIndex = 9;
            cbSaleType.ValueMember = "Value";
            // 
            // label6
            // 
            label6.Location = new Point(6, 145);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 8;
            label6.Text = "Tipo Venta:";
            // 
            // cbSaleReceiptType
            // 
            cbSaleReceiptType.DisplayMember = "Text";
            cbSaleReceiptType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSaleReceiptType.FormattingEnabled = true;
            cbSaleReceiptType.Location = new Point(134, 103);
            cbSaleReceiptType.Name = "cbSaleReceiptType";
            cbSaleReceiptType.Size = new Size(241, 23);
            cbSaleReceiptType.TabIndex = 7;
            cbSaleReceiptType.ValueMember = "Value";
            // 
            // label5
            // 
            label5.Location = new Point(6, 103);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 6;
            label5.Text = "Tipo Comprobante:";
            // 
            // lblUser
            // 
            lblUser.Location = new Point(134, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(241, 23);
            lblUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // cbCustomer
            // 
            cbCustomer.DisplayMember = "Text";
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(134, 61);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(241, 23);
            cbCustomer.TabIndex = 3;
            cbCustomer.ValueMember = "Value";
            // 
            // label1
            // 
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 2;
            label1.Text = "Cliente:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblUserId);
            groupBox3.Controls.Add(lblHeaderId);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lblTax);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblSubTotal);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(390, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 149);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // lblUserId
            // 
            lblUserId.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.Location = new Point(274, 56);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(84, 25);
            lblUserId.TabIndex = 10;
            lblUserId.Text = "USER ID";
            lblUserId.Visible = false;
            // 
            // lblHeaderId
            // 
            lblHeaderId.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderId.Location = new Point(274, 21);
            lblHeaderId.Name = "lblHeaderId";
            lblHeaderId.Size = new Size(84, 25);
            lblHeaderId.TabIndex = 9;
            lblHeaderId.Text = "HEADER ID";
            lblHeaderId.Visible = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(106, 21);
            label11.Name = "label11";
            label11.Size = new Size(16, 25);
            label11.TabIndex = 8;
            label11.Text = "$";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(107, 62);
            label9.Name = "label9";
            label9.Size = new Size(15, 25);
            label9.TabIndex = 7;
            label9.Text = "$";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(103, 106);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 6;
            label8.Text = "$";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(131, 106);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(119, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0.0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 110);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 4;
            label12.Text = "Total";
            // 
            // lblTax
            // 
            lblTax.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(131, 62);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(119, 25);
            lblTax.TabIndex = 3;
            lblTax.Text = "0.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 66);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 2;
            label10.Text = "IVA";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(131, 21);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(119, 25);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "0.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Sub-Total";
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnFinish);
            Controls.Add(btnSaveHeader);
            Controls.Add(btnAddNewSale);
            Controls.Add(dgProducts);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "PointOfSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Point Of Sale";
            Load += PointOfSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProducts;
        private Button btnAddNewSale;
        private Button btnSaveHeader;
        private Button btnFinish;
        private GroupBox groupBox1;
        private Button btnAddProduct;
        private TextBox txtQuantity;
        private Label label2;
        private ComboBox cbProducts;
        private GroupBox groupBox2;
        private ComboBox cbCustomer;
        private Label label1;
        private Label label3;
        private Label lblUser;
        private Label label4;
        private ComboBox cbSaleReceiptType;
        private Label label5;
        private ComboBox cbSaleType;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblSubTotal;
        private Label label7;
        private Label lblTotal;
        private Label label12;
        private Label lblTax;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label lblHeaderId;
        private Label lblUserId;
    }
}