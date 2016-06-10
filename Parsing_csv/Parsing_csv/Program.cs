using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_csv
{
    class Program
    {
 

        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            string[] fileLines = File.ReadAllLines(@"C:\Users\monny\Desktop\pdsfeed_footlocker_fr_neu.csv");


            // Skip(1) - zaisti aby sa nevypisala hlavicka / nevypise sa prvy riadok suboru
            var items = ((from line in fileLines.Skip(1)
                         // nastavenie speparatora v hlavicke suboru 
                        let data = line.Split(';')
                        select new
                        {
                            ID = data[0],
                            Title = data[2],
                            Price = data[4],
                            Availability = data[8],
                        }).Take(10)).ToList();

            foreach (var i in items)
             {
                 Console.WriteLine(i);

             }

            Console.ReadKey();

        }
    }
}
