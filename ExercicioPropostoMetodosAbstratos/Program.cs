using ExercicioPropostoMetodosAbstratos.Entities;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {









            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= taxPayers; i++)
            {
                Console.Write($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type)
                {
                    case 'c':
                        Console.Write("Number of employees: ");
                        int employees = int.Parse(Console.ReadLine());
                        list.Add(new LegalPerson
                        {
                            Name = name,
                            AnnualIncome = annualIncome,
                            Employees = employees
                        });
                        break;
                    default:
                        Console.Write("Health Expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new PhysicalPerson
                        {
                            Name = name,
                            AnnualIncome = annualIncome,
                            HealthExpenditures = healthExpenditures
                        });
                        break;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Person person in list)
            {
                sum += person.CalcTax();
                Console.WriteLine(person.Name + ": R$ " + person.CalcTax().ToString("F2"), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("");
            Console.WriteLine("TOTAL TAXES: R$ " + sum.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}