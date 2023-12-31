using System.Collections.Generic;
using System.Linq;
using InvoiceManage.Database.Contexts;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        public List<Invoice> GetInvoices()
        {
            using var db = new SqliteDbContext();
            return db.Invoice.ToList();
        }

        public void DeleteInvoice(long invoiceId)
        {
            using var db = new SqliteDbContext();
            var invoice = db.Invoice.Single(x => x.Id == invoiceId);
            db.Invoice.Remove(invoice);
            db.SaveChanges();
        }
    }
}
