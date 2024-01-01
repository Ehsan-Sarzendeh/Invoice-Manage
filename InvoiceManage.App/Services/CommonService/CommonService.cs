﻿using System;
using System.Collections.Generic;
using System.Linq;
using InvoiceManage.Database.Contexts;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.CommonService
{
    public class CommonService : ICommonService, IDisposable
    {
        public override List<Product> GetProducts()
        {
            using var db = new SqliteDbContext();
            return db.Product.ToList();
        }

        public override List<Company> GetCompanies()
        {
            using var db = new SqliteDbContext();
            return db.Company.ToList();
        }

        public override List<Customer> GetCustomers()
        {
            using var db = new SqliteDbContext();
            return db.Customer.ToList();
        }

        public override void AddProduct(Product product)
        {
            using var db = new SqliteDbContext();
            db.Product.Add(product);
            db.SaveChanges();
        }

        public override void AddCompany(Company company)
        {
            using var db = new SqliteDbContext();
            db.Company.Add(company);
            db.SaveChanges();
        }

        public override void AddCustomer(Customer customer)
        {
            using var db = new SqliteDbContext();
            db.Customer.Add(customer);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
