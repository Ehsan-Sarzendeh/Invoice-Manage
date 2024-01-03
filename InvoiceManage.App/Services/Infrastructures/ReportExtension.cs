using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;

namespace InvoiceManage.App.Services.Infrastructures
{
    public static class ReportExtension
    {
        public static void MakeReport(this string mrtName, string destPath, Dictionary<string, IEnumerable> parameters)
        {
            try
            {
                var sti = new StiReport();

                var stiFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources\\Templates", mrtName).Replace("/", "\\");

                sti.Load(stiFilePath);

                foreach (var parameter in parameters.Where(parameter => sti.Dictionary.DataSources[parameter.Key] is not null))
                    sti.RegData(parameter.Key, parameter.Value);

                sti.Render(true);

                sti.LoadDocumentFonts();
                sti.LoadFonts();

                sti.ExportDocument(StiExportFormat.Pdf, destPath, new StiPdfExportSettings
                {
                    EmbeddedFonts = true,
                    UseUnicode = true
                });
            }
            catch (Exception)
            {
                CustomMessageBox.Show("فایل انتخابی باز است. برای ذخیره فایل آن را ببندید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}