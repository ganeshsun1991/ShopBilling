using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Billing.BL
{
    class product_bl
    {
        SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        BL.productmodel Product = new BL.productmodel();
        /// <summary>
        /// get records from db user details
        /// </summary>
        /// <returns></returns>
        public DataTable GetProductRecords()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlcon.Open();
                SqlDataAdapter da;
                da = new SqlDataAdapter("SELECT PRODUCT_ID,PRODUCT_NAME AS 'PRODUCT NAME',AMOUNT,[PRODUCT_TYPE] as 'PRODUCT TYPE',(select NAME from TBL_A_USER where USER_ID=CREATED_BY) as 'CREATED BY' FROM TBL_PRODUCT_MASTER", sqlcon);
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
        /// <summary>
        /// to Insert Details in DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string InsertDetails(productmodel Product)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_INSERT_PRODUCT_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@PRODUCTNAME", Product.ProductName);
            cmd.Parameters.AddWithValue("@AMOUNT", Product.Amount);
            cmd.Parameters.AddWithValue("@PRODUCTTYPE", Product.ProductType);
            cmd.Parameters.AddWithValue("@CREATED_BY", Product.createdby);
            try
            {
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// UPDATE PRODUCT DETAILS
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateProductDetails(productmodel Product)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_UPDATE_PRODUCT_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@PRODUCTNAME", Product.ProductName);
            cmd.Parameters.AddWithValue("@AMOUNT", Product.Amount);
            cmd.Parameters.AddWithValue("@CREATED_BY", Product.createdby);
            cmd.Parameters.AddWithValue("@PRODUCTID", Product.ProductId);
            try
            {
                cmd.ExecuteNonQuery();
                return "Updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// already exists check product name
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataTable AlreadyExistsProductname(string productname)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_ALREADYEXITS_PRODUCTNAME]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@PRODUCT_NAME", productname);
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
        public string DeleteProductDetailsByProductId(int productid)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_DELETE_PRODUCT_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@PRODUCT_ID", productid);
            try
            {
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd.CommandText, sqlcon);

                cmd.ExecuteNonQuery();
                return "Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                sqlcon.Close();
            }
        }

    }
}
