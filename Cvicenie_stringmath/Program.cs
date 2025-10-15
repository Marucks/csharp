using System.Threading.Channels;

namespace Cvicenie_stringmath
{
    internal class Program
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("People_100.csv");
            Kamnem(text);
        }

        public static void Kamnem(string[] text)
        {
            int sum = 0;
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(';');
                int RodneCislo = int.Parse(splits[2]);
                sum += RodneCislo;
            }
            Console.WriteLine(sum);
        }
    }
}
