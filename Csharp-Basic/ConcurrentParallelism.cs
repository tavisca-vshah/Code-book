using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Basic
{
    //This class demostrate concurrent vs parallelism concent
    public class ConcurrentParallelism
    {
        public static void ParallelOrchestration()
        {
            // simulate some background task
            Task.Factory.StartNew(DownloadFile1Parallel);
            Task.Factory.StartNew(DownloadFile2Parallel);

            Console.WriteLine("Both file downloaded, ready to perform new operation");
            Console.WriteLine("Enter some string:");
            string userName = Console.ReadLine();
            Console.WriteLine(userName);
        }
        private static void DownloadFile1Parallel()
        {
            // simulate some background task
            Task.Delay(10000).Wait();
            Console.WriteLine("downloaded file 1");
        }
        private static void DownloadFile2Parallel()
        {
            // simulate some background task
            Task.Delay(10000).Wait();
            Console.WriteLine("downloaded file 2");
        }
        public static void ConcurrentOrchestration()
        {
            // simulate some background task
            DownloadFile1Concurrent();
            DownloadFile2Concurrent();

            Console.WriteLine("Both file downloaded, ready to perform new operation");
            Console.WriteLine("Enter some string:");
            string userName = Console.ReadLine();
            Console.WriteLine(userName);
        }
        private static async Task DownloadFile1Concurrent()
        {
            // simulate some background task
            await Task.Delay(10000);
            Console.WriteLine("downloaded file 1");
        }
        private static async Task DownloadFile2Concurrent()
        {
            // simulate some background task
            await Task.Delay(10000);
            Console.WriteLine("downloaded file 2");
        }
    }
}
