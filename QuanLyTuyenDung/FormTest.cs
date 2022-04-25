using QuanLyTuyenDung.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenDung
{
    public partial class FormTest : Form
    {
        UngVienBLL ungVienBLL;
        public FormTest()
        {
            InitializeComponent();
            ungVienBLL = new UngVienBLL();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            showAllUngVien();


        }
        public void showAllUngVien()
        {
            DataTable dt;
            dt= ungVienBLL.getAllUngVien();
            mdataGridView.DataSource = dt;
        }
        public bool checkData()
        {
            if (String.IsNullOrEmpty(textBoxIdUngVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập Id Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxIdUngVien.Focus();
                return false;
             }
            if (String.IsNullOrEmpty(textBoxTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTen.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxTuoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập tuổi Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTuoi.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxGioiTinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập gới tính Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxGioiTinh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxHinhAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập hình ảnh Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (String.IsNullOrEmpty(textBoxHinhAnh.Text))
                    textBoxHinhAnh.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxKinhNghiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập kinh nghiệm Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxKinhNghiem.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxHocVan.Text))
            {
                MessageBox.Show("Bạn chưa nhập học vấn Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHocVan.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập sđt Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxEmail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxTiengAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiếng anh Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTiengAnh.Focus();
                return false;
            }
            return true;
        }
       private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                UngVien uv = new UngVien();
                uv.IDUngVien1 = int.Parse(textBoxIdUngVien.Text);
                uv.KinhNghiem1 = textBoxKinhNghiem.Text;
                uv.HocVan1 = textBoxHocVan.Text;
                uv.Tuoi1 = int.Parse(textBoxTuoi.Text);
                uv.TiengAnh1 = textBoxTiengAnh.Text;
                uv.HinhAnh = textBoxHinhAnh.Text;
                uv.GioiTinh1 = textBoxGioiTinh.Text;
                uv.SDT1 = textBoxSDT.Text;
                uv.Email1 = textBoxEmail.Text;
                uv.Ten1 = textBoxTen.Text;
                uv.DiaChi1 = textBoxDiaChi.Text;
                if (ungVienBLL.insertUngVien(uv)){
                    showAllUngVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                UngVien uv = new UngVien();
                uv.IDUngVien1 = int.Parse(textBoxIdUngVien.Text);
                uv.KinhNghiem1 = textBoxKinhNghiem.Text;
                uv.HocVan1 = textBoxHocVan.Text;
                uv.Tuoi1 = int.Parse(textBoxTuoi.Text);
                uv.TiengAnh1 = textBoxTiengAnh.Text;
                uv.HinhAnh = textBoxHinhAnh.Text;
                uv.GioiTinh1 = textBoxGioiTinh.Text;
                uv.SDT1 = textBoxSDT.Text;
                uv.Email1 = textBoxEmail.Text;
                uv.Ten1 = textBoxTen.Text;
                uv.DiaChi1 = textBoxDiaChi.Text;
                if (ungVienBLL.updateUngVien(uv))
                {
                    showAllUngVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá hay không!","Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                UngVien uv = new UngVien();
                uv.IDUngVien1 = int.Parse(textBoxIdUngVien.Text);
                if (ungVienBLL.deleteUngVien(uv))
                {
                    clearTextboxData();
                    showAllUngVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
         }

        private void clearTextboxData()
        {
                textBoxDiaChi.Text = "";
                textBoxEmail.Text = "";
                textBoxSDT.Text = "";
                textBoxKinhNghiem.Text = "";
                textBoxTiengAnh.Text = "";
                textBoxTen.Text = "";
                textBoxHocVan.Text = "";
                textBoxGioiTinh.Text = "";
                textBoxHinhAnh.Text = "";
                textBoxTuoi.Text = "";
                textBoxIdUngVien.Text = "";
        }

        private void mdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < mdataGridView.RowCount)
            {
                textBoxDiaChi.Text = mdataGridView.Rows[index].Cells["DiaChi"].Value.ToString();
                textBoxEmail.Text = mdataGridView.Rows[index].Cells["Email"].Value.ToString();
                textBoxSDT.Text = mdataGridView.Rows[index].Cells["SDT"].Value.ToString();
                textBoxKinhNghiem.Text = mdataGridView.Rows[index].Cells["KinhNghiem"].Value.ToString();
                textBoxTiengAnh.Text = mdataGridView.Rows[index].Cells["TiengAnh"].Value.ToString();
                textBoxTen.Text = mdataGridView.Rows[index].Cells["Ten"].Value.ToString();
                textBoxHocVan.Text = mdataGridView.Rows[index].Cells["HocVan"].Value.ToString();
                textBoxGioiTinh.Text = mdataGridView.Rows[index].Cells["GioiTinh"].Value.ToString();
                textBoxHinhAnh.Text = "";
                textBoxTuoi.Text =mdataGridView.Rows[index].Cells["Tuoi"].Value.ToString();
                textBoxIdUngVien.Text = mdataGridView.Rows[index].Cells["IdUngVien"].Value.ToString();
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimKiem.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                DataTable dt = ungVienBLL.findUngVien(keyword);
                mdataGridView.DataSource = dt;
            }
            else
                showAllUngVien();
           
        }
    }
}
