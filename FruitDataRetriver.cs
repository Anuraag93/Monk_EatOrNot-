using System;
using System.Linq;

namespace Monk_github
{
    public class FruitDataRetriver : IFruitDataRetriver
    {
        private readonly string[] input;
        private readonly IInputValidator validator;
        public FruitDataRetriver(string[] _input, IInputValidator _validator)
        {
            input = _input;
            validator = _validator;
        }
        public int[,] FruitData()
        {
            if(validator.IsNuberOfFruitsValid())
            {
                int num = Convert.ToInt32(input[1].Trim());
                int[,] data = new int[num,4];           
                
                for(int i = 0; i < num; i++)
                {
                    if(validator.IsNumberOfSuplimentsValid(i))
                    {                        
                        int[] fruit = input[i+2].Trim().Split(' ').Select<string, int>(int.Parse).ToArray();
                        data[i,0] = fruit[0];
                        data[i,1] = fruit[1];
                        data[i,2] = fruit[2];
                        data[i,3] = fruit[3];
                    }
                }
            
            return data;
            }
            Console.WriteLine("invalid number of fruits");
            return null;
        }
    }
}