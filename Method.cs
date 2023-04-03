using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Method
    {

        // User Master
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4PEG8NT\SQLEXPRESS;Initial Catalog=My test;User ID=sa;Password=12345");

        public static DataTable Save_Update_User_Master(Class_Properties.User cls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd = new SqlCommand("Save_Update_User_Master", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task", cls.TASK);
                cmd.Parameters.AddWithValue("@ID", string.IsNullOrEmpty(cls.ID) ? (object)DBNull.Value : cls.ID);
                cmd.Parameters.AddWithValue("@USER_NAME", string.IsNullOrEmpty(cls.USER_NAME) ? (object)DBNull.Value : cls.USER_NAME);
                cmd.Parameters.AddWithValue("@NAME", string.IsNullOrEmpty(cls.NAME) ? (object)DBNull.Value : cls.NAME);
                cmd.Parameters.AddWithValue("@ADDRESS", string.IsNullOrEmpty(cls.ADDRESS) ? (object)DBNull.Value : cls.ADDRESS);
                cmd.Parameters.AddWithValue("@MOBILE_NO", string.IsNullOrEmpty(cls.MOBILE_NO) ? (object)DBNull.Value : cls.MOBILE_NO);
                cmd.Parameters.AddWithValue("@PASSWORD", string.IsNullOrEmpty(cls.PASSWORD) ? (object)DBNull.Value : cls.PASSWORD);
                cmd.Parameters.AddWithValue("@CREATED_BY", string.IsNullOrEmpty(cls.CREATED_BY) ? (object)DBNull.Value : cls.CREATED_BY);
                cmd.Parameters.AddWithValue("@ISDELETED", string.IsNullOrEmpty(cls.ISDELETED) ? (object)DBNull.Value : cls.ISDELETED);
                cmd.Parameters.AddWithValue("@SEARCH_VALUE", string.IsNullOrEmpty(cls.SEARCH_VALUE) ? (object)DBNull.Value : cls.SEARCH_VALUE);
                cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 200);
                cmd.Parameters["@Message"].Direction = ParameterDirection.Output;
                if (con.State == ConnectionState.Open) {con.Close(); }
                con.Open();
                string msg = String.Empty;

                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                con.Close();

                return ds.Tables[0];
            }
            catch (Exception)
             {
                throw;
            }
        }

        internal static DataTable Save_Delete_User_Master(Class_Properties.User cp)
        {
            throw new NotImplementedException();
        }
    }
}