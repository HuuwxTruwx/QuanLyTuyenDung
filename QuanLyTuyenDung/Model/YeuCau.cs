using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTuyenDung
{
    class YeuCau
    {
        private int IDCongViec;
        private string KinhNgiem;
        private string HocVan;
        private string TiengAnh;
        private int SoLuong;
        private int Luong;




        private int IDPhongBan;

        public YeuCau(int IDcongViec, string KinhNgiem, string HocVan, string TiengAnh, int SoLuong, int Luong)
        {
            this.IDcongViec1 = IDcongViec;
            this.KinhNgiem1 = KinhNgiem;
            this.HocVan1 = HocVan;
            this.TiengAnh1 = TiengAnh;
            this.SoLuong1 = SoLuong;
            this.Luong1 = Luong;

        }

        public int IDcongViec1 { get => IDCongViec; set => IDCongViec = value; }
        public string KinhNgiem1 { get => KinhNgiem; set => KinhNgiem = value; }
        public string HocVan1 { get => HocVan; set => HocVan = value; }
        public string TiengAnh1 { get => TiengAnh; set => TiengAnh = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int Luong1 { get => Luong; set => Luong = value; }
    }
}
