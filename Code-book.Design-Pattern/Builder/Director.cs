using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_book.Design_Pattern.Builder
{
    public class Director
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.NewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
