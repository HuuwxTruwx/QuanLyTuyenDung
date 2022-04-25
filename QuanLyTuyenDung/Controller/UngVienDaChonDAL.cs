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
    class UngVienDaChonDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public UngVienDaChonDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllUngVienDaChon()
        {
            //dc.OpenConection();
            string sql = "select * from  UngVienDaChon";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertUngVienDaChon(UngVienDaChon ungVienDaChon)
        {
            string sql = "INSERT INTO UngVienDaChon(IdCongViec,IdNhanVien,IdUngVien) VALUES(@IdCongViec,@IdNhanVien,@IdUngVien)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = ungVienDaChon.IDcongViec1;
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Int);
                cmd.Parameters["@IdNhanVien"].Value = ungVienDaChon.IDnhanVien1;
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVienDaChon.IDUngVien1;



                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
                return false;
            }

            return true;
        }
        public bool updateUngVienDaChon(UngVienDaChon ungVienDaChon)
        {
            string sql = "UPDATE UngVienDaChon SET IdCongViec=@IdCongViec,IdNhanVien=@IdNhanVien WHERE IdUngVien=@IdUngVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = ungVienDaChon.IDcongViec1;
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Int);
                cmd.Parameters["@IdNhanVien"].Value = ungVienDaChon.IDnhanVien1;
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVienDaChon.IDUngVien1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return false;
            }

            return true;
        }
        public bool deleteUngVienDaChon(UngVienDaChon ungVienDaChon)
        {
            string sql = "DELETE UngVienDaChon  WHERE IdUngVien=@IdUngVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVienDaChon.IDUngVien1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findUngVienDaChon(string keyword)
        {
            string sql = "SELECT * FROM  UngVienDaChon WHERE TenCV like '%" + keyword + "%'";
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
