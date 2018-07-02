using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace EasyToken.Classes
{
    public class Messege
    {

        public static string SendMessege(string to, string toname, string from, string fromname, string subject, string body, string datetime)
        {
            //try
            //{
            string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Messeges([To],[ToName],[From],[FromName],[Subject],[Body],[DateTime],[Status]) values(@T,@TN,@F,@FN,@S,@B,@D,@ST)", con);
            cmd.Parameters.AddWithValue("T", to);
            cmd.Parameters.AddWithValue("F", from);
            cmd.Parameters.AddWithValue("TN", toname);
            cmd.Parameters.AddWithValue("FN", fromname);
            cmd.Parameters.AddWithValue("S", subject);
            cmd.Parameters.AddWithValue("B", body);
            cmd.Parameters.AddWithValue("D", datetime);
            cmd.Parameters.AddWithValue("ST", "<span class='ur'>New</span>");
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            cmd.Dispose();
            return null;
            //}
            //catch (Exception e)
            //{
            //    return null;
            // }
        }



        public static string getMessegeList(string userId)
        {

            string messegeList = "<table class='table'><tbody>";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges Where [To]=@AS order by DateTime DESC", con);
                comm.Parameters.AddWithValue("AS", userId);
                SqlDataReader reader;
                reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        messegeList += "<tr class='table-row'> <td class='table-text'><h6><a href='ViewMessege.aspx?M=" + reader["Id"] + "'>" + reader["Subject"] + "</a></h6></td>";
                        messegeList += "<td>" + reader["Status"] + "</td>";
                        messegeList += "<td class='march'>" + reader["DateTime"] + "</td></tr>";

                    }
                    return messegeList;
                }
                return messegeList + "</tbody></table>";
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }

        public static string numinbox(string uid)
        {

            string num = "";

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select COUNT(*) From Messeges where [To]=@I", con);
                cmd.Parameters.AddWithValue("I", uid);
                num = cmd.ExecuteScalar().ToString();
                return num;



            }
            catch (Exception e)
            {
                return "Couldnt retrive pickups";
            }
        }
        public static string numsent(string uid)
        {

            string num = "";

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select COUNT(*) From Messeges where [From]=@I", con);
                cmd.Parameters.AddWithValue("I", uid);
                num = cmd.ExecuteScalar().ToString();
                return num;



            }
            catch (Exception e)
            {
                return "Couldnt retrive pickups";
            }
        }



        //public static string getManMassegeList(string man)
        //{

        //    string messegeList = "<table class='table'><tbody>";

        //    try
        //    {

        //        string cs = ConfigurationManager.ConnectionStrings["DLConnectionString1"].ConnectionString;
        //    SqlConnection con = new SqlConnection(cs);
        //    con.Open();
        //    SqlCommand comm = new SqlCommand("Select * From  Messeges where [To]=@I ORDER BY DateTime DESC", con);
        //    comm.Parameters.AddWithValue("I", man);
        //    SqlDataReader reader;
        //    reader = comm.ExecuteReader();



        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {

        //            messegeList += "<trclass='table-row'> <td class='table-text'><h6><a href='ViewMessege.aspx?M=" + reader["Id"] + "'>" + reader["Subject"] + "</a></h6></td>";
        //            messegeList += "<td> <span class='fam'>" + reader["Status"] + "</span></td>";
        //            messegeList += "<td class='march'>" + reader["DateTime"] + "</td></tr>";

        //        }
        //        return messegeList;
        //    }
        //    return messegeList + "</tbody></table>";
        //    }

        //    catch (Exception e)
        //    {
        //        return "An error occured,please try again later";
        //    }


        //}

        public static string getsentList(string userId)
        {

            string messegeList = "<table class='table'><tbody>";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges Where [From]=@AS order by DateTime DESC", con);
                comm.Parameters.AddWithValue("AS", userId);
                SqlDataReader reader;
                reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        messegeList += "<tr class='table-row'> <td class='table-text'><h6><a href='ViewSentMessege.aspx?M=" + reader["Id"] + "'>" + reader["Subject"] + "</a></h6></td>";
                        messegeList += "<td>" + reader["Status"] + "</td>";
                        messegeList += "<td class='march'>" + reader["DateTime"] + "</td></tr>";

                    }
                    return messegeList;
                }
                return messegeList + "</tbody></table>";
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }

        public static string getManSentList(string man)
        {

            string messegeList = "<table class='table'><tbody>";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From  Messeges where [From]=@I ORDER BY DateTime DESC", con);
                comm.Parameters.AddWithValue("I", man);
                SqlDataReader reader;
                reader = comm.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        messegeList += "<trclass='table-row'> <td class='table-text'><h6><a href='ViewSentMessege.aspx?SM=" + reader["Id"] + "'>" + reader["Subject"] + "</a></h6></td>";
                        messegeList += "<td> <span class='fam'>" + reader["Status"] + "</span></td>";
                        messegeList += "<td class='march'>" + reader["DateTime"] + "</td></tr>";

                    }
                    return messegeList;
                }
                return messegeList + "</tbody></table>";
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }




        public static string viewmessege(string userId)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * from Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", userId);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m += reader["Subject"] + "<br/><br/>";
                m += reader["Body"] + "<br/><br/>";
                m += "from: " + reader["FromName"] + "<br/>" + reader["DateTime"];

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }

        public static string getreplysubject(string mid)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", mid);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m = reader["Subject"].ToString();

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }
        public static string gettoid(string mid)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", mid);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m = reader["From"].ToString();

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }
        public static string getfromid(string mid)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", mid);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m = reader["To"].ToString();

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }
        public static string gettoname(string mid)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", mid);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m = reader["FromName"].ToString();

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }
        public static string getfromname(string mid)
        {

            string m = "";

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand comm = new SqlCommand("Select * From Messeges where Id=@I", con);
                comm.Parameters.AddWithValue("I", mid);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                reader.Read();

                m = reader["ToName"].ToString();

                return m;
            }

            catch (Exception e)
            {
                return "An error occured,please try again later";
            }


        }

        public static string UpdateStatus(string status, string mid)
        {


            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Messeges SET Status=@stat where Id=@Mid", con);
                cmd.Parameters.AddWithValue("stat", status);
                cmd.Parameters.AddWithValue("Mid", mid);
                cmd.ExecuteNonQuery();
                return null;



            }
            catch (Exception e)
            {
                return "couldnt update pickup,please try again";
            }


        }



    }
}