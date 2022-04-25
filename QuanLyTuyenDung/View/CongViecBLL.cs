using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class CongViecBLL
    {
        CongViecDAL dalUV;
        public CongViecBLL()
        {
            dalUV = new CongViecDAL();
        }
        public DataTable getAllCongViec()
        {
            return dalUV.getAllCongViec();
        }
        public bool insertCongViec(CongViec ungVien)
        {
            return dalUV.insertCongViec(ungVien);
        }
        public bool updateCongViec(CongViec ungVien)
        {
            return dalUV.updateCongViec(ungVien);
        }
        public bool deleteCongViec(CongViec ungVien)
        {
            return dalUV.deleteCongViec(ungVien);
        }
        public DataTable findCongViec(string keyword)
        {
            return dalUV.findCongViec(keyword);
        }
    }
}
