using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Services.InvoiceService.Dtos
{
    public class PrintInvoiceDto : Invoice
    {
        #region Seller

        public string Seller_Address { get; set; }
        public string Seller_Phone { get; set; }
        public string Seller_Name { get; set; }
        public string Seller_NationalId { get; set; }
        public string Seller_PostalCode { get; set; }
        public string Seller_ApprovalNo { get; set; }

        #endregion

        #region Buyer

        public string Buyer_Address { get; set; }
        public string Buyer_Phone { get; set; }
        public string Buyer_Name { get; set; }
        public string Buyer_NationalId { get; set; }
        public string Buyer_PostalCode { get; set; }
        public string Buyer_ApprovalNo { get; set; }
        public string Buyer_Tins { get; set; }

        #endregion
    }
}
