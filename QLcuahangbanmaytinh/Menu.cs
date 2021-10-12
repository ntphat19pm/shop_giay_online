using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLcuahangbanmaytinh
{
    public partial class frmMenu : Form
    {
        string MaNV = "";
        string MatKhau = "";
        public frmMenu()
        {
            InitializeComponent();
            //this.MaNV = MaNV;
            //this.MatKhau = MatKhau;
        }
        public void user()
        {
            thôngTinNhàCungCấpToolStripMenuItem.Enabled = false;
            thôngTinNhàCungCấpToolStripMenuItem1.Enabled = false;
            thôngTinNhânViênToolStripMenuItem.Enabled = false;
            thôngTinNhânViênToolStripMenuItem1.Enabled = false;
            thốngKêToolStripMenuItem.Enabled = false;
            hóaĐơnNhậpToolStripMenuItem.Enabled = false;
            lbltrangthai.Text = "'Nhân viên";

        }
        public void admin()
        {
            lbltrangthai.Text = "'Quản lý";
        }

        public int i = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Left += i;
            if (label1.Left >= this.Width - label1.Width || label1.Left <= 0)
                i = -i;
        }

        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        public void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLthongtinmaytinh frm = new frmQLthongtinmaytinh();
            frm.Show();
            this.Hide();
        }

        public void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.Show();
            this.Hide();
        }

        public void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhacungcap frm = new frmnhacungcap();
            frm.Show();
            this.Hide();
        }

        public void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonnhap frm = new frmhoadonnhap();
            frm.Show();
            this.Hide();
        }

        public void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonban frm = new frmhoadonban();
            frm.Show();
            this.Hide();
        }

        public void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.Show();
            this.Hide();
        }

        public void thôngTinMáyTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkthongtinmaytinh frm = new frmtkthongtinmaytinh();
            frm.Show();
            this.Hide();
        }

        public void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtknhanvien frm = new frmtknhanvien();
            frm.Show();
            this.Hide();
        }

        public void thôngTinNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkncc frm = new frmtkncc();
            frm.Show();
            this.Hide();
        }

        public void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtkkhachhang frm = new frmtkkhachhang();
            frm.Show();
            this.Hide();
        }

        public void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        public void quayLaijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangnhap tc = new frmdangnhap();
            tc.Show();
            this.Hide();
        }

        public void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongke frm = new frmthongke();
            frm.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (MaNV == "NV001")
            {
                admin();
            }
            else
            {
                user();
            }
            



        }
    }
    }
