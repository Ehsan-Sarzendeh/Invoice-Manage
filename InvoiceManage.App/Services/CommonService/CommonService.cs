﻿using System;
using System.Collections.Generic;
using System.Linq;
using InvoiceManage.Database.Contexts;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.CommonService
{
    public class CommonService : ICommonService
    {
        public List<Product> GetProducts()
        {
            using var db = new SqliteDbContext();
            return db.Product.ToList();
        }

        public List<Company> GetCompanies()
        {
            using var db = new SqliteDbContext();
            return db.Company.ToList();
        }

        public List<Customer> GetCustomers()
        {
            using var db = new SqliteDbContext();
            return db.Customer.ToList();
        }

        public void AddProduct(Product product)
        {
            using var db = new SqliteDbContext();
            db.Product.Add(product);
            db.SaveChanges();
        }

        public void AddCompany(Company company)
        {
            using var db = new SqliteDbContext();
            db.Company.Add(company);
            db.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            using var db = new SqliteDbContext();
            db.Customer.Add(customer);
            db.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            using var db = new SqliteDbContext();
            db.Product.Update(product);
            db.SaveChanges();
        }

        public void EditCompany(Company company)
        {
            using var db = new SqliteDbContext();
            db.Company.Update(company);
            db.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            using var db = new SqliteDbContext();
            db.Customer.Update(customer);
            db.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            using var db = new SqliteDbContext();
            db.Product.Remove(product);
            db.SaveChanges();
        }

        public void DeleteCompany(Company company)
        {
            using var db = new SqliteDbContext();
            db.Company.Remove(company);
            db.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            using var db = new SqliteDbContext();
            db.Customer.Remove(customer);
            db.SaveChanges();
        }
    }
}
