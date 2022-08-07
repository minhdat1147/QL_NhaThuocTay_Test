
namespace QL_NhaThuocTay
{
    partial class frmBanHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TG = new System.Windows.Forms.Label();
            this.cboTenThuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTenLoai = new System.Windows.Forms.ComboBox();
            this.lOAITHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhaThuocTayDataSet1 = new QL_NhaThuocTay.QL_NhaThuocTayDataSet1();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qL_NhaThuocTayDataSet = new QL_NhaThuocTay.QL_NhaThuocTayDataSet();
            this.qLNhaThuocTayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAITHUOCTableAdapter = new QL_NhaThuocTay.QL_NhaThuocTayDataSet1TableAdapters.LOAITHUOCTableAdapter();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocTayDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTienKhachDua);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTienThua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TG);
            this.groupBox1.Controls.Add(this.cboTenThuoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnTaoHD);
            this.groupBox1.Controls.Add(this.txtMaCTHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboTenLoai);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(945, 144);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(487, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 101;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 100;
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(250, 88);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(60, 13);
            this.TG.TabIndex = 98;
            this.TG.Text = "Đơn vị tính";
            // 
            // cboTenThuoc
            // 
            this.cboTenThuoc.DisplayMember = "TENDU";
            this.cboTenThuoc.FormattingEnabled = true;
            this.cboTenThuoc.Location = new System.Drawing.Point(333, 20);
            this.cboTenThuoc.Name = "cboTenThuoc";
            this.cboTenThuoc.Size = new System.Drawing.Size(224, 21);
            this.cboTenThuoc.TabIndex = 97;
            this.cboTenThuoc.ValueMember = "DONGIA";
            this.cboTenThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tên thuốc";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(408, 110);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 29);
            this.btnThoat.TabIndex = 95;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(322, 110);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 29);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(232, 110);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 29);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(130, 110);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 29);
            this.btnThem.TabIndex = 92;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTaoHD.Location = new System.Drawing.Point(194, 23);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(31, 23);
            this.btnTaoHD.TabIndex = 91;
            this.btnTaoHD.Text = "+";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(95, 24);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(97, 20);
            this.txtMaCTHD.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Mã HD";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(333, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 88;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(746, 51);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(186, 20);
            this.txtTT.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Thành tiền";
            // 
            // cboTenLoai
            // 
            this.cboTenLoai.DataSource = this.lOAITHUOCBindingSource;
            this.cboTenLoai.DisplayMember = "TENLOAI";
            this.cboTenLoai.FormattingEnabled = true;
            this.cboTenLoai.Location = new System.Drawing.Point(95, 57);
            this.cboTenLoai.Name = "cboTenLoai";
            this.cboTenLoai.Size = new System.Drawing.Size(130, 21);
            this.cboTenLoai.TabIndex = 85;
            this.cboTenLoai.ValueMember = "MALOAI";
            this.cboTenLoai.SelectedIndexChanged += new System.EventHandler(this.cboTen_SelectedIndexChanged);
            // 
            // lOAITHUOCBindingSource
            // 
            this.lOAITHUOCBindingSource.DataMember = "LOAITHUOC";
            this.lOAITHUOCBindingSource.DataSource = this.qL_NhaThuocTayDataSet1;
            // 
            // qL_NhaThuocTayDataSet1
            // 
            this.qL_NhaThuocTayDataSet1.DataSetName = "QL_NhaThuocTayDataSet1";
            this.qL_NhaThuocTayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(746, 18);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(186, 20);
            this.txtGia.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tên loại";
            // 
            // dgvBH
            // 
            this.dgvBH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBH.Location = new System.Drawing.Point(15, 17);
            this.dgvBH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBH.Name = "dgvBH";
            this.dgvBH.RowHeadersWidth = 51;
            this.dgvBH.Size = new System.Drawing.Size(917, 220);
            this.dgvBH.TabIndex = 93;
            this.dgvBH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBH_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBH);
            this.groupBox2.Location = new System.Drawing.Point(9, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(945, 241);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // qL_NhaThuocTayDataSet
            // 
            this.qL_NhaThuocTayDataSet.DataSetName = "QL_NhaThuocTayDataSet";
            this.qL_NhaThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNhaThuocTayDataSetBindingSource
            // 
            this.qLNhaThuocTayDataSetBindingSource.DataSource = this.qL_NhaThuocTayDataSet;
            this.qLNhaThuocTayDataSetBindingSource.Position = 0;
            // 
            // lOAITHUOCTableAdapter
            // 
            this.lOAITHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(746, 119);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(186, 20);
            this.txtTienThua.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tiền trả lại";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(746, 85);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(186, 20);
            this.txtTienKhachDua.TabIndex = 105;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            this.txtTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKhachDua_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Tiền mặt khách đưa";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocTayDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTenLoai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTenThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource qLNhaThuocTayDataSetBindingSource;
        private QL_NhaThuocTayDataSet qL_NhaThuocTayDataSet;
        private QL_NhaThuocTayDataSet1 qL_NhaThuocTayDataSet1;
        private System.Windows.Forms.BindingSource lOAITHUOCBindingSource;
        private QL_NhaThuocTayDataSet1TableAdapters.LOAITHUOCTableAdapter lOAITHUOCTableAdapter;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label2;
    }
}