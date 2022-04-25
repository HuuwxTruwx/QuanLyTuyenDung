using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class NVTuyenDungBLL
    {
        NVTuyenDungDAL dalUV;
        public NVTuyenDungBLL()
        {
            dalUV = new NVTuyenDungDAL();
        }
        public DataTable getAllCongViec()
        {
            return dalUV.getAllNhanVienTuyenDung();
        }
        public bool insertNhanVienTuyenDung(NVTuyenDung ungVien)
        {
            return dalUV.insertNhanVienTuyenDung(ungVien);
        }
        public bool updateNhanVienTuyenDung(NVTuyenDung ungVien)
        {
            return dalUV.updateNhanVienTuyenDung(ungVien);
        }
        public bool deleteNhanVienTuyenDung(NVTuyenDung ungVien)
        {
            return dalUV.deleteNhanVienTuyenDung(ungVien);
        }
        public DataTable findNhanVienTuyenDung(string keyword)
        {
            return dalUV.findNhanVienTuyenDung(keyword);
        }
    }
}
