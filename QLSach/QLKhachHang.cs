using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLSach
{
    public partial class QLKhachHang : Form
    {
        chucnang cn = new chucnang();
        SqlConnection conn = new SqlConnection();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.ShowDataGV(dataGridView1, "select * from KHACH_HANG", conn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void ResetValue()
        {
            txthoten.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            checkBoxNam.Checked = false;
            checkBoxNu.Checked = false;
            btn_add_kh.Enabled = true;

        }

        private void btn_add_kh_Click(object sender, EventArgs e)
        {
            
            btn_edit_kh.Enabled = false;
            btn_del_kh.Enabled = false;
            btnSave.Enabled = true;

            ResetValue();
            txtma.Text = chucnang.CreateKey("KH");
        }

        private void btn_edit_kh_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txthoten.Text;
            string diachi = txtdc.Text;
            string sdt = txtsdt.Text;
            string gt;
            if (checkBoxNam.Checked)
            {
                gt = checkBoxNam.Text;
            }
            else
            {
                gt = checkBoxNu.Text;
            }

            string sql_update_kh = "UPDATE KHACH_HANG SET TenKH = N'"+ten+"', DiaChi = N'"+diachi+"', SDT = '"+sdt+"', GioiTinh = '"+gt+"' WHERE MaKH = '"+ma+"'";

            try
            {
                cn.capnhat(sql_update_kh, conn);
                MessageBox.Show("Sửa khách hàng thành công!");
                cn.ShowDataGV(dataGridView1, "select * from KHACH_HANG", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            btn_add_kh.Enabled = true;
            btnSave.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_add_kh.Enabled = false;
            btn_edit_kh.Enabled = true;
            btnSave.Enabled = false;
            btn_del_kh.Enabled = true;


            txtma.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txthoten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string gt = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if(gt.ToLower() == "nam")
            {
                checkBoxNam.Enabled = true;
            }
            else
            {
                checkBoxNu.Enabled = true;
            }
        }

        private void btn_del_kh_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql_del_kh = "DELETE FROM KHACH_HANG WHERE MaKH = '" + ma + "'";

            try
            {
                cn.capnhat(sql_del_kh, conn);
                MessageBox.Show("Xóa khách hàng thành công!");
                cn.ShowDataGV(dataGridView1, "select * from KHACH_HANG", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            btn_add_kh.Enabled = true;
            btnSave.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txthoten.Text;
            string diachi = txtdc.Text;
            string sdt = txtsdt.Text;
            string gt;
            if (checkBoxNam.Checked)
            {
                gt = checkBoxNam.Text;
            }
            else
            {
                gt = checkBoxNu.Text;
            }

            string sql_add_kh = "INSERT INTO KHACH_HANG VALUES(N'" + ma + "', N'" + ten + "', N'" + diachi + "', '" + sdt + "', '" + gt + "')";

            try
            {
                cn.capnhat(sql_add_kh, conn);
                MessageBox.Show("Thêm khách hàng vào thành công!");
                cn.ShowDataGV(dataGridView1, "select * from KHACH_HANG", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            btn_edit_kh.Enabled = true;
            btn_del_kh.Enabled = true;
            btn_add_kh.Enabled = true;

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string datafind = txtFind.Text;

            cn.ShowDataGV(dataGridView1, "SELECT * FROM KHACH_HANG WHERE TenKH = '"+datafind+"'", conn);
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 12))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
