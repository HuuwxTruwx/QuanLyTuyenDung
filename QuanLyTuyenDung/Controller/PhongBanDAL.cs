using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.Controller
{
    class PhongBanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhongBanDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllPhongBan()
        {
            //dc.OpenConection();
            string sql = "select * from  PhongBan";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertPhongBan(PhongBan phongBan)
        {
            string sql = "INSERT INTO PhongBan(IdPhongBan,TenPhongBan) VALUES(@IdPhongBan,@TenPhongBan)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = phongBan.IDPhongBan1;
                cmd.Parameters.Add("@TenPhongBan", SqlDbType.NChar);
                cmd.Parameters["@TenPhongBan"].Value = phongBan.Ten1;


                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
                return false;
            }

            return true;
        }
        public bool updatePhongBan(PhongBan phongBan)
        {
            string sql = "UPDATE PhongBan SET TenPhongBan=@TenPhongBan WHERE IdPhongBan=@IdPhongBan";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = phongBan.IDPhongBan1;
                cmd.Parameters.Add("@TenPhongBan", SqlDbType.NChar);
                cmd.Parameters["@TenPhongBan"].Value = phongBan.Ten1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return false;
            }

            return true;
        }
        public bool deletePhongBan(PhongBan phongBan)
        {
            string sql = "DELETE PhongBan  WHERE IdPhongBan=@IdPhongBan";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = phongBan.IDPhongBan1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findPhongBan(string keyword)
        {
            string sql = "SELECT * FROM  PhongBan WHERE TenPhongBan like '%" + keyword + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
