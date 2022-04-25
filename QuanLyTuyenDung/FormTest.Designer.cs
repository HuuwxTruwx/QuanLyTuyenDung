
namespace QuanLyTuyenDung
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mdataGridView = new System.Windows.Forms.DataGridView();
            this.IdUngVien = new System.Windows.Forms.Label();
            this.textBoxIdUngVien = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.Tuoi = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxKinhNghiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHocVan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHinhAnh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTiengAnh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mdataGridView
            // 
            this.mdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdataGridView.Location = new System.Drawing.Point(12, 200);
            this.mdataGridView.Name = "mdataGridView";
            this.mdataGridView.RowTemplate.Height = 25;
            this.mdataGridView.Size = new System.Drawing.Size(776, 155);
            this.mdataGridView.TabIndex = 0;
            this.mdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdataGridView_CellClick);
            // 
            // IdUngVien
            // 
            this.IdUngVien.AutoSize = true;
            this.IdUngVien.Location = new System.Drawing.Point(12, 9);
            this.IdUngVien.Name = "IdUngVien";
            this.IdUngVien.Size = new System.Drawing.Size(18, 15);
            this.IdUngVien.TabIndex = 1;
            this.IdUngVien.Text = "ID";
            // 
            // textBoxIdUngVien
            // 
            this.textBoxIdUngVien.Location = new System.Drawing.Point(56, 6);
            this.textBoxIdUngVien.Name = "textBoxIdUngVien";
            this.textBoxIdUngVien.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdUngVien.TabIndex = 2;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(12, 135);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(378, 6);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(100, 23);
            this.textBoxTuoi.TabIndex = 6;
            // 
            // Tuoi
            // 
            this.Tuoi.AutoSize = true;
            this.Tuoi.Location = new System.Drawing.Point(334, 12);
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Size = new System.Drawing.Size(30, 15);
            this.Tuoi.TabIndex = 5;
            this.Tuoi.Text = "Tuoi";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(206, 6);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(100, 23);
            this.textBoxTen.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(162, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 15);
            this.label.TabIndex = 7;
            this.label.Text = "Ten";
            // 
            // textBoxKinhNghiem
            // 
            this.textBoxKinhNghiem.Location = new System.Drawing.Point(27, 66);
            this.textBoxKinhNghiem.Name = "textBoxKinhNghiem";
            this.textBoxKinhNghiem.Size = new System.Drawing.Size(100, 23);
            this.textBoxKinhNghiem.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kinh Nghiệm";
            // 
            // textBoxHocVan
            // 
            this.textBoxHocVan.Location = new System.Drawing.Point(206, 66);
            this.textBoxHocVan.Name = "textBoxHocVan";
            this.textBoxHocVan.Size = new System.Drawing.Size(100, 23);
            this.textBoxHocVan.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Học vấn";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(378, 69);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(100, 23);
            this.textBoxSDT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "SĐT";
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Location = new System.Drawing.Point(542, 9);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(100, 23);
            this.textBoxGioiTinh.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giới tính";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(526, 66);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // textBoxHinhAnh
            // 
            this.textBoxHinhAnh.Location = new System.Drawing.Point(705, 12);
            this.textBoxHinhAnh.Name = "textBoxHinhAnh";
            this.textBoxHinhAnh.Size = new System.Drawing.Size(100, 23);
            this.textBoxHinhAnh.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hình Ảnh";
            // 
            // textBoxTiengAnh
            // 
            this.textBoxTiengAnh.Location = new System.Drawing.Point(705, 69);
            this.textBoxTiengAnh.Name = "textBoxTiengAnh";
            this.textBoxTiengAnh.Size = new System.Drawing.Size(100, 23);
            this.textBoxTiengAnh.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tiếng Anh";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(240, 135);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 23;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(125, 135);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 24;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Địa chỉ";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(383, 118);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(100, 23);
            this.textBoxDiaChi.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm Kiếm";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(599, 144);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(124, 23);
            this.textBoxTimKiem.TabIndex = 28;
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.textBoxTiengAnh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxHinhAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGioiTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHocVan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKinhNghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxTuoi);
            this.Controls.Add(this.Tuoi);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxIdUngVien);
            this.Controls.Add(this.IdUngVien);
            this.Controls.Add(this.mdataGridView);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView mdataGridView;
        private Label IdUngVien;
        private TextBox textBoxIdUngVien;
        private Button buttonThem;
        private TextBox textBoxTuoi;
        private Label Tuoi;
        private TextBox textBoxTen;
        private Label label;
        private TextBox textBoxKinhNghiem;
        private Label label4;
        private TextBox textBoxHocVan;
        private Label label5;
        private TextBox textBoxSDT;
        private Label label6;
        private TextBox textBoxGioiTinh;
        private Label label7;
        private TextBox textBoxEmail;
        private Label label8;
        private TextBox textBoxHinhAnh;
        private Label label9;
        private TextBox textBoxTiengAnh;
        private Label label10;
        private Button buttonXoa;
        private Button buttonSua;
        private Label label1;
        private TextBox textBoxDiaChi;
        private Label label2;
        private TextBox textBoxTimKiem;
    }
}