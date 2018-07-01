using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace EasyToken.Classes
{
    public class UserAccounts
    {
        public static string Reg(string firstname, string lastname,string username, string email, string password)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users(FirstName,LastName,Username,Email,Password) values('" + firstname + "','" + lastname + "','" + username + "','" + email + "','" + password + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                cmd.Dispose();
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public static int login(string username, string password)
        {
            try
            {
                int logi = 0;
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Users where Username='" + username + "' AND Password='" + password + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    logi = 1;
                    return logi;
                }
                else
                {
                    return logi;
                }

                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public static string GetUsername(string username)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Users where Username='" + username + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["Username"].ToString();
                return name;
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string GetID(string username)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Users where Username='" + username + "'", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string userid = reader["Id"].ToString();
                return userid;
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}