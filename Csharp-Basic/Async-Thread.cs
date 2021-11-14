using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basic
{
    public static class Async_Thread
    {
        public static void AsyncOrchestration()
        {
            DownloadAsync();
            Console.WriteLine("In main thread");
        }
        private static async Task DownloadAsync()
        {
            // simulate some background task
            /*
             * It will not spawn new thread, here is catch once async operation completes, it spawn worker thread to resume async code block, 
             * it is very very light thread
             * */
            await Task.Delay(60000);
            Console.WriteLine("Async code completed");
        }
    }
}
