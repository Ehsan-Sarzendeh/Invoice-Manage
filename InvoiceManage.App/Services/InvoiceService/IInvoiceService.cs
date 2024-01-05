using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService
{
    public interface IInvoiceService
    {
        List<Invoice> GetInvoices();
        Invoice GetInvoice(int invoiceId);
        void AddInvoice(Invoice invoice);
        void EditInvoice(Invoice invoice);
        void DeleteInvoice(Invoice invoice);
        void DeleteInvoice(long invoiceId);

        void EditInvoiceItem(InvoiceItem invoiceItem);
        void DeleteInvoiceItem(InvoiceItem invoiceItem);

        long GenerateInnoCode();
    }
}
