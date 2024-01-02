using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStepList : UserControl
    {
        public ItemStepList()
        {
            InitializeComponent();
        }

        private void ItemStepList_Load(object sender, System.EventArgs e)
        {
            SetDataBindings();
        }

        public void SetDataBindings()
        {
            var parentForm = ParentForm! as FrmInvoice;
            GvItems.DataSource = parentForm!.Invoice.Items;
        }
    }
}
