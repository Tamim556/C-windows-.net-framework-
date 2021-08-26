namespace Gadgets_Shop_Management_System
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSell = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellerReg = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddproduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.UC_SellerReg = new Gadgets_Shop_Management_System.AllUserControl.UC_SellerReg();
            this.UC_AddProduct1 = new Gadgets_Shop_Management_System.AllUserControl.UC_AddProduct();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UC_Stock = new Gadgets_Shop_Management_System.AllUserControl.UC_Stock();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnCustomerRecord);
            this.panel1.Controls.Add(this.btnSellerReg);
            this.panel1.Controls.Add(this.btnaddproduct);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 539);
            this.panel1.TabIndex = 0;
            // 
            // btnSell
            // 
            this.btnSell.BorderRadius = 20;
            this.btnSell.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSell.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSell.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnSell.CheckedState.Parent = this.btnSell;
            this.btnSell.CustomImages.Parent = this.btnSell;
            this.btnSell.FillColor = System.Drawing.Color.Lime;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.HoverState.Parent = this.btnSell;
            this.btnSell.Location = new System.Drawing.Point(6, 202);
            this.btnSell.Name = "btnSell";
            this.btnSell.ShadowDecoration.Parent = this.btnSell;
            this.btnSell.Size = new System.Drawing.Size(141, 42);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Sell Product";
            this.btnSell.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // btnStock
            // 
            this.btnStock.BorderRadius = 20;
            this.btnStock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStock.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStock.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnStock.CheckedState.Parent = this.btnStock;
            this.btnStock.CustomImages.Parent = this.btnStock;
            this.btnStock.FillColor = System.Drawing.Color.Lime;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.HoverState.Parent = this.btnStock;
            this.btnStock.Location = new System.Drawing.Point(3, 336);
            this.btnStock.Name = "btnStock";
            this.btnStock.ShadowDecoration.Parent = this.btnStock;
            this.btnStock.Size = new System.Drawing.Size(141, 42);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCustomerRecord
            // 
            this.btnCustomerRecord.BorderRadius = 20;
            this.btnCustomerRecord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRecord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRecord.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerRecord.CheckedState.Parent = this.btnCustomerRecord;
            this.btnCustomerRecord.CustomImages.Parent = this.btnCustomerRecord;
            this.btnCustomerRecord.FillColor = System.Drawing.Color.Lime;
            this.btnCustomerRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecord.HoverState.Parent = this.btnCustomerRecord;
            this.btnCustomerRecord.Location = new System.Drawing.Point(6, 270);
            this.btnCustomerRecord.Name = "btnCustomerRecord";
            this.btnCustomerRecord.ShadowDecoration.Parent = this.btnCustomerRecord;
            this.btnCustomerRecord.Size = new System.Drawing.Size(141, 42);
            this.btnCustomerRecord.TabIndex = 5;
            this.btnCustomerRecord.Text = "Customer Records";
            this.btnCustomerRecord.Click += new System.EventHandler(this.btnSellerReg_Click);
            // 
            // btnSellerReg
            // 
            this.btnSellerReg.BorderRadius = 20;
            this.btnSellerReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellerReg.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellerReg.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnSellerReg.CheckedState.Parent = this.btnSellerReg;
            this.btnSellerReg.CustomImages.Parent = this.btnSellerReg;
            this.btnSellerReg.FillColor = System.Drawing.Color.Lime;
            this.btnSellerReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerReg.ForeColor = System.Drawing.Color.White;
            this.btnSellerReg.HoverState.Parent = this.btnSellerReg;
            this.btnSellerReg.Location = new System.Drawing.Point(3, 135);
            this.btnSellerReg.Name = "btnSellerReg";
            this.btnSellerReg.ShadowDecoration.Parent = this.btnSellerReg;
            this.btnSellerReg.Size = new System.Drawing.Size(135, 42);
            this.btnSellerReg.TabIndex = 5;
            this.btnSellerReg.Text = "Seller Regtration";
            this.btnSellerReg.Click += new System.EventHandler(this.btnSellerReg_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.BorderRadius = 20;
            this.btnaddproduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddproduct.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnaddproduct.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnaddproduct.CheckedState.Parent = this.btnaddproduct;
            this.btnaddproduct.CustomImages.Parent = this.btnaddproduct;
            this.btnaddproduct.FillColor = System.Drawing.Color.Lime;
            this.btnaddproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.ForeColor = System.Drawing.Color.White;
            this.btnaddproduct.HoverState.Parent = this.btnaddproduct;
            this.btnaddproduct.Location = new System.Drawing.Point(3, 66);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.ShadowDecoration.Parent = this.btnaddproduct;
            this.btnaddproduct.Size = new System.Drawing.Size(135, 42);
            this.btnaddproduct.TabIndex = 5;
            this.btnaddproduct.Text = "Add Product";
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.UC_Stock);
            this.panel2.Controls.Add(this.UC_SellerReg);
            this.panel2.Controls.Add(this.UC_AddProduct1);
            this.panel2.Location = new System.Drawing.Point(151, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 539);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.Location = new System.Drawing.Point(3, 10);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(31, 33);
            this.btnexit.TabIndex = 4;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // UC_SellerReg
            // 
            this.UC_SellerReg.BackColor = System.Drawing.Color.White;
            this.UC_SellerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UC_SellerReg.Location = new System.Drawing.Point(-3, 0);
            this.UC_SellerReg.Name = "UC_SellerReg";
            this.UC_SellerReg.Size = new System.Drawing.Size(858, 536);
            this.UC_SellerReg.TabIndex = 1;
            this.UC_SellerReg.Visible = false;
            this.UC_SellerReg.Load += new System.EventHandler(this.UC_SellerReg_Load);
            // 
            // UC_AddProduct1
            // 
            this.UC_AddProduct1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UC_AddProduct1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_AddProduct1.Location = new System.Drawing.Point(0, 0);
            this.UC_AddProduct1.Name = "UC_AddProduct1";
            this.UC_AddProduct1.Size = new System.Drawing.Size(865, 536);
            this.UC_AddProduct1.TabIndex = 0;
            this.UC_AddProduct1.Visible = false;
            this.UC_AddProduct1.Load += new System.EventHandler(this.uC_AddProduct1_Load);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 26;
            this.guna2Elipse2.TargetControl = this;
            // 
            // UC_Stock
            // 
            this.UC_Stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UC_Stock.Location = new System.Drawing.Point(0, 0);
            this.UC_Stock.Name = "UC_Stock";
            this.UC_Stock.Size = new System.Drawing.Size(865, 536);
            this.UC_Stock.TabIndex = 1;
            this.UC_Stock.Visible = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnSellerReg;
        private Guna.UI2.WinForms.Guna2Button btnaddproduct;
        private AllUserControl.UC_AddProduct UC_AddProduct1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControl.UC_SellerReg UC_SellerReg;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRecord;
        private Guna.UI2.WinForms.Guna2Button btnSell;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControl.UC_Stock UC_Stock;
    }
}