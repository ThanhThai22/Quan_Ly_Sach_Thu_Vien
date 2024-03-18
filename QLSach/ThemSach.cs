using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace QLSach
{
    public partial class ThemSach : Form
    {
        SqlConnection conn = new SqlConnection();
        chucnang cn = new chucnang();
        public string hoten;
        public string imgdong = AppDomain.CurrentDomain.BaseDirectory + "\\IMG\\";
        public ThemSach()
        {
            InitializeComponent();
        }
        public ThemSach(string param_ten)
        {
            InitializeComponent();
            hoten = param_ten;
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            cn.ketnoi(conn);
            cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '"+imgdong+"'+HinhAnh as Image, TacGia, DonGiaBan from SACH", conn);
            label9.Text = hoten;
            cn.ShowInComboBox(comboBox1, "select * from LOAISACH", conn, "TenLoai", "MaLoai");
            txthidden.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) //Luu thong tin sach
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string loai = comboBox1.SelectedValue.ToString();
            //MessageBox.Show(loai);
            string nxb = txtnxb.Text;
            string tacgia = txttg.Text;

            File.Copy(txthidden.Text, imgdong + Path.GetFileName(txthidden.Text));

            string sql_add = "INSERT INTO SACH VALUES(N'" + ma + "', N'" + ten + "', N'" + nxb + "', N'" + loai + "', N'" + Path.GetFileName(txthidden.Text) + "', N'" + tacgia + "', '"+textBox1.Text+"')";
            try
            {
                cn.capnhat(sql_add, conn);
                MessageBox.Show("Thêm Vào Thành Công!");
                cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '" + imgdong + "'+HinhAnh as Image, TacGia, DonGiaBan from SACH", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);
            }
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_edit.Enabled = true;
            button5.Enabled = true;
        }

        private void ResetValue()
        {
            comboBox1.Text = "";
            txtten.Text = "";
            txtnxb.Text = "";
            txttg.Text = "";
            textBox1.Text = "0";
            pictureBox1.Image = null;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            button6.Enabled = true;
            button5.Enabled = true;
            btn_add.Enabled = false;
            ResetValue();
            txtma.Enabled = true;
            textBox1.Enabled = true;
            txtma.Text = chucnang.CreateKey("SA");

            /*string ma = txtma.Text;
            string ten = txtten.Text;
            string loai = comboBox1.SelectedValue.ToString();
            //MessageBox.Show(loai);
            string nxb = txtnxb.Text;
            string tacgia = txttg.Text;
            File.Copy(txthidden.Text, imgdong + Path.GetFileName(txthidden.Text));

            string sql_add = "INSERT INTO SACH VALUES('" + ma + "', '" + ten + "', '" + nxb + "', '" + loai + "', '" + Path.GetFileName(txthidden.Text) + "', '" + tacgia + "')";
            try
            {
                cn.capnhat(sql_add, conn);
                MessageBox.Show("Thêm Vào Thành Công!");
                cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '" + imgdong + "'+HinhAnh, TacGia from SACH", conn);
            } catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);
            }*/
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string loai = comboBox1.SelectedValue.ToString();
            //MessageBox.Show(loai);
            string nxb = txtnxb.Text;
            string tacgia = txttg.Text;


            string sql_update;
            sql_update = "update SACH set TenSach =  N'"+ten+"', NXB = N'"+nxb+"', MaLoai  = N'"+loai+"', HinhAnh = N'" + Path.GetFileName(txthidden.Text+'1') + "', " +"TacGia = N'"+tacgia+"', DonGiaBan = '"+textBox1.Text+"' where MaSach = '" + ma + "'";
            try
            {
                cn.capnhat(sql_update, conn);
                MessageBox.Show("Cập Nhật Thành Công!");
                cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '" + imgdong + "'+HinhAnh as Image, TacGia, DonGiaBan from SACH", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult dr = open.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                txthidden.Text = open.FileName;

            } }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string sql_del = "DELETE FROM SACH WHERE MaSach = '"+ma+"'";

            try
            {
                cn.capnhat(sql_del, conn);
                MessageBox.Show("Xóa dữ liệu Thành Công!");
                cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '" + imgdong + "'+HinhAnh as Image, TacGia, DonGiaBan from SACH", conn);
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);

            }
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_edit.Enabled = true;
            button5.Enabled = true;
        }

        private void thốngKêSốLượngBánRaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLKhachHang kh = new QLKhachHang();
            kh.Show();
        }

        private void thốngKêSốLượngNhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien nv = new QLNhanVien();
            nv.Show();
        }

        private void thốngKêSốLượngBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLapHD hd = new FormLapHD();
            hd.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_add.Enabled = false;
            button5.Enabled = false;

            txtma.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //masach
            txtten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); //tensach
            txtnxb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); //nxb
            //maloai
            pictureBox1.Image = new Bitmap(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()); //hinhanh
            txttg.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); //tacgia
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); //dongiaban
        }

        private void thốngKêSốLượngBánRaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            QLKhachHang kh = new QLKhachHang();
            kh.ShowDialog();
        }

        private void thốngKêSốLượngNhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLNhanVien nv = new QLNhanVien();
            nv.ShowDialog();
        }

        private void thốngKêSốLượngBánRaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormLapHD hd = new FormLapHD();
            hd.ShowDialog();
        }

        private void btn_find_sach_Click(object sender, EventArgs e)
        {
            string data = txtfind.Text;
            cn.ShowDataGV(dataGridView1, "select MaSach, TenSach, NXB, MaLoai, '" + imgdong + "'+HinhAnh as Image, TacGia, DonGiaBan from SACH where TenSach = '"+data+"'", conn);
        }
    }
    }
