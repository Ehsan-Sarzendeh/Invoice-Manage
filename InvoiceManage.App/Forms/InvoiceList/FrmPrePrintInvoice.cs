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
                    new()
                    {
                        Id = _invoice.Id,
                        Indatim_1 = _invoice.Indatim_1,
                        Indatim_2 = _invoice.Indatim_2,
                        Inno = _invoice.Inno,
                        Inty = _invoice.Inty,
                        Inp = _invoice.Inp,
                        Ins = _invoice.Ins,
                        Tins = _invoice.Tins,
                        Tob = _invoice.Tob,
                        Tinb = _invoice.Tinb,
                        Setm = _invoice.Setm,
                        SendStatus = _invoice.SendStatus,
                        Items = _invoice.Items
                    }
                };

                var dic = new Dictionary<string, IEnumerable>
                {
                    { @"Invoice", dto},
                    { @"InvoiceItemList", _invoice.Items}
                };

                "Invoice.mrt".MakeReport(saveDialog.FileName, dic);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
