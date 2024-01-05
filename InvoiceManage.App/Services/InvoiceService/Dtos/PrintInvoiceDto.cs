using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService.Dtos
{
    public class PrintInvoiceDto : Invoice
    {
        public PrintInvoiceDto(Invoice invoice)
        {
            Id = invoice.Id;
            TaxId = invoice.TaxId;
            Indatim = invoice.Indatim;
            Indatim_1 = invoice.Indatim_1;
            Indatim_2 = invoice.Indatim_2;
            Indatim2m = invoice.Indatim2m;
            Indatim2m_1 = invoice.Indatim2m_1;
            Indatim2m_2 = invoice.Indatim2m_2;
            Inno_1 = invoice.Inno_1;
            GenerateInno = invoice.GenerateInno;
            Irtaxid = invoice.Irtaxid;
            Tins = invoice.Tins;
            Sbc = invoice.Sbc;
            Scc = invoice.Scc;
            Crn = invoice.Crn;
            Scln = invoice.Scln;
            Bid = invoice.Bid;
            Tinb = invoice.Tinb;
            Bpc = invoice.Bpc;
            Bbc = invoice.Bbc;
            Bpn = invoice.Bpn;
            BillId = invoice.BillId;
            Cdcn = invoice.Cdcn;
            Cdcd_1 = invoice.Cdcd_1;
            Cdcd = invoice.Cdcd;
            Cap = invoice.Cap;
            Insp = invoice.Insp;
            Tax17 = invoice.Tax17;
            Iinn = invoice.Iinn;
            Acn = invoice.Acn;
            Trmn = invoice.Trmn;
            Trn = invoice.Trn;
            Pcn = invoice.Pcn;
            Pid = invoice.Pid;
            Pdt_1 = invoice.Pdt_1;
            Pdt = invoice.Pdt;
            Pdt_2 = invoice.Pdt_2;
            Pv = invoice.Pv;
            Tm = invoice.Tm;
            RefrenceNumber = invoice.RefrenceNumber;
            SendStatus = invoice.SendStatus;
            ResultStatus = invoice.ResultStatus;
            Inty = invoice.Inty;
            Inp = invoice.Inp;
            Ins = invoice.Ins;
            Tob = invoice.Tob;
            Ft = invoice.Ft;
            Pmt = invoice.Pmt;
            Setm = invoice.Setm;
            CompanyId = invoice.CompanyId;
            Company = invoice.Company;
            Items = invoice.Items;
        }

        #region Buyer

        public string Bcell { get; set; }
        public string Baddress { get; set; }

        #endregion
    }
}
