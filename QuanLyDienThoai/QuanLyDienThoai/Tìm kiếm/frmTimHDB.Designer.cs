namespace QuanLyDienThoai
{
    partial class frmTimHDB
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
            this.tong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btntl = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.MKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngayban = new System.Windows.Forms.Label();
            this.MHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tong
            // 
            this.tong.Location = new System.Drawing.Point(435, 221);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(217, 22);
            this.tong.TabIndex = 44;
            this.tong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tổng tiền";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(713, 503);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 42;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntl
            // 
            this.btntl.Location = new System.Drawing.Point(478, 503);
            this.btntl.Name = "btntl";
            this.btntl.Size = new System.Drawing.Size(75, 23);
            this.btntl.TabIndex = 41;
            this.btntl.Text = "Tìm lại";
            this.btntl.UseVisualStyleBackColor = true;
            this.btntl.Click += new System.EventHandler(this.btntl_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(276, 504);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 40;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.ngay,
            this.MNV,
            this.TT,
            this.MaKH});
            this.dataGridView1.Location = new System.Drawing.Point(157, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 213);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaHDB";
            this.MaHDB.HeaderText = "Mã HDBan";
            this.MaHDB.MinimumWidth = 6;
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.Width = 125;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "Ngayban";
            this.ngay.HeaderText = "Ngày bán";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.Width = 125;
            // 
            // MNV
            // 
            this.MNV.DataPropertyName = "MaNV";
            this.MNV.HeaderText = "Mã NV";
            this.MNV.MinimumWidth = 6;
            this.MNV.Name = "MNV";
            this.MNV.Width = 125;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "Tongtien";
            this.TT.HeaderText = "Tông tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(643, 181);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(160, 22);
            this.txtMKH.TabIndex = 38;
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(643, 144);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(160, 22);
            this.txtMNV.TabIndex = 37;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(320, 181);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(121, 22);
            this.txtNgay.TabIndex = 36;
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(320, 145);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(121, 22);
            this.txtMHD.TabIndex = 35;
            // 
            // MKH
            // 
            this.MKH.AutoSize = true;
            this.MKH.Location = new System.Drawing.Point(565, 181);
            this.MKH.Name = "MKH";
            this.MKH.Size = new System.Drawing.Size(47, 16);
            this.MKH.TabIndex = 34;
            this.MKH.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã NV ";
            // 
            // ngayban
            // 
            this.ngayban.AutoSize = true;
            this.ngayban.Location = new System.Drawing.Point(205, 182);
            this.ngayban.Name = "ngayban";
            this.ngayban.Size = new System.Drawing.Size(66, 16);
            this.ngayban.TabIndex = 32;
            this.ngayban.Text = "Ngày bán";
            // 
            // MHD
            // 
            this.MHD.AutoSize = true;
            this.MHD.Location = new System.Drawing.Point(202, 145);
            this.MHD.Name = "MHD";
            this.MHD.Size = new System.Drawing.Size(73, 16);
            this.MHD.TabIndex = 31;
            this.MHD.Text = "Mã HDBan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(332, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm hóa đơn bán";
            // 
            // frmTimHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntl);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMKH);
            this.Controls.Add(this.txtMNV);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.MKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ngayban);
            this.Controls.Add(this.MHD);
            this.Controls.Add(this.label1);
            this.Name = "frmTimHDB";
            this.Text = "frmTimHDB";
            this.Load += new System.EventHandler(this.frmTimHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntl;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label MKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ngayban;
        private System.Windows.Forms.Label MHD;
        private System.Windows.Forms.Label label1;
    }
}