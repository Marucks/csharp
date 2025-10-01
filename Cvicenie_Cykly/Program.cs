using System.Threading.Channels;

namespace Cvicenie_Cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   for (int i = 100; i >= 0; i--)

                       Console.WriteLine(i);
            */
            {
                /*   int i = 0;
                     while (i <= 100)

                      Console.WriteLine(i);
                     i++;
                */
                /*   while (true)
                   {
                       string input = Console.ReadLine();

                       if (input == "pozdrav")
                       {
                           Console.WriteLine("ahoj");
                       }
                       else if (input == "exit")
                       {
                           break;
                       }
                       else if (input == "koniec") ;
                       {
                           break;
                       }
                   */
                /*
                while (true)
                {
                    while (true)
                    {

                        Console.WriteLine("Type Exit to exit aplication");
                        string input = Console.ReadLine();
                        if (input == "Exit")
                        {
                            break;
                        }
                        Console.WriteLine("PLease Exit the aplication");
                    }

                    Console.WriteLine("There was an Error while trying to exit");
                    Console.WriteLine("Type ForceExit to Force Crash");
                    
                    string inputOne = Console.ReadLine();
                    if (inputOne == "ForceExit")
                    {
                        break;
                    }
                        Console.WriteLine("PLease close once again");

                }
                */

            }
            
             
                    Console.WriteLine("Enter Size");
                    string input3 = Console.ReadLine();

                    Console.WriteLine("Enter Symbol");
                    string input2 = Console.ReadLine();

                   
                    int input = int.Parse(input3);
                    for (int i = 1; i < input; i++)
                    {
                        string row = input2;
                        for (int j = 0; j < i; j++)
                        {
                            row += input2;
                        }

                        Console.WriteLine(row);
                    }
            


                
            
            
            
            
            
            
        
        
        
        
        
        
        }

    }
}
