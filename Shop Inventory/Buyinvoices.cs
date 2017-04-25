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
    public partial class Buyinvoices : Form
    {
        logic lgic;
        DataSet ds;
        public Buyinvoices()
        {
            InitializeComponent();
            lgic = new logic();
            ds = lgic.get_tabl("perchas");
            sal_gridview.DataSource = ds.Tables[0];
            count(ds);
            sal_ad_name.DataSource = lgic.combodata("perchas", "saller_name");
            sal_srch_sal_name.DataSource = lgic.combodata("perchas", "saller_name");
        }
        private void sal_ad_done_Click(object sender, EventArgs e)
        {
            sal_ad_name.Select();
            string[] at = { sal_ad_name.Text, sal_ad_invoicenmbr.Text, sal_ad_detail.Text,  
                              sal_ad_total.Text, sal_ad_pay.Text,  sal_ad_balance.Text,
                              sal_ad_status.Text, sal_datetoday.Value.ToString()};
            string msg = lgic.invoicesale(at);
            MessageBox.Show(msg);


            ds = lgic.get_tabl("perchas");
            sal_gridview.DataSource = ds.Tables[0];
            count(ds);

            sal_srch_sal_name.DataSource = lgic.combodata("perchas", "saller_name");
            int index = sal_srch_sal_name.FindString(sal_ad_name.Text);
            sal_srch_sal_name.SelectedIndex = index;

            sal_ad_name.Text = "";
            sal_ad_invoicenmbr.Text = "";
            sal_ad_detail.Text = "";
            sal_ad_total.Text = "0";
            sal_ad_pay.Text = "0";
            sal_ad_balance.Text = "0";
            sal_ad_name.Select();

        }
        public void count(DataSet table)
        {
            string balnce = "";
            int total = 0, pay = 0, balance = 0;

            foreach (DataRow row in table.Tables[0].Rows)
            {
                balnce = row[6].ToString();
                total += int.Parse(row[4].ToString());
                pay += int.Parse(row[5].ToString());
                balance += int.Parse(row[6].ToString());
            }
            sal_grid_balance.Text = balance.ToString();
            sal_grid_total.Text = total.ToString();
            sal_grid_receive.Text = pay.ToString();

        }

        private void sal_ad_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("pleas enter number only.. ");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sal_ad_pay_TextChanged(object sender, EventArgs e)
        {
            if (sal_ad_pay.Text != "" && sal_ad_total.Text != "")
            {
                int tl = Convert.ToInt32(sal_ad_total.Text.ToString());
                int rc = Convert.ToInt32(sal_ad_pay.Text.ToString());

                sal_ad_balance.Text = (tl - rc).ToString();
            }
        }

        private void sal_ad_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sal_ad_status.Text == "Pay")
            {
                sal_ad_total.Text = "0";
                sal_ad_pay.Select();
            }
        }

        private void sal_srch_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = lgic.search("perchas", "saller_name", sal_srch_sal_name.Text);
            sal_gridview.DataSource = ds.Tables[0];
            count(ds);
        }

        private void sal_grid_total_Click(object sender, EventArgs e)
        {

        }

        private void sal_srch_nmbr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DataSet ds = null;
                ds = lgic.search("perchas", "invoice_no", sal_srch_nmbr.Text);
                sal_gridview.DataSource = ds.Tables[0];
                count(ds);
            }
        }

        private void sal_srch_daily_Click(object sender, EventArgs e)
        {
            ds = lgic.toFrom("perchas", sal_srch_fromdate.Value.ToString(), sal_srch_todate.Value.ToString());
            sal_gridview.DataSource = ds.Tables[0];
            count(ds);
        }
    }
}
