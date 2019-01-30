using System;
using MessagePrinter; 

namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MessagePrintingService("this message"); 
            var newservice = new MessagePrintingService();             
            service.PrintMessage();
            newservice.PrintMessage();          
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); 
        }
    }
}
