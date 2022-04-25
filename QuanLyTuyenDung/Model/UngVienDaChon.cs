using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTuyenDung
{
    class UngVienDaChon
    {
        private int IDcongViec;
        private int IDUngVien;
        private int IDnhanVien;
        public UngVienDaChon(int IDcongViec, int IDUngVien, int IDnhanVien)
        {
            this.IDcongViec1 = IDcongViec;
            this.IDnhanVien1 = IDnhanVien;
            this.IDUngVien1 = IDUngVien;

        }

        public int IDcongViec1 { get => IDcongViec; set => IDcongViec = value; }
        public int IDUngVien1 { get => IDUngVien; set => IDUngVien = value; }
        public int IDnhanVien1 { get => IDnhanVien; set => IDnhanVien = value; }

       
    }
}
