using System;
using System.Drawing;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.InvoiceService;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStep : UserControl
    {
        public ItemStep(ICommonService commonService, IInvoiceService invoiceService)
        {
            InitializeComponent();

            PanelSlider.Controls.Add(new ItemStepAdd(commonService));
            PanelSlider.Controls.Add(new ItemStepList(invoiceService));
        }

        #region Events

        public void TabAdd_Click(object sender, EventArgs e)
        {
            TabAdd.BackgroundColor = Color.PeachPuff;
            TabList.BackgroundColor = Color.LightGray;

            PanelSlider.Controls.Find("ItemStepAdd", false)[0].BringToFront();
        }

        public void TabList_Click(object sender, EventArgs e)
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
            var step = new Step().Next(ParentForm!, "ItemStep", "SumStep", "SumStep");

            var sumStep = step as SumStep;

            sumStep!.SetComputedProperties();
        }

        #endregion
    }
}
