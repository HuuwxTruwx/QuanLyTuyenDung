using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.Controller
{
    class YeuCauDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public YeuCauDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllYeuCau()
        {
            //dc.OpenConection();
            string sql = "Select * FROM  YeuCauCongViec";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertYeuCau(YeuCau yeuCau)
        {
            string sql = "INSERT INTO YeuCau(IdCongViec,KinhNghiem,HocVan,TiengAnh,SoLuong,Luong) VALUES(@IdCongViec,@KinhNghiem,@HocVan,@TiengAnh,@SoLuong,@Luong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = yeuCau.IDcongViec1;
                cmd.Parameters.Add("@KinhNghiem", SqlDbType.NChar);
                cmd.Parameters["@KinhNghiem"].Value = yeuCau.KinhNgiem1;
                cmd.Parameters.Add("@HocVan", SqlDbType.NChar);
                cmd.Parameters["@HocVan"].Value = yeuCau.HocVan1;
                cmd.Parameters.Add("@TiengAnh", SqlDbType.NChar);
                cmd.Parameters["@TiengAnh"].Value = yeuCau.TiengAnh1;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NChar);
                cmd.Parameters["@SoLuong"].Value = yeuCau.SoLuong1;
                cmd.Parameters.Add("@Luong", SqlDbType.NChar);
                cmd.Parameters["@Luong"].Value = yeuCau.Luong1;
             

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool updateYeuCau(YeuCau yeuCau)
        {
            string sql = "UPDATE YeuCau SET KinhNghiem=@KinhNghiem,HocVan=@HocVan,TiengAnh=@TiengAnh,SoLuong=@SoLuong,Luong=@Luong WHERE IdCongViec=@IdCongViec ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = yeuCau.IDcongViec1;
                cmd.Parameters.Add("@KinhNghiem", SqlDbType.NChar);
                cmd.Parameters["@KinhNghiem"].Value = yeuCau.KinhNgiem1;
                cmd.Parameters.Add("@HocVan", SqlDbType.NChar);
                cmd.Parameters["@HocVan"].Value = yeuCau.HocVan1;
                cmd.Parameters.Add("@TiengAnh", SqlDbType.NChar);
                cmd.Parameters["@TiengAnh"].Value = yeuCau.TiengAnh1;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NChar);
                cmd.Parameters["@SoLuong"].Value = yeuCau.SoLuong1;
                cmd.Parameters.Add("@Luong", SqlDbType.NChar);
                cmd.Parameters["@Luong"].Value = yeuCau.Luong1;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool deleteYeuCau(YeuCau yeuCau)
        {
            string sql = "DELETE YeuCau  WHERE IdCongViec=@IdCongViec";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdCongViec", SqlDbType.Int);
                cmd.Parameters["@IdCongViec"].Value = yeuCau.IDcongViec1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findYeuCau(string keyword)
        {
            string sql = "SELECT * FROM  YeuCau WHERE Luong >=" + keyword;
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
