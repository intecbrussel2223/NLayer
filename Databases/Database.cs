using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Databases
{
    public class Database
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name="Laptop", Category="Elektro",Price=600.00,Quantity=20},
            new Product(){Name="TV", Category="Elektro",Price=800.00,Quantity=150},
            new Product(){Name="CellPhone", Category="Elektro",Price=700.00,Quantity=25},
            new Product(){Name="AntiVirus", Category="Software",Price=70.00,Quantity=1},
            new Product(){Name="Ms Word", Category="Software",Price=50.00,Quantity=2},
            new Product(){Name="Ms Excel", Category="Software",Price=55.00,Quantity=1},
        };

        public static void SaveToTextFile(List<Product> list, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string HeaderProductName = "Product Name";
                string HeaderPrice = "Price";
                string HeaderQuantity = "Quantity";
                writer.WriteLine(HeaderProductName.PadRight(25) +  HeaderPrice.PadRight(25) + HeaderQuantity.PadRight(25) );

                foreach (Product product in products)
                {
                    writer.WriteLine(product.Name.PadRight(25)  +
                                     product.Price.ToString().
                                     PadRight(25) + 
                                     product.Quantity.ToString().PadRight(25));
                }
            }
        }
    }

}
