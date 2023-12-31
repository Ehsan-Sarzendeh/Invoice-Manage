using InvoiceManage.App.Services.Infrastructures;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoiceList
{
    public partial class FrmInvoiceList : Form
    {
        public FrmInvoiceList()
        {
            InitializeComponent();
        }

        private void FrmInvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Show();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void FrmInvoiceList_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
