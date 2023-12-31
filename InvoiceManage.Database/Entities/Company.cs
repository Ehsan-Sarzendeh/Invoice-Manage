using System.ComponentModel.DataAnnotations;
using InvoiceManage.Database.Entities.Common;

namespace InvoiceManage.Database.Entities
{
    public class Company : BaseEntity
    {
        [Display(Name = "شماره اقتصادی فروشنده")]
        public string Tins { get; set; }
        [Display(Name = "نام شرکت")]
        public string Name { get; set; }
        [Display(Name = "کد شعبه فروشنده")]
        public string Sbc { get; set; }
        [Display(Name = "شماره پروانه گمرکی")]
        public string Scln { get; set; }
        [Display(Name = "شناسه یکتای ثبت قرارداد فروشنده")]
        public string Crn { get; set; }
        [Display(Name = "سود شرکت")]
        public string Pro { get; set; }
    }
}