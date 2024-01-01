using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.CommonService
{
    public abstract class ICommonService
    {
        public abstract List<Product> GetProducts();
        public abstract List<Company> GetCompanies();
        public abstract List<Customer> GetCustomers();
        public abstract void AddProduct(Product product);
        public abstract void AddCompany(Company company);
        public abstract void AddCustomer(Customer customer);
    }
}
