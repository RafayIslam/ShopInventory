using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Inventory
{
    public partial class Monthlyexpence : Form
    {
        logic lgic;
        DataSet ds;
        public Monthlyexpence()
        {
            InitializeComponent();
            lgic = new logic();
            ds = lgic.get_tabl("account");
            acc_grid.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds = lgic.get_tabl("account");
            acc_grid.DataSource = ds.Tables[0];
        }
    }
}
