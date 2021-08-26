using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadgets_Shop_Management_System
{
    public partial class AdminPage : Form
    {

      SellerForm1 S1 { set;get; }


        public AdminPage()
        {
            InitializeComponent();
            S1 = new SellerForm1();
            
          

          
        }

      

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            // this.UC_AddProduct.Visible = true;
            this.UC_AddProduct1.Visible = true;
            this.UC_SellerReg.Visible = false;
            this.UC_Stock.Visible = false;
        }

        private void btnSellerReg_Click(object sender, EventArgs e)
        {
            this.UC_AddProduct1.Visible = false;
            this.UC_SellerReg.Visible = true;
            this.UC_Stock.Visible = false;
        }

        private void uC_AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddProduct1_Load(object sender, EventArgs e)
        {

        }

        private void UC_SellerReg_Load(object sender, EventArgs e)
        {

        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            this.S1 = new SellerForm1();
            S1.Visible = true;
          //  this.Visible = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.UC_Stock.Visible = true;
            this.UC_SellerReg.Visible = false;
            this.UC_SellerReg.Visible = false;
        }
    }
}
