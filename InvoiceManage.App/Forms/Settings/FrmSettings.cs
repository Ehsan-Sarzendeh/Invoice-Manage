using System.Drawing;
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

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {
            BtnProduct.Focus();

            BtnProduct.BackColor = Color.White;
            BtnProduct.ForeColor = Color.FromArgb(68, 68, 68);

            BtnCompany.BackColor = Color.FromArgb(68, 68, 68);
            BtnCompany.ForeColor = Color.White;

            BtnCustomer.BackColor = Color.FromArgb(68, 68, 68);
            BtnCustomer.ForeColor = Color.White;
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
            PanelSlider.Controls.Find("ProductSettings", false)[0].BringToFront();
            if (BtnProduct.Focused)
            {
                BtnProduct.BackColor = Color.White;
                BtnProduct.ForeColor = Color.FromArgb(68, 68, 68);

                BtnCompany.BackColor = Color.FromArgb(68, 68, 68);
                BtnCompany.ForeColor = Color.White;

                BtnCustomer.BackColor = Color.FromArgb(68, 68, 68);
                BtnCustomer.ForeColor = Color.White;
            }
        }

        private void BtnCompany_Click(object sender, System.EventArgs e)
        {
            PanelSlider.Controls.Find("CompanySettings", false)[0].BringToFront();

            if (BtnCompany.Focused)
            {
                BtnProduct.BackColor = Color.FromArgb(68, 68, 68);
                BtnProduct.ForeColor = Color.White;

                BtnCompany.BackColor = Color.White;
                BtnCompany.ForeColor = Color.FromArgb(68, 68, 68);

                BtnCustomer.BackColor = Color.FromArgb(68, 68, 68);
                BtnCustomer.ForeColor = Color.White;
            }
        }

        private void BtnCustomer_Click(object sender, System.EventArgs e)
        {
            PanelSlider.Controls.Find("CustomerSettings", false)[0].BringToFront();

            if (BtnCustomer.Focused)
            {
                BtnProduct.BackColor = Color.FromArgb(68, 68, 68);
                BtnProduct.ForeColor = Color.White;

                BtnCompany.BackColor = Color.FromArgb(68, 68, 68);
                BtnCompany.ForeColor = Color.White;

                BtnCustomer.BackColor = Color.White;
                BtnCustomer.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}
