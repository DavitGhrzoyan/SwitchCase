using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int orer = int.Parse(Console.ReadLine());
            switch (orer)
            {
                case 1:
                    Console.WriteLine("Erkushabti");
                    break;
                case 2:
                    Console.WriteLine("Ereqshabti");
                    break;
                case 3:
                    Console.WriteLine("4shabti");
                    break;
                case 4:
                    Console.WriteLine("5shabti");
                    break;
                case 5:
                    Console.WriteLine("Urbat");
                    break;
                case 6:
                    Console.WriteLine("Shabat");
                    break;
                case 7:
                    Console.WriteLine("Kiraki");
                    break;
                default:
                    Console.WriteLine("Goyutyun chuni");
                    break;
                    
            }

        }
    }
}
