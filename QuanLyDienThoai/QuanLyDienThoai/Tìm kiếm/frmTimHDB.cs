using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class frmTimHDB : Form
    {
        public frmTimHDB()
        {
            InitializeComponent();
        }
        DataTable tblTKHDB;
        private void frmTimHDB_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMHD.Focus();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMHD.Text == "") && (txtMNV.Text == "") &&
               (txtNgay.Text == "") && (txtMKH.Text == "") &&
               (tong.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHDBan WHERE 1=1";
            if (txtMHD.Text != "")
                sql = sql + " AND MaHDB Like N'%" + txtMHD.Text + "%'";
            if (txtMKH.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMKH.Text + "%'";
            if (txtNgay.Text != "")
                sql = sql + " AND Ngayban =" + txtNgay.Text;
            if (txtMNV.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtMNV.Text + "%'";

            tblTKHDB = functions.GetDataToTable(sql);
            if (tblTKHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTKHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = tblTKHDB;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "select MaHDB, Ngayban, MaNV, MaKH, Tongtien from tblHDBan where MaHDB = '" + txtMHD.Text + "'";
            tblTKHDB = functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblTKHDB;

            dataGridView1.Columns[0].HeaderText = "Mã HDB";
            dataGridView1.Columns[1].HeaderText = "Ngày bán";
            dataGridView1.Columns[2].HeaderText = "Mã NV";
            dataGridView1.Columns[3].HeaderText = "Mã KH";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntl_Click(object sender, EventArgs e)
        {

            ResetValues();
            LoadDataGridView();
        }

        private void tong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dataGridView1.CurrentRow.Cells["MaHDB"].Value.ToString();
                frmTimHDB frm = new frmTimHDB();
                frm.txtMHD.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
