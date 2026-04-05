namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tblCustomer = new TableLayoutPanel();
            txtId = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblId = new Label();
            txtPhone = new TextBox();
            flpCustomer = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblCustomer.SuspendLayout();
            flpCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tblCustomer
            // 
            tblCustomer.ColumnCount = 2;
            tblCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tblCustomer.Controls.Add(txtId, 1, 4);
            tblCustomer.Controls.Add(txtAddress, 1, 3);
            tblCustomer.Controls.Add(txtEmail, 1, 2);
            tblCustomer.Controls.Add(lblName, 0, 0);
            tblCustomer.Controls.Add(txtName, 1, 0);
            tblCustomer.Controls.Add(lblPhone, 0, 1);
            tblCustomer.Controls.Add(lblEmail, 0, 2);
            tblCustomer.Controls.Add(lblAddress, 0, 3);
            tblCustomer.Controls.Add(lblId, 0, 4);
            tblCustomer.Controls.Add(txtPhone, 1, 1);
            tblCustomer.Dock = DockStyle.Top;
            tblCustomer.Location = new Point(0, 0);
            tblCustomer.Name = "tblCustomer";
            tblCustomer.RowCount = 5;
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tblCustomer.RowStyles.Add(new RowStyle());
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tblCustomer.Size = new Size(643, 192);
            tblCustomer.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(99, 163);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(541, 25);
            txtId.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(99, 114);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(541, 43);
            txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(99, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(541, 25);
            txtEmail.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 9.75F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(99, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(541, 25);
            txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9.75F);
            lblPhone.Location = new Point(3, 37);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(90, 37);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9.75F);
            lblEmail.Location = new Point(3, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 37);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 9.75F);
            lblAddress.Location = new Point(3, 111);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(90, 49);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 9.75F);
            lblId.Location = new Point(3, 160);
            lblId.Name = "lblId";
            lblId.Size = new Size(90, 37);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(99, 40);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(541, 25);
            txtPhone.TabIndex = 6;
            // 
            // flpCustomer
            // 
            flpCustomer.Controls.Add(btnSave);
            flpCustomer.Controls.Add(btnCancel);
            flpCustomer.Dock = DockStyle.Bottom;
            flpCustomer.FlowDirection = FlowDirection.RightToLeft;
            flpCustomer.Location = new Point(0, 232);
            flpCustomer.Name = "flpCustomer";
            flpCustomer.Size = new Size(643, 53);
            flpCustomer.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDark;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.ico_save;
            btnSave.Location = new Point(530, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.Image = Properties.Resources.ico_cancel;
            btnCancel.Location = new Point(412, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 42);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 285);
            Controls.Add(flpCustomer);
            Controls.Add(tblCustomer);
            Font = new Font("Segoe UI", 9.75F);
            Name = "CustomerForm";
            Text = "CustomerForm";
            tblCustomer.ResumeLayout(false);
            tblCustomer.PerformLayout();
            flpCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCustomer;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblId;
        private TextBox txtPhone;
        private FlowLayoutPanel flpCustomer;
        private Button btnSave;
        private Button btnCancel;
    }
}