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
    public partial class FormDangKy : Form
    {
        chucnang cn = new chucnang();
        SqlConnection conn = new SqlConnection();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            string ma = txtma.Text;
            string username = txtUS.Text;
            string hoten = txthoten.Text;
            string password = txtPS.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            //string diachi = txtDC.Text;
            string sdt = txtSDT.Text;
            string gioitinh = txtGT.Text;

            string sql_dk = "insert into NHAN_VIEN values('" + ma+"', '"+hoten+"', '"+sdt+"', '"+date+"', '"+gioitinh+"', '"+username+"', '"+password+"')";
            try
            {
                cn.capnhat(sql_dk, conn);
                MessageBox.Show("Đăng Ký Thành Công!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);

            }
        }
    }
}
