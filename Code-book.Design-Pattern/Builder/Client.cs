using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_book.Design_Pattern.Builder
{
    public class Client
    {

        public void Use()
        {
            Report report;
            Director director = new Director();

            ReportBuilder pdfReportBuilder = new PdfReportBuilder();
            report = director.MakeReport(pdfReportBuilder);
            report.DisplayReport();

            ReportBuilder reportBuilder = new ExcelReportBuilder();
            report = director.MakeReport(reportBuilder);
            report.DisplayReport();
        }
    }
}
