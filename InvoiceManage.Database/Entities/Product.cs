using InvoiceManage.Database.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManage.Database.Entities
{
    public class Product : BaseEntity
    {
        [Display(Name = "شناسه کالا/خدمت")]
        public string Sstid { get; set; }
        [Display(Name = "شرح کالا خدمت")] 
        public string Sstt { get; set; }
        [Display(Name = "نرخ مالیات بر ارزش افزوده")] 
        public double Vra { get; set; }
        
        public string InternalCode { get; set; }
    }
}
