using Essentials2.Exceptions;
using Essentials2.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Essentials2.Threading
{
    public class ThreadingDemo
    {
        // Async and Await
        public async Task SimpleThreadAsync()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            try
            {
                Task tRichard = DoFileWorkAsync("RichardData");
                Task rErlich = DoFileWorkAsync("ErlichData");

                Console.WriteLine("Work happening in main thread.");

                await Task.WhenAll(tRichard, rErlich);
            }
            catch (AggregateException ex)
            {
                //ex.Handle((inner) => inner is JsonException);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        public async Task DoFileWorkAsync(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            string filePath = $"..\\..\\..\\{fileName}.json";
            //this could take a while
            var employeeJson = await File.ReadAllTextAsync(filePath);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"File access thread id **: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            var data = JsonSerializer.Deserialize<Worker>(employeeJson);

            Console.WriteLine($"Employee read from file: {data.Id} , {data.FirstName} {data.LastName}");
        }

        // ****************************************************************************************************
        
        // Treading Basics
        public void SimpleThread()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            Thread t = new Thread(DoFileWork);

            t.Start();
            Console.WriteLine("Work happening in main thread.");
            t.Join();
        }

        public static void DoFileWork()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ResetColor();

            string filePath = "..\\..\\..\\RichardData.json";
            //this could take a while
            var employeeJson = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<Worker>(employeeJson);

            Console.WriteLine($"Employee read from file: {data.Id} , {data.FirstName} {data.LastName}");
        }


    }
}
