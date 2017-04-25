using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop_Inventory
{
    class logic
    {

        public static int v_id = 0;
        // saday pangay
        DB dtbs = new DB();
        DataSet ds = new DataSet();
        public static Double quunti, pkitms, echsle, echcst, pksel, pkcst, sel_itms,sel_total, que;

        public string Login(string uname, string pass)
        {
            string q = "SELECT * from users where [user_name]='" + uname + "' and [password]='" + pass + "'";
            SqlDataReader sqldr = dtbs.DRselect(q);
            
            try
            {
                if (sqldr.Read())
                {
                    return "Successfull";
                }
               
            }
            catch (Exception s)
            {
                return s.ToString();
            }
            finally {
                sqldr.Close();
            }
            
            return "Fail";
        }

        public void Displaynotify()
        {
            try
            {
                NotifyIcon notifyIcon1 = new NotifyIcon();
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"C:\Users\Developer\documents\visual studio 2015\Projects\inventory\inventory\image\Login.ico"));
                //notifyIcon1.Text = "Inventory Login";
                //notifyIcon1.Visible = true;
                //notifyIcon1.BalloonTipTitle = "you have successfully login ....";
                //notifyIcon1.BalloonTipText = "Click Here to see details";
                //notifyIcon1.ShowBalloonTip(10);

            }
            catch (Exception)
            {

            }
        }

        public DataSet today(string tblnm) {
            ds = null;
            ds = dtbs.getTable("SELECT * FROM " + tblnm + " where date  BETWEEN '" + DateTime.Today.ToString() + "' And '" + DateTime.Today.AddDays(1).ToString() + "' ;");
            return ds;
        }

        // add expence function
        public String ins_expence(String[] t)
        {
            String qur = "insert into expence ( [type], [discription], [expence], [date]) VALUES ('" + t[0] + "','" + t[1] + "'," + t[2] + ",'" + t[3] + "' )";
            blanceadd("cradit",t[0]+t[1],int.Parse(t[2]));
            return dtbs.IUD(qur);
        }
        public void blanceadd(string typ,string disc, int amt) {
            int db = sumfun("debit", "account");
            int crd = sumfun("cradit", "account");
            int blc = 0;

            if (typ == "debit")
            {
                blc = db + amt - crd;
                dtbs.IUD("insert into account ( [discription], [debit],[balance],[date]) VALUES ('" + disc + "' ," + amt + "," + blc + ",'" + DateTime.Today.ToString() + "' )");
            }
            else {

                blc = db - amt - crd;
                dtbs.IUD("insert into account ( [discription], [cradit],[balance],[date]) VALUES ('" + disc + "' ," + amt + "," + blc + ",'" + DateTime.Today.ToString() + "' )");
            }
          
        }
        // add invoice data
        public string invoicedata(string[] dt)
        {
            string qur = "insert into invoice ([customer_name], [invoice_no], [discription], [total], [receive], [balance], [status],[date]) VALUES ( '" + dt[0] + "', '" + dt[1] + "','" + dt[2] + "'," + dt[3] + "," + dt[4] + ", " + dt[5] + ", '" + dt[6] + "', '" + dt[7] + "' );";
            blanceadd("debit", dt[0] + "...." + dt[1] + "..." + dt[2] + "...." + dt[6], int.Parse(dt[4]));
            return dtbs.IUD(qur);
        }
        public int sumfun(string colm, string tabl)
        {
            int sum = 0;
            string sm = dtbs.sumof("select sum(" + colm + ") from " + tabl + ";");
            if (sm == "")
            {
                sum = 0;
            }
            else
            {
                sum = int.Parse(sm);
            }
           
            return sum;

        }
        public int sumfundte(string tbl, string colm, string frm, string to)
        {
            int cont = 0;
            string q =dtbs.sumof( "select sum(" + colm + ") from " + tbl + " where date  BETWEEN '" + frm + "' And '" + to + "' ;") ;
            if (q == "")
            {
                cont = 0;
            }
            else
            {
                cont = int.Parse(q);
            }
            return cont;
        }
        public string invoicesale(string[] dt)
        {
            string qur = "insert into perchas ([saller_name], [invoice_no], [discription], [total], [pay], [balance], [status],[date]) VALUES ( '" + dt[0] + "', '" + dt[1] + "','" + dt[2] + "'," + dt[3] + "," + dt[4] + ", " + dt[5] + ", '" + dt[6] + "' ,'" + dt[7] + "');";
            blanceadd("cradit", dt[0]+"...." + dt[1]+"..."+dt[2]+"...."+dt[6], int.Parse(dt[4]));
            return dtbs.IUD(qur);
        }
        
        public String sele(String[] datee)
        {
            Double pid, by, sel, qnti;
            pid = Convert.ToDouble(datee[1]);
            by = Convert.ToDouble(datee[1]);
            sel = Convert.ToDouble(datee[1]);
            qnti = Convert.ToDouble(datee[1]);
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            // Insert into UserData(F_name, L_name,
            String qur = "Insert into stock( product_id, product_name, buying, seling, quantity,brand,catagory, date) VALUES(" + pid + ", '" + pid + "'," + by + " , " + sel + ", " + qnti + ", '" + pid + "', '" + pid + "', '" + date + "')";
            return dtbs.IUD(qur);
        }

        public String add_prduct(String[] data )
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            String qur = "Insert into product(item_name, company, category, barcode, date) VALUES('" + data[0] + "', '" + data[1] + "','" + data[2] + "','" + data[3] + "','" + date + "')";
            dtbs.IUD(qur);
            qur = "Insert into stock(item_name, company, category, barcode, date) VALUES('" + data[0] + "', '" + data[1] + "','" + data[2] + "','" + data[3] + "','" + date + "')";
            return dtbs.IUD(qur);
        }

        public string Get_Top_ID(string Table_name, string id)
        {
            string q = "select max("+ id + ") from " + Table_name + "";
            DataSet ds = dtbs.getTable(q);
            string S;
            try
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return "0";
                }
                else
                {
                    S = ds.Tables[0].Rows[0][0].ToString();
                    if (S == "")
                    {
                        return "0";
                    }
                    return S;
                }
            }
            catch (Exception)
            {
                return "Null";
            }

        }

        // search function
        public DataSet search(string tab_nam, string colm, string name)
        {
            DataSet ds;
            // select * from product where stock= name;
            string q = "Select * from "+tab_nam+" where "+colm+" like '" + name + "' ";
            ds = dtbs.getTable(q);
            return ds;
        }

       public List<String> combodata(string tbl, string clm)
        {
            string Sql = "select Distinct "+clm+" from "+tbl;
            List<String> ast = new List<string>();

            DB dtb = new DB();
            SqlDataReader DR = dtb.DRselect(Sql);

            while (DR.Read())
            {
                ast.Add(DR[0].ToString());
            }
            return ast;
        }

       public SqlDataReader Readdata(string tbl, string frm, string to) {

           string q = "select * from " + tbl + " where date  BETWEEN '" + frm + "' And '" + to + "'";
           DB dtb = new DB();
           SqlDataReader DR = dtb.DRselect(q);

           return DR;
       }
       
        public DataSet get_tabl(string qur)
        {
            DataSet dss = new DataSet();
            String qr = "select * from " + qur;
            dss = dtbs.getTable(qr);
            return dss;
        }

       public String product(String[] ap)
        {
            String abc = "SELECT * from product where [item_name]='" + ap[0] + "' and [company]='" + ap[1] + "' and [category]='" + ap[2] + "'";
            SqlDataReader sqldr = dtbs.DRselect(abc);
            if (sqldr.Read())
            {
                abc = "success";
            }else { abc = "fail"; }
            sqldr.Close();
            return abc;
        }

        public String[] barselection(string sy)
        {
           
            String[] dtt = new String[10];
            string bb = "select * from product where[barcode]='" + sy + "'";
            DataSet bards = new DataSet();
            bards = dtbs.getTable(bb);
            for(int i=0;i< bards.Tables[0].Columns.Count; i++)
            {
                dtt[i] = bards.Tables[0].Rows[0][i].ToString();
            }

            return dtt;
        }


        public DataSet DalyReport()
        {
            DataSet ds;
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string q = "select * from product where date = '"+date+ "'";
            DB db = new DB();
            ds = db.getTable(q);
            return ds;
        }
        public DataSet toFrom(string tbl,string from, string to)
        {
            DataSet ds;

            string q = "select * from " + tbl + " where date  BETWEEN '" + from + "' And '" + to + "'";
            DB db = new DB();
            ds = db.getTable(q);
            return ds;
        }

        public DataSet stockrep(string b_code)
        {
            DataSet ds;

            string q = "select * from stock where barcode  '" + b_code + "'";
            DB db = new DB();
            ds = db.getTable(q);
            return ds;
        }


        public string sale_Product(int v_id,string customer_nam, string item_name , string company, string category, string size, string sele_cost, int qunty, int totl, string barcode)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            String qur = "INSERT INTO seledata ([vouchr_id], [customer_nam], [item_name], [company], [category], [size], [sele_cost], [qunty], [totl], [date], [barcode]) VALUES ("+v_id+", '"+customer_nam+"', '"+item_name+"', '"+company+"', '"+category+"', '"+size+"', "+sele_cost+", "+qunty+", "+totl+", '"+date+"', '"+barcode+"')";
           // dtbs.IUD(qur);
           // qur = "Insert into stock(item_name, company, category, barcode, date) VALUES('" + data[0] + "', '" + data[1] + "','" + data[2] + "','" + data[3] + "','" + date + "')";
           return dtbs.IUD(qur);
        }

        public string add_sale(string[] tt)
        {
            int qqt = Convert.ToInt32(Get_Top_ID("product","qunty"));
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            qqt = qqt - Convert.ToInt32(tt[7]);
            String qur = "INSERT INTO seledata ([vouchr_id], [customer_nam], [item_name], [company], [category], [size], [sele_cost], [qunty], [totl], [date], [barcode]) VALUES (" + tt[0] + ", '" + tt[1] + "', '" + tt[2] + "', '" + tt[3] + "', '" + tt[4] + "', '" + tt[5] + "', " + tt[6] + ", " + tt[7] + ", " + tt[8] + ", '" + date + "', '" + tt[9] + "')";
            dtbs.IUD("update product set qunty = " + qqt + "");
            return dtbs.IUD(qur);

        }


        public DataSet Get_Bill(int v_id)
        {
            DataSet ds;
            v_id = v_id - 1;
            int totl = 0;
            string q = "select * from seledata where vouchr_id =" + v_id + "";
            DB db = new DB();
            ds = db.getTable(q);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) { 
                totl=totl+ Convert.ToInt32( ds.Tables[0].Rows[i][9].ToString());
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i][5] = totl.ToString();
            }

            return ds;
        }

    }
}
