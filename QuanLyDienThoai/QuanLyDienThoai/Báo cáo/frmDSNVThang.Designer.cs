﻿namespace QuanLyDienThoai
{
    partial class frmDSNVThang
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.dgridBCDSNV = new System.Windows.Forms.DataGridView();
            this.msp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBCDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(528, 494);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(115, 23);
            this.btnIn.TabIndex = 43;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(703, 494);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(383, 494);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(96, 23);
            this.btnBaocao.TabIndex = 41;
            this.btnBaocao.Text = "Tạo báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(245, 494);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 40;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // dgridBCDSNV
            // 
            this.dgridBCDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBCDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msp,
            this.tsp,
            this.sl});
            this.dgridBCDSNV.Location = new System.Drawing.Point(170, 229);
            this.dgridBCDSNV.Name = "dgridBCDSNV";
            this.dgridBCDSNV.RowHeadersWidth = 51;
            this.dgridBCDSNV.RowTemplate.Height = 24;
            this.dgridBCDSNV.Size = new System.Drawing.Size(753, 204);
            this.dgridBCDSNV.TabIndex = 39;
            // 
            // msp
            // 
            this.msp.DataPropertyName = "MaSP";
            this.msp.HeaderText = "Mã sản phẩm";
            this.msp.MinimumWidth = 6;
            this.msp.Name = "msp";
            this.msp.Width = 125;
            // 
            // tsp
            // 
            this.tsp.DataPropertyName = "TenSP";
            this.tsp.HeaderText = "Tên sản phẩm";
            this.tsp.MinimumWidth = 6;
            this.tsp.Name = "tsp";
            this.tsp.Width = 125;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Tongsoluong";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 125;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(613, 164);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(187, 22);
            this.txtnam.TabIndex = 38;
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tháng";
            // 
            // cbothang
            // 
            this.cbothang.FormattingEnabled = true;
            this.cbothang.Location = new System.Drawing.Point(268, 167);
            this.cbothang.Name = "cbothang";
            this.cbothang.Size = new System.Drawing.Size(184, 24);
            this.cbothang.TabIndex = 35;
//            this.cbothang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbothang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 41);
            this.label2.TabIndex = 34;
            this.label2.Text = "bán chạy nhất trong 1 tháng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "Báo cáo danh sách nhân viên ";
            // 
            // frmDSNVThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 529);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.dgridBCDSNV);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbothang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDSNVThang";
            this.Text = "frmDSNVThang";
            this.Load += new System.EventHandler(this.frmDSNVThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridBCDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.DataGridView dgridBCDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn msp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}