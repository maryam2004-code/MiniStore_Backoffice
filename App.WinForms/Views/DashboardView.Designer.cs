namespace App.WinForms.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.lvRecentOrders = new System.Windows.Forms.ListView();
            this.colOrders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblDashboard.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(944, 645);
            this.tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.pnlSales);
            this.flpKpi.Controls.Add(this.pnlOrders);
            this.flpKpi.Controls.Add(this.pnlRevenue);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpi.Location = new System.Drawing.Point(3, 3);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(938, 114);
            this.flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(103, 27);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(25, 13);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "163";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(13, 28);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(33, 13);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Location = new System.Drawing.Point(209, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 100);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Location = new System.Drawing.Point(110, 27);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(19, 13);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "33";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Location = new System.Drawing.Point(30, 26);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(38, 13);
            this.lblOrderT.TabIndex = 0;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(415, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(200, 100);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(133, 28);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(40, 13);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "37,356";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(35, 27);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(51, 13);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(938, 256);
            this.pnlLowStock.TabIndex = 1;
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrders);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 385);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(938, 257);
            this.pnlRecentOrders.TabIndex = 2;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(34, 16);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(67, 13);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock";
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(19, 52);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(916, 90);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(34, 21);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(89, 13);
            this.lblRecentOrders.TabIndex = 0;
            this.lblRecentOrders.Text = "Recent Orders";
            // 
            // lvRecentOrders
            // 
            this.lvRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrders,
            this.colCustomers,
            this.colTotal,
            this.colStatus});
            this.lvRecentOrders.HideSelection = false;
            this.lvRecentOrders.Location = new System.Drawing.Point(19, 55);
            this.lvRecentOrders.Name = "lvRecentOrders";
            this.lvRecentOrders.Size = new System.Drawing.Size(916, 97);
            this.lvRecentOrders.TabIndex = 1;
            this.lvRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrders.View = System.Windows.Forms.View.Details;
            // 
            // colOrders
            // 
            this.colOrders.Text = "Orders";
            // 
            // colCustomers
            // 
            this.colCustomers.Text = "Customers";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(944, 645);
            this.tblDashboard.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrders;
        private System.Windows.Forms.ColumnHeader colCustomers;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblRecentOrders;
    }
}
