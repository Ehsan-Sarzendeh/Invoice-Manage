using System;
using System.Drawing;
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

        #region Events

        private void TabAdd_Click(object sender, EventArgs e)
        {
            TabAdd.BackgroundColor = Color.PeachPuff;
            TabList.BackgroundColor = Color.LightGray;

            PanelSlider.Controls.Find("ItemStepAdd", false)[0].BringToFront();
        }

        private void TabList_Click(object sender, EventArgs e)
        {
            TabAdd.BackgroundColor = Color.LightGray;
            TabList.BackgroundColor = Color.PeachPuff;

            PanelSlider.Controls.Find("ItemStepList", false)[0].BringToFront();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "ItemStep", "CustomerStep", "CustomerStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "ItemStep", "SumStep", "SumStep");
        }

        #endregion
    }
}
