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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBCDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyDienThoai.Properties.Resources.btn_in;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(577, 461);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(105, 47);
            this.btnIn.TabIndex = 43;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLyDienThoai.Properties.Resources.btn_Thoat;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(762, 461);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 47);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Image = global::QuanLyDienThoai.Properties.Resources.btn_Them;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(397, 461);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(117, 47);
            this.btnBaocao.TabIndex = 41;
            this.btnBaocao.Text = "Tạo báo cáo";
            this.btnBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Image = global::QuanLyDienThoai.Properties.Resources.btn_Hienthi;
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(244, 461);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(94, 47);
            this.btnHienthi.TabIndex = 40;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // dgridBCDSNV
            // 
            this.dgridBCDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBCDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnv,
            this.tnv,
            this.tt});
            this.dgridBCDSNV.Location = new System.Drawing.Point(170, 229);
            this.dgridBCDSNV.Name = "dgridBCDSNV";
            this.dgridBCDSNV.RowHeadersWidth = 51;
            this.dgridBCDSNV.RowTemplate.Height = 24;
            this.dgridBCDSNV.Size = new System.Drawing.Size(753, 204);
            this.dgridBCDSNV.TabIndex = 39;
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
            this.label1.Size = new System.Drawing.Size(527, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "Báo cáo danh sách 5 nhân viên ";
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "MaNV";
            this.mnv.HeaderText = "Mã nhân viên";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            this.mnv.Width = 125;
            // 
            // tnv
            // 
            this.tnv.DataPropertyName = "TenNV";
            this.tnv.HeaderText = "Tên nhân viên";
            this.tnv.MinimumWidth = 6;
            this.tnv.Name = "tnv";
            this.tnv.Width = 125;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "Tong";
            this.tt.HeaderText = "Tổng tiền";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.Width = 125;
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
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
    }
}