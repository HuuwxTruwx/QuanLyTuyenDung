using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.Controller
{
    class UngVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public UngVienDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllUngVien()
        {
            //dc.OpenConection();
            string sql = "select * from  ungvien";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertUngVien(UngVien ungVien)
        {
            string sql = "INSERT INTO UngVien(IdUngVien,Ten,Tuoi,GioiTinh,KinhNghiem,HocVan,TiengAnh,DiaChi,SDT,Email) VALUES(@IdUngVien,@Ten,@Tuoi,@GioiTinh,@KinhNghiem,@HocVan,@TiengAnh,@DiaChi,@SDT,@Email)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVien.IDUngVien1;
                cmd.Parameters.Add("@Ten", SqlDbType.NChar);
                cmd.Parameters["@Ten"].Value = ungVien.Ten1;
                cmd.Parameters.Add("@Tuoi", SqlDbType.Int);
                cmd.Parameters["@Tuoi"].Value = ungVien.Tuoi1;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar);
                cmd.Parameters["@Gioitinh"].Value = ungVien.GioiTinh1;
                //cmd.Parameters.Add("@HinhAnh", SqlDbType.Image);
                //cmd.Parameters["@HinhAnh"].Value = null;
                cmd.Parameters.Add("@KinhNghiem", SqlDbType.NChar);
                cmd.Parameters["@KinhNghiem"].Value = ungVien.KinhNghiem1;
                cmd.Parameters.Add("@HocVan", SqlDbType.NChar);
                cmd.Parameters["@HocVan"].Value = ungVien.HocVan1;
                cmd.Parameters.Add("@TiengAnh", SqlDbType.NChar);
                cmd.Parameters["@TiengAnh"].Value = ungVien.TiengAnh1;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar);
                cmd.Parameters["@DiaChi"].Value = ungVien.DiaChi1;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar);
                cmd.Parameters["@SDT"].Value = ungVien.SDT1;
                cmd.Parameters.Add("@Email", SqlDbType.NChar);
                cmd.Parameters["@Email"].Value = ungVien.Email1;

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool updateUngVien(UngVien ungVien)
        {


            string sql = "UPDATE UngVien SET Ten=@Ten,Tuoi=@Tuoi,GioiTinh=@GioiTinh,KinhNghiem=@KinhNghiem,HocVan=@HocVan,TiengAnh=@TiengAnh,DiaChi=@DiaChi,SDT=@SDT,Email=@Email WHERE IdUngVien=@IdUngVien ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVien.IDUngVien1;
                cmd.Parameters.Add("@Ten", SqlDbType.NChar);
                cmd.Parameters["@Ten"].Value = ungVien.Ten1;
                cmd.Parameters.Add("@Tuoi", SqlDbType.Int);
                cmd.Parameters["@Tuoi"].Value = ungVien.Tuoi1;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NChar);
                cmd.Parameters["@GioiTinh"].Value = ungVien.GioiTinh1;
                //cmd.Parameters.Add("@HinhAnh", SqlDbType.Image);
                //cmd.Parameters["@HinhAnh"].Value = null;
                cmd.Parameters.Add("@KinhNghiem", SqlDbType.NChar);
                cmd.Parameters["@KinhNghiem"].Value = ungVien.KinhNghiem1;
                cmd.Parameters.Add("@HocVan", SqlDbType.NChar);
                cmd.Parameters["@HocVan"].Value = ungVien.HocVan1;
                cmd.Parameters.Add("@TiengAnh", SqlDbType.NChar);
                cmd.Parameters["@TiengAnh"].Value = ungVien.TiengAnh1;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar);
                cmd.Parameters["@DiaChi"].Value = ungVien.DiaChi1;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar);
                cmd.Parameters["@SDT"].Value = ungVien.SDT1;
                cmd.Parameters.Add("@Email", SqlDbType.NChar);
                cmd.Parameters["@Email"].Value = ungVien.Email1;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool deleteUngvien(UngVien ungVien)
        {
            string sql = "DELETE UngVien  WHERE IdUngVien=@IdUngVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IdUngVien", SqlDbType.Int);
                cmd.Parameters["@IdUngVien"].Value = ungVien.IDUngVien1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public DataTable findUngVien(string keyword)
        {
            string sql = "SELECT * FROM  UngVien WHERE Ten like '%"+ keyword+"%'";
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
