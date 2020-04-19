using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Aula_206.Entities
{
    class Product //A classe não implementa mais a inteface IComperable nem preciso do método do mesmo, com isso a classe estar fechada
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
