using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace EasyToken.Classes
{
    public class Request
    {
        public static string Req(string userid, string cusname,string hospital,string hospitalid,string notes,string appoi,string medication)
        {
            //try
            //{
                string cs = ConfigurationManager.ConnectionStrings["ETDBConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tokens (UserID,Cusname,Hospital,OwnerID,CreationDate,DoctorNotes,NextAppointment,Medication, Status) values('" + userid + "','" + cusname + "','" + hospital + "','" + hospitalid + "','" + DateTime.Now + "','" + notes + "','" + appoi + "','" + medication + "',1)", con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                cmd.Dispose();
                return null;
            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
        }

      




    }
}