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
    class CongViecDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CongViecDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllCongViec()
        {
            //dc.OpenConection();
            string sql = "select * from  CongViec";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertCongViec(CongViec congViec)
        {
            string sql = "INSERT INTO CongViec(IdCongViec,TenCV,IdPhongBan) VALUES(@IdCongViec,@TenCV,@IdPhongBan)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = congViec.IDcongViec1;
                cmd.Parameters.Add("@TenCV", SqlDbType.NChar);
                cmd.Parameters["@TenCV"].Value = congViec.Ten1;
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = congViec.IDPhongBan1;
               

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
                return false;
            }

            return true;
        }
        public bool updateCongViec(CongViec congViec)
        {
            string sql = "UPDATE CongViec SET TenCV=@TenCV,IdPhongBan=@IdPhongBan WHERE IdCongViec=@IdCongViec";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = congViec.IDcongViec1;
                cmd.Parameters.Add("@TenCV", SqlDbType.NChar);
                cmd.Parameters["@TenCV"].Value = congViec.Ten1;
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = congViec.IDPhongBan1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return false;
            }

            return true;
        }
        public bool deleteCongViec(CongViec congViec)
        {
            string sql = "DELETE CongViec  WHERE IdCongViec=@IdCongViec";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = congViec.IDcongViec1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findCongViec(string keyword)
        {
            string sql = "SELECT * FROM  CongViec WHERE TenCV like '%" + keyword + "%'";
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
