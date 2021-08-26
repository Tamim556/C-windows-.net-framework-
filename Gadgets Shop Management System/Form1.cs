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
    public partial class LoginForm : Form
    {

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {



            string sql = @"select * from UserLogin where Name = '" + this.txtusername.Text + "' and" +
                " Password = '" + this.txtpassword.Text + "' and Type = '" + this.cmblogin.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            // string sql2 = "select * from UserLogin where Type ='admin';";
            //this.Ds = this.Da.ExecuteQuery(sql2);

           


                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    if (cmblogin.Text == "Admin")
                    {
                        AdminPage a1 = new AdminPage();
                        a1.Visible = true;
                         this.Visible = false;
                    }
                    else
                    {
                        SellerForm1 s1 = new SellerForm1();
                        s1.Visible = true;
                    this.Visible = false;
                    // AdminForm1 a1 = new AdminForm1();
                    // a1.Visible = false;
                }
                }
                else
                {
                    lblwrong.Visible = true;
                    // MessageBox.Show("Invalid User Name Or Password ");
                }
            
               


           // AddproductForm add1 = new AddproductForm();
         //   add1.Visible = true;
           // this.Visible = false;

        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblwrong_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
