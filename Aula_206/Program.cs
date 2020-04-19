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

            //Outra maneira é criar uma expressão lambda, ou seja uma função que não precisa ser declarada
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);//Passar a variável que guarda a função

            //OU
            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
