using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class PhongBanBLL
    {
        PhongBanDAL dalUV;
        public PhongBanBLL()
        {
            dalUV = new PhongBanDAL();
        }
        public DataTable getAllPhongBan()
        {
            return dalUV.getAllPhongBan();
        }
        public bool insertPhongBan(PhongBan ungVien)
        {
            return dalUV.insertPhongBan(ungVien);
        }
        public bool updatePhongBan(PhongBan ungVien)
        {
            return dalUV.updatePhongBan(ungVien);
        }
        public bool deletePhongBan(PhongBan ungVien)
        {
            return dalUV.deletePhongBan(ungVien);
        }
        public DataTable findPhongBan(string keyword)
        {
            return dalUV.findPhongBan(keyword);
        }
    }
}
