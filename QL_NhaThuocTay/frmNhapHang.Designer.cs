
namespace QL_NhaThuocTay
{
    partial class frmNhapHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.txtMaCTPN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenLoai = new System.Windows.Forms.ComboBox();
            this.lOAITHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhaThuocTayDataSet = new QL_NhaThuocTay.QL_NhaThuocTayDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.TG = new System.Windows.Forms.Label();
            this.cboTenThuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lOAITHUOCTableAdapter = new QL_NhaThuocTay.QL_NhaThuocTayDataSetTableAdapters.LOAITHUOCTableAdapter();
            this.txtDVT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(726, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 34);
            this.label2.TabIndex = 101;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(571, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 45);
            this.button1.TabIndex = 100;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTT.Location = new System.Drawing.Point(805, 427);
            this.btnTT.Margin = new System.Windows.Forms.Padding(4);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(186, 45);
            this.btnTT.TabIndex = 95;
            this.btnTT.Text = "Xuất hóa đơn";
            this.btnTT.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(379, 427);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 45);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(200, 427);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 45);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(13, 427);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 45);
            this.btnThem.TabIndex = 92;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPN
            // 
            this.dgvPN.AllowUserToAddRows = false;
            this.dgvPN.AllowUserToDeleteRows = false;
            this.dgvPN.AllowUserToResizeColumns = false;
            this.dgvPN.AllowUserToResizeRows = false;
            this.dgvPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Location = new System.Drawing.Point(13, 41);
            this.dgvPN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.ReadOnly = true;
            this.dgvPN.RowHeadersWidth = 51;
            this.dgvPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPN.Size = new System.Drawing.Size(704, 359);
            this.dgvPN.TabIndex = 87;
            this.dgvPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 86;
            this.label1.Text = "Chi tiết phiếu nhập";
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTaoPN.Location = new System.Drawing.Point(961, 86);
            this.btnTaoPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(41, 28);
            this.btnTaoPN.TabIndex = 106;
            this.btnTaoPN.Text = "+";
            this.btnTaoPN.UseVisualStyleBackColor = false;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.Location = new System.Drawing.Point(834, 88);
            this.txtMaCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Size = new System.Drawing.Size(123, 22);
            this.txtMaCTPN.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Mã HD";
            // 
            // cboTenLoai
            // 
            this.cboTenLoai.DataSource = this.lOAITHUOCBindingSource;
            this.cboTenLoai.DisplayMember = "TENLOAI";
            this.cboTenLoai.FormattingEnabled = true;
            this.cboTenLoai.Location = new System.Drawing.Point(834, 140);
            this.cboTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenLoai.Name = "cboTenLoai";
            this.cboTenLoai.Size = new System.Drawing.Size(167, 24);
            this.cboTenLoai.TabIndex = 103;
            this.cboTenLoai.ValueMember = "MALOAI";
            this.cboTenLoai.SelectedIndexChanged += new System.EventHandler(this.cboTenLoai_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 102;
            this.label3.Text = "Tên loại";
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(720, 291);
            this.TG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(75, 17);
            this.TG.TabIndex = 111;
            this.TG.Text = "Đơn vị tính";
            // 
            // cboTenThuoc
            // 
            this.cboTenThuoc.DisplayMember = "TENDU";
            this.cboTenThuoc.FormattingEnabled = true;
            this.cboTenThuoc.Location = new System.Drawing.Point(834, 190);
            this.cboTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenThuoc.Name = "cboTenThuoc";
            this.cboTenThuoc.Size = new System.Drawing.Size(167, 24);
            this.cboTenThuoc.TabIndex = 110;
            this.cboTenThuoc.ValueMember = "DONGIA";
            this.cboTenThuoc.SelectedIndexChanged += new System.EventHandler(this.cboTenThuoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Tên thuốc";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(834, 244);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 22);
            this.numericUpDown1.TabIndex = 108;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "Số lượng";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(834, 381);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(168, 22);
            this.txtTT.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "Thành tiền";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(834, 334);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(168, 22);
            this.txtGia.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 113;
            this.label8.Text = "Đơn giá";
            // 
            // lOAITHUOCTableAdapter
            // 
            this.lOAITHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(834, 291);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(168, 22);
            this.txtDVT.TabIndex = 117;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 518);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.cboTenThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTaoPN);
            this.Controls.Add(this.txtMaCTPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTenLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPN);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAITHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhaThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.TextBox txtMaCTPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.ComboBox cboTenThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label8;
        private QL_NhaThuocTayDataSet qL_NhaThuocTayDataSet;
        private System.Windows.Forms.BindingSource lOAITHUOCBindingSource;
        private QL_NhaThuocTayDataSetTableAdapters.LOAITHUOCTableAdapter lOAITHUOCTableAdapter;
        private System.Windows.Forms.TextBox txtDVT;
    }
}