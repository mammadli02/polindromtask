using System.Runtime.Intrinsics.Arm;

namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number2; 
            int number3; 
            int result = 0;
            int number;
           
            Console.WriteLine("ededi daxil edin : ");
 number = Convert.ToInt32(Console.ReadLine());
            number3 = number;
            while (number > 0)
            {
                number2 = number % 10;

                result = result * 10 + number2;
                number = number / 10;

            }
            if (result == number3)
            {
                Console.WriteLine("polindrom ededdir");
            }
            else
            {
                Console.WriteLine( "polindrom deyil");
            }

        }
    }
}