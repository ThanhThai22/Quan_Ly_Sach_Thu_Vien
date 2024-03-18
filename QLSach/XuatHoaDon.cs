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
    public partial class XuatHoaDon : Form
    {
        chucnang cn = new chucnang();
        SqlConnection conn = new SqlConnection();
        public string maHDXuat; //mã hóa đơn lấy từ form hóa đơn
        public XuatHoaDon()
        {
            InitializeComponent();
        }

        public XuatHoaDon(string mahd)
        {
            InitializeComponent();
            maHDXuat = mahd;
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            string makh = Convert.ToString(chucnang.GetFieldValues("SELECT MaKH FROM HOA_DON WHERE MaHD = '" + maHDXuat + "'", conn));
            string tenkh = Convert.ToString(chucnang.GetFieldValues("SELECT TenKH FROM KHACH_HANG WHERE MaKH = '"+makh+"'", conn));
            string sql = "SELECT a.MaHD, d.TenSach, a.Soluong, a.DonGia, a.ThanhTien FROM CHITIETHD a, HOA_DON b, KHACH_HANG c, SACH d WHERE c.MaKH='" + makh + "' and a.MaSach=d.MaSach and a.MaHD=b.MaHD and b.MaKH=c.MaKH and b.MaHD=a.MaHD";
            cn.ShowDataGV(dataGridView1,sql, conn);
            txtma.Text = makh;
            txtTenKH.Text = tenkh;
            txtmahd.Text = maHDXuat;
            string str_Tong = chucnang.GetFieldValues("SELECT SUM(a.ThanhTien) FROM CHITIETHD a, HOA_DON b, KHACH_HANG c WHERE a.MaHD=b.MaHD and b.MaKH=c.MaKH and c.MaKH = '" + makh + "'", conn);
            txtTong.Text = str_Tong;
        }
    }
}
