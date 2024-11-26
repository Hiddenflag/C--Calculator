using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Calculator
{
    internal class Program
    {
        enum Operators
        {
            Add = 1, Subtract = 2, Multiply = 3, Divide = 4 , Exit = 0
        }
        static void Main(string[] args)
        {
            Operators input = Operators.Add;
            Console.WriteLine("Welcome to C#-Calculator , Please choose of the operators below and write ONLY their given numbers.");
            while (input != Operators.Exit)
            {
                try
                {
                    Console.WriteLine("1.Add , 2.Substract , 3.Multiply , 4.Divide , 0.Exit");
                    int given = Convert.ToInt32(Console.ReadLine());
                    if ((given > 4) || (given < 0))
                    {
                        Console.WriteLine("The entry number must be between 0-4, try again.");
                        continue;
                    }
                    else if (given == 0)
                    {
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        input = (Operators)given;
                        Console.WriteLine("Now enter your two numbers.");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case Operators.Add:
                                double temp = a + b;
                                Console.WriteLine("{0} + {1} = {2}",a,b,temp);
                                break;
                            case Operators.Subtract:
                                temp = a - b;
                                Console.WriteLine("{0} - {1} = {2}",a,b,temp);
                                break;
                            case Operators.Multiply:
                                temp = a * b;
                                Console.WriteLine("{0} * {1} = {2}",a,b,temp);
                                break;
                            case Operators.Divide:
                                temp = a / b;
                                Console.WriteLine("{0} / {1} = {2}",a,b,temp);
                                break;
                            case Operators.Exit:
                                Console.WriteLine("Bye!");
                                break;
                            default:
                                break;
                        }
                        
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input.");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Dividing by zero is sth not even a calculator can do.");
                    continue;
                }
                catch 
                {
                    Console.WriteLine("Bad input.");
                    continue ;
                }

                
            }
            
            
        }
    }
}
