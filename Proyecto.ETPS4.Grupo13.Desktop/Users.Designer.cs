namespace Proyecto.ETPS4.Grupo13.Desktop
{
    partial class Users
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
            txtPassword = new TextBox();
            label6 = new Label();
            cbEnabled = new CheckBox();
            cbUserType = new ComboBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            lblGuid = new Label();
            label1 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgUsers = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbEnabled);
            groupBox1.Controls.Add(cbUserType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblGuid);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(18, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(322, 23);
            txtPassword.TabIndex = 15;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 223);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 14;
            label6.Text = "Clave";
            // 
            // cbEnabled
            // 
            cbEnabled.AutoSize = true;
            cbEnabled.Location = new Point(18, 318);
            cbEnabled.Name = "cbEnabled";
            cbEnabled.Size = new Size(81, 19);
            cbEnabled.TabIndex = 11;
            cbEnabled.Text = "Habilitado";
            cbEnabled.UseVisualStyleBackColor = true;
            // 
            // cbUserType
            // 
            cbUserType.FormattingEnabled = true;
            cbUserType.Items.AddRange(new object[] { "Cajero", "Administrador" });
            cbUserType.Location = new Point(18, 289);
            cbUserType.Name = "cbUserType";
            cbUserType.Size = new Size(322, 23);
            cbUserType.TabIndex = 9;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 271);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 172);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(18, 138);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(322, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(18, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(322, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // lblGuid
            // 
            lblGuid.Location = new Point(18, 35);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(322, 26);
            lblGuid.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(274, 403);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(99, 35);
            btnNew.TabIndex = 13;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 403);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 35);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 403);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgUsers
            // 
            dgUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(379, 21);
            dgUsers.Name = "dgUsers";
            dgUsers.RowTemplate.Height = 25;
            dgUsers.Size = new Size(553, 417);
            dgUsers.TabIndex = 1;
            dgUsers.CellClick += dgUsers_CellClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(dgUsers);
            Controls.Add(groupBox1);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            MaximizeBox = false;
            MaximumSize = new Size(960, 489);
            MinimizeBox = false;
            MinimumSize = new Size(960, 489);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblGuid;
        private Label label1;
        private DataGridView dgUsers;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private ComboBox cbUserType;
        private Button btnAdd;
        private CheckBox cbEnabled;
        private Button btnNew;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label label6;
    }
}