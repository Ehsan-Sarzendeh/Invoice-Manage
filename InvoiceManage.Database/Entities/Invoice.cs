using InvoiceManage.Database.Entities.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using InvoiceManage.Database.Infrastructures;

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

        [Display(Name = "سریال داخلی")]
        [Description("سریال صورتحساب داخلی حافطه مالیاتی")]
        public string Inno => $"{Inno_1:X}";
        [Display(Name = "کد سریال داخلی")]
        public long Inno_1 { get; set; }
        [Browsable(false)]
        public bool GenerateInno { get; set; }

        [Display(Name = "شماره منحصربفرد مالیاتی صورتحساب مرجع")]
        public string Irtaxid { get; set; }

        [Display(Name = "شماره اقتصادی فروشنده")]
        public string Tins { get; set; }

        [Display(Name = "شماره اقتصادی خریدار")]
        public string Tinb { get; set; }

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

        [Display(Name = "شماره پروانه گمرکی")]
        public string Scln { get; set; }

        [Display(Name = "کد گمرکی محل اظهار فروشنده")]
        public string Scc { get; set; }

        [Display(Name = "شناسه یکتای ثبت قرارداد فروشنده")]
        public string Crn { get; set; }

        [Display(Name = "شماره کوتاژ اظهارنامه گمرکی")]
        public string Cdcn { get; set; }

        [Display(Name = "تاریخ کوتاژ اظهارنامه گمرکی")]
        public string Cdcd_1 { get; set; }

        public decimal Cdcd { get; set; }

        [Display(Name = "شماره اشتراک/ شناسه قبض بهربرداری")]
        public string BillId { get; set; }

        [Bindable(false)]
        [Display(Name = "مجموع مبلغ قبل از کسر تخفیف")]
        public decimal Tprdis => Items?.Sum(x => x.Prdis) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع تخفیفات")]
        public decimal Tdis => Items?.Sum(x => x.Dis) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع مبلغ پس از کسر تخفیف")]
        public decimal Tadis => Items?.Sum(x => x.Adis) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع مالیات بر ارزش افزوده")]
        public decimal Tvam => Items?.Sum(x => x.Vam) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع سایر مالیات، عوارض و وجوه قانونی")]
        public decimal Todam => Items?.Sum(x => x.Odam) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع صورتحساب")]
        public decimal Tbill => Items?.Sum(x => x.Tsstam) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع وزن خالص")]
        public decimal Tonw => Items?.Sum(x => x.Nw) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع ارزش ریالی")]
        public decimal Torv => Items?.Sum(x => x.Ssrv) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع ارزش ارزی")]
        public decimal Tocv => Items?.Sum(x => x.Sscv) ?? 0;

        [Bindable(false)]
        [Display(Name = "مجموع سهم مالیات بر ارزش افزوده از پرداخت")]
        public decimal Tvop => Items?.Sum(x => x.Vop) ?? 0;

        [Display(Name = "مبلغ پرداختی نقدی")]
        public decimal Cap { get; set; }

        [Display(Name = "مبلغ نسیه")]
        public decimal Insp { get; set; }

        [Display(Name = "مالیات موضوع ماده 17")]
        public decimal Tax17 { get; set; }

        [Display(Name = "شماره سوییج پرداخت")]
        public string Iinn { get; set; }

        [Display(Name = "شماره پذیرنده فروشگاهی")]
        public string Acn { get; set; }

        [Display(Name = "شماره پایانه")]
        public string Trmn { get; set; }

        [Display(Name = "شماره پیگیری/مرجع")]
        public string Trn { get; set; }

        [Display(Name = "شماره کارت پرداخت کننده صورتحساب")]
        public string Pcn { get; set; }

        [Display(Name = "شماره/شناسه ملی پرداخت کننده")]
        public string Pid { get; set; }

        [Display(Name = "تاریخ پرداخت")]
        public string Pdt_1 { get; set; }
        public decimal Pdt { get; set; }

        [Display(Name = "زمان پرداخت")]
        public string Pdt_2 { get; set; }

        [Display(Name = "مبلغ پرداختی")]
        public decimal Pv { get; set; }

        public string Tm { get; set; }

        public string RefrenceNumber { get; set; }

        public string SendStatus { get; set; }

        [Display(Name = "نتیجه ارسال")]
        public string ResultStatus { get; set; }

        [Display(Name = "نوع صورتحساب")]
        public Inty Inty { get; set; }
        [Bindable(false)]
        public string Inty_1 => Inty.ToDisplay();

        [Display(Name = "الگوی صورتحساب")]
        public Inp Inp { get; set; }
        [Bindable(false)]
        public string Inp_1 => Inp.ToDisplay();

        [Display(Name = "موضوع صورتحساب")]
        public Ins? Ins { get; set; }
        [Bindable(false)]
        public string Ins_1 => Ins?.ToDisplay();

        [Display(Name = "نوع شخص خریدار")]
        public Tob? Tob { get; set; }
        [Bindable(false)]
        public string Tob_1 => Tob?.ToDisplay();

        [Display(Name = "نوع پرواز")]
        public Ft? Ft { get; set; }
        [Bindable(false)]
        public string Ft_1 => Ft?.ToDisplay();

        [Display(Name = "روش پرداخت")]
        public Pmt? Pmt { get; set; }
        [Bindable(false)]
        public string Pmt_1 => Pmt?.ToDisplay();

        [Display(Name = "روش تسویه")]
        public Setm? Setm { get; set; }
        [Bindable(false)]
        public string Setm_1 => Setm?.ToDisplay();

        [Display(Name = "شناسه شرکت")]
        public long CompanyId { get; set; }

        [Browsable(false)]
        public Company Company { get; set; }

        [Browsable(false)]
        public BindingList<InvoiceItem> Items { get; set; }
    }

    public enum Inty
    {
        [Display(Name = "نوع اول")]
        First = 1,
        [Display(Name = "نوع دوم")]
        Second = 2
    }

    public enum Inp
    {
        [Display(Name = "الگوی اول")]
        First = 1,
        [Display(Name = "الگوی دوم")]
        Second = 2
    }

    public enum Ins
    {
        [Display(Name = "اصلی")]
        Main = 1,
        [Display(Name = "اصلاحی")]
        Corrective = 2,
        [Display(Name = "ابطالی")]
        Cancel = 3,
        [Display(Name = "برگشت از فروش")]
        Return = 4
    }

    public enum Tob
    {
        [Display(Name = "حقیقی")]
        Natural = 1,
        [Display(Name = "حقوقی")]
        Legal = 2
    }

    public enum Ft
    {
        [Display(Name = "تست")]
        Internal = 1,
        [Display(Name = "خارجی")]
        Foreign = 2
    }

    public enum Pmt
    {
        [Display(Name = "چک")]
        Check = 1,
        [Display(Name = "اصلاحی")]
        Corrective = 2,
        [Display(Name = "وجه نقد")]
        Cash = 3,
        [Display(Name = "pos")]
        Pos = 4,
        [Display(Name = "درگاه پرداخت اینترنتی")]
        Gateway = 5,
        [Display(Name = "کارت به کارت")]
        CardByCard = 6,
        [Display(Name = "انتقال به حساب")]
        AccountTransfer = 7,
        [Display(Name = "سایر")]
        Other = 8
    }

    public enum Setm
    {
        [Display(Name = "نقدی")]
        Cash = 1,
        [Display(Name = "نسیه")]
        Credit = 2,
        [Display(Name = "نقدی/نسیه")]
        CashAndCredit = 3,
    }
}