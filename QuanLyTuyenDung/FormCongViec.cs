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
    public partial class FormCongViec : Form
    {
        CongViecBLL congViecBLL;
        public FormCongViec()
        {
            InitializeComponent();
            congViecBLL = new CongViecBLL();
        }
        public bool checkData()
        {
            if (String.IsNullOrEmpty(textBoxIDCongViec.Text))
            {
                MessageBox.Show("Bạn chưa nhập Id Công Việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxIDCongViec.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxTenCongViec.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên Công Việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenCongViec.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxTenPhongBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên/Id phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenPhongBan.Focus();
                return false;
            }
            
            return true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                CongViec cv = new CongViec();
                cv.IDcongViec1 = int.Parse(textBoxIDCongViec.Text);
                cv.IDPhongBan1 = int.Parse(textBoxTenPhongBan.Text);
                cv.Ten1 = textBoxTenCongViec.Text;
                
                if (congViecBLL.insertCongViec(cv))
                {
                    showAllCongViec();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        public void showAllCongViec()
        {
            DataTable dt;
            dt = congViecBLL.getAllCongViec();
            dataGridViewCongViec.DataSource = dt;
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                CongViec cv = new CongViec();
                cv.IDcongViec1 = int.Parse(textBoxIDCongViec.Text);
                cv.IDPhongBan1 = int.Parse(textBoxTenPhongBan.Text);
                cv.Ten1 = textBoxTenCongViec.Text;
                if (congViecBLL.updateCongViec(cv))
                {
                    showAllCongViec();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá hay không!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CongViec cv = new CongViec();
                cv.IDcongViec1 = int.Parse(textBoxIDCongViec.Text);
                if (congViecBLL.deleteCongViec(cv))
                {
                    clearTextboxData();
                    showAllCongViec();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void clearTextboxData()
        {
            textBoxIDCongViec.Text = "";
            textBoxTenCongViec.Text = "";
            textBoxTenPhongBan.Text = "";
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            showAllCongViec();
        }

        private void dataGridViewCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewCongViec.RowCount)
            {
                textBoxIDCongViec.Text = dataGridViewCongViec.Rows[index].Cells["IdCongViec"].Value.ToString();
                textBoxTenPhongBan.Text = dataGridViewCongViec.Rows[index].Cells["IdPhongBan"].Value.ToString();
                textBoxTenCongViec.Text = dataGridViewCongViec.Rows[index].Cells["TenCV"].Value.ToString();
               
            }
        }
    }
}
