using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.CommonService
{
    public interface ICommonService
    {
        public List<Product> GetProducts();
        public List<Company> GetCompanies();
        public List<Customer> GetCustomers();
        public void AddProduct(Product product);
        public void AddCompany(Company company);
        public void AddCustomer(Customer customer);
    }
}