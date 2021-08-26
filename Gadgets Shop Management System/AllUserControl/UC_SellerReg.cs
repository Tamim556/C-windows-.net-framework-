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
    public partial class UC_SellerReg : UserControl
    {


        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public UC_SellerReg()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ShowData();
        }
        private void ShowData(string sql = "select * from UserLogin;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgtLogin.DataSource = this.Ds.Tables[0];

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {

        }
    }
}
