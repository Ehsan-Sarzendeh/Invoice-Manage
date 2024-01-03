using System;
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

        public Invoice GetInvoice(int invoiceId)
        {
            using var db = new SqliteDbContext();
            return db.Invoice.Single(x => x.Id == invoiceId);
        }

        public void AddInvoice(Invoice invoice)
        {
            using var db = new SqliteDbContext();
            db.Invoice.Add(invoice);
            db.SaveChanges();
        }

        public void EditInvoice(Invoice invoice)
        {
            using var db = new SqliteDbContext();
            db.Invoice.Update(invoice);
            db.SaveChanges();
        }

        public void DeleteInvoice(long invoiceId)
        {
            using var db = new SqliteDbContext();
            var invoice = db.Invoice.Single(x => x.Id == invoiceId);
            db.Invoice.Remove(invoice);
            db.SaveChanges();
        }

        public decimal GenerateInnoCode()
        {
            using var db = new SqliteDbContext();

            var maxCode = db.Invoice.Where(x => x.GenerateInno).Max(x => x.Inno_1)  + 1;
            while (db.Invoice.Any(x => x.Inno_1 == maxCode))
                maxCode++;

            return maxCode;
        }
    }
}
