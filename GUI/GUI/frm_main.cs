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


namespace GUI
{
    public partial class frm_main : Form
    {
        
        Frm_hangsx hsx = null;
        Frm_khachhang kh = null;
        Frm_nhanvien nv = null;
        Frm_hoadon hd = null;
        FRM_taikhoan tk = null;
        Frm_sanpham sp = null;
        Frm_saoluuphuchoi slph = null;
        Frm_baocao bc = null;

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        string MaNV = "";
        string MatKhau = "";

        public frm_main(string MaNV, string MatKhau)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        public void QuanLy()
        {
            
            lblTrangThai.Text = "Quản lý"  ;
            
        }
        public void NhanVien()
        {
            btn_nv.Enabled = false;
            btn_tk.Enabled = false;
            btn_hangsx.Enabled = false;
            button8.Enabled = false;
            lblTrangThai.Text = "Nhân viên"  ;
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            
            if (MaNV == "NV001"||MaNV=="NV003"||MaNV=="NV005"||MaNV=="NV007"|| MaNV == "NV009"|| MaNV == "NV011"|| MaNV == "NV013")
            {
                QuanLy();
            }
            else
            {
                NhanVien();
            }
            
        }
        

        

        private void bar_dx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_dangnhap fDN = new Frm_dangnhap();
            fDN.Show();
            this.Hide();
        }

        private void bar_t_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bar_tk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tk == null || tk.IsDisposed)
            {
                tk = new FRM_taikhoan();
                tk.MdiParent = this;
                tk.Show();
            }
            else
                tk.Activate();
        }

        private void bar_nv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nv == null || nv.IsDisposed)
            {
                nv = new Frm_nhanvien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
                nv.Activate();
        }

        private void bar_kh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kh == null || kh.IsDisposed)
            {
                kh = new Frm_khachhang();
                kh.MdiParent = this;
                kh.Show();
            }
            else
                kh.Activate();
        }

        private void bar_hsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hsx == null || hsx.IsDisposed)
            {
                hsx = new Frm_hangsx();
                hsx.MdiParent = this;
                hsx.Show();
            }
            else
                hsx.Activate();
        }

        private void bar_sp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sp == null || sp.IsDisposed)
            {
                sp = new Frm_sanpham();
                sp.MdiParent = this;
                sp.Show();
            }
            else
                sp.Activate();
        }

        private void bar_hd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hd == null || hd.IsDisposed)
            {
                hd = new Frm_hoadon();
                hd.MdiParent = this;
                hd.Show();
            }
            else
                hd.Activate();
        }

        private void bar_bc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bc == null || bc.IsDisposed)
            {
                bc = new Frm_baocao();
                bc.MdiParent = this;
                bc.Show();
            }
            else
                bc.Activate();
        }

        private void bar_slph_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (slph == null || slph.IsDisposed)
            {
                slph = new Frm_saoluuphuchoi();
                slph.MdiParent = this;
                slph.Show();
            }
            else
                slph.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_taikhoan(), sender);
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_nhanvien(), sender);
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_khachhang(), sender);
        }

        private void btn_hangsx_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_hangsx(), sender);
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_sanpham(), sender);
        }

        private void btn_hd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_hoadon(), sender);
        }

        private void btn_bc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_baocao(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_saoluuphuchoi(), sender);
        }

        private void btn_dx_Click(object sender, EventArgs e)
        {
            Frm_dangnhap fDN = new Frm_dangnhap();
            fDN.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "TRANG CHỦ";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
