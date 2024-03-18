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
    public partial class QLNhanVien : Form
    {
        chucnang cn = new chucnang();
        SqlConnection conn = new SqlConnection();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN", conn);
        }

        private void ResetValue()
        {
            string ngaysinh = dateTimePicker1.Value.ToShortDateString();
            txtten.Text = "";
            txtsdt.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txtus.Text = "";
            txtps.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;

            ResetValue();
            txtma.Text = chucnang.CreateKey("NV");
            cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN", conn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string sdt = txtsdt.Text;
            string ngaysinh = dateTimePicker1.Value.ToShortDateString();
            string gioitinh;
            if (checkBox1.Checked)
            {
                gioitinh = checkBox1.Text;
            }
            else
            {
                gioitinh = checkBox2.Text;
            }
            string US = txtus.Text;
            string PS = txtps.Text;

            string sql_update_nv = "UPDATE NHAN_VIEN SET TenNV = N'" + ten + "', SDT = '" + sdt + "', NgaySinh = '" + ngaysinh + "', GioiTinh = '" + gioitinh + "', Username = N'"+US+"', Password = '"+PS+"' WHERE MaNV = '" + ma + "'";

            try
            {
                cn.capnhat(sql_update_nv, conn);
                MessageBox.Show("Sửa nhan vien thành công!");
                cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            button1.Enabled = true;
            button4.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql_del_nv = "DELETE FROM NHAN_VIEN WHERE MaNV = '" + ma + "'";

            try
            {
                cn.capnhat(sql_del_nv, conn);
                MessageBox.Show("Xóa nhan vien thành công!");
                cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string ma = txtma.Text;
            string ten = txtten.Text;
            string sdt = txtsdt.Text;
            string ngaysinh = dateTimePicker1.Value.ToShortDateString();
            string gioitinh;
            if (checkBox1.Checked)
            {
                gioitinh = checkBox1.Text;
            }
            else
            {
                gioitinh = checkBox2.Text;
            }
            string US = txtus.Text;
            string PS = txtps.Text;

            string sql_add_nv = "INSERT INTO NHAN_VIEN VALUES(N'" + ma + "', N'" + ten + "', '" + sdt + "', '" + ngaysinh + "', '" + gioitinh + "', N'" + US + "', '" + PS + "')";
            try
            {
                cn.capnhat(sql_add_nv, conn);
                MessageBox.Show("Thêm vào thành công!");
                cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err);
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngaysinh = dateTimePicker1.Value.ToShortDateString();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;

            txtma.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ngaysinh = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtgt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtps.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string datafind = txtfindnv.Text;

            cn.ShowDataGV(dataGridView1, "SELECT * FROM NHAN_VIEN WHERE TenNV = '" + datafind + "'", conn);
        }
    }
}
