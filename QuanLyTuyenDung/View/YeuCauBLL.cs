using QuanLyTuyenDung.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenDung.View
{
    class YeuCauBLL
    {
        YeuCauDAL dalUV;
        public YeuCauBLL()
        {
            dalUV = new YeuCauDAL();
        }
        public DataTable getAllUngVien()
        {
            return dalUV.getAllYeuCau();
        }
        public bool insertUngVien(YeuCau ungVien)
        {
            return dalUV.insertYeuCau(ungVien);
        }
        public bool updateUngVien(YeuCau ungVien)
        {
            return dalUV.updateYeuCau(ungVien);
        }
        public bool deleteUngVien(YeuCau ungVien)
        {
            return dalUV.deleteYeuCau(ungVien);
        }
        public DataTable findUngVien(string keyword)
        {
            return dalUV.findYeuCau(keyword);
        }
    }
}
