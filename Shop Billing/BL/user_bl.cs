using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Billing.BL
{
    class user_bl
    {
        SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
       
        BL.usermodel User = new BL.usermodel();
        /// <summary>
        /// get records from db user details
        /// </summary>
        /// <returns></returns>
        public DataTable getuserrecords()
        {
            sqlcon.Open();
            da = new SqlDataAdapter("select USER_ID,NAME,MOBILE_NUMBER,USER_NAME,CREATED_BY from TBL_A_USER", sqlcon);
            da.Fill(dt);
            sqlcon.Close();
            return dt;
        }

        public string insertdetails(usermodel user)
        {

            //string strQry = @"INSERT INTO [dbo].[TBL_A_USER]([NAME],[MOBILE_NUMBER],[USER_NAME],[PASSWORD],[CREATED_BY]) VALUES('"+user.Name+"','"+user.Mobilenumber+"','"+user.Username+"','"+user.password+"',1)INSERT INTO [dbo].[TBL_A_USER_ROLE]([USER_ID],[USER_ACCESS],[CREATED_BY])VALUES(1,'Admin',1)";
            //sqlcon.Open();
            //cmd.ExecuteNonQuery();
            sqlcon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_INSERT_USER_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@NAME",user.Name);
            cmd.Parameters.AddWithValue("@MOBILE_NUMBER", user.Mobilenumber);
            cmd.Parameters.AddWithValue("@USER_NAME", user.Username);
            cmd.Parameters.AddWithValue("@PASSWORD", user.password);
            cmd.Parameters.AddWithValue("@CREATED_BY", user.createdby);
            cmd.Parameters.AddWithValue("@USER_ACCESS", user.UserRole);
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
               // sqlcon.Dispose();
            }
        }
    }
}
