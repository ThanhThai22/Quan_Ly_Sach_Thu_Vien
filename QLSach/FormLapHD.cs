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
    public partial class FormLapHD : Form
    {
        DataTable tblCTHDB;
        chucnang cn = new chucnang();
        SqlConnection conn = new SqlConnection();
        public FormLapHD()
        {
            InitializeComponent();
        }

        private void FormLapHD_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            string sql_hoadon = "SELECT * FROM HOA_DON";
            //cn.ShowDataGV(dataGridView1, sql_hoadon, conn);
            cn.ShowInComboBox(comboBoxNV, "SELECT * FROM NHAN_VIEN", conn, "TenNV", "MaNV");
            cn.ShowInComboBox(comboBoxSach, "SELECT * FROM SACH", conn, "TenSach", "MaSach");
            cn.ShowInComboBox(comboBoxKH, "SELECT * FROM KHACH_HANG", conn, "TenKH", "MaKH");
            if (txtmahd.Text != "")
            {
                LoadInfoHoaDon();
            }
            LoadDataGridView();
        }

        private void thốngKêSốLượngBánRaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLKhachHang kh = new QLKhachHang();
            kh.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            string mahdhientai = txtmahd.Text;
            //MessageBox.Show(mahdhientai);
            XuatHoaDon xhd = new XuatHoaDon(mahdhientai);
            xhd.ShowDialog();
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            btndel.Enabled = false;
            btnedit.Enabled = true; //save
            del_hd_xuat.Enabled = false;
            btnreset.Enabled = false; //xuathd


            ResetValue();
            txtmahd.Text = chucnang.CreateKey("HD");
            //cn.ShowDataGV(dataGridView1, "select * from CHITIET_HD", conn);
            LoadDataGridView();
        }

        private void ResetValue()
        {
            txtdongia.Text = "0";
            //txtsdt.Text = "";
            txtsl.Text = "";
            txtmahd.Text = "";
            txtThanhTien.Text = "0";
            txttongtien.Text = "0";
            comboBoxKH.Text = "";
            comboBoxNV.Text = "";
            comboBoxSach.Text = "";

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHD, b.TenSach, a.Soluong, a.DonGia, a.ThanhTien FROM CHITIETHD a, SACH b WHERE a.MaSach=b.MaSach";
            //sql = "SELECT * FROM CHITIETHD";
            tblCTHDB = chucnang.GetDataToTable(sql, conn);
            dataGridView1.DataSource = tblCTHDB;
            dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadDataGridViewfind(string tensach)
        {
            string sql;
            sql = "SELECT a.MaHD, b.TenSach, a.Soluong, a.DonGia, a.ThanhTien FROM CHITIETHD a, SACH b WHERE a.MaSach=b.MaSach and b.TenSach = '"+tensach+"'";
            //sql = "SELECT * FROM CHITIETHD";
            tblCTHDB = chucnang.GetDataToTable(sql, conn);
            dataGridView1.DataSource = tblCTHDB;
            dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                //Xóa chi tiết hóa đơn
                sql = "DELETE CHITIETHD WHERE MaHD=N'" + txtmahd.Text + "'";
                //chucnang.RunSqlDel(sql);
                cn.capnhat(sql, conn);

                //Xóa hóa đơn
                sql = "DELETE HOA_DON WHERE MaHD=N'" + txtmahd.Text + "'";
                //chucnang.RunSqlDel(sql);
                cn.capnhat(sql, conn);
                ResetValue();
                //LoadDataGridView();
                //btndel.Enabled = false;
                //btnprint.Enabled = false;
                //cn.ShowDataGV(dataGridView1, "select * from CHITIET_HD", conn);
                LoadDataGridView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled = false;
            comboBoxNV.Enabled = false;
            comboBoxKH.Enabled = false;
            comboBoxSach.Enabled = false;
            txtsl.Enabled = false;
            btnedit.Enabled = false;

            txtmahd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxSach.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsl.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdongia.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtThanhTien.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //LoadInfoHoaDon();
            string str_nv = "SELECT b.TenNV FROM HOA_DON a, NHAN_VIEN b WHERE MaHD = N'" + txtmahd.Text + "' and a.MaNV=b.MaNV";
            comboBoxNV.Text = chucnang.GetFieldValues(str_nv, conn);
            string str_kh = "SELECT b.TenKH FROM HOA_DON a, KHACH_HANG b WHERE MaHD = N'" + txtmahd.Text + "' and a.MaKH=b.MaKH";
            comboBoxKH.Text = chucnang.GetFieldValues(str_kh, conn);

            //Lay thong tin TongTien cua hoadon
            string sql = "SELECT TongTien FROM HOA_DON WHERE MaHD = '" + txtmahd.Text + "'";
            string tongtien = Convert.ToString(chucnang.GetFieldValues(sql, conn));
            txttongtien.Text = tongtien;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            string ngay = dateTimePicker1.Value.ToShortDateString();
            sql = "INSERT INTO HOA_DON VALUES ('" + txtmahd.Text.Trim() + "', '" + ngay + "','" + comboBoxNV.SelectedValue + "','" +
                        comboBoxKH.SelectedValue + "'," + txttongtien.Text + ")";
            cn.capnhat(sql, conn);
            /*// Lưu thông tin của các mặt hàng
            if (comboBoxSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxSach.Focus();
                return;
            }
            if ((txtsdt.Text.Trim().Length == 0) || (txtsdt.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Text = "";
                txtsdt.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblChiTietHDBan WHERE MaHang=N'" + comboBoxSach.SelectedValue + "' AND MaHDBan = N'" + txtmahd.Text.Trim() + "'";
            if (chucnang.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ResetValuesHang();
                comboBoxSach.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHang WHERE MaHang = N'" + cboMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsl.Text = "";
                txtsl.Focus();
                return;
            }*/
            double dongia = Convert.ToDouble(chucnang.GetFieldValues("SELECT DonGiaBan FROM SACH WHERE MaSach = '" + comboBoxSach.SelectedValue + "'", conn));
            double thanhtien = Convert.ToDouble(txtsl.Text) * dongia;


            sql = "INSERT INTO CHITIETHD VALUES(N'" + txtmahd.Text.Trim() + "',N'" + comboBoxSach.SelectedValue + "'," + txtsl.Text + "," + dongia + "," + thanhtien + ")";
            /*chucnang.RunSQL(sql);*/
            cn.capnhat(sql, conn);

            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(chucnang.GetFieldValues("SELECT TongTien FROM HOA_DON WHERE MaHD = N'" + txtmahd.Text + "'", conn));
            Tongmoi = tong + thanhtien;
            sql = "UPDATE HOA_DON SET TongTien =" + Tongmoi + " WHERE MaHD = N'" + txtmahd.Text + "'";
            cn.capnhat(sql, conn);
            txttongtien.Text = Tongmoi.ToString();
            /*//tong = Convert.ToDouble(chucnang.GetFieldValues("SELECT TongTien FROM HoaDon WHERE MaHD = '" + txtmahd.Text + "'", conn));
            double tong1 = Convert.ToDouble(chucnang.GetFieldValues("SELECT SUM(ThanhTien) FROM CHITIETHD", conn));
            Tongmoi += *//*Convert.ToDouble(txttongtien.Text);*//* tong1;
            sql = "UPDATE HOA_DON SET TongTien =" + Tongmoi + " WHERE MaHD = N'" + txtmahd.Text + "'";
            cn.capnhat(sql, conn);
            txttongtien.Text = Tongmoi.ToString();*/
            btndel.Enabled = true;
            btnadd.Enabled = true;
            btnreset.Enabled = true;
            del_hd_xuat.Enabled = true;
            btnedit.Enabled = true;
            btnexit.Enabled = true;
            //cn.ShowDataGV(dataGridView1, "select * from CHITIETHD", conn);
            LoadDataGridView();
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM HOA_DON WHERE MaHD = N'" + txtmahd.Text + "'";
            dateTimePicker1.Text = chucnang.ConvertDateTime(chucnang.GetFieldValues(str,conn));
            str = "SELECT MaNhanVien FROM HOA_DON WHERE MaHD = N'" + txtmahd.Text + "'";
            comboBoxNV.Text = chucnang.GetFieldValues(str,conn);
            str = "SELECT MaKhach FROM HOA_DON WHERE MaHD = N'" + txtmahd.Text + "'";
            comboBoxKH.Text = chucnang.GetFieldValues(str,conn);
            str = "SELECT TongTien FROM HOA_DON WHERE MaHD = N'" + txtmahd.Text + "'";
            txttongtien.Text = chucnang.GetFieldValues(str, conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datafind = txtfind.Text;

            LoadDataGridViewfind(datafind);
        }

        private void del_hd_xuat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("MaKH: "+comboBoxKH.SelectedValue);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                //Xóa chi tiết hóa đơn
                string get_maHD = chucnang.GetFieldValues("SELECT a.MaHD FROM CHITIETHD a, HOA_DON b WHERE a.MaHD = b.MaHD and b.MaKH = '" + comboBoxKH.SelectedValue + "'", conn);
                sql = "DELETE CHITIETHD WHERE MaHD=N'" + get_maHD + "'";
                //chucnang.RunSqlDel(sql);
                cn.capnhat(sql, conn);

                //Xóa hóa đơn
                sql = "DELETE HOA_DON WHERE MaKH=N'" + comboBoxKH.SelectedValue + "'";
                //chucnang.RunSqlDel(sql);
                cn.capnhat(sql, conn);
                ResetValue();
                //LoadDataGridView();
                //btndel.Enabled = false;
                //btnprint.Enabled = false;
                //cn.ShowDataGV(dataGridView1, "select * from CHITIET_HD", conn);
                LoadDataGridView();
            }
        }
    }
}
