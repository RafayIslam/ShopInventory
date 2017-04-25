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
    public partial class sum_totl_exp : Form
    {

        logic lgic;

        int sal_totl = 0, sal_rec = 0, Sal_blnc = 0, pr_totl = 0, pr_pay = 0, pr_blnc = 0, expnc = 0;
        int oth=0, ptrl=0, ent=0, load=0, carg=0, chy=0, hm=0, bk=0, trns=0, rnt=0, utity=0, salry=0;
        public sum_totl_exp()   
        {
            InitializeComponent(); 
            lgic = new logic();
            refrash();

        }
        void refrash()
        {
            // get from invoice table
            sal_totl = lgic.sumfun("total", "invoice");
            sal_rec = lgic.sumfun("receive", "invoice");
            Sal_blnc = lgic.sumfun("balance", "invoice");

           

            // get sum from perchase table 
            pr_totl = lgic.sumfun("total", "perchas");
            pr_pay = lgic.sumfun("pay", "perchas");
            pr_blnc = lgic.sumfun("balance", "perchas");

            // get from expence table
            expnc = lgic.sumfun("expence", "expence");

            addexpence(lgic.get_tabl("expence"));
            putdata();          

        }

        void putdata() {
            // put from invoice table
            smry_invc_sale.Text = sal_totl.ToString();
            smry_invc_rec.Text = sal_rec.ToString();
            smry_invc_blnc.Text = Sal_blnc.ToString();

            // put sum from perchase table 
            smry_buy_totl.Text = pr_totl.ToString();
            smry_buy_pay.Text = pr_pay.ToString();
            smry_buy_blnc.Text = pr_blnc.ToString();

            smry_acc_exp.Text = expnc.ToString();


            // account data
            smry_acc_sale.Text = sal_totl.ToString();
            smry_acc_buy.Text = pr_totl.ToString();

            smry_acc_cash.Text = (sal_rec - pr_pay - expnc).ToString();
            smry_acc_cradit.Text = pr_pay.ToString();
            smry_acc_dabit.Text = sal_rec.ToString();

            // summry data
            smry_cash.Text = (sal_rec - pr_pay - expnc).ToString();
            smry_balance.Text = pr_blnc.ToString();
            smry_cradit.Text = Sal_blnc.ToString();
            smry_updown.Text = (Sal_blnc - pr_blnc).ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoices invc = new Invoices();
            invc.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buyinvoices sinv = new Buyinvoices();
            sinv.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expences exp = new Expences();
            exp.Show();
        }
        // search button 
        private void button10_Click(object sender, EventArgs e)   // search data
        {
            expnc = lgic.sumfundte("expence", "expence", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());
            // get from invoice table
            sal_totl = lgic.sumfundte("total", "invoice", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());
            sal_rec = lgic.sumfundte("receive", "invoice", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());
            Sal_blnc = lgic.sumfundte("balance", "invoice", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());



            // get sum from perchase table 
            pr_totl = lgic.sumfundte("total", "perchas", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());
            pr_pay = lgic.sumfundte("pay", "perchas", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());
            pr_blnc = lgic.sumfundte("balance", "perchas", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());

            // get from expence table
            expnc = lgic.sumfundte("expence", "expence", sum_exp_fromdate.Value.ToString(), sum_exp_todate.Value.ToString());

            addexpence(lgic.get_tabl("expence"));
            putdata();
        }
        private void btn_refrash_Click(object sender, EventArgs e)
        {
            refrash();
        }

        private void smry_invc_btn_dabit_Click(object sender, EventArgs e)
        {
            Invoices inv = new Invoices();
            inv.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Buyinvoices sal = new Buyinvoices();
            sal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expences exp = new Expences();
            exp.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void sum_totl_exp_Load(object sender, EventArgs e)
        {

        }

        private void smry_exp_btn_Click(object sender, EventArgs e)
        {
            Expences exp = new Expences();
            exp.Show();
        }

        void addexpence(DataSet ds)
        {
           foreach(DataRow dr in ds.Tables[0].Rows){
               putexpence(dr[1].ToString(), int.Parse(dr[3].ToString()));
           }
        }
        void putexpence(string exp, int amnt)
        {

            switch (exp)
            {
                case "Other":
                    oth = oth + amnt;
                    smry_exp_other.Text = oth.ToString();
                    break;
                case "Petrol":
                    ptrl = ptrl + amnt;
                    smry_exp_petrol.Text = ptrl.ToString();
                    break;
                case "Entertainment":
                    ent = ent + amnt;
                    smry_exp_entrmnt.Text = ent.ToString();
                    break;
                case "Load":
                    load = load + amnt;
                    smry_exp_load.Text = load.ToString();
                    break;
                case "Cargo":
                    carg = carg + amnt;
                    smry_exp_cargo.Text = carg.ToString();
                    break;
                case "Chay":
                    chy = chy + amnt;
                    smry_exp_chy.Text = chy.ToString();
                    break;
                case "Home":
                    hm = hm + amnt;
                    smry_exp_home.Text = hm.ToString();
                    break;
                case "Bike":
                    bk = bk + amnt;
                    smry_exp_bike.Text = bk.ToString();
                    break;
                case "Transport":
                    trns = trns + amnt;
                    smry_exp_trnsport.Text = trns.ToString();
                    break;
                case "Rent":
                    rnt = rnt + amnt;
                    smry_exp_rent.Text = rnt.ToString();
                    break;
                case "Sallary":
                    salry = salry + amnt;
                    smry_exp_sallry.Text = salry.ToString();
                    break;
                case "Utility bills":
                    utity = utity + amnt;
                    smry_exp_utility.Text = utity.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)// account button
        {
            Monthlyexpence acc = new Monthlyexpence();
            acc.Show();
        }
    }
}
