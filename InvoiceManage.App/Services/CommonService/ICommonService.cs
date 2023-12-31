using System.Collections.Generic;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.CommonService
{
    public interface ICommonService
    {
        List<Product> GetProducts();
        List<Company> GetCompanies();
        List<Customer> GetCustomers();
        void AddProduct(Product product);
        void AddCompany(Company company);
        void AddCustomer(Customer customer);
    }
}
