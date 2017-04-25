using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace Shop_Inventory
{
    class DB
    {
        string cs = Shop_Inventory.Properties.Settings.Default.DatabaseshopConnectionString;
         
        SqlConnection sqlcon = new SqlConnection();
        public void openCon()
        {
            string A = "A";
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            try
            {
               sqlcon = new SqlConnection(cs);
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }


        public string IUD(string iuds)
        {
            openCon();
            SqlCommand cmd = new SqlCommand(iuds, sqlcon);
            try
            {
                cmd.ExecuteNonQuery();
                return "Success";
            }

            catch (Exception)
            {
                return "Fail";
            }
            finally
            {
              //  sqlcon.Close();
            }     

        }
        public SqlDataReader sdr;
        public SqlDataReader DRselect(string drs)
        {
            if (sqlcon.State == 0)
            {
                openCon();
               //sqlcon.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(drs, sqlcon);
                sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                //sqlcon.Close();
                //sdr.Close();
            }
            
        }
        public void con_close() {
            sqlcon.Close();
        }

        public DataSet getTable(string gts)
        {
            if (sqlcon.State == 0)
            {
                openCon();
            }
            DataSet ds = new DataSet();
            try
            {
                openCon();
                SqlDataAdapter da = new SqlDataAdapter(gts, sqlcon);
                da.Fill(ds);
            }
            catch (Exception)
            {

                return ds;
            }
            finally {
               // sqlcon.Close();
            }
           

            return ds;
        }

        public string sumof(string qur)
        {
             if (sqlcon.State == 0)
            {
                openCon();
            }
             string sum;
             try
             {
                SqlCommand cmd = new SqlCommand(qur, sqlcon);
                sum = cmd.ExecuteScalar().ToString();
                 
             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return sum;
        }
        public DataSet grid_update(String qr)
        {
            DataSet ds = new DataSet();

            return ds;
        }

        public DataSet comb_data(String qr)
        {
            DataSet ds = new DataSet();

            return ds;
        }

    }
}
