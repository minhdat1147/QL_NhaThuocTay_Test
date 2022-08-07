
namespace QL_NhaThuocTay
{
    partial class frmThuoc
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
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.lOAITHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhaThuocTayDataSet = new QL_NhaThuocTay.QL_NhaThuocTayDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.TG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lOAITHUOCTableAdapter = new QL_NhaThuocTay.QL_NhaThuocTayDataSetTableAdapters.LOAITHUOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Vỉ",
            "Hộp",
            "Chai",
            "Viên"});
            this.cboDVT.Location = new System.Drawing.Point(770, 412);
            this.cboDVT.Margin = new System.Windows.Forms.Padding(4);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(168, 24);
            this.cboDVT.TabIndex = 94;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(729, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 40);
            this.button5.TabIndex = 91;
            this.button5.Text = "Quản lý loại ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DataSource = this.lOAITHUOCBindingSource;
            this.cboMaLoai.DisplayMember = "MALOAI";
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(471, 415);
            this.cboMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(155, 24);
            this.cboMaLoai.TabIndex = 90;
            this.cboMaLoai.ValueMember = "MALOAI";
            this.cboMaLoai.SelectedIndexChanged += new System.EventHandler(this.cboMaLoai_SelectedIndexChanged);
            // 
            // lOAITHUOCBindingSource
            // 
            this.lOAITHUOCBindingSource.DataMember = "LOAITHUOC";
            this.lOAITHUOCBindingSource.DataSource = this.qL_NhaThuocTayDataSet;
            // 
            // qL_NhaThuocTayDataSet
            // 
            this.qL_NhaThuocTayDataSet.DataSetName = "QL_NhaThuocTayDataSet";
            this.qL_NhaThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Loại sản phẩm";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DataSource = this.lOAITHUOCBindingSource;
            this.cboLoaiSP.DisplayMember = "TENLOAI";
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(286, 16);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(399, 24);
            this.cboLoaiSP.TabIndex = 88;
            this.cboLoaiSP.ValueMember = "MALOAI";
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(758, 274);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 51);
            this.btnThoat.TabIndex = 87;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 207);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(471, 474);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(155, 22);
            this.txtGia.TabIndex = 85;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(384, 483);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 17);
            this.label.TabIndex = 84;
            this.label.Text = "GIá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 419);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mã loại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(119, 470);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(243, 22);
            this.txtTen.TabIndex = 82;
            // 
            // txtMT
            // 
            this.txtMT.Location = new System.Drawing.Point(119, 415);
            this.txtMT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(243, 22);
            this.txtMT.TabIndex = 81;
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(653, 422);
            this.TG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(75, 17);
            this.TG.TabIndex = 80;
            this.TG.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mã thuốc";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(494, 275);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 50);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(245, 275);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 49);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(8, 274);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 50);
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(421, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 74;
            this.label1.Text = "Thông tin thuốc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(770, 470);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 95;
            this.label5.Text = "HSD";
            // 
            // lOAITHUOCTableAdapter
            // 
            this.lOAITHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 535);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMT);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMT;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private QL_NhaThuocTayDataSet qL_NhaThuocTayDataSet;
        private System.Windows.Forms.BindingSource lOAITHUOCBindingSource;
        private QL_NhaThuocTayDataSetTableAdapters.LOAITHUOCTableAdapter lOAITHUOCTableAdapter;
    }
}