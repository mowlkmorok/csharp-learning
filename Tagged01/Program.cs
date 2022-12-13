using Tagged01.Entities;
using System;

namespace Tagged01
{

    class Program
    {

        static void Main(string[] args)
        {


            //=====================================================================================

            List<Product> list = new List<Product>();

            //-------HOW MANY PRODUCTS-------------------------------------------------------------
            System.Console.Write("How many product: ");
            int count = int.Parse(Console.ReadLine()!);

            while (count > 0)
            {
                System.Console.WriteLine("------------------------------------------------------");
                System.Console.WriteLine("Common, used or imported ( c/u/i )");

                string op1 = System.Console.ReadLine()!;

                string op = op1.ToLower();

                System.Console.Write("Product name: ");
                string name = System.Console.ReadLine()!;

                System.Console.Write("Price: ");
                double price = double.Parse(System.Console.ReadLine()!);
                
                switch (op)
                {
                    case "c":
                        list.Add(new Product(name, price));
                        break;

                    case "u":
                        System.Console.WriteLine("Manufacture date (DD/MM/YYYY)");
                        string dat = System.Console.ReadLine()!;
                        DateTime date_ = DateTime.ParseExact(dat, "dd/MM/yyyy", null);

                        list.Add(new UsedProd(name, price, date_));
                        break;

                    case "i":
                        System.Console.Write("Customs fee: ");
                        double customsFee = double.Parse(System.Console.ReadLine()!);

                        list.Add(new ImportedProd(name, price, customsFee));

                        break;

                    default:

                        System.Console.WriteLine("Invalid option [!]");
                        break;
                }

                count-=1;

            }

        System.Console.WriteLine("\n--------\nPrice TAGS:\n");
        foreach (Product item in list)
        {
            System.Console.WriteLine(item.priceTag());
        }


            
        }
        
    }
    
}