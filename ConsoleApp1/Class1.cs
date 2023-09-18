using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckIsEvenNumber
    {
        public void IsEvenNumber()
        {
            Console.WriteLine("Введите число :");
            string? userInput = Console.ReadLine();
            if (userInput != null)
            {
                int userInputNum = Convert.ToInt32(userInput);
                string result = Check(userInputNum);
                Console.WriteLine(result);
            }
        }
        public bool Parity(int num)
        {
            return num % 2 == 0; 
        }

        public string Check(int num)
        {
            bool isEven = Parity(num);
            return isEven ? $"Число - {num} нечетное" : $"Число - {num} нечетное";
        }
    }
}
