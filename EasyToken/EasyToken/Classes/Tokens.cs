using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace EasyToken.Classes
{
    public class Tokens
    {


        public static string ManActiveTokens(string adminid)
        {

            string tokens = "<table class='table table-bordered'><thead><tr> <th>Patient Name</th><th>NextAppointment</th><th>Creation Date</th> </tr></thead><tbody>";

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Status=1 AND OwnerID='" + adminid + "' Order by CreationDate DESC", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        tokens += "<tr><th scope='row'> <a href='ViewToken.aspx?T=" + reader["Id"] + "'> " + reader["CusName"];
                        tokens += "<th scope='row'>" + reader["NextAppointment"] + "</th>";
                        tokens += "<th scope='row'>" + reader["CreationDate"] + "</th>";



                    }
                    return tokens;
                }
                return tokens + "</tbody></table></div>";

            }
            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }

        public static string UserActiveTokens(string userid)
        {

            string tokens = "<table class='table table-bordered'><thead><tr> <th>Patient Name</th><th>Creation Date</th> </tr></thead><tbody>";

            //try
            //{
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Status=1 AND  UserID='" + userid + "' Order by CreationDate DESC", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        tokens += "<tr><th scope='row'> <a href='ViewToken.aspx?T=" + reader["Id"] + "'> " + reader["CusName"];
                      
                        tokens += "<th scope='row'>" + reader["CreationDate"] + "</th>";



                    }
                    return tokens;
                }
                return tokens + "</tbody></table></div>";

            //}
            //catch (Exception e)
            //{
            //    return "An error occured,please try again later";
            //}


        }
        public static string GetCusname(string tokenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["CusName"].ToString();
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

        public static string GetAppointment(string tokenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["NextAppointment"].ToString();
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
        public static string GetMedication(string tokenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["Medication"].ToString();
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

        public static string GetTokenDesc(string tokenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["Description"].ToString();
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

        public static string UpdateToken( string tokenid)
        {


            //try
            //{
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Tokens SET Status=0 where Id=@tid", con);
                cmd.Parameters.AddWithValue("tid", tokenid);
                cmd.ExecuteNonQuery();
                return null;



            //}
            //catch (Exception e)
            //{
            //    return "couldnt update pickup,please try again";
            //}


        }


        public static string deletetoken(string tokenid)
        {


            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tokens WHERE Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                cmd.ExecuteNonQuery();
                return null;



            }
            catch (Exception e)
            {
                return "couldnt delete service,please try again";
            }


        }


        public static string GetDocNotes(string tokenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tokens where Id=@I", con);
                cmd.Parameters.AddWithValue("I", tokenid);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["DoctorNotes"].ToString();
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

        public static string SearchUsers(string search)
        {
            //try
            //{
                string result = "<ul>";
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Users where Name Like '%' "+search+"'%'", con);
                
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result += "<li><a href='AddUserToToken.aspx?AD=" + reader["Id"] + "'> " + reader["Name"] +"</a></li>";

                    }
                    return result;
                }
                return result + "</ul>";

                    }
            //catch (Exception e)
            //{
            //    return null;
            //}
    //    }








    }
}