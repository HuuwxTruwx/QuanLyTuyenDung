namespace QuanLyTuyenDung
{
    partial class FormCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCongViec));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewCongViec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDCongViec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenCongViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenPhongBan = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewCongViec
            // 
            this.dataGridViewCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCongViec.Location = new System.Drawing.Point(67, 149);
            this.dataGridViewCongViec.Name = "dataGridViewCongViec";
            this.dataGridViewCongViec.RowTemplate.Height = 25;
            this.dataGridViewCongViec.Size = new System.Drawing.Size(720, 230);
            this.dataGridViewCongViec.TabIndex = 1;
            this.dataGridViewCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCongViec_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // textBoxIDCongViec
            // 
            this.textBoxIDCongViec.Location = new System.Drawing.Point(49, 6);
            this.textBoxIDCongViec.Name = "textBoxIDCongViec";
            this.textBoxIDCongViec.Size = new System.Drawing.Size(100, 23);
            this.textBoxIDCongViec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Công Việc";
            // 
            // textBoxTenCongViec
            // 
            this.textBoxTenCongViec.Location = new System.Drawing.Point(262, 8);
            this.textBoxTenCongViec.Name = "textBoxTenCongViec";
            this.textBoxTenCongViec.Size = new System.Drawing.Size(100, 23);
            this.textBoxTenCongViec.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Phòng Ban";
            // 
            // textBoxTenPhongBan
            // 
            this.textBoxTenPhongBan.Location = new System.Drawing.Point(495, 8);
            this.textBoxTenPhongBan.Name = "textBoxTenPhongBan";
            this.textBoxTenPhongBan.Size = new System.Drawing.Size(100, 23);
            this.textBoxTenPhongBan.TabIndex = 7;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(37, 96);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 8;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(160, 96);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 9;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(271, 96);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(602, 96);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(698, 96);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(100, 23);
            this.textBoxFind.TabIndex = 12;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // FormCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 526);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxTenPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTenCongViec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDCongViec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCongViec);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCongViec";
            this.Text = "FormCongViec";
            this.Load += new System.EventHandler(this.FormCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewCongViec;
        private Label label1;
        private TextBox textBoxIDCongViec;
        private Label label2;
        private TextBox textBoxTenCongViec;
        private Label label3;
        private TextBox textBoxTenPhongBan;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonFind;
        private TextBox textBoxFind;
    }
}