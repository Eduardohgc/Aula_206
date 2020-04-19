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

            //Outra maneira é criar uma variável(comp) para guardar uma referência para a função CompareProducts
            Comparison<Product> comp = CompareProducts;

            list.Sort(comp);//Passar a variável que guarda a função


            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        //Método static. Esse método fará a mesma função do IComperable que tinha na classe Product
        static int CompareProducts(Product p1, Product p2)//Os dois produtos para serem comparados
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

    }
}
