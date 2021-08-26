using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadgets_Shop_Management_System.AllUserControl
{
    public partial class UC_Stock : UserControl
    {

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public UC_Stock()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ShowData();
        }
        private void ShowData(string sql = "select * from product;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvproduct.AutoGenerateColumns = false;
            this.dgvproduct.DataSource = this.Ds.Tables[0];
        }
            private void UC_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from Product where Brand = '" + txtSearch.Text + "'or Model ='" + txtSearch.Text + "' " +
               "or ProductName ='" + txtSearch.Text + "'or ProductId ='" + txtSearch.Text + "' or Price ='" + txtSearch.Text + "';";
            this.ShowData(Sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {

                this.lblProductName.Text = this.dgvproduct.CurrentRow.Cells["name"].Value.ToString();
                this.lblProductId.Text = this.dgvproduct.CurrentRow.Cells["id"].Value.ToString();
                this.lblModel.Text = this.dgvproduct.CurrentRow.Cells["Model"].Value.ToString();
                this.lblBrand.Text = this.dgvproduct.CurrentRow.Cells["Brand"].Value.ToString();
                this.lblPrice.Text = this.dgvproduct.CurrentRow.Cells["Price"].Value.ToString();
                this.lblQuantity.Text = this.dgvproduct.CurrentRow.Cells["Quantity"].Value.ToString();
            }
            else
                MessageBox.Show("Product Not Found");
        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
           

            this.lblProductName.Text = this.dgvproduct.CurrentRow.Cells["name"].Value.ToString();
            this.lblProductId.Text = this.dgvproduct.CurrentRow.Cells["id"].Value.ToString();
            this.lblModel.Text= this.dgvproduct.CurrentRow.Cells["Model"].Value.ToString();
            this.lblBrand.Text = this.dgvproduct.CurrentRow.Cells["Brand"].Value.ToString();
            this.lblPrice.Text = this.dgvproduct.CurrentRow.Cells["Price"].Value.ToString();
            this.lblQuantity.Text = this.dgvproduct.CurrentRow.Cells["Quantity"].Value.ToString();

        }
    }
}
