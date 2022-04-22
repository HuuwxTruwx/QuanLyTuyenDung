using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTuyenDung
{
    class CongViec
    {
        private int IDcongViec;
        private string Ten;
        private int IDPhongBan;

        public CongViec(int IDcongViec, string Ten, int IDPhongBan)
        {
            this.IDcongViec1 = IDcongViec;
            this.Ten1 = Ten;
            this.IDPhongBan1 = IDPhongBan;

        }

        public int IDcongViec1 { get => IDcongViec; set => IDcongViec = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int IDPhongBan1 { get => IDPhongBan; set => IDPhongBan = value; }
    }
}
