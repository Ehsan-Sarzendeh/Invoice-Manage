using InvoiceManage.Database.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManage.Database.Entities
{
    public class InvoiceItem : BaseEntity
    {
        public long InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        [Display(Name = "مبلغ کل کالا و خدمت")]
        public decimal Tsstam { get; set; }
        [Display(Name = "تفاوت نرخ خرید  فروش ارز/ کارمزد")]
        public decimal Pspd { get; set; }

        [Display(Name = "شناسه کالا/ خدمت")]
        public string SstId { get; set; }
        [Display(Name = "شرح کالا خدمت")]
        public string Sstt { get; set; }
        [Display(Name = "تعداد / مقدار")]
        public decimal Am { get; set; }
        
        [Display(Name = "واحد اندازه گیری")]
        public string Mu { get; set; }
        
        [Display(Name = "وزن خالص")]
        public decimal Nw { get; set; }
        [Display(Name = "مبلغ واحد")]
        public decimal Fee { get; set; }
        [Display(Name = "میزان ارز")]
        public decimal CFee { get; set; }
        [Display(Name = "کد نوع ارز")]
        public string Cut { get; set; }
        [Display(Name = "نرخ برابری ارز با ریال")]
        public decimal Exr { get; set; }
        [Display(Name = "ارزش ریالی کالا")]
        public decimal Ssrv { get; set; }
        [Display(Name = "ارزش ارزی کالا")]
        public decimal Sscv { get; set; }
        [Display(Name = "مبلغ قبل از تخفیف")]
        public decimal Prdis { get; set; }
        [Display(Name = "مبلغ تخفیف")]
        public decimal Dis { get; set; }
        [Display(Name = "مبلغ بعد از تخفیف")]
        public decimal Adis { get; set; }
        [Display(Name = "نرخ مالیات بر ارزش افزوده")]
        public double Vra { get; set; }
        [Display(Name = "مبلغ مالیات بر ارزش افزوده")]
        public decimal Vam { get; set; }
        [Display(Name = "موضوع سایر مالیات و عوارض")]
        public string Odt { get; set; }
        [Display(Name = "نرخ سایر مالیات و عوارض")]
        public double Odr { get; set; }
        [Display(Name = "مبلغ سایر مالیات و عوارض")]
        public decimal Odam { get; set; }
        [Display(Name = "موضوع سایر وجوه قانونی")]
        [StringLength(255)]
        public string Olt { get; set; }
        [Display(Name = "نرخ سایر وجوه قانونی")]
        public double Olr { get; set; }
        [Display(Name = "مبلغ سایر وجوه قانونی")]
        public decimal Olam { get; set; }
        [Display(Name = "اجرت ساخت")]
        public decimal Consfee { get; set; }
        [Display(Name = "سود فروشنده")]
        public decimal Spro { get; set; }
        [Display(Name = "حق العمل")]
        public decimal Bros { get; set; }
        [Display(Name = "جمع کل اجرت، حق العمل و سود")]
        public decimal Tcpbs { get; set; }
        [Display(Name = "سهم نقدی از پرداخت")]
        public decimal Cop { get; set; }
        [Display(Name = "سهم مالیات بر ارزش افزوده از پرداخت")]
        public decimal Vop { get; set; }
        
        public string Mu_1 { get; set; }

        public string Bsrn { get; set; }
    }
}
