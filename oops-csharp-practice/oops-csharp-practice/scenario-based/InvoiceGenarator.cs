using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops
{
    internal class InvoiceGenarator
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("------------------------ Welcome to the Invoice generator -----------------------------");
            Console.WriteLine("The format of your input should follow : Task Name - Amount Currency which will be separated by commas");


            string InpFromTheUser = Console.ReadLine();
            StoreTasks(InpFromTheUser);

        }

        public void StoreTasks(string str)
        {
            string[] tasks = str.Split(',');



            string[,] invoices = new string[tasks.Length, 2];

            for (int i = 0; i < tasks.Length; i++) 
            {
                string[] parts = tasks[i].Split("-");
                invoices[i,0] = parts[0].Trim();
                invoices[i,1] = parts[1].Trim();
            }

            CreateInvoice(invoices);
        }

        public void CreateInvoice(string[,] invoices) 
        {
            Console.WriteLine("Invoice for the provided services ");


            int total = 0;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Item No.   Service                     Amount");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < invoices.GetLength(0); i++)
            {
                Console.WriteLine($"{(i + 1),-10} {invoices[i, 0],-25} {invoices[i, 1],-10}");

                string amountText = invoices[i, 1].Replace("INR", "").Trim();
                total += Convert.ToInt32(amountText);
                
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine($"{"",-10} {"Total Amount",-25} {total} INR");

        }


    }
}
