using System;
using System.Globalization;

namespace Vet_Produtos

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i].Price;
            }
            double avg = sum/ n;
            Console.WriteLine("O preco medio dos produtos e de: $ " + avg.ToString("F2", CultureInfo.InvariantCulture)); 
        }

    }
}
