using System;
using System.Collections;
using System.Collections.Generic;

namespace CleanCode.AgilePractices.Smells
{
    public class PrintInvoice
    {
        public void PrintOwing(Invoice invoice)
        {
            int outstanding = 0;

            Console.WriteLine("---------------------");
            Console.WriteLine("-----Customer Owes---");
            Console.WriteLine("---------------------");


            foreach (var o in invoice.Orders)
            {
                outstanding += o.Amount;
            }

            Console.WriteLine($" name :{invoice.Customer}");
            Console.WriteLine($" amount :{outstanding}");
        }
    }

    public class Order
    {
        public int Amount { get; set; }
    }
    public class Invoice
    {
        public IEnumerable<Order> Orders { get; set; }
        public string Customer { get; set; }
    }
}