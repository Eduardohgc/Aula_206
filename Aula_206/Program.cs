using System;
using System.Globalization;
using System.Collections.Generic;
using Aula_206.Entities;

namespace Aula_206
{
    class Program
    {
        /*
            Na forma anterior nossa classe Product não fica fechada
            para alteração: se o critério de comparação mudar,
            precisaremos alterar a classe Product. Ou seja se a classe 
            quiser modificar a comparação pelo Price em ver pelo Name a classe terá de ser
            modificada.

            Podemos então usar outra sobrecarga do método "Sort" da
            classe List:
            public void Sort(Comparison<T> comparison)
        */
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort(CompareProducts);// Utilizar o Sort que recebe um Comparison como argumento que será o método CompareProducts. 
                                       //Não será necessário modificar Product 
                                       //apenas mudar em program caso queira organizar pelo Price 


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
