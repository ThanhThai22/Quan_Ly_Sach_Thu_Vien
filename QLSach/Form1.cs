using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSach
{
    public partial class Form1 : Form
    {
        chucnang cn = new chucnang();
        public SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy fdk = new FormDangKy();
            fdk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            string username = txtUS.Text;
            string password = txtPS.Text;

            string sql_Check = "select * from NHAN_VIEN where Username = '" + username + "' and Password = '" + password + "'";
            SqlCommand com = new SqlCommand(sql_Check, conn);
            //Thuc thi cau lenh bang sql data reader
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                
                string ten = txtUS.Text;
                ThemSach ts = new ThemSach(ten);
                ts.Show();
                
            }
            else 
            {
                MessageBox.Show("Username và Password không đúng");
            }
            
        }
    }
}
