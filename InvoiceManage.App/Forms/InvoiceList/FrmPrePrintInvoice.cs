using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService.Dtos;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoiceList
{
    public partial class FrmPrePrintInvoice : Form
    {
        private readonly Invoice _invoice;

        public FrmPrePrintInvoice(Invoice invoice)
        {
            _invoice = invoice;
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();

            saveDialog.Filter = "PDF File|*.pdf";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                var dto = new List<PrintInvoiceDto>
                {
                    new(_invoice)
                    {
                        Baddress = TxtBaddress.Text,
                        Bcell = TxtBcell.Text
                    }
                };

                var dic = new Dictionary<string, IEnumerable>
                {
                    { @"Invoice", dto},
                    { @"InvoiceItemList", _invoice.Items}
                };

                "Invoice.mrt".MakeReport(saveDialog.FileName, dic);
            }

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
