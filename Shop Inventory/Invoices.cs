using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Inventory
{
    public partial class Invoices : Form
    {
        logic lgic;
        DataSet ds;

        public Invoices()
        {
            InitializeComponent();
            lgic = new logic();
            ds = lgic.get_tabl("invoice");
            invn_gridview.DataSource = ds.Tables[0];
            count(ds);
            invn_ad_cst_name.DataSource = lgic.combodata("invoice", "customer_name");
            invn_srch_cst_name.DataSource = lgic.combodata("invoice", "customer_name");
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)  //done button
        {
            
            // here write function that save data

            string[] at = { invn_ad_cst_name.Text, invn_ad_invoicenmbr.Text, inv1_ad_detail.Text, 
                              invn_ad_total.Text, invn_ad_receive.Text,  invn_ad_balance.Text,
                              invn_ad_status.Text, inv_datetoday.Value.ToString() };
            string msg = lgic.invoicedata(at);
            MessageBox.Show(msg);

            ds = lgic.get_tabl("invoice");
            invn_gridview.DataSource = ds.Tables[0];
            count(ds);

            invn_srch_cst_name.DataSource = lgic.combodata("invoice", "customer_name");
            int index = invn_srch_cst_name.FindString(invn_ad_cst_name.Text);
            invn_srch_cst_name.SelectedIndex = index;

            inv1_ad_detail.Text = "";
            invn_ad_invoicenmbr.Text = "";
            invn_ad_receive.Text = "";
            invn_ad_total.Text = "";
            invn_ad_balance.Text = "";
            invn_ad_cst_name.Select(); 
            
        }

        private void inv1_ad_detail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void invn_srch_daily_Click(object sender, EventArgs e)
        {
            ds = lgic.toFrom("invoice", invn_srch_fromdate.Value.ToString(), invn_srch_todate.Value.ToString());
            invn_gridview.DataSource = ds.Tables[0];
            count(ds);

        }

        private void invn_ad_receive_TextChanged(object sender, EventArgs e)
        {
            if (invn_ad_receive.Text != "" && invn_ad_total.Text!="")
            {
                int tl = Convert.ToInt32(invn_ad_total.Text.ToString());
                int rc = Convert.ToInt32(invn_ad_receive.Text.ToString());

                invn_ad_balance.Text = (tl - rc).ToString();
            }
        }

        private void invn_ad_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invn_ad_status.Text == "Receive")
            {
                invn_ad_total.Text = "0";
                invn_ad_receive.Select();
            }
        }

        private void invn_srch_cst_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = lgic.search("invoice", "customer_name", invn_srch_cst_name.Text);
            invn_gridview.DataSource=ds.Tables[0];
            count(ds);

        }

        private void invn_srch_nmbr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void invn_srch_nmbr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DataSet ds = null;
                ds = lgic.search("invoice", "invoice_no", invn_srch_nmbr.Text);
                invn_gridview.DataSource = ds.Tables[0];
                count(ds);
            }

        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }

       public void count(DataSet table) {
           string balnce="";
           int total=0, recevie=0 , balance=0;
           
           foreach (DataRow row in table.Tables[0].Rows) {
               balnce = row[6].ToString();
               total += int.Parse(row[4].ToString());
               recevie += int.Parse(row[5].ToString());
               balance += int.Parse(row[6].ToString());
           }
           invn_balance.Text = balance.ToString();
           total_invoice.Text = total.ToString();
           recive_invo.Text = recevie.ToString();
           //foreach (DataTable thisTable in table.Tables)
           //{
           //     For each row, print the values of each column.
           //    foreach (DataRow row in thisTable.Rows)
           //    {
           //        foreach (DataColumn column in thisTable.Columns)
           //        {
           //            Console.WriteLine(row[column]);
           //        }
           //    }
           //}
        }

       private void invn_srch_tody_Click(object sender, EventArgs e)
       {
           DataSet ds = null;
           ds = lgic.today("invoice");
           invn_gridview.DataSource = ds.Tables[0];
           count(ds);
       }
    }
}
