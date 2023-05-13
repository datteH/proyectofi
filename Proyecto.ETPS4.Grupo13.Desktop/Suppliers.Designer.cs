namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class Suppliers
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
            dgvSuppliers = new DataGridView();
            lblId = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(336, 20);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowTemplate.Height = 25;
            dgvSuppliers.Size = new Size(436, 429);
            dgvSuppliers.TabIndex = 1;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // lblId
            // 
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(6, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(303, 23);
            lblId.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(303, 23);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 23);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(303, 23);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(9, 174);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(303, 23);
            txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 148);
            label3.Name = "label3";
            label3.Size = new Size(303, 23);
            label3.TabIndex = 6;
            label3.Text = "Dirección:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(9, 245);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(303, 23);
            txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 219);
            label4.Name = "label4";
            label4.Size = new Size(303, 23);
            label4.TabIndex = 8;
            label4.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(9, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(303, 23);
            txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 291);
            label5.Name = "label5";
            label5.Size = new Size(303, 23);
            label5.TabIndex = 10;
            label5.Text = "Correo Electrónico:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(231, 402);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(99, 35);
            btnNew.TabIndex = 16;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvSuppliers);
            Controls.Add(groupBox1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvSuppliers;
        private Label lblId;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtAddress;
        private Label label3;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnAdd;
    }
}