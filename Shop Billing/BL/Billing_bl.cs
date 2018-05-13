using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Billing.BL
{
    class Billing_bl
    {
        SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;


        /// get MObile Product details from db  
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetMobileProductRecords(string mobiletype)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlcon.Open();
                SqlDataAdapter da;
                da = new SqlDataAdapter("SELECT PRODUCT_ID,PRODUCT_NAME  FROM TBL_PRODUCT_MASTER WHERE  [PRODUCT_TYPE]='" + mobiletype + "'", sqlcon);
                da.Fill(dt);
                sqlcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                return dt;
            }
        }

        public DataTable AmountGetbyProductId(int productid)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            
           // cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SELECT AMOUNT FROM TBL_PRODUCT_MASTER WHERE PRODUCT_ID=@PRODUCTID";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@PRODUCTID", productid);
            DataTable dtproductname = new DataTable();
            try
            {

                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);

                da.Fill(dtproductname);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlcon.Close();
            }

            return dtproductname;
        }
    }
}
