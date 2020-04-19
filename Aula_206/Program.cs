using System;
using System.Globalization;
using System.Collections.Generic;
using Aula_206.Entities;

namespace Aula_206
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort();

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
