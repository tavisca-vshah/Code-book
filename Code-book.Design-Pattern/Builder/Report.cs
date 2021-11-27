using System;
using System.Collections;

namespace Code_book.Design_Pattern.Builder
{
    public class Report
    {
        public string ReportType { get; internal set; }
        public ArrayList Headers = new ArrayList();
        public ArrayList Footers = new ArrayList();

        public void SetFooter(string data)
        {
            Footers.Add(data);
        }
        public void SetHeader(string data)
        {
            Headers.Add(data);
        }

        public void DisplayReport()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Report is of type "+ ReportType);
            foreach(var str in Headers)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            foreach (var str in Footers)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("--------------------");
        }
    }
}