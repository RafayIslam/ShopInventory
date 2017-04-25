using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Inventory
{
    public partial class Expences : Form
    {
        logic lgic;
        DataSet ds;
        public Expences()
        {
            InitializeComponent();
            lgic = new logic();
            ds=lgic.get_tabl("expence");
            dl_exp_datagrid.DataSource = ds.Tables[0];

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // remove text data from amout textbox.. 
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

            if (e.KeyChar == (char)Keys.Enter && dl_exp_amouth.Text!="")
            {
                int mount = Convert.ToInt32(dl_exp_amouth.Text);
                // save data to databse and show in gridview
                addexpnc(dl_exp_type.Text, mount);
                dl_exp_amouth.Text = "";
            }
           
        }

        private void button4_Click(object sender, EventArgs e)   /// done button click
        {
            int mount = Convert.ToInt32(dl_exp_amouth.Text);
            // save data to databse and show in gridview

            // Display the selected date and time:
          
            // Display today's date and time:
            MessageBox.Show("Today is: " + DateTime.Today);
            MessageBox.Show("nexr day is: " + DateTime.Today.AddDays(1));


            string[] data = { dl_exp_type.Text, dl_exp_discription.Text, dl_exp_amouth.Text, dl_exp_today.Value.ToString()};
            string msg=lgic.ins_expence(data);
            MessageBox.Show(msg);
            dl_exp_amouth.Text = "";
            dl_exp_discription.Text = "";
            addexpnc(dl_exp_type.Text, mount);
            ds.Clear();
            ds = lgic.get_tabl("expence");
            dl_exp_datagrid.DataSource = ds.Tables[0];

            dl_exp_type.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Monthlyexpence mnth = new Monthlyexpence();
            mnth.ShowDialog();
        }

        private void addexpnc(string typ, int amnt) {
            dl_exp_amouth.Text = "";
            switch (typ) {
                case "Other":
                    dl_exp_other.Text = amnt.ToString();
                    break;
                case "Petrol":
                    dl_exp_petrol.Text = amnt.ToString();
                    break;
                case "Entertainment":
                    dl_exp_entrmnt.Text = amnt.ToString();
                    break;
                case "Load":
                    dl_exp_load.Text = amnt.ToString();
                    break;
                case "Cargo":
                    dl_exp_cargo.Text = amnt.ToString();
                    break;
                case "Chay":
                    dl_exp_chay.Text = amnt.ToString();
                    break;
                case "Home":
                    dl_exp_home.Text = amnt.ToString();
                    break;
                case "Bike":
                    dl_exp_bike .Text = amnt.ToString();
                    break;
                case "Transport":
                    dl_exp_transport.Text = amnt.ToString();
                    break;
                case "Rent":
                    dl_exp_rent.Text = amnt.ToString();
                    break;
                case "Sallary":
                    dl_exp_sallary.Text = amnt.ToString();
                    break;
                case "Utility bills":
                    dl_exp_utility.Text = amnt.ToString();
                    break;    
                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            oth = ptrl = ent = load = carg = chy = hm = bk = trns =rnt= utity= salry=0;
          // string dates = DateTime.Now.ToString();
           ds = null;
         //  ds= lgic.search("expence","date",dates);
           SqlDataReader read = lgic.Readdata("expence", dl_exp_fromdate.Value.ToString(), dl_exp_todate.Value.ToString());
           ds = lgic.toFrom("expence",dl_exp_fromdate.Value.ToString(), dl_exp_todate.Value.ToString());
           dl_exp_datagrid.DataSource = ds.Tables[0];
           // for loop for get data from table
           while (read.Read())
           { 
               string tp = read[1].ToString();
               int mnt = Convert.ToInt32(read[3].ToString());
               addexpence(tp, mnt);
           }


            
        }

        int oth, ptrl, ent, load, carg, chy, hm, bk,trns, rnt, utity, salry ;
        void addexpence(string exp, int amnt) {
           
            switch (exp) {
                case "Other":
                    oth = oth + amnt;
                    dl_exp_other.Text = oth.ToString();
                    break;
                case "Petrol":
                    ptrl = ptrl + amnt;
                    dl_exp_petrol.Text = ptrl.ToString();
                    break;
                case "Entertainment":
                    ent = ent + amnt;
                    dl_exp_entrmnt.Text = ent.ToString();
                    break;
                case "Load":
                    load = load + amnt;
                    dl_exp_load.Text = load.ToString();
                    break;
                case "Cargo":
                    carg = carg + amnt;
                    dl_exp_cargo.Text = carg.ToString();
                    break;
                case "Chay":
                    chy = chy + amnt;
                    dl_exp_chay.Text = chy.ToString();
                    break;
                case "Home":
                    hm = hm + amnt;
                    dl_exp_home.Text = hm.ToString();
                    break;
                case "Bike":
                    bk = bk + amnt;
                    dl_exp_bike.Text = bk.ToString();
                    break;
                case "Transport":
                    trns = trns + amnt;
                    dl_exp_transport.Text = trns.ToString();
                    break;
                case "Rent":
                    rnt = rnt + amnt;
                    dl_exp_rent.Text = rnt.ToString();
                    break;
                case "Sallary":
                    salry = salry + amnt;
                    dl_exp_sallary.Text = salry.ToString();
                    break;
                case "Utility bills":
                    utity = utity + amnt;
                    dl_exp_utility.Text = utity.ToString();
                    break;    
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
