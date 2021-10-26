using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_saoluuphuchoi : Form
    {
        public Frm_saoluuphuchoi()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txt_server.Text));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = txt_database.Text };
                dbBackup.Devices.AddDevice(@"D:\DPM185170_DANGQUANGMINH\QLĐT.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblstatus.Invoke((MethodInvoker)delegate
                    {
                        lblstatus.Text = e.Error.Message;
                    });
               
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value = e.Percent;
                    progressBar.Update();
                });
            lblpercent.Invoke((MethodInvoker)delegate
                {
                    lblpercent.Text = $"{e.Percent}%";
                });
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txt_server.Text));
                Restore dbRestore = new Restore() { Database = txt_database.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(@"D:\DPM185170_DANGQUANGMINH\QLĐT.bak", DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblstatus.Invoke((MethodInvoker)delegate
                {
                    lblstatus.Text = e.Error.Message;
                });

            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblpercent.Invoke((MethodInvoker)delegate
            {
                lblpercent.Text = $"{e.Percent}%";
            });
        }

        private void Frm_saoluuphuchoi_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }
    }
}
