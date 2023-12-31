﻿using System.Collections.Generic;

namespace CreateNewInvoiceFrm
{
    static class InvoiceProN
    {
        static Dictionary<string, string> InvoceFieldName = new Dictionary<string, string>()
            {
               {"Taxid", "شماره منحصر به فرد مالیاتی" },
               {"Indatim_1", "تاریخ صدور صورتحساب" },
               {"Indatim_2", "زمان صدور صورتحساب" },
               {"Indati2m_1", "تاریخ ایجاد صورتحساب" },
               { "Indati2m_2", "زمان ایجاد صورتحساب" },
               { "Inty_1", "نوع صورتحساب" },
               {"Inno_1", "سریال داخلی صورتحساب"/* "سریال صورتحساب داخلی حافطه مالیاتی"*/},
               {"Irtaxid", "شماره منحصربفرد مالیاتی صورتحساب مرجع"},
               { "Inp_1", "الگوی صورتحساب"},
               { "Ins_1", "موضوع صورتحساب"},
               { "Tins", "شماره اقتصادی فروشنده"},
               {"Tob_1", "نوع شخص خریدار" },
               {"Bid", "شماره /شناسه ملی" },
               {"Tinb", "شماره اقتصادی خریدار" },
               {"Sbc", "کد شعبه فروشنده" },
               {"Bpc", "کد پستی خریدار" },
               {"Bbc", "کد شعبه خریدار" },
               {"Ft", "نوع پرواز" },
               {"Bpn", "شماره گذرنامه خریدار" },
               {"Scln", "شماره پروانه گمرکی" },
               {"Scc", "کد گمرک محل اظهار فروشنده"},
               { "Cdcn", "شماره کوتاژ اظهارنامه گمرکی"},
               { "Cdcd_1", "تاریخ کوتاژ اظهارنامه گمرکی"},
               {"Crn", "شناسه یکتای ثبت قرارداد فروشنده" },
                 {"Billid", "شماره اشتراک/ شناسه قبض بهربرداری" },
                {"Tprdis", "مجموع مبلغ قبل از کسر تخفیف" },
                {"Tdis", "مجموع تخفیفات" },
                {"Tadis", "مجموع مبلغ پس از کسر تخفیف" },
                {"Tvam", "مجموع مالیات بر ارزش افزوده" },
               {"Todam", "مجموع سایر مالیات، عوارض و وجوه قانونی" },
               {"Tbill", "مجموع صورتحساب"},
               {"Tonw", "مجموع وزن خالص"},
                {"Torv", "مجموع ارزش ریالی"},
               {"Tocv", "مجموع ارزش ارزی"},
                {"Setm_1", "روش تسویه"},
                {"Cap", "مبلغ پرداختی نقدی"},
                 {"Insp", "مبلغ نسیه"},
               {"Tvop", "مجموع سهم مالیات بر ارزش افزوده از پرداخت"},
               {"Tax17", "مالیات موضوع ماده 17"},
                { "Sstid", "شناسه کالا/ خدمت"},
                { "Sstt","شرح کالا خدمت" },
                {"Am" ,"تعداد / مقدار" },
                { "Mu_1","  واحد اندازه گیری" },
                {"Nw" ,"وزن خالص" },
                { "Fee", "مبلغ واحد"},
                { "Cfee","میزان ارز" },
                { "Cut", " کد نوع ارز" },
                {"Exr" ,"نرخ برابری ارز با ریا ل"},
                { "Ssrv", "ارزش ریالی کالا"},
                { "Sscv","ارزش ارزی کالا" },
                { "Prdis","مبلغ قبل از تخفیف" },
                { "Dis","مبلغ تخفیف" },
                {"Adis" ,"مبلغ بعد از تخفیف" },
                {"Vra" , "نرخ مالیات بر ارزش افزوده"},
                { "Vam","مبلغ مالیات بر ارزش افزوده" },
                { "Odt","موضوع سایر مالیات و عوارض" },
                { "Odr", "نرخ سایر مالیات و عوارض"},
                {"Odam" ,"مبلغ سایر مالیات و عوارض" },
                { "Olt", "موضوع سایر وجوه قانونی"},
                { "Olr","نرخ سایر وجوه قانونی" },
                {"Olam" ,"مبلغ سایر وجوه قانونی" },
                {"Consfee" , "اجرت ساخت"},
                { "Spro", "سود فروشنده"},
                { "Bros", "حق العمل"},
                {"Tcpbs" , "جمع کل اجرت، حق العمل و سود"},
                {"Cop" ,"سهم نقدی از پرداخت" },
                { "Vop","سهم مالیات بر ارزش افزوده از پرداخت" },
                { "Bsrn","شناسه یکتای ثبت قرارداد حق العملکاری" },
                { "Tsstam","مبلغ کل کالا و خدمت" },

                { "Iinn","شماره سوییج پرداخت" },
                { "Acn","شماره پذیرنده فروشگاهی" },
                {"Trmn" ,"شماره پایانه" },
                { "Pmt","روش پرداخت" },
                {"Trn" ,"شماره پیگیری/ شماره مرجع" },
                { "Pcn","شماره کارت پرداخت کننده صورتحساب" },
                {"Pid" , "شماره/شناسه ملی پرداخت کننده"},
                { "Pdt_1","تاریخ پرداخت" },
                { "Pdt_2","زمان پرداخت" },
                {"Pv" , "مبلغ پرداختی"},
                {"Pspd" , "تفاوت نرخ خرید  فروش ارز/ کارمزد"},
            };

        static public Dictionary<string, string> GetInvoiceFiledName()
        {
            return InvoceFieldName; // 
        }

        static Dictionary<string, string> Type1Patern1 = new Dictionary<string, string>()
            {
               {"Taxid", "M" },//شماره منحصر به فرد مالیاتی
               {"Indatim_1", "M" },//تاریخ صدور صورتحساب
               {"Indatim_2", "M" },//زمان صدور صورتحساب
               {"Indati2m_1", "MC" },//تاریخ ایجاد صورتحساب
               { "Indati2m_2", "MC" },//زمان ایجاد صورتحساب
               { "Inty_1", "M" },//نوع صورتحساب
               {"Inno_1", "A"},//سریال داخلی صورتحساب
               {"Irtaxid", "MC"},//شماره منحصربفرد مالیاتی صورتحساب مرجع
               { "Inp_1", "M"},//الگوی صورتحساب
               { "Ins_1", "M"},//موضوع صورتحساب
               { "Tins", "M"},//شماره اقتصادی فروشنده
               {"Tob_1", "M" },//نوع شخص خریدار
               {"Bid", "A" },//شماره /شناسه ملی
               {"Tinb", "MC" },//شماره اقتصادی خریدار
               {"Sbc", "A" },//کد شعبه فروشنده
               {"Bpc", "A" },//کد پستی خریدار
               {"Bbc", "A" },//کد شعبه خریدار
               {"Ft", "I" },//نوع پرواز
               {"Bpn", "I" },//شماره گذرنامه خریدار
               {"Scln", "A" },//شماره پروانه گمرکی
               {"Scc", "A"},//کد گمرک محل اظهار فروشنده
               { "Cdcn", "I"},//شماره کوتاژ اظهارنامه گمرکی
               { "Cdcd_1", "I"},//تاریخ کوتاژ اظهارنامه گمرکی
               {"Crn", "A" },//شناسه یکتای ثبت قرارداد فروشنده
                 {"Billid", "I" },//شماره اشتراک/ شناسه قبض بهربرداری
                {"Tprdis", "M" },//مجموع مبلغ قبل از کسر تخفیف
                {"Tdis", "A" },//مجموع تخفیفات
                {"Tadis", "M" },//مجموع مبلغ پس از کسر تخفیف
                {"Tvam", "M" },//مجموع مالیات بر ارزش افزوده
               {"Todam", "M" },//مجموع سایر مالیات، عوارض و وجوه قانونی
               {"Tbill", "M"},//مجموع صورتحساب
               {"Tonw", "I"},//مجموع وزن خالص
                {"Torv", "I"},//مجموع ارزش ریالی
               {"Tocv", "I"},//مجموع ارزش ارزی
                {"Setm", "A"},//روش تسویه
                {"Cap", "MC"},//مبلغ پرداختی نقدی
                 {"Insp", "MC"},//مبلغ نسیه
               {"Tvop", "A"},//مجموع سهم مالیات بر ارزش افزوده از پرداخت
               {"Tax17", "A"},//"مالیات موضوع ماده 17"
                { "Sstid", "M"},//شناسه کالا/ خدمت
                { "Sstt","A" },//شرح کالا خدمت
                {"Am" ,"M" },//تعداد / مقدار
                { "Mu_1","A" },//واحد اندازه گیری
                {"Nw" ,"I" },//وزن خالص
                { "Fee", "M"},//مبلغ واحد
                { "Cfee","A" },//میزان ارز
                { "Cut", "A" },//کد نوع ارز
                {"Exr" ,"A"},//نرخ برابری ارز با ریا ل
                { "Ssrv", "I"},//ارزش ریالی کالا
                { "Sscv","I" },//ارزش ارزی کالا
                { "Prdis","M" },//مبلغ قبل از تخفیف
                { "Dis","M" },//مبلغ تخفیف
                {"Adis" ,"M" },//مبلغ بعد از تخفیف
                {"Vra" , "M"},//نرخ مالیات بر ارزش افزوده
                { "Vam","M" },//مبلغ مالیات بر ارزش افزوده
                { "Odt","MC" },//موضوع سایر مالیات و عوارض
                { "Odr", "MC"},//نرخ سایر مالیات و عوارض
                {"Odam" ,"MC" },//مبلغ سایر مالیات و عوارض
                { "Olt", "MC"},//موضوع سایر وجوه قانونی
                { "Olr","MC" },//نرخ سایر وجوه قانونی
                {"Olam" ,"MC" },//مبلغ سایر وجوه قانونی
                {"Consfee" , "I"},//اجرت ساخت
                { "Spro", "I"},//سود فروشنده
                { "Bros", "I"},//حق العمل
                {"Tcpbs" , "I"},//جمع کل اجرت، حق العمل و سود
                {"Cop" ,"A" },//سهم نقدی از پرداخت
                { "Vop","A" },//سهم مالیات بر ارزش افزوده از پرداخت
                { "Bsrn","A" },//شناسه یکتای ثبت قرارداد حق العملکاری
                { "Tsstam","M" },//مبلغ کل کالا و خدمت

                { "Iinn","A" },//شماره سوییج پرداخت
                { "Acn","A" },//شماره پذیرنده فروشگاهی
                {"Trmn" ,"A" },//شماره پایانه
                { "Pmt","A" },//روش پرداخت
                {"Trn" ,"A" },//شماره پیگیری/ شماره مرجع
                { "Pcn","A" },//شماره کارت پرداخت کننده صورتحساب
                {"Pid" , "A"},//شماره/شناسه ملی پرداخت کننده
                { "Pdt_1","A" },//تاریخ پرداخت
                { "Pdt_2","A" },//زمان پرداخت
                {"Pv" , "A"},//مبلغ پرداختی
                {"Pspd" , "I"},//تفاوت نرخ خرید  فروش ارز/ کارمزد
            };

        static public Dictionary<string, string> GetType1Patern1()
        {
            return Type1Patern1; // 
        }

        static Dictionary<string, string> Type1Patern3 = new Dictionary<string, string>()
            {
               {"Taxid", "M" },//شماره منحصر به فرد مالیاتی
               {"Indatim_1", "M" },//تاریخ صدور صورتحساب
               {"Indatim_2", "M" },//زمان صدور صورتحساب
               {"Indati2m_1", "MC" },//تاریخ ایجاد صورتحساب
               { "Indati2m_2", "MC" },//زمان ایجاد صورتحساب
               { "Inty_1", "M" },//نوع صورتحساب
               {"Inno_1", "A"},//سریال داخلی صورتحساب
               {"Irtaxid", "MC"},//شماره منحصربفرد مالیاتی صورتحساب مرجع
               { "Inp_1", "M"},//الگوی صورتحساب
               { "Ins_1", "M"},//موضوع صورتحساب
               { "Tins", "M"},//شماره اقتصادی فروشنده
               {"Tob_1", "M" },//نوع شخص خریدار
               {"Bid", "A" },//شماره /شناسه ملی
               {"Tinb", "MC" },//شماره اقتصادی خریدار
               {"Sbc", "A" },//کد شعبه فروشنده
               {"Bpc", "A" },//کد پستی خریدار
               {"Bbc", "A" },//کد شعبه خریدار
               {"Ft", "I" },//نوع پرواز
               {"Bpn", "I" },//شماره گذرنامه خریدار
               {"Scln", "I" },//شماره پروانه گمرکی
               {"Scc", "I"},//کد گمرک محل اظهار فروشنده
               { "Cdcn", "I"},//شماره کوتاژ اظهارنامه گمرکی
               { "Cdcd_1", "I"},//تاریخ کوتاژ اظهارنامه گمرکی
               {"Crn", "A" },//شناسه یکتای ثبت قرارداد فروشنده
                 {"Billid", "I" },//شماره اشتراک/ شناسه قبض بهربرداری
                {"Tprdis", "M" },//مجموع مبلغ قبل از کسر تخفیف
                {"Tdis", "A" },//مجموع تخفیفات
                {"Tadis", "M" },//مجموع مبلغ پس از کسر تخفیف
                {"Tvam", "M" },//مجموع مالیات بر ارزش افزوده
               {"Todam", "M" },//مجموع سایر مالیات، عوارض و وجوه قانونی
               {"Tbill", "M"},//مجموع صورتحساب
               {"Tonw", "I"},//مجموع وزن خالص
                {"Torv", "I"},//مجموع ارزش ریالی
               {"Tocv", "I"},//مجموع ارزش ارزی
                {"Setm_1", "M"},//روش تسویه
                {"Cap", "MC"},//مبلغ پرداختی نقدی
                 {"Insp", "MC"},//مبلغ نسیه
               {"Tvop", "A"},//مجموع سهم مالیات بر ارزش افزوده از پرداخت
               {"Tax17", "A"},//"مالیات موضوع ماده 17"
                { "Sstid", "M"},//شناسه کالا/ خدمت
                { "Sstt","A" },//شرح کالا خدمت
                {"Am" ,"M" },//تعداد / مقدار
                { "Mu_1","A" },//واحد اندازه گیری
                {"Nw" ,"I" },//وزن خالص
                { "Fee", "M"},//مبلغ واحد
                { "Cfee","A" },//میزان ارز
                { "Cut", "A" },//کد نوع ارز
                {"Exr" ,"A"},//نرخ برابری ارز با ریا ل
                { "Ssrv", "I"},//ارزش ریالی کالا
                { "Sscv","I" },//ارزش ارزی کالا
                { "Prdis","M" },//مبلغ قبل از تخفیف
                { "Dis","M" },//مبلغ تخفیف
                {"Adis" ,"M" },//مبلغ بعد از تخفیف
                {"Vra" , "M"},//نرخ مالیات بر ارزش افزوده
                { "Vam","M" },//مبلغ مالیات بر ارزش افزوده
                { "Odt","MC" },//موضوع سایر مالیات و عوارض
                { "Odr", "MC"},//نرخ سایر مالیات و عوارض
                {"Odam" ,"MC" },//مبلغ سایر مالیات و عوارض
                { "Olt", "MC"},//موضوع سایر وجوه قانونی
                { "Olr","MC" },//نرخ سایر وجوه قانونی
                {"Olam" ,"MC" },//مبلغ سایر وجوه قانونی
                {"Consfee" , "M"},//اجرت ساخت
                { "Spro", "M"},//سود فروشنده
                { "Bros", "M"},//حق العمل
                {"Tcpbs" , "M"},//جمع کل اجرت، حق العمل و سود
                {"Cop" ,"A" },//سهم نقدی از پرداخت
                { "Vop","A" },//سهم مالیات بر ارزش افزوده از پرداخت
                { "Bsrn","A" },//شناسه یکتای ثبت قرارداد حق العملکاری
                { "Tsstam","M" },//مبلغ کل کالا و خدمت

                { "Iinn","A" },//شماره سوییج پرداخت
                { "Acn","A" },//شماره پذیرنده فروشگاهی
                {"Trmn" ,"A" },//شماره پایانه
                { "Pmt","A" },//روش پرداخت
                {"Trn" ,"A" },//شماره پیگیری/ شماره مرجع
                { "Pcn","A" },//شماره کارت پرداخت کننده صورتحساب
                {"Pid" , "A"},//شماره/شناسه ملی پرداخت کننده
                { "Pdt_1","A" },//تاریخ پرداخت
                { "Pdt_2","A" },//زمان پرداخت
                {"Pv" , "A"},//مبلغ پرداختی
                {"Pspd" , "I"},//تفاوت نرخ خرید  فروش ارز/ کارمزد
            };

        static public Dictionary<string, string> GetType1Patern3()
        {
            return Type1Patern3; // 
        }

        static Dictionary<string, string> Type2Patern1 = new Dictionary<string, string>()
            {
               {"Taxid", "M" },//شماره منحصر به فرد مالیاتی
               {"Indatim_1", "M" },//تاریخ صدور صورتحساب
               {"Indatim_2", "M" },//زمان صدور صورتحساب
               {"Indati2m_1", "MC" },//تاریخ ایجاد صورتحساب
               { "Indati2m_2", "MC" },//زمان ایجاد صورتحساب
               { "Inty_1", "M" },//نوع صورتحساب
               {"Inno_1", "A"},//سریال داخلی صورتحساب
               {"Irtaxid", "MC"},//شماره منحصربفرد مالیاتی صورتحساب مرجع
               { "Inp_1", "M"},//الگوی صورتحساب
               { "Ins_1", "M"},//موضوع صورتحساب
               { "Tins", "M"},//شماره اقتصادی فروشنده
               {"Tob_1", "A" },//نوع شخص خریدار
               {"Bid", "A" },//شماره /شناسه ملی
               {"Tinb", "A" },//شماره اقتصادی خریدار
               {"Sbc", "A" },//کد شعبه فروشنده
               {"Bpc", "A" },//کد پستی خریدار
               {"Bbc", "A" },//کد شعبه خریدار
               {"Ft", "I" },//نوع پرواز
               {"Bpn", "I" },//شماره گذرنامه خریدار
               {"Scln", "I" },//شماره پروانه گمرکی
               {"Scc", "I"},//کد گمرک محل اظهار فروشنده
               { "Cdcn", "I"},//شماره کوتاژ اظهارنامه گمرکی
               { "Cdcd_1", "I"},//تاریخ کوتاژ اظهارنامه گمرکی
               {"Crn", "I" },//شناسه یکتای ثبت قرارداد فروشنده
                 {"Billid", "I" },//شماره اشتراک/ شناسه قبض بهربرداری
                {"Tprdis", "M" },//مجموع مبلغ قبل از کسر تخفیف
                {"Tdis", "A" },//مجموع تخفیفات
                {"Tadis", "M" },//مجموع مبلغ پس از کسر تخفیف
                {"Tvam", "M" },//مجموع مالیات بر ارزش افزوده
               {"Todam", "M" },//مجموع سایر مالیات، عوارض و وجوه قانونی
               {"Tbill", "M"},//مجموع صورتحساب
               {"Tonw", "I"},//مجموع وزن خالص
                {"Torv", "I"},//مجموع ارزش ریالی
               {"Tocv", "I"},//مجموع ارزش ارزی
                {"Setm", "I"},//روش تسویه
                {"Cap", "I"},//مبلغ پرداختی نقدی
                 {"Insp", "I"},//مبلغ نسیه
               {"Tvop", "I"},//مجموع سهم مالیات بر ارزش افزوده از پرداخت
               {"Tax17", "A"},//"مالیات موضوع ماده 17"
                { "Sstid", "M"},//شناسه کالا/ خدمت
                { "Sstt","A" },//شرح کالا خدمت
                {"Am" ,"M" },//تعداد / مقدار
                { "Mu_1","A" },//واحد اندازه گیری
                {"Nw" ,"I" },//وزن خالص
                { "Fee", "M"},//مبلغ واحد
                { "Cfee","A" },//میزان ارز
                { "Cut", "A" },//کد نوع ارز
                {"Exr" ,"A"},//نرخ برابری ارز با ریا ل
                { "Ssrv", "I"},//ارزش ریالی کالا
                { "Sscv","I" },//ارزش ارزی کالا
                { "Prdis","M" },//مبلغ قبل از تخفیف
                { "Dis","M" },//مبلغ تخفیف
                {"Adis" ,"M" },//مبلغ بعد از تخفیف
                {"Vra" , "M"},//نرخ مالیات بر ارزش افزوده
                { "Vam","M" },//مبلغ مالیات بر ارزش افزوده
                { "Odt","MC" },//موضوع سایر مالیات و عوارض
                { "Odr", "MC"},//نرخ سایر مالیات و عوارض
                {"Odam" ,"MC" },//مبلغ سایر مالیات و عوارض
                { "Olt", "MC"},//موضوع سایر وجوه قانونی
                { "Olr","MC" },//نرخ سایر وجوه قانونی
                {"Olam" ,"MC" },//مبلغ سایر وجوه قانونی
                {"Consfee" , "I"},//اجرت ساخت
                { "Spro", "I"},//سود فروشنده
                { "Bros", "I"},//حق العمل
                {"Tcpbs" , "I"},//جمع کل اجرت، حق العمل و سود
                {"Cop" ,"I" },//سهم نقدی از پرداخت
                { "Vop","I" },//سهم مالیات بر ارزش افزوده از پرداخت
                { "Bsrn","A" },//شناسه یکتای ثبت قرارداد حق العملکاری
                { "Tsstam","M" },//مبلغ کل کالا و خدمت

                { "Iinn","A" },//شماره سوییج پرداخت
                { "Acn","A" },//شماره پذیرنده فروشگاهی
                {"Trmn" ,"A" },//شماره پایانه
                { "Pmt","A" },//روش پرداخت
                {"Trn" ,"A" },//شماره پیگیری/ شماره مرجع
                { "Pcn","A" },//شماره کارت پرداخت کننده صورتحساب
                {"Pid" , "A"},//شماره/شناسه ملی پرداخت کننده
                { "Pdt_1","A" },//تاریخ پرداخت
                { "Pdt_2","A" },//زمان پرداخت
                {"Pv" , "A"},//مبلغ پرداختی
                {"Pspd" , "I"},//تفاوت نرخ خرید  فروش ارز/ کارمزد
            };

        static public Dictionary<string, string> GetType2Patern1()
        {
            return Type2Patern1; // 
        }

        static Dictionary<string, string> Type2Patern3 = new Dictionary<string, string>()
            {
               {"Taxid", "M" },//شماره منحصر به فرد مالیاتی
               {"Indatim_1", "M" },//تاریخ صدور صورتحساب
               {"Indatim_2", "M" },//زمان صدور صورتحساب
               {"Indati2m_1", "MC" },//تاریخ ایجاد صورتحساب
               { "Indati2m_2", "MC" },//زمان ایجاد صورتحساب
               { "Inty_1", "M" },//نوع صورتحساب
               {"Inno_1", "A"},//سریال داخلی صورتحساب
               {"Irtaxid", "MC"},//شماره منحصربفرد مالیاتی صورتحساب مرجع
               { "Inp_1", "M"},//الگوی صورتحساب
               { "Ins_1", "M"},//موضوع صورتحساب
               { "Tins", "M"},//شماره اقتصادی فروشنده
               {"Tob_1", "A" },//نوع شخص خریدار
               {"Bid", "A" },//شماره /شناسه ملی
               {"Tinb", "A" },//شماره اقتصادی خریدار
               {"Sbc", "A" },//کد شعبه فروشنده
               {"Bpc", "A" },//کد پستی خریدار
               {"Bbc", "A" },//کد شعبه خریدار
               {"Ft", "I" },//نوع پرواز
               {"Bpn", "I" },//شماره گذرنامه خریدار
               {"Scln", "I" },//شماره پروانه گمرکی
               {"Scc", "I"},//کد گمرک محل اظهار فروشنده
               { "Cdcn", "I"},//شماره کوتاژ اظهارنامه گمرکی
               { "Cdcd_1", "I"},//تاریخ کوتاژ اظهارنامه گمرکی
               {"Crn", "I" },//شناسه یکتای ثبت قرارداد فروشنده
                 {"Billid", "I" },//شماره اشتراک/ شناسه قبض بهربرداری
                {"Tprdis", "M" },//مجموع مبلغ قبل از کسر تخفیف
                {"Tdis", "A" },//مجموع تخفیفات
                {"Tadis", "M" },//مجموع مبلغ پس از کسر تخفیف
                {"Tvam", "M" },//مجموع مالیات بر ارزش افزوده
               {"Todam", "M" },//مجموع سایر مالیات، عوارض و وجوه قانونی
               {"Tbill", "M"},//مجموع صورتحساب
               {"Tonw", "I"},//مجموع وزن خالص
                {"Torv", "I"},//مجموع ارزش ریالی
               {"Tocv", "I"},//مجموع ارزش ارزی
                {"Setm", "I"},//روش تسویه
                {"Cap", "I"},//مبلغ پرداختی نقدی
                 {"Insp", "I"},//مبلغ نسیه
               {"Tvop", "I"},//مجموع سهم مالیات بر ارزش افزوده از پرداخت
               {"Tax17", "A"},//"مالیات موضوع ماده 17"
                { "Sstid", "M"},//شناسه کالا/ خدمت
                { "Sstt","A" },//شرح کالا خدمت
                {"Am" ,"M" },//تعداد / مقدار
                { "Mu_1","A" },//واحد اندازه گیری
                {"Nw" ,"I" },//وزن خالص
                { "Fee", "M"},//مبلغ واحد
                { "Cfee","A" },//میزان ارز
                { "Cut", "A" },//کد نوع ارز
                {"Exr" ,"A"},//نرخ برابری ارز با ریا ل
                { "Ssrv", "I"},//ارزش ریالی کالا
                { "Sscv","I" },//ارزش ارزی کالا
                { "Prdis","M" },//مبلغ قبل از تخفیف
                { "Dis","M" },//مبلغ تخفیف
                {"Adis" ,"M" },//مبلغ بعد از تخفیف
                {"Vra" , "M"},//نرخ مالیات بر ارزش افزوده
                { "Vam","M" },//مبلغ مالیات بر ارزش افزوده
                { "Odt","MC" },//موضوع سایر مالیات و عوارض
                { "Odr", "MC"},//نرخ سایر مالیات و عوارض
                {"Odam" ,"MC" },//مبلغ سایر مالیات و عوارض
                { "Olt", "MC"},//موضوع سایر وجوه قانونی
                { "Olr","MC" },//نرخ سایر وجوه قانونی
                {"Olam" ,"MC" },//مبلغ سایر وجوه قانونی
                {"Consfee" , "M"},//اجرت ساخت
                { "Spro", "M"},//سود فروشنده
                { "Bros", "M"},//حق العمل
                {"Tcpbs" , "M"},//جمع کل اجرت، حق العمل و سود
                {"Cop" ,"I" },//سهم نقدی از پرداخت
                { "Vop","I" },//سهم مالیات بر ارزش افزوده از پرداخت
                { "Bsrn","A" },//شناسه یکتای ثبت قرارداد حق العملکاری
                { "Tsstam","M" },//مبلغ کل کالا و خدمت
                { "Iinn","A" },//شماره سوییج پرداخت
                { "Acn","A" },//شماره پذیرنده فروشگاهی
                {"Trmn" ,"A" },//شماره پایانه
                { "Pmt","A" },//روش پرداخت
                {"Trn" ,"A" },//شماره پیگیری/ شماره مرجع
                { "Pcn","A" },//شماره کارت پرداخت کننده صورتحساب
                {"Pid" , "A"},//شماره/شناسه ملی پرداخت کننده
                { "Pdt_1","A" },//تاریخ پرداخت
                { "Pdt_2","A" },//زمان پرداخت
                {"Pv" , "A"},//مبلغ پرداختی
                {"Pspd" , "I"},//تفاوت نرخ خرید  فروش ارز/ کارمزد
            };

        static public Dictionary<string, string> GetType2Patern3()
        {
            return Type2Patern3; // 
        }
    }
}
