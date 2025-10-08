using System.Net.WebSockets;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Dlzka pola je : " + numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }


            int[] numbersNew = new int[11];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersNew[i] = numbers[i];
            }
            numbersNew[10] = 10000;
            foreach (var i in numbersNew)
            {
                Console.WriteLine(numbersNew[i]);
            }











        }
    }
}