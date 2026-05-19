using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World"); //print String

            //Numbers 
            int num1 = 100;
            Console.WriteLine(num1);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long number = 1220000000L;
            Console.WriteLine(number);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            float floatNumber = 15.00021F;
            Console.WriteLine(floatNumber);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal decimalNumber = 100.90M;
            Console.WriteLine($"Decimal Number: { decimalNumber}");
            //Same code 
            Console.WriteLine("Dceimal Number : {0}", decimalNumber);

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            double number2 = 12500D;
            Console.WriteLine(number2);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //String 
            string name = "Nazmul Hoque"; // String used double quate
            Console.WriteLine(name);

            char letter = 'M'; //character used single quate
            Console.WriteLine(letter);

            //convert Number 
            string ageString = "27";
            int intNumber = Convert.ToInt32(ageString);
            Console.WriteLine(intNumber);

            string numString1 = "9000000000000";
            long bigNumger = Convert.ToInt64(numString1); // Convert into long number
            Console.WriteLine(bigNumger);

            string numSting2 = "55.265";
            double doubleNum = Convert.ToDouble(numSting2); //Convert into Double number
            Console.WriteLine(doubleNum);

            string numString3 = "10.00000525646";
            float floatNum = Convert.ToSingle(numString3); //convert into Float number
            Console.WriteLine(floatNum);

            string numString4 = "10.99";
            decimal decimalNum = Convert.ToDecimal(numString4); // Convert into Decimal 
            Console.WriteLine(decimalNum);

            //Boolean Type 
            bool isMale = true;
            Console.WriteLine(isMale);

            // Operators 

            int value = 10;
            value++; // Increment Operator. It means value + 1.
            //Same code 
            value = value + 1;
            //Or
            value += 1;
            //Same as --, +=, *=, /=, -=

            Console.WriteLine(value);
            value--; // Decrement operator. It means value - 1.
            Console.WriteLine(value);

            //Remainder operator
            int fNum = 100;
            int lNum = 3;
            int modulus = fNum % lNum;
            Console.WriteLine(modulus); //1


            // var keyword

            var intNum = 1000;

            Console.WriteLine(intNum);
            var n= 1000000;
            var str = "Nazmul Hoque";


            // const keyword : const keyword used to constant data. It is unmute data. 
            const int n1 = 12;
            //n1 = 90;  // show Error. Because n1 declare const.

            Console.ReadLine();
        }
    }
}
