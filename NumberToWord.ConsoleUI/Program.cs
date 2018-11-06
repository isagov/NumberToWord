using System;
using System.Text.RegularExpressions;
using NumberToWord.Core;


namespace NumberToWord.ConsoleUI
{
    class Program
    {
        static void Main()
        {
        Start:
            Operations helper=new Operations();

            Console.WriteLine("1-999 999 999 999 aralığında tam ədəd daxil edin:");

            string sNumber = Console.ReadLine();

            if (sNumber!=null&&helper.CheckNumberForLength(sNumber)&&long.Parse(sNumber)>=0)
            {
                long inp = long.Parse(sNumber);
                string input = helper.MakeStandartString(inp);
                string[] array = helper.CreateArrayFromString(input);
                string result = "";

                helper.RemoveRedundantClasses(inp, array);
                helper.RemoveZeroesFromArray(input, array);

                for (int j = 0; j <= 18; j++)
                {
                    result += array[j] + " ";
                }

                if (inp==0)
                {
                    Console.WriteLine("SIFIR");
                }
                Console.Write(Regex.Replace(result, "[ ]+", " ").ToUpper());

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Düzgün ədəd daxil edilməyib!");
            }
            
            goto Start;
        }
    }
}
