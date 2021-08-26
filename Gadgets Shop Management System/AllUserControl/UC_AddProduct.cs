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
    public partial class UC_AddProduct : UserControl
    {

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public UC_AddProduct()
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
        private void btnshowall_Click(object sender, EventArgs e)
        {
            string sql = "select * from product;";
            //  this.Ds = this.Da.ExecuteQuery(sql);

            // this.dgvproduct.DataSource = Ds.Tables[0];
            this.ShowData();

        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            try
            {

                this.Sql = @"insert into Product values ('" + this.txtproductname.Text + "','" + this.txtproductid.Text + "','" + this.txtbrand.Text + "'" +
                ",'" + this.txtmodel.Text + "','" + this.txtquantity.Text + "','" + this.txtprice.Text + "' );";


                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                if (count == 1)
                    MessageBox.Show("Data inserted successfully");
                else
                    MessageBox.Show("Error while inserting data");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            this.ShowData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from Product where Brand = '" + txtsearch.Text + "'or Model ='"+ txtsearch.Text + "' " +
                "or ProductName ='"+ txtsearch.Text + "'or ProductId ='"+ txtsearch.Text + "' or Price ='"+ txtsearch.Text + "';";
            this.ShowData(Sql);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"update Product
              SET ProductName = '" + txtproductname.Text + "', Brand = '" + txtbrand.Text + "', Model = '" + txtmodel.Text + "', " +
              "Quantity = '" + txtquantity.Text + "', price = '" + txtprice.Text + "'WHERE ProductId = '" + txtproductid.Text + "'; ";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                if (count == 1)
                    MessageBox.Show("Data update successfully");
                else
                    MessageBox.Show("Error while updating data");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            this.ShowData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                this.Sql = "delete Product where ProductName ='" + txtproductname.Text + "' or ProductId ='" + txtproductid.Text + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                if (count == 1)
                    MessageBox.Show("Data delete successfully");
                else
                    MessageBox.Show("Error while deleting data");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            this.ShowData();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            Application.Restart();
        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.txtproductname.Text = this.dgvproduct.CurrentRow.Cells["name"].Value.ToString();
           // this.txtproductid.Text = this.dgvproduct.CurrentRow.Cells["id"].Value.ToString();
           // this.txtmodel.Text = this.dgvproduct.CurrentRow.Cells["Model"].Value.ToString();
           // this.txtproductbrand.Text = this.dgvproduct.CurrentRow.Cells["Brand"].Value.ToString();
          //  this.txtproductprice.Text = this.dgvproduct.CurrentRow.Cells["Price"].Value.ToString();
          //  this.txtproductQuantity.Text = this.dgvproduct.CurrentRow.Cells["Quantity"].Value.ToString();
        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtproductname.Text = this.dgvproduct.CurrentRow.Cells["name"].Value.ToString();
             this.txtproductid.Text = this.dgvproduct.CurrentRow.Cells["id"].Value.ToString();
             this.txtmodel.Text = this.dgvproduct.CurrentRow.Cells["Model"].Value.ToString();
             this.txtbrand.Text = this.dgvproduct.CurrentRow.Cells["Brand"].Value.ToString();
              this.txtprice.Text = this.dgvproduct.CurrentRow.Cells["Price"].Value.ToString();
              this.txtquantity.Text = this.dgvproduct.CurrentRow.Cells["Quantity"].Value.ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtproductname.Text = "";
            txtproductid.Text = "";
            txtbrand.Text = "";
            txtmodel.Text = "";
            txtquantity.Text = "";
            txtprice.Text = "";
            txtsearch.Text = "";
        }
    }
}
