using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStep : UserControl
    {
        public ItemStep()
        {
            InitializeComponent();

            PanelSlider.Controls.Add(new ItemStepAdd());
            PanelSlider.Controls.Add(new ItemStepList());
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "ItemStep", "BuyerStep", "BuyerStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "ItemStep", "SumStep", "SumStep");
        }

        private void TabAdd_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("ItemStepAdd", false)[0].BringToFront();
        }

        private void TabList_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("ItemStepList", false)[0].BringToFront();
        }
    }
}
