using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Invoice FInvoice = new FinalInvoice();
            //Invoice PInvoice = new ProposedInvoice();
            //Invoice RInvoice = new RecurringInvoice();
            //double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            //double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            //double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);


            //Fruit fruit = new Orange();
            //Console.WriteLine(fruit.GetColor());
            //fruit = new Apple();
            //Console.WriteLine(fruit.GetColor());

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }



    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

}
