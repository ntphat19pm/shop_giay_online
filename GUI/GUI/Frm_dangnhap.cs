using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Frm_dangnhap : Form
    {
        public Frm_dangnhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        frm_main fm;

        private void btn_dangnhap_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.OK;
            SqlConnection cn = new SqlConnection(@"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QLMT;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where MANV='" + txt_MaNV.Text + "' and MATKHAU ='" + DataProvider.MD5(txt_MatKhau.Text) + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                fm=new frm_main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                fm.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_dangnhap_KeyDown(object sender, KeyEventArgs e)
        { 
        }

        private void txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }
    }
}
