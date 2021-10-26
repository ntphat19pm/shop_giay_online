
namespace GUI
{
    partial class frm_main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dx = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_bc = new System.Windows.Forms.Button();
            this.btn_hd = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_hangsx = new System.Windows.Forms.Button();
            this.btn_kh = new System.Windows.Forms.Button();
            this.btn_nv = new System.Windows.Forms.Button();
            this.btn_tk = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(56, 17);
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Tài khoản";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(98)))));
            this.panelMenu.Controls.Add(this.btn_thoat);
            this.panelMenu.Controls.Add(this.btn_dx);
            this.panelMenu.Controls.Add(this.button8);
            this.panelMenu.Controls.Add(this.btn_bc);
            this.panelMenu.Controls.Add(this.btn_hd);
            this.panelMenu.Controls.Add(this.btn_sp);
            this.panelMenu.Controls.Add(this.btn_hangsx);
            this.panelMenu.Controls.Add(this.btn_kh);
            this.panelMenu.Controls.Add(this.btn_nv);
            this.panelMenu.Controls.Add(this.btn_tk);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 543);
            this.panelMenu.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_thoat.Image = global::GUI.Properties.Resources.cancel_32x32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(0, 480);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_thoat.Size = new System.Drawing.Size(220, 45);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dx
            // 
            this.btn_dx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dx.FlatAppearance.BorderSize = 0;
            this.btn_dx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dx.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dx.Image = global::GUI.Properties.Resources.logout32;
            this.btn_dx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dx.Location = new System.Drawing.Point(0, 435);
            this.btn_dx.Name = "btn_dx";
            this.btn_dx.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_dx.Size = new System.Drawing.Size(220, 45);
            this.btn_dx.TabIndex = 9;
            this.btn_dx.Text = "Đăng xuất";
            this.btn_dx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dx.UseVisualStyleBackColor = true;
            this.btn_dx.Click += new System.EventHandler(this.btn_dx_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Image = global::GUI.Properties.Resources.icons8_data_backup_32;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 390);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(220, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "Sao lưu phục hồi";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_bc
            // 
            this.btn_bc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bc.FlatAppearance.BorderSize = 0;
            this.btn_bc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_bc.Image = global::GUI.Properties.Resources.patient_information;
            this.btn_bc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bc.Location = new System.Drawing.Point(0, 345);
            this.btn_bc.Name = "btn_bc";
            this.btn_bc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_bc.Size = new System.Drawing.Size(220, 45);
            this.btn_bc.TabIndex = 7;
            this.btn_bc.Text = "Báo cáo";
            this.btn_bc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bc.UseVisualStyleBackColor = true;
            this.btn_bc.Click += new System.EventHandler(this.btn_bc_Click);
            // 
            // btn_hd
            // 
            this.btn_hd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hd.FlatAppearance.BorderSize = 0;
            this.btn_hd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_hd.Image = global::GUI.Properties.Resources.action_item_list;
            this.btn_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hd.Location = new System.Drawing.Point(0, 300);
            this.btn_hd.Name = "btn_hd";
            this.btn_hd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_hd.Size = new System.Drawing.Size(220, 45);
            this.btn_hd.TabIndex = 6;
            this.btn_hd.Text = "Hoá đơn";
            this.btn_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hd.UseVisualStyleBackColor = true;
            this.btn_hd.Click += new System.EventHandler(this.btn_hd_Click);
            // 
            // btn_sp
            // 
            this.btn_sp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sp.FlatAppearance.BorderSize = 0;
            this.btn_sp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sp.Image = global::GUI.Properties.Resources.icons8_mobile_phone_32;
            this.btn_sp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sp.Location = new System.Drawing.Point(0, 255);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_sp.Size = new System.Drawing.Size(220, 45);
            this.btn_sp.TabIndex = 5;
            this.btn_sp.Text = "Sản phẩm";
            this.btn_sp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sp.UseVisualStyleBackColor = true;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // btn_hangsx
            // 
            this.btn_hangsx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hangsx.FlatAppearance.BorderSize = 0;
            this.btn_hangsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hangsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hangsx.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_hangsx.Image = global::GUI.Properties.Resources.world;
            this.btn_hangsx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hangsx.Location = new System.Drawing.Point(0, 210);
            this.btn_hangsx.Name = "btn_hangsx";
            this.btn_hangsx.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_hangsx.Size = new System.Drawing.Size(220, 45);
            this.btn_hangsx.TabIndex = 4;
            this.btn_hangsx.Text = "Hãng sản xuất";
            this.btn_hangsx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hangsx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hangsx.UseVisualStyleBackColor = true;
            this.btn_hangsx.Click += new System.EventHandler(this.btn_hangsx_Click);
            // 
            // btn_kh
            // 
            this.btn_kh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kh.FlatAppearance.BorderSize = 0;
            this.btn_kh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_kh.Image = global::GUI.Properties.Resources.iconfinder_Customer_Male_Light_80830;
            this.btn_kh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kh.Location = new System.Drawing.Point(0, 165);
            this.btn_kh.Name = "btn_kh";
            this.btn_kh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_kh.Size = new System.Drawing.Size(220, 45);
            this.btn_kh.TabIndex = 3;
            this.btn_kh.Text = "Khách hàng";
            this.btn_kh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kh.UseVisualStyleBackColor = true;
            this.btn_kh.Click += new System.EventHandler(this.btn_kh_Click);
            // 
            // btn_nv
            // 
            this.btn_nv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nv.FlatAppearance.BorderSize = 0;
            this.btn_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nv.Image = global::GUI.Properties.Resources.users32_2;
            this.btn_nv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nv.Location = new System.Drawing.Point(0, 120);
            this.btn_nv.Name = "btn_nv";
            this.btn_nv.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_nv.Size = new System.Drawing.Size(220, 45);
            this.btn_nv.TabIndex = 2;
            this.btn_nv.Text = "Nhân viên";
            this.btn_nv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nv.UseVisualStyleBackColor = true;
            this.btn_nv.Click += new System.EventHandler(this.btn_nv_Click);
            // 
            // btn_tk
            // 
            this.btn_tk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tk.FlatAppearance.BorderSize = 0;
            this.btn_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_tk.Image = global::GUI.Properties.Resources.allowuserstoeditranges_32x32;
            this.btn_tk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tk.Location = new System.Drawing.Point(0, 75);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_tk.Size = new System.Drawing.Size(220, 45);
            this.btn_tk.TabIndex = 1;
            this.btn_tk.Text = "Tài Khoản";
            this.btn_tk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Máy Tính Q.M";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(693, 90);
            this.panelTitleBar.TabIndex = 7;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::GUI.Properties.Resources.delete32;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 90);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(271, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang Chủ";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::GUI.Properties.Resources.image_1534_;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 90);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(693, 453);
            this.panelDesktopPane.TabIndex = 8;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 565);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_main";
            this.Text = "Cửa hàng bán điện thoại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dx;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_bc;
        private System.Windows.Forms.Button btn_hd;
        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_hangsx;
        private System.Windows.Forms.Button btn_kh;
        private System.Windows.Forms.Button btn_nv;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}

