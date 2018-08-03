using System;
using System.IO;
using System.Linq;

namespace Monk_github
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(StreamReader reader = File.OpenText("input.txt"))
                {
                    Console.WriteLine("Start reading input text file....");
                    string[] content = reader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                                       
                    IInputValidator validator = new InputValidator(content);
                    IFruitDataRetriver retrive = new FruitDataRetriver(content, validator);

                    validator.IsNumberOfMonkSuplimentsValid();
                    
                    int[] expected = content[0].Trim().Split(' ').Select<string, int>(int.Parse).ToArray();
                    int[,] fruits = retrive.FruitData();
                    int num = Convert.ToInt32(content[1].Trim());
                    
                    
                    ICalculateMonkSupliments process = new CalculateMonkSupliments(expected, num);

                    if(process.IsMonkSatisfied(fruits, num, expected[0], expected[1], expected[2], expected[3]))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Error has occured." + ex);

            }
            Console.WriteLine("*********************");
            Console.WriteLine("Press Any Key to exit.");
            Console.ReadKey();
        }
    }
}
