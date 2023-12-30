using System.Windows.Forms;

namespace InvoiceManage.App.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Show();
        }
    }
}
