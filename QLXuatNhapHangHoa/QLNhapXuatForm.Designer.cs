
namespace QLXuatNhapHangHoa
{
    partial class QLNhapXuatForm
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
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTonDauKy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongXuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTonKhoHienTai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLF = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnRF = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.chbMaSoHangHoa = new System.Windows.Forms.CheckBox();
            this.chbTenHangHoa = new System.Windows.Forms.CheckBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(135, 119);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(97, 20);
            this.txtTenHangHoa.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên hàng hóa:";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(136, 77);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(96, 20);
            this.txtMaHangHoa.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã số hàng hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ NHẬP, XUẤT HÀNG HÓA";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Location = new System.Drawing.Point(244, 426);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvNhap
            // 
            this.dgvNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Location = new System.Drawing.Point(238, 119);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.Size = new System.Drawing.Size(260, 180);
            this.dgvNhap.TabIndex = 23;
            this.dgvNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhap_CellClick);
            // 
            // dgvXuat
            // 
            this.dgvXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Location = new System.Drawing.Point(512, 120);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.Size = new System.Drawing.Size(260, 180);
            this.dgvXuat.TabIndex = 34;
            this.dgvXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXuat_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Chi tiết nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chi tiết xuất";
            // 
            // txtTongNhap
            // 
            this.txtTongNhap.Location = new System.Drawing.Point(358, 317);
            this.txtTongNhap.Name = "txtTongNhap";
            this.txtTongNhap.Size = new System.Drawing.Size(96, 20);
            this.txtTongNhap.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tổng nhập:";
            // 
            // txtTonDauKy
            // 
            this.txtTonDauKy.Location = new System.Drawing.Point(358, 363);
            this.txtTonDauKy.Name = "txtTonDauKy";
            this.txtTonDauKy.Size = new System.Drawing.Size(96, 20);
            this.txtTonDauKy.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tồn đầu kỳ:";
            // 
            // txtTongXuat
            // 
            this.txtTongXuat.Location = new System.Drawing.Point(632, 317);
            this.txtTongXuat.Name = "txtTongXuat";
            this.txtTongXuat.Size = new System.Drawing.Size(96, 20);
            this.txtTongXuat.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tổng xuất:";
            // 
            // txtTonKhoHienTai
            // 
            this.txtTonKhoHienTai.Location = new System.Drawing.Point(632, 363);
            this.txtTonKhoHienTai.Name = "txtTonKhoHienTai";
            this.txtTonKhoHienTai.Size = new System.Drawing.Size(96, 20);
            this.txtTonKhoHienTai.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tồn kho hiện tại:";
            // 
            // btnLF
            // 
            this.btnLF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLF.Location = new System.Drawing.Point(12, 426);
            this.btnLF.Name = "btnLF";
            this.btnLF.Size = new System.Drawing.Size(44, 23);
            this.btnLF.TabIndex = 45;
            this.btnLF.Text = "|<";
            this.btnLF.UseVisualStyleBackColor = true;
            this.btnLF.Click += new System.EventHandler(this.btnLF_Click);
            // 
            // btnL
            // 
            this.btnL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnL.Location = new System.Drawing.Point(62, 426);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(44, 23);
            this.btnL.TabIndex = 46;
            this.btnL.Text = "<";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnR.Location = new System.Drawing.Point(144, 426);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(44, 23);
            this.btnR.TabIndex = 47;
            this.btnR.Text = ">";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnRF
            // 
            this.btnRF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRF.Location = new System.Drawing.Point(194, 426);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(44, 23);
            this.btnRF.TabIndex = 48;
            this.btnRF.Text = ">|";
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(112, 429);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(26, 16);
            this.lblPage.TabIndex = 49;
            this.lblPage.Text = "0/0";
            // 
            // chbMaSoHangHoa
            // 
            this.chbMaSoHangHoa.AutoSize = true;
            this.chbMaSoHangHoa.Location = new System.Drawing.Point(15, 211);
            this.chbMaSoHangHoa.Name = "chbMaSoHangHoa";
            this.chbMaSoHangHoa.Size = new System.Drawing.Size(103, 17);
            this.chbMaSoHangHoa.TabIndex = 50;
            this.chbMaSoHangHoa.Text = "Mã số hàng hóa";
            this.chbMaSoHangHoa.UseVisualStyleBackColor = true;
            this.chbMaSoHangHoa.CheckedChanged += new System.EventHandler(this.chbMaSoHangHoa_CheckedChanged);
            // 
            // chbTenHangHoa
            // 
            this.chbTenHangHoa.AutoSize = true;
            this.chbTenHangHoa.Location = new System.Drawing.Point(15, 254);
            this.chbTenHangHoa.Name = "chbTenHangHoa";
            this.chbTenHangHoa.Size = new System.Drawing.Size(93, 17);
            this.chbTenHangHoa.TabIndex = 51;
            this.chbTenHangHoa.Text = "Tên hàng hóa";
            this.chbTenHangHoa.UseVisualStyleBackColor = true;
            this.chbTenHangHoa.CheckedChanged += new System.EventHandler(this.chbTenHangHoa_CheckedChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(157, 276);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 52;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(136, 251);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(97, 20);
            this.txtTim.TabIndex = 53;
            // 
            // QLNhapXuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.chbTenHangHoa);
            this.Controls.Add(this.chbMaSoHangHoa);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnRF);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnLF);
            this.Controls.Add(this.txtTonKhoHienTai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTongXuat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTonDauKy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTongNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvXuat);
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvNhap);
            this.Name = "QLNhapXuatForm";
            this.Text = "QLNhapXuatForm";
            this.Load += new System.EventHandler(this.QLNhapXuatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvNhap;
        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTonDauKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTonKhoHienTai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLF;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.CheckBox chbMaSoHangHoa;
        private System.Windows.Forms.CheckBox chbTenHangHoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}