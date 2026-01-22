namespace QuanLyBanHang.Forms
{
    partial class FrmHoaDon
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            label1 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dgvHangSanXuat = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            txtGhiChuHD = new TextBox();
            label2 = new Label();
            txtNhanVienID = new TextBox();
            label3 = new Label();
            txtKhachHangID = new TextBox();
            label4 = new Label();
            dtpNgayLapHoaDon = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLapHoaDon);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKhachHangID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNhanVienID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGhiChuHD);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Location = new Point(18, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(840, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyBo.Location = new Point(722, 150);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 5;
            label1.Text = "Ngày lập hóa đơn(*)";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(591, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(450, 150);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sữa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(171, 150);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(299, 150);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHangSanXuat);
            groupBox2.Location = new Point(18, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1179, 465);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dgvHangSanXuat
            // 
            dgvHangSanXuat.AllowUserToAddRows = false;
            dgvHangSanXuat.AllowUserToDeleteRows = false;
            dgvHangSanXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangSanXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangSanXuat.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dgvHangSanXuat.Dock = DockStyle.Fill;
            dgvHangSanXuat.Location = new Point(3, 23);
            dgvHangSanXuat.MultiSelect = false;
            dgvHangSanXuat.Name = "dgvHangSanXuat";
            dgvHangSanXuat.ReadOnly = true;
            dgvHangSanXuat.RowHeadersWidth = 51;
            dgvHangSanXuat.Size = new Size(1173, 439);
            dgvHangSanXuat.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Tên Hãng Sản Xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            // 
            // txtGhiChuHD
            // 
            txtGhiChuHD.Location = new Point(601, 33);
            txtGhiChuHD.Name = "txtGhiChuHD";
            txtGhiChuHD.Size = new Size(243, 27);
            txtGhiChuHD.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 40);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Ghi chú hóa đơn:";
            // 
            // txtNhanVienID
            // 
            txtNhanVienID.Location = new Point(171, 72);
            txtNhanVienID.Name = "txtNhanVienID";
            txtNhanVienID.Size = new Size(243, 27);
            txtNhanVienID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 75);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhân Viên ID:";
            // 
            // txtKhachHangID
            // 
            txtKhachHangID.Location = new Point(601, 72);
            txtKhachHangID.Name = "txtKhachHangID";
            txtKhachHangID.Size = new Size(243, 27);
            txtKhachHangID.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 79);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 5;
            label4.Text = "Khách Hàng";
            // 
            // dtpNgayLapHoaDon
            // 
            dtpNgayLapHoaDon.Format = DateTimePickerFormat.Custom;
            dtpNgayLapHoaDon.Location = new Point(172, 31);
            dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            dtpNgayLapHoaDon.Size = new Size(242, 27);
            dtpNgayLapHoaDon.TabIndex = 13;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 690);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvHangSanXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private Button btnThoat;
        private Button btnHuyBo;
        private Label label1;
        private Button btnXoa;
        private TextBox txtTenHangSanXuat;
        private Button btnSua;
        private Button btnThem;
        private Button btnLuu;
        private Label label4;
        private Label label3;
        private TextBox txtKhachHangID;
        private Label label2;
        private TextBox txtNhanVienID;
        private TextBox txtGhiChuHD;
        private DateTimePicker dtpNgayLapHoaDon;
    }
}