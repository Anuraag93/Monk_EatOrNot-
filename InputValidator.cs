using System;

namespace Monk_github
{
    class InputValidator : IInputValidator
    {
        private readonly string[] input;
        public InputValidator(string[] _input)
        {
            input = _input;
        }
        
        public bool IsNumberOfMonkSuplimentsValid()
        {
            string[] MonkNeeds = input[0].Split(' ');
            if(MonkNeeds.Length == 4)
            {
                return IsValueOfSuplimentsValid(MonkNeeds);
            }
            Console.WriteLine("Please Enter valid number of Supliments for Monk.");
            return false;
        }
        public bool IsValueOfSuplimentsValid(string[] sup)
        {
            if(Int32.TryParse(sup[0].Trim(), out Int32 Vit) && 
            Int32.TryParse(sup[1].Trim(), out Int32 Cal) && 
            Int32.TryParse(sup[2].Trim(), out Int32 Fat) && 
            Int32.TryParse(sup[3].Trim(), out Int32 Pro))
            {
                if(10 <= Vit && Vit <= 1000 && 10 <= Cal && Cal <= 1000 && 10 <= Fat && Fat <= 1000 && 10 <= Pro && Pro <= 1000)
                {
                    return true;
                }
                Console.WriteLine($"The value of the supliments are out of range V => {Vit}, C => {Cal}, F => {Fat}, P => {Pro}");
                return false;
            }
            Console.WriteLine("The Entered value of supliments are not numeric.");
            return false;
        }
        public bool IsNuberOfFruitsValid()
        {
            if(int.TryParse(input[1].Trim(), out int NumberOfFruits))
            {
                if(1 <= NumberOfFruits && NumberOfFruits <= 20)
                {
                    if((input.Length - 2) == NumberOfFruits){
                    return true;
                    }
                    Console.WriteLine("The number of Fruits and each fruit detail do not match.");
                    return false;        
                }
                Console.WriteLine("The number of Fruits should be in range of 1 to 20.");
                return false;    
            }
            Console.WriteLine("The Entered number of Fruits are not Valid.");
            return false;
        }
        public bool IsNumberOfSuplimentsValid(int index)
        {
            index += 2;
            string[] fruit = input[index].Split(' ');
            if(fruit.Length == 4)
            {
                return IsValueOfSuplimentsValid(fruit);
            }
            Console.WriteLine($"Please Enter valid number of Supliments for the fruit at {index}.");
            return false;
        }
        // bool IsValueOfSuplimentsValid(int index);
    }
}