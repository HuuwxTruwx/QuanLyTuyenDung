using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class UngVienDaChonBLL
    {
        UngVienDaChonDAL dalUV;
        public UngVienDaChonBLL()
        {
            dalUV = new UngVienDaChonDAL();
        }
        public DataTable getAllUngVienDaChon()
        {
            return dalUV.getAllUngVienDaChon();
        }
        public bool insertUngVienDaChon(UngVienDaChon ungVien)
        {
            return dalUV.insertUngVienDaChon(ungVien);
        }
        public bool updateUngVienDaChon(UngVienDaChon ungVien)
        {
            return dalUV.updateUngVienDaChon(ungVien);
        }
        public bool deleteUngVienDaChon(UngVienDaChon ungVien)
        {
            return dalUV.deleteUngVienDaChon(ungVien);
        }
        public DataTable findUngVienDaChon(string keyword)
        {
            return dalUV.findUngVienDaChon(keyword);
        }
    }
}
