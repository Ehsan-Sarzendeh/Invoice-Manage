using InvoiceManage.Database.Entities.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManage.Database.Entities
{
    public class Invoice : BaseEntity
    {
        [StringLength(22)]
        [Display(Name = "شماره منحصر به فرد مالیاتی")]
        public string TaxId { get; set; }
        [Display(Name = "تاریخ و زمان صدور صورتحساب")]
        public decimal Indatim { get; set; }
        [Display(Name = "تاریخ صدور صورتحساب")]
        public string Indatim_1 { get; set; }
        [Display(Name = "زمان صدور صورتحساب")]
        public string Indatim_2 { get; set; }
        [Display(Name = "تاریخ و زمان ایجاد صورتحساب")]
        public decimal Indatim2m { get; set; }
        [Display(Name = "تاریخ ایجاد صورتحساب")]
        public string Indatim2m_1 { get; set; }
        [Display(Name = "زمان ایجاد صورتحساب")]
        public string Indatim2m_2 { get; set; }
        [Display(Name = "نوع صورتحساب")]
        public int Inty { get; set; }
        [Display(Name = "سریال داخلی صورتحساب")]
        [Description("سریال صورتحساب داخلی حافطه مالیاتی")]
        public string Inno { get; set; }
        [Display(Name = "شماره منحصربفرد مالیاتی صورتحساب مرجع")]
        public string Irtaxid { get; set; }
        [Display(Name = "الگوی صورتحساب")]
        public int Inp { get; set; }
        [Display(Name = "موضوع صورتحساب")]
        public int Ins { get; set; }
        [Display(Name = "شماره اقتصادی فروشنده")]
        public string Tins { get; set; }
        [Display(Name = "شماره اقتصادی خریدار")]
        public string Tinb { get; set; }
        [Display(Name = "نوع شخص خریدار")]
        public int Tob { get; set; }
        [Display(Name = "کد شعبه فروشنده")]
        public string Sbc { get; set; }
        [Display(Name = "شماره /شناسه ملی")]
        public string Bid { get; set; }
        [Display(Name = "کد پستی خریدار")]
        public string Bpc { get; set; }
        [Display(Name = "کد شعبه خریدار")]
        public string Bbc { get; set; }
        [Display(Name = "شماره گذرنامه خریدار")]
        public string Bpn { get; set; }
        [Display(Name = "نوع پرواز")]
        public int Ft { get; set; }
        [Display(Name = "شماره پروانه گمرکی")]
        public string Scln { get; set; }
        [Display(Name = "کد گمرک محل اظهار فروشنده")]
        public string Scc { get; set; }
        [Display(Name = "شناسه یکتای ثبت قرارداد فروشنده")]
        public string Crn { get; set; }
        [Display(Name = "شماره کوتاژ اظهارنامه گمرکی")]
        public string Cdcn { get; set; }
        [Display(Name = "تاریخ کوتاژ اظهارنامه گمرکی")]
        public string Cdcd_1 { get; set; }
        [Display(Name = "شماره اشتراک/ شناسه قبض بهربرداری")]
        public string BillId { get; set; }
        [Display(Name = "مجموع مبلغ قبل از کسر تخفیف")]
        public decimal Tprdis { get; set; }
        [Display(Name = "مجموع تخفیفات")]
        public decimal Tdis { get; set; }
        [Display(Name = "مجموع مبلغ پس از کسر تخفیف")]
        public decimal Tadis { get; set; }
        [Display(Name = "مجموع مالیات بر ارزش افزوده")]
        public decimal Tvam { get; set; }
        [Display(Name = "مجموع سایر مالیات، عوارض و وجوه قانونی")]
        public decimal Todam { get; set; }
        [Display(Name = "مجموع صورتحساب")]
        public decimal Tbill { get; set; }
        [Display(Name = "مجموع وزن خالص")]
        public decimal Tonw { get; set; }
        [Display(Name = "مجموع ارزش ریالی")]
        public decimal Torv { get; set; }
        [Display(Name = "مجموع ارزش ارزی")]
        public decimal Tocv { get; set; }
        [Display(Name = "روش تسویه")]
        public int Setm { get; set; }
        [Display(Name = "مبلغ پرداختی نقدی")]
        public decimal Cap { get; set; }
        [Display(Name = "مبلغ نسیه")]
        public decimal Insp { get; set; }
        [Display(Name = "مجموع سهم مالیات بر ارزش افزوده از پرداخت")]
        public decimal Tvop { get; set; }
        [Display(Name = "مالیات موضوع ماده 17")]
        public decimal Tax17 { get; set; }
        [Display(Name = "شماره سوییج پرداخت")]
        public string Iinn { get; set; }
        [Display(Name = "شماره پذیرنده فروشگاهی")]
        public string Acn { get; set; }
        [Display(Name = "شماره پایانه")]
        public string Trmn { get; set; }
        [Display(Name = "روش پرداخت")]
        public int Pmt { get; set; }
        [Display(Name = "شماره کارت پرداخت کننده صورتحساب")]
        public string Pcn { get; set; }
        [Display(Name = "شماره/شناسه ملی پرداخت کننده")]
        public string Pid { get; set; }
        [Display(Name = "تاریخ پرداخت")]
        public string Pdt_1 { get; set; }
        [Display(Name = "زمان پرداخت")]
        public string Pdt_2 { get; set; }
        [Display(Name = "مبلغ پرداختی")]
        public decimal Pv { get; set; }

        public string Tm { get; set; }

        public decimal Cdcd { get; set; }

        public string Ins_1 { get; set; }

        public string Inp_1 { get; set; }

        public string Tob_1 { get; set; }

        public decimal Pdt { get; set; }

        public string RefrenceNumber { get; set; }

        public string SendStatus { get; set; }

        public string ResultStatus { get; set; }

        public string Inty_1 { get; set; }

        public decimal Inno_1 { get; set; }

        public long CompanyId { get; set; }
        public Company Company { get; set; }
    }
}