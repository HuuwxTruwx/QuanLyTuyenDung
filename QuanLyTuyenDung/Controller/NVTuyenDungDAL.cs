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
    class NVTuyenDungDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NVTuyenDungDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNhanVienTuyenDung()
        {
            //dc.OpenConection();
            string sql = "select * from  NhanVienTuyenDung";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertNhanVienTuyenDung(NVTuyenDung nVTuyenDung)
        {
            string sql = "INSERT INTO NhanVienTuyenDung(IdNhanVien,TenNhanVien,IdPhongBan) VALUES(@IdNhanVien,@TenNhanVien,@IdPhongBan)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Int);
                cmd.Parameters["@IdNhanVien"].Value = nVTuyenDung.IDNhanVien1;
                cmd.Parameters.Add("@TenNhanVien", SqlDbType.NChar);
                cmd.Parameters["@TenNhanVien"].Value = nVTuyenDung.TenNhanVien1;
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = nVTuyenDung.IDPhongBan1;


                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
                return false;
            }

            return true;
        }
        public bool updateNhanVienTuyenDung(NVTuyenDung nVTuyenDung)
        {
            string sql = "UPDATE NhanVienTuyenDung SET TenNhanVien=@TenNhanVien,IdPhongBan=@IdPhongBan WHERE IdNhanVien=@IdNhanVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Int);
                cmd.Parameters["@IdNhanVien"].Value = nVTuyenDung.IDNhanVien1;
                cmd.Parameters.Add("@TenNhanVien", SqlDbType.NChar);
                cmd.Parameters["@TenNhanVien"].Value = nVTuyenDung.TenNhanVien1;
                cmd.Parameters.Add("@IdPhongBan", SqlDbType.Int);
                cmd.Parameters["@IdPhongBan"].Value = nVTuyenDung.IDPhongBan1;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return false;
            }

            return true;
        }
        public bool deleteNhanVienTuyenDung(NVTuyenDung nVTuyenDung)
        {
            string sql = "DELETE NhanVienTuyenDung  WHERE IdNhanVien=@IdNhanVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Int);
                cmd.Parameters["@IdNhanVien"].Value = nVTuyenDung.IDNhanVien1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findNhanVienTuyenDung(string keyword)
        {
            string sql = "SELECT * FROM  NhanVienTuyenDung WHERE TenNhanVien like '%" + keyword + "%'";
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
