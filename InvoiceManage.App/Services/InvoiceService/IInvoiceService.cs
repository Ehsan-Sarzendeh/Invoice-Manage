using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService
{
    public interface IInvoiceService
    {
        List<Invoice> GetInvoices();
        void DeleteInvoice(long invoiceId);
    }
}
