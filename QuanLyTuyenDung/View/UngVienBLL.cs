using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class UngVienBLL
    {
        UngVienDAL dalUV;
        public UngVienBLL()
        {
            dalUV = new UngVienDAL();
        }
        public DataTable getAllUngVien()
        {
            return dalUV.getAllUngVien();
        }
        public bool insertUngVien(UngVien ungVien)
        {
            return dalUV.insertUngVien(ungVien);
        }
        public bool updateUngVien(UngVien ungVien)
        {
            return dalUV.updateUngVien(ungVien);
        }
        public bool deleteUngVien(UngVien ungVien)
        {
            return dalUV.deleteUngvien(ungVien);
        }
        public DataTable findUngVien(string keyword)
        {
            return dalUV.findUngVien(keyword);
        }
    }
}
