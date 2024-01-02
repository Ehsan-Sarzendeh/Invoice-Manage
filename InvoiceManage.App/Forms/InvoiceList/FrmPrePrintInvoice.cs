using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoiceList
{
    public partial class FrmPrePrintInvoice : Form
    {
        public FrmPrePrintInvoice()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF File|*.pdf";
            saveDialog.ShowDialog();

            // if (saveDialog.FileName != "")
            // {
            //     var dto = new List<PrintInvoiceDto>
            //     {
            //         new()
            //         {
            //             Invoices_Id = _invoice.Invoices_Id,
            //             Indatim_1 = _invoice.Indatim_1,
            //             Indatim_2 = _invoice.Indatim_2,
            //             Inno = _invoice.Inno,
            //             Inty = _invoice.Inty,
            //             Inp = _invoice.Inp,
            //             Ins = _invoice.Ins,
            //             Tins = _invoice.Tins,
            //             Tob = _invoice.Tob,
            //             Tinb = _invoice.Tinb,
            //             Tprdis = _invoice.Tprdis,
            //             Tadis = _invoice.Tadis,
            //             Tvam = _invoice.Tvam,
            //             Todam = _invoice.Todam,
            //             Tbill = _invoice.Tbill,
            //             Setm = _invoice.Setm,
            //             SendStatus = _invoice.SendStatus,
            //             Index = _invoice.Index,
            //             InvoiceItems = _invoice.InvoiceItems,
            //             Buyer_Address = addressTxt.Text,
            //             Buyer_Phone = phoneTxt.Text
            //         }
            //     };
            //
            //     var dic = new Dictionary<string, IEnumerable>
            //     {
            //         { @"Invoice", dto},
            //         { @"InvoiceItemList", _invoice.InvoiceItems}
            //     };

            // "Invoice.mrt".MakeReport(saveDialog.FileName, dic);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
