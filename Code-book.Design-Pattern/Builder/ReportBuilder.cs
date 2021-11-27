using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_book.Design_Pattern.Builder
{
    public abstract class ReportBuilder
    {
        protected Report report;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public void NewReport()
        {
            report = new Report();
        }

        public Report GetReport()
        {
            return report;
        }

    }

    public class PdfReportBuilder : ReportBuilder
    {
        public override void SetReportFooter()
        {
            report.SetFooter("XYZ PVT LTD PDF report");
        }

        public override void SetReportHeader()
        {
            report.SetHeader("XYZ PVT LTD PDF report");
        }

        public override void SetReportType()
        {
            report.ReportType = "PDF";
        }
    }
    public class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportFooter()
        {
            report.SetFooter("XYZ PVT LTD Excel report");
        }

        public override void SetReportHeader()
        {
            report.SetHeader("XYZ PVT LTD Excel report");
        }

        public override void SetReportType()
        {
            report.ReportType = "Excel";
        }
    }
}
