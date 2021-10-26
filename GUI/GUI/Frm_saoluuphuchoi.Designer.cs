
namespace GUI
{
    partial class Frm_saoluuphuchoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblpercent = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(147, 121);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(21, 13);
            this.lblpercent.TabIndex = 1;
            this.lblpercent.Text = "0%";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(87, 30);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(201, 20);
            this.txt_server.TabIndex = 2;
            this.txt_server.Text = "ADMINISTRATOR\\MINH";
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(87, 60);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(201, 20);
            this.txt_database.TabIndex = 3;
            this.txt_database.Text = "QLĐT";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(31, 86);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(257, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(28, 145);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 6;
            this.lblstatus.Text = "Status";
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(294, 86);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(75, 23);
            this.btn_backup.TabIndex = 7;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(375, 86);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 23);
            this.btn_restore.TabIndex = 8;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // Frm_saoluuphuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 190);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.lblpercent);
            this.Controls.Add(this.label1);
            this.Name = "Frm_saoluuphuchoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và phục hồi";
            this.Load += new System.EventHandler(this.Frm_saoluuphuchoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_restore;
    }
}