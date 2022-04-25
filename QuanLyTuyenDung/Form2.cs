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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pnlNav.Height = buttonTongQuan.Height;
            pnlNav.Top = buttonTongQuan.Top;
            pnlNav.Left = buttonTongQuan.Left;
            openChildFormInPanel(new FromTongQuan());
        }
       
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonTongQuan.Height;
            pnlNav.Top = buttonTongQuan.Top;
            pnlNav.Left = buttonTongQuan.Left;
            openChildFormInPanel(new FromTongQuan());
        }

        private void buttonUngVien_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonUngVien.Height;
            pnlNav.Top = buttonUngVien.Top;
            pnlNav.Left = buttonUngVien.Left;
            openChildFormInPanel(new FormTest());
        }

        private void buttonCongViec_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonCongViec.Height;
            pnlNav.Top = buttonCongViec.Top;
            pnlNav.Left = buttonCongViec.Left;
            openChildFormInPanel(new FormCongViec());
        }

        private void buttonTuyenDung_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonTuyenDung.Height;
            pnlNav.Top = buttonTuyenDung.Top;
            pnlNav.Left = buttonTuyenDung.Left;
            openChildFormInPanel(new FormBPTuyenDung());
        }

        private void buttonTongQuan_Leave(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
