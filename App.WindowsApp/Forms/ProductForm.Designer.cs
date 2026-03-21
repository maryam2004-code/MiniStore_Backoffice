namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tblProductForm = new TableLayoutPanel();
            lblName = new Label();
            label2 = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtID = new TextBox();
            flpProductForm = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            flpProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // tblProductForm
            // 
            tblProductForm.ColumnCount = 2;
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblProductForm.Controls.Add(lblName, 0, 0);
            tblProductForm.Controls.Add(label2, 0, 1);
            tblProductForm.Controls.Add(lblPrice, 0, 2);
            tblProductForm.Controls.Add(lblStock, 0, 3);
            tblProductForm.Controls.Add(lblStatus, 0, 4);
            tblProductForm.Controls.Add(lblID, 0, 5);
            tblProductForm.Controls.Add(txtName, 1, 0);
            tblProductForm.Controls.Add(cmbCategory, 1, 1);
            tblProductForm.Controls.Add(numericUpDownPrice, 1, 2);
            tblProductForm.Controls.Add(numericUpDownStock, 1, 3);
            tblProductForm.Controls.Add(cmbStatus, 1, 4);
            tblProductForm.Controls.Add(txtID, 1, 5);
            tblProductForm.Dock = DockStyle.Top;
            tblProductForm.Location = new Point(0, 0);
            tblProductForm.Name = "tblProductForm";
            tblProductForm.RowCount = 6;
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblProductForm.Size = new Size(860, 310);
            tblProductForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Left;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 50);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Location = new Point(3, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 50);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Left;
            lblStock.Location = new Point(3, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 50);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Left;
            lblStatus.Location = new Point(3, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 50);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Left;
            lblID.Location = new Point(3, 250);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 60);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(175, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(682, 31);
            txtName.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(175, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(682, 33);
            cmbCategory.TabIndex = 7;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Dock = DockStyle.Fill;
            numericUpDownPrice.Location = new Point(175, 103);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(682, 31);
            numericUpDownPrice.TabIndex = 8;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Dock = DockStyle.Fill;
            numericUpDownStock.Location = new Point(175, 153);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(682, 31);
            numericUpDownStock.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(175, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(682, 33);
            cmbStatus.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(175, 253);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(682, 31);
            txtID.TabIndex = 11;
            // 
            // flpProductForm
            // 
            flpProductForm.Controls.Add(btnSave);
            flpProductForm.Controls.Add(btnCancel);
            flpProductForm.Dock = DockStyle.Bottom;
            flpProductForm.FlowDirection = FlowDirection.RightToLeft;
            flpProductForm.Location = new Point(0, 397);
            flpProductForm.Name = "flpProductForm";
            flpProductForm.Size = new Size(860, 100);
            flpProductForm.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Image = Properties.Resources.ico_save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(745, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Image = Properties.Resources.ico_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(627, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 42);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 497);
            Controls.Add(flpProductForm);
            Controls.Add(tblProductForm);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tblProductForm.ResumeLayout(false);
            tblProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            flpProductForm.ResumeLayout(false);
            flpProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblProductForm;
        private Label lblName;
        private Label label2;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private FlowLayoutPanel flpProductForm;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownStock;
        private ComboBox cmbStatus;
        private TextBox txtID;
    }
}