namespace QLSach
{
    partial class QLKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNu = new System.Windows.Forms.CheckBox();
            this.checkBoxNam = new System.Windows.Forms.CheckBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_del_kh = new System.Windows.Forms.Button();
            this.btn_add_kh = new System.Windows.Forms.Button();
            this.btn_edit_kh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxNu);
            this.groupBox1.Controls.Add(this.checkBoxNam);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // checkBoxNu
            // 
            this.checkBoxNu.AutoSize = true;
            this.checkBoxNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNu.Location = new System.Drawing.Point(240, 232);
            this.checkBoxNu.Name = "checkBoxNu";
            this.checkBoxNu.Size = new System.Drawing.Size(48, 24);
            this.checkBoxNu.TabIndex = 6;
            this.checkBoxNu.Text = "Nữ";
            this.checkBoxNu.UseVisualStyleBackColor = true;
            // 
            // checkBoxNam
            // 
            this.checkBoxNam.AutoSize = true;
            this.checkBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNam.Location = new System.Drawing.Point(126, 232);
            this.checkBoxNam.Name = "checkBoxNam";
            this.checkBoxNam.Size = new System.Drawing.Size(61, 24);
            this.checkBoxNam.TabIndex = 6;
            this.checkBoxNam.Text = "Nam";
            this.checkBoxNam.UseVisualStyleBackColor = true;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(127, 138);
            this.txtdc.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(203, 20);
            this.txtdc.TabIndex = 4;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(127, 188);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(203, 20);
            this.txtsdt.TabIndex = 5;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(127, 88);
            this.txthoten.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(203, 20);
            this.txthoten.TabIndex = 3;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(127, 38);
            this.txtma.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(203, 20);
            this.txtma.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập Tên Khách Hàng Cần Tìm: ";
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(620, 9);
            this.txtFind.Margin = new System.Windows.Forms.Padding(0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(170, 29);
            this.txtFind.TabIndex = 1;
            // 
            // btn_find
            // 
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_find.FlatAppearance.BorderSize = 2;
            this.btn_find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_find.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(805, 9);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(82, 33);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "Tìm";
            this.btn_find.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_del_kh);
            this.groupBox2.Controls.Add(this.btn_add_kh);
            this.groupBox2.Controls.Add(this.btn_edit_kh);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(29, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(301, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "LƯU THÔNG TIN";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(29, 194);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(301, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "THOÁT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_del_kh
            // 
            this.btn_del_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del_kh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_del_kh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_del_kh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_kh.Location = new System.Drawing.Point(29, 109);
            this.btn_del_kh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_del_kh.Name = "btn_del_kh";
            this.btn_del_kh.Size = new System.Drawing.Size(301, 35);
            this.btn_del_kh.TabIndex = 6;
            this.btn_del_kh.Text = "XÓA KHÁCH HÀNG";
            this.btn_del_kh.UseVisualStyleBackColor = true;
            this.btn_del_kh.Click += new System.EventHandler(this.btn_del_kh_Click);
            // 
            // btn_add_kh
            // 
            this.btn_add_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_kh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_add_kh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_add_kh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_kh.Location = new System.Drawing.Point(29, 19);
            this.btn_add_kh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_kh.Name = "btn_add_kh";
            this.btn_add_kh.Size = new System.Drawing.Size(301, 35);
            this.btn_add_kh.TabIndex = 4;
            this.btn_add_kh.Text = "THÊM KHÁCH HÀNG";
            this.btn_add_kh.UseVisualStyleBackColor = true;
            this.btn_add_kh.Click += new System.EventHandler(this.btn_add_kh_Click);
            // 
            // btn_edit_kh
            // 
            this.btn_edit_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_kh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_edit_kh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_edit_kh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_kh.Location = new System.Drawing.Point(29, 64);
            this.btn_edit_kh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit_kh.Name = "btn_edit_kh";
            this.btn_edit_kh.Size = new System.Drawing.Size(301, 35);
            this.btn_edit_kh.TabIndex = 5;
            this.btn_edit_kh.Text = "SỬA KHÁCH HÀNG";
            this.btn_edit_kh.UseVisualStyleBackColor = true;
            this.btn_edit_kh.Click += new System.EventHandler(this.btn_edit_kh_Click);
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label6);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_kh;
        private System.Windows.Forms.Button btn_edit_kh;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_del_kh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxNu;
        private System.Windows.Forms.CheckBox checkBoxNam;
    }
}