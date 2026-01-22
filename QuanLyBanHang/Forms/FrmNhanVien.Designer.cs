namespace QuanLyBanHang.Forms
{
    partial class FrmNhanVien
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
            dgvNhanVien = new DataGridView();
            groupBox2 = new GroupBox();
            txtMatKhau = new TextBox();
            label6 = new Label();
            txtTenDangNhap = new TextBox();
            label5 = new Label();
            txtDC = new TextBox();
            label4 = new Label();
            txtQuyenHan = new TextBox();
            label3 = new Label();
            txtDT = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DiaChi, DienThoai, TenDangNhap, MatKhau, QuyenHan });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1173, 375);
            dgvNhanVien.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.Location = new Point(15, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1179, 401);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(530, 88);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(245, 27);
            txtMatKhau.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 147);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 6;
            label6.Text = "Quyền hạn:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(530, 29);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(245, 27);
            txtTenDangNhap.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 94);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 6;
            label5.Text = "Mật khẩu:";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(120, 140);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(245, 27);
            txtDC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 144);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ:";
            // 
            // txtQuyenHan
            // 
            txtQuyenHan.Location = new Point(530, 147);
            txtQuyenHan.Name = "txtQuyenHan";
            txtQuyenHan.Size = new Size(245, 27);
            txtQuyenHan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 32);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên đăng nhập:";
            // 
            // txtDT
            // 
            txtDT.Location = new Point(120, 91);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(245, 27);
            txtDT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 91);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Điện thoại:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 33);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(245, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtQuyenHan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 258);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ Và Tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.HeaderText = "Mặt Khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(756, 203);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyBo.Location = new Point(638, 203);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(507, 203);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(366, 203);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sữa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(215, 203);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(87, 203);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 690);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private GroupBox groupBox2;
        private TextBox txtMatKhau;
        private Label label6;
        private TextBox txtTenDangNhap;
        private Label label5;
        private TextBox txtDC;
        private Label label4;
        private TextBox txtQuyenHan;
        private Label label3;
        private TextBox txtDT;
        private Label label2;
        private TextBox txtHoTen;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn QuyenHan;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnThem;
    }
}