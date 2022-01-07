namespace QuanLyDienThoai
{
    partial class frmNhanHieu
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
            this.dgridNhanHieu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhanhieu = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtmanhanhieu = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNhanHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridNhanHieu
            // 
            this.dgridNhanHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridNhanHieu.Location = new System.Drawing.Point(59, 248);
            this.dgridNhanHieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgridNhanHieu.Name = "dgridNhanHieu";
            this.dgridNhanHieu.RowHeadersWidth = 51;
            this.dgridNhanHieu.Size = new System.Drawing.Size(667, 193);
            this.dgridNhanHieu.TabIndex = 35;
            this.dgridNhanHieu.Click += new System.EventHandler(this.dgridNhanHieu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên nhãn hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã nhãn hiệu";
            // 
            // txttennhanhieu
            // 
            this.txttennhanhieu.Location = new System.Drawing.Point(230, 200);
            this.txttennhanhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txttennhanhieu.Name = "txttennhanhieu";
            this.txttennhanhieu.Size = new System.Drawing.Size(132, 22);
            this.txttennhanhieu.TabIndex = 32;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(688, 467);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(100, 28);
            this.btndong.TabIndex = 31;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(551, 467);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(100, 28);
            this.btnhuy.TabIndex = 30;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(410, 467);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 29;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(280, 467);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 28;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(143, 467);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 27;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txtmanhanhieu
            // 
            this.txtmanhanhieu.Location = new System.Drawing.Point(230, 148);
            this.txtmanhanhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanhanhieu.Name = "txtmanhanhieu";
            this.txtmanhanhieu.Size = new System.Drawing.Size(132, 22);
            this.txtmanhanhieu.TabIndex = 26;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 467);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "DANH MỤC NHÃN HIỆU";
            // 
            // frmNhanHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.dgridNhanHieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttennhanhieu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.txtmanhanhieu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanHieu";
            this.Text = "frmNhanHieu";
            this.Load += new System.EventHandler(this.frmNhanHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridNhanHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridNhanHieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhanhieu;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtmanhanhieu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
    }
}