using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTuyenDung
{
    class UngVien
    {
        private int IDUngVien;
        private string Ten;
        private string GioiTinh;
        private int Tuoi;
        private string KinhNghiem;
        private string HocVan;
        private string TiengAnh;
        private string DiaChi;
        private string SDT;
        private string Email;
        private string HinhAnh;
        public UngVien(int IDUngVien,
         string Ten,
         string GioiTinh,
         int Tuoi,
         string KinhNghiem,
         string HocVan,
         string TiengAnh,
         string DiaChi,
         string SDT,
         string Email,
         string HinhAnh)
        {
        }

        public int IDUngVien1 { get => IDUngVien; set => IDUngVien = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string KinhNghiem1 { get => KinhNghiem; set => KinhNghiem = value; }
        public string HocVan1 { get => HocVan; set => HocVan = value; }
        public string TiengAnh1 { get => TiengAnh; set => TiengAnh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
