using InvoiceManage.Database.Entities.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using InvoiceManage.Database.Infrastructures;

namespace InvoiceManage.Database.Entities
{
    public class InvoiceItem : BaseEntity
    {
        [Browsable(false)]
        public long InvoiceId { get; set; }
        [Browsable(false)]
        public Invoice Invoice { get; set; }

        [Display(Name = "مبلغ کل کالا و خدمت")]
        public decimal Tsstam => Vam + Adis + Odam + Olam;
        [Display(Name = "تفاوت نرخ خرید  فروش ارز/ کارمزد")]
        public decimal Pspd { get; set; }

        [Display(Name = "شناسه کالا/ خدمت")]
        public string SstId { get; set; }
        [Display(Name = "شرح کالا خدمت")]
        public string Sstt { get; set; }
        [Display(Name = "تعداد / مقدار")]
        public decimal Am { get; set; }

        [Display(Name = "کد واحد اندازه گیری")]
        public Mu Mu { get; set; }
        [Display(Name = "واحد اندازه گیری")]
        public string Mu_1 => Mu.ToDisplay();

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
        public decimal Prdis => Am * Fee;

        [Display(Name = "مبلغ تخفیف")]
        public decimal Dis { get; set; }
        [Display(Name = "مبلغ بعد از تخفیف")]
        public decimal Adis => Prdis - Dis + Tcpbs;
        [Display(Name = "نرخ مالیات بر ارزش افزوده")]
        public double Vra { get; set; }

        [Display(Name = "مبلغ مالیات بر ارزش افزوده")]
        public decimal Vam => Invoice is null 
            ? 0
            : Invoice.Inp == Inp.First
                ? (decimal)Vra * Adis / 100
                : Tcpbs * 9 / 100 + Prdis * (decimal)Vra / 100;

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
        public decimal Tcpbs => Consfee + Spro + Bros;
        [Display(Name = "سهم نقدی از پرداخت")]
        public decimal Cop { get; set; }
        [Display(Name = "سهم مالیات بر ارزش افزوده از پرداخت")]
        public decimal Vop { get; set; }


        public string Bsrn { get; set; }
    }

    public enum Mu
    {
        [Display(Name = "لنگه")]
        لنگه = 1611,
        [Display(Name = "عدل")]
        عدل = 1612,
        [Display(Name = "جعبه")]
        جعبه = 1613,
        [Display(Name = "توپ")]
        توپ = 1618,
        [Display(Name = "ست")]
        ست = 1619,
        [Display(Name = "دست")]
        دست = 1620,
        [Display(Name = "کارتن")]
        کارتن = 1624,
        [Display(Name = "عدد")]
        عدد = 1627,
        [Display(Name = "بسته")]
        بسته = 1628,
        [Display(Name = "پاکت")]
        پاکت = 1629,
        [Display(Name = "دستگاه")]
        دستگاه = 1631,
        [Display(Name = "تخته")]
        تخته = 1640,
        [Display(Name = "رول")]
        رول = 1641,
        [Display(Name = "طاقه")]
        طاقه = 1642,
        [Display(Name = "جفت")]
        جفت = 1643,
        [Display(Name = "مترمربع")]
        مترمربع = 1645,
        [Display(Name = "پالت")]
        پالت = 1649,
        [Display(Name = "دوجین")]
        دوجین = 1661,
        [Display(Name = "حلقه-رینگ")]
        رینگ = 1668,
        [Display(Name = "قراص")]
        قراص = 1673,
        [Display(Name = "قراصه")]
        قراصه = 1694,
        [Display(Name = "لیتر")]
        لیتر = 1637,
        [Display(Name = "ساشه")]
        ساشه = 1650,
        [Display(Name = "کپسول")]
        کپسول = 1683,
        [Display(Name = "بندیل")]
        بندیل = 1656,
        [Display(Name = "حلقه-رول")]
        حلقهرول = 1630,
        [Display(Name = "قالب")]
        قالب = 163,
        [Display(Name = "شانه")]
        شانه = 1660,
        [Display(Name = "مترمکعب")]
        مترمکعب = 1647,
        [Display(Name = "ثوب")]
        ثوب = 1689,
        [Display(Name = "نیم دوجین")]
        نیمدوجین = 1690,
        [Display(Name = "قرقره")]
        قرقره = 1635,
        [Display(Name = "کیلوگرم")]
        کیلوگرم = 164,
        [Display(Name = "بطری")]
        بطری = 1638,
        [Display(Name = "برگ")]
        برگ = 161,
        [Display(Name = "سطل")]
        سطل = 1625,
        [Display(Name = "ورق")]
        ورق = 1654,
        [Display(Name = "شاخه")]
        شاخه = 1646,
        [Display(Name = "قوطی")]
        قوطی = 1644,
        [Display(Name = "جلد")]
        جلد = 1617,
        [Display(Name = "تیوب")]
        تیوب = 162,
        [Display(Name = "متر")]
        متر = 165,
        [Display(Name = "کلاف")]
        کلاف = 1610,
        [Display(Name = "کیسه")]
        کیسه = 1615,
        [Display(Name = "طغرا")]
        طغرا = 1680,
        [Display(Name = "بشکه")]
        بشکه = 1639,
        [Display(Name = "گالن")]
        گالن = 1614,
        [Display(Name = "فاقد بسته بندی")]
        فاقدبستهبندی = 1687,
        [Display(Name = "کارتن(master case)")]
        کارتنمستر = 1693,
        [Display(Name = "صفحه")]
        صفحه = 166,
        [Display(Name = "مخزن")]
        مخزن = 1666,
        [Display(Name = "تانکر")]
        تانکر = 1626,
        [Display(Name = "دبه")]
        دبه = 1648,
        [Display(Name = "سبد")]
        سبد = 1684,
        [Display(Name = "تن")]
        تن = 169,
        [Display(Name = "بانکه")]
        بانکه = 1651,
        [Display(Name = "سیلندر")]
        سیلندر = 1633,
        [Display(Name = "فوت مربع")]
        فوتمربع = 1679,
        [Display(Name = "حلب")]
        حلب = 168,
        [Display(Name = "شیت")]
        شیت = 1665,
        [Display(Name = "چلیک")]
        چلیک = 1659,
        [Display(Name = "جام")]
        جام = 1636,
        [Display(Name = "گرم")]
        گرم = 1622,
        [Display(Name = "نخ")]
        نخ = 1616,
        [Display(Name = "شعله")]
        شعله = 1652,
        [Display(Name = "قیراط")]
        قیراط = 1678,
        [Display(Name = "میلی لیتر")]
        میلیلیتر = 16100,
        [Display(Name = "میلی متر")]
        میلیمتر = 16101,
        [Display(Name = "میلی گرم")]
        میلیگرم = 16102,
        [Display(Name = "ساعت")]
        ساعت = 1617,
        [Display(Name = "روز")]
        روز = 16103,
        [Display(Name = "تن کیلومتر")]
        تنکیلومتر = 16105,
        [Display(Name = "کیلو وات ساعت")]
        کیلوواتساعت = 1669,
        [Display(Name = "نفر")]
        نفر = 1676,
        [Display(Name = "ثانیه")]
        ثانیه = 16110,
        [Display(Name = "دقیقه")]
        دقیقه = 16111,
        [Display(Name = "ماه")]
        ماه = 16112,
        [Display(Name = "سال")]
        سال = 16113,
        [Display(Name = "قطعه")]
        قطعه = 16114,
        [Display(Name = "سانتی متر")]
        سانتیمتر = 16115,
        [Display(Name = "سانتی متر مربع")]
        سانتیمترمربع = 16116,
        [Display(Name = "فروند")]
        فروند = 1632,
        [Display(Name = "واحد")]
        واحد = 1653,
        [Display(Name = "لیوان")]
        لیوان = 16108,
        [Display(Name = "نوبت")]
        نوبت = 16117,
        [Display(Name = "مگا وات ساعت")]
        مگاواتساعت = 16118,
    }

}
