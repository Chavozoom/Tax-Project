using System.Globalization;
using Training.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(ch == 'i' || ch == 'Y')
                {
                    Console.Write("Health Expeditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employees));
                }
                Console.WriteLine();
            }
            Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += taxPayer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}