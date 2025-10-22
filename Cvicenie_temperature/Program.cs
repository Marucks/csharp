using System.ComponentModel.Design;

namespace Cvicenie_temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var temp = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };
            
            string command = Console.ReadLine();
            int avg = temp.Sum();
            foreach (int temps in temp)
            {
                Console.WriteLine();
            }
            Console.Write("Enter command: ");
            if (command == "min")
            {
                int min = temp.Min();
                Console.WriteLine("Lowest temperature: " + min);
            }
            else if (command == "max")
            {
                int max = temp.Max();
                Console.WriteLine("Highest temprerature: " + max);
            }
            else if (command == "avg")
            {
                
                Console.WriteLine("Average temprerature: " + (double)avg / temp.Count);
            }
            else if (command == "HAvg")
            {

            }
            */

            List<int> teploty = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };
            List<int> kladneTeploty = new List<int>();
            foreach (int teplota in teploty)
            {
                if(teplota >= 0)
                {
                    kladneTeploty.Add(teplota);
                }
            }

            Console.WriteLine("Kladne: ");
            foreach (var i in kladneTeploty)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();









        }
    }
}
