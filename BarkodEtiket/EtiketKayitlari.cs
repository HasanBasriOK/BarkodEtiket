using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace BarkodEtiket
{
    public class EtiketKayitlari
    {
        
        public int DataID { get; set; }
        public string Alan1 { get; set; }
        public string Alan2 { get; set; }
        public string Alan3 { get; set; }
        public string Alan4 { get; set; }
        public string Alan5 { get; set; }
        public string Alan6 { get; set; }
        public string Alan7 { get; set; }
        public string Alan8 { get; set; }
        public string Alan9 { get; set; }
        public string Alan10 { get; set; }
        public string Barkod { get; set; }
        public string SonBarkod { get; set; }

        public List<EtiketKayitlari> GetObjects()
        {
            List<EtiketKayitlari> items = new List<EtiketKayitlari>();
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string commandString = "Select * From Kayitlar";

            using (SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd=new SqlCommand(commandString,con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EtiketKayitlari item = new EtiketKayitlari();
                        item.Alan1 = string.IsNullOrEmpty(dr["Alan1"].ToString()) ? string.Empty : dr["Alan1"].ToString();
                        item.Alan2 = string.IsNullOrEmpty(dr["Alan2"].ToString()) ? string.Empty : dr["Alan2"].ToString();
                        item.Alan3 = string.IsNullOrEmpty(dr["Alan3"].ToString()) ? string.Empty : dr["Alan3"].ToString();
                        item.Alan4 = string.IsNullOrEmpty(dr["Alan4"].ToString()) ? string.Empty : dr["Alan4"].ToString();
                        item.Alan5 = string.IsNullOrEmpty(dr["Alan5"].ToString()) ? string.Empty : dr["Alan5"].ToString();
                        item.Alan6 = string.IsNullOrEmpty(dr["Alan6"].ToString()) ? string.Empty : dr["Alan6"].ToString();
                        item.Alan7 = string.IsNullOrEmpty(dr["Alan7"].ToString()) ? string.Empty : dr["Alan7"].ToString();
                        item.Alan8 = string.IsNullOrEmpty(dr["Alan8"].ToString()) ? string.Empty : dr["Alan8"].ToString();
                        item.Alan9 = string.IsNullOrEmpty(dr["Alan9"].ToString()) ? string.Empty : dr["Alan9"].ToString();
                        item.Alan10 = string.IsNullOrEmpty(dr["Alan10"].ToString()) ? string.Empty : dr["Alan10"].ToString();
                        item.DataID = (int)dr["DataID"];

                        items.Add(item);
                    }
                }
            }
            return items;
        }
        public void Insert(EtiketKayitlari data)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string commandString = "INSERT INTO Kayitlar(Alan1,Alan2,Alan3,Alan4,Alan5,Alan6,Alan7,Alan8,Alan9,Alan10) VALUES (@Alan1,@Alan2,@Alan3,@Alan4,@Alan5,@Alan6,@Alan7,@Alan8,@Alan9,@Alan10)";

            using (SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd=new SqlCommand(commandString,con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Alan1", data.Alan1);
                    cmd.Parameters.AddWithValue("@Alan2", data.Alan2);
                    cmd.Parameters.AddWithValue("@Alan3", data.Alan3);
                    cmd.Parameters.AddWithValue("@Alan4", data.Alan4);
                    cmd.Parameters.AddWithValue("@Alan5", data.Alan5);
                    cmd.Parameters.AddWithValue("@Alan6", data.Alan6);
                    cmd.Parameters.AddWithValue("@Alan7", data.Alan7);
                    cmd.Parameters.AddWithValue("@Alan8", data.Alan8);
                    cmd.Parameters.AddWithValue("@Alan9", data.Alan9);
                    cmd.Parameters.AddWithValue("@Alan10", data.Alan10);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(EtiketKayitlari data)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string commandString = "UPDATE Kayitlar SET Alan1=@Alan1,Alan2=@Alan2,Alan3=@Alan3,Alan4=@Alan4,Alan5=@Alan5,Alan6=@Alan6,Alan7=@Alan7,Alan8=@Alan8,Alan9=@Alan9,Alan10=@Alan10 WHERE DataID=@DataID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(commandString, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Alan1", data.Alan1);
                    cmd.Parameters.AddWithValue("@Alan2", data.Alan2);
                    cmd.Parameters.AddWithValue("@Alan3", data.Alan3);
                    cmd.Parameters.AddWithValue("@Alan4", data.Alan4);
                    cmd.Parameters.AddWithValue("@Alan5", data.Alan5);
                    cmd.Parameters.AddWithValue("@Alan6", data.Alan6);
                    cmd.Parameters.AddWithValue("@Alan7", data.Alan7);
                    cmd.Parameters.AddWithValue("@Alan8", data.Alan8);
                    cmd.Parameters.AddWithValue("@Alan9", data.Alan9);
                    cmd.Parameters.AddWithValue("@Alan10", data.Alan10);
                    cmd.Parameters.AddWithValue("@DataID", data.DataID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string commandString = "Delete From Kayitlar Where DataID=@DataID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(commandString, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@DataID", id);
                    cmd.ExecuteNonQuery();
                }
            }
    
        }
        
    }
}
