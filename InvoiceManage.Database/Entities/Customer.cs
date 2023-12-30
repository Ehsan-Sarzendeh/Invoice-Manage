using System.ComponentModel.DataAnnotations;
using InvoiceManage.Database.Entities.Common;

namespace InvoiceManage.Database.Entities
{
    public class Customer : BaseEntity
    {
        [Display(Name = "شماره /شناسه ملی")]
        public long? BId { get; set; }
        [Display(Name = "شماره اقتصادی خریدار")]
        public string Tinb { get; set; }
        [Display(Name = "نام خریدار")]
        public string Name { get; set; }
        [Display(Name = "کد پستی خریدار")]
        public string Bpc { get; set; }
        [Display(Name = "کد شعبه خریدار")]
        public string Bbc { get; set; }
        [Display(Name = "شماره گذرنامه خریدار")]
        public string Bpn { get; set; }
        [Display(Name = "شماره اشتراک/ شناسه قبض بهربرداری")]
        public string BillId { get; set; }
        [Display(Name = "سود خریدار")]
        public string Pro { get; set; }
    }
}