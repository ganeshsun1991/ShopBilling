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
        BL.usermodel User = new BL.usermodel();
        /// <summary>
        /// get records from db user details
        /// </summary>
        /// <returns></returns>
        public DataTable getuserrecords()
        {
            DataTable dt = new DataTable();
            try
            {
                sqlcon.Open();
                SqlDataAdapter da;
                da = new SqlDataAdapter("select u.USER_ID,NAME,MOBILE_NUMBER as 'MOBILE NUMBER',USER_NAME as 'USER NAME',role.USER_ACCESS as 'USER ROLE',(select NAME from TBL_A_USER where USER_ID=CREATED_BY) as 'CREATED BY' from TBL_A_USER u inner join TBL_A_USER_ROLE role on role.USER_ID=u.USER_ID", sqlcon);
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
        public string insertdetails(usermodel user)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
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
            }
        }
        /// <summary>
        /// UPDATE USER DETAILS
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateUserDetails(usermodel user)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_UPDATE_USER_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@NAME", user.Name);
            cmd.Parameters.AddWithValue("@MOBILE_NUMBER", user.Mobilenumber);
            cmd.Parameters.AddWithValue("@USER_NAME", user.Username);
            cmd.Parameters.AddWithValue("@PASSWORD", user.password);
            cmd.Parameters.AddWithValue("@CREATED_BY", user.createdby);
            cmd.Parameters.AddWithValue("@USER_ACCESS", user.UserRole);
            cmd.Parameters.AddWithValue("@USER_ID", user.UserID);
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
        public string DeleteUserDetailsByuserId(int userid)
        {
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_DELETE_USER_DETAILS]";
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@USER_ID", userid);
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
        //public DataTable AlreadyExistsUsername(string username)
        //{
        //    sqlcon.Open();
        //    cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "[dbo].[SP_ALREADYEXITSUSER_USER_DETAILS]";
        //    cmd.Connection = sqlcon;
        //    cmd.Parameters.AddWithValue("@USER_NAME", username);
        //    DataTable dtusername = new DataTable();
        //    try
        //    {
               
        //        SqlDataAdapter da;
        //        da = new SqlDataAdapter(cmd.CommandText, sqlcon);
        //        da.Fill(dtusername);
        //        return dtusername;
        //    }
        //    catch 
        //    {
        //        return dtusername;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}
       
        //public DataTable AlreadyExistsUsername(string username)
        //{
        //    DataTable dtusername = new DataTable();
        //    try
        //    {
        //        sqlcon.Open();
        //        SqlDataAdapter da;
        //        da = new SqlDataAdapter("SELECT USER_ID,USER_NAME from TBL_A_USER WHERE  USER_NAME= '" + username + "'", sqlcon);
        //        da.Fill(dtusername);
        //        sqlcon.Close();
        //        return dtusername;
        //    }
        //    catch (Exception ex)
        //    {
        //        sqlcon.Close();
        //        return dtusername;
        //    }
        //}
    }
}
