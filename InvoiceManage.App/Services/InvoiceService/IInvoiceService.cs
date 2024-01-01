using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService
{
    public interface IInvoiceService
    {
        List<Invoice> GetInvoices();
        Invoice GetInvoice(int invoiceId);
        void DeleteInvoice(long invoiceId);
    }
}
