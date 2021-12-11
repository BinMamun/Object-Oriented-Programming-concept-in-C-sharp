using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitasking_Using_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Asynchronous Thread Starting ....");
            Console.WriteLine();
            int[] numbers = new int[] { 2, 4, 6, 8 };

            for (var i = 0; i < numbers.Length; i++)
            {

                
                CallSumAsync((i + 1) * 2, $"# 1+2+...+{(i + 1) * 2} = ");

            }

            Console.WriteLine();
            Console.ReadLine();

        }//Main method


        public static async void CallSumAsync(int n, string s)
        {
            await Task<int>.Run(() =>
            {
                SumAsync(n)
                .ContinueWith(t => Console.WriteLine($"{s} {t.Result}"));

            });
        }//CallSum method 

        private static async Task<int> SumAsync(int n)
        {
            Random r = new Random();
            int sum = 0;
            Console.WriteLine($"Thread no: {Thread.CurrentThread.ManagedThreadId}" +
                $" starts calculating sum of \"1+2+...+{n}\"");

            await Task.Run(() =>
            {
                for (var i = 1; i <= n; i++)
                {

                    sum = sum + i;
                    Task.Delay(r.Next(300))
                    .Wait();

                }
            });
            return sum;
        }//Sumasync method 
                

    }//Program Class
}
