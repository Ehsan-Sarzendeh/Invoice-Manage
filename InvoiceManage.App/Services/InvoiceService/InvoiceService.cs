using System.Collections.Generic;
using System.Linq;
using InvoiceManage.Database.Contexts;
using InvoiceManage.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManage.App.Services.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        public List<Invoice> GetInvoices()
        {
            using var db = new SqliteDbContext();
            return db.Invoice.ToList();
        }

        public Invoice GetInvoice(int invoiceId)
        {
            using var db = new SqliteDbContext();
            return db.Invoice.Include(x => x.Items).Single(x => x.Id == invoiceId);
        }

        public void AddInvoice(Invoice invoice)
        {
            using var db = new SqliteDbContext();
            invoice.Id = 0;
            foreach (var t in invoice.Items) t.Id = 0;
            db.Invoice.Add(invoice);
            db.SaveChanges();
        }

        public void EditInvoice(Invoice invoice)
        {
            using var db = new SqliteDbContext();
            db.InvoiceItem.UpdateRange(invoice.Items);
            db.Invoice.Update(invoice);
            db.SaveChanges();
        }

        public void DeleteInvoice(Invoice invoice)
        {
            using var db = new SqliteDbContext();
            db.InvoiceItem.RemoveRange(invoice.Items);
            db.Invoice.Remove(invoice);
            db.SaveChanges();
        }

        public void DeleteInvoice(long invoiceId)
        {
            using var db = new SqliteDbContext();
            var invoice = db.Invoice.Include(x => x.Items).Single(x => x.Id == invoiceId);
            db.InvoiceItem.RemoveRange(invoice.Items);
            db.Invoice.Remove(invoice);
            db.SaveChanges();
        }

        public long GenerateInnoCode()
        {
            using var db = new SqliteDbContext();

            long maxCode;

            if (!db.Invoice.Any(x => x.GenerateInno))
                maxCode = 1;
            else
                maxCode = db.Invoice.Where(x => x.GenerateInno).Max(x => x.Inno_1)  + 1;

            while (db.Invoice.Any(x => x.Inno_1 == maxCode))
                maxCode++;

            return maxCode;
        }
    }
}
