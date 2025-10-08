using System.ComponentModel;
using System.Data;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("pick a number to add");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);
                    numbers.Add(number);
                }
                if (command == "del")
                {
                    Console.WriteLine("pick a number to delete");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);
                    numbers.RemoveAt(numbers.Count - 1);
                }
                if (command == "end")
                {
                    break;
                }
                if (command == "list")
                {
                    foreach (int i in numbers)
                    {
                        Console.WriteLine(i);
                    }

                }
                if (command == "deli")
                {
                    Console.WriteLine("pick a position of a number to delete");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);
                    if (number >= 0 && number < numbers.Count)
                    {
                        numbers.RemoveAt(number);
                    }
                    else
                    {
                        Console.WriteLine("this position is not in the list");
                    }

                }
                if (command == "help")
                {
                    Console.WriteLine("type ´add´ to add a number into the list");
                    Console.WriteLine("type ´del´ to remove the number from the list");
                    Console.WriteLine("type ´deli´ to remove the a number from the chosen position");
                    Console.WriteLine("type ´has´ to check if the chosen number is in the list");
                    Console.WriteLine("type ´list´ to open the list");
                    Console.WriteLine("type ´end´ to exit the console");
                    Console.WriteLine("type ´avg´ to calculate the average number on list");
                    Console.WriteLine("type ´min´ to get the biggest number on list");
                    Console.WriteLine("type ´max´ to get the smallest number on list");
                    Console.WriteLine("type ´get´ to find the number on chosen position");
                }
                if (command == "has")
                {
                    Console.WriteLine("pick a number to check");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);
                    bool hasnumberint = numbers.Contains(number);
                    if (hasnumberint)
                    {
                        Console.WriteLine("this number is in the list");
                    }
                    else
                    {
                        Console.WriteLine("this number is not in the list");
                    }
                }
                if (command == "count")
                {
                    int sum = 0;
                    foreach (int num in numbers)
                    {
                        sum += num;
                    }
                    Console.WriteLine(sum);
                }

                if (command == "avg")
                {
                    int sum = 0;
                    foreach (int num in numbers)
                    {
                        sum += num;
                    }
                    Console.WriteLine((double)sum / numbers.Count);
                }

                if (command == "max")
                {
                    int max = numbers[0];
                    foreach (int num in numbers)
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                    Console.WriteLine(max);
                }

                if (command == "min")
                {
                    int min = numbers[0];
                    foreach (int num in numbers)
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                    Console.WriteLine(min);
                }

                if (command == "get")
                {
                    Console.WriteLine("pick a position of a number to get");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);

                    if (number >= 0 && number < numbers.Count)
                    {
                        Console.WriteLine(numbers[number]);
                    }
                    else
                    {
                        Console.WriteLine("this position is not in the list");
                    }

                }
              }
            }
        }
    }