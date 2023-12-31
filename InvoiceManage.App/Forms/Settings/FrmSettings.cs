using System.Windows.Forms;
using InvoiceManage.App.Forms.Settings.Controls;

namespace InvoiceManage.App.Forms.Settings
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

            PanelSlider.Controls.Add(new ProductSettings());
            PanelSlider.Controls.Add(new CustomerSettings());
            PanelSlider.Controls.Add(new CompanySettings());
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Show();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnProduct_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnCompany_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnCustomer_Click(object sender, System.EventArgs e)
        {

        }
    }
}
