using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JSONDesralize
{
    class Program
    {
        static void Main(string[] args)
        {
            int work= 0, completionPortThreads = 0;
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine($"{0} and {1}",workerThreads, completionPortThreads);
            Console.ReadLine();
            
        }
        static async Task<int> InvokeNow()
        {
            var invoke = AsyncAndWait.ReadFromFile();
            Console.WriteLine("Hi");
          
            return invoke.Result;
        }
    }
}
