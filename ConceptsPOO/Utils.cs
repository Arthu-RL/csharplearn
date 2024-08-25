using System;

namespace utils
{
    public class Utils {
        public static string processInput(string input) => input.Length > 0 ? input : "";

        public static Func<string, int> stoi = input => input.Length > 0 ? Convert.ToInt32(input) : (int)0;
    }

    public class PrimeNumbers {
        public static bool VerifyPrime(int x)
        {
            Console.Write("Put the number you want to discover if it is prime: ");

            if (x < 2)
            {
                Console.WriteLine("That is not a prime number!");
                return false;
            }
            else if (x == 2)
            {
                Console.WriteLine("FOUND A PRIME NUMBER!!!");
                return true;
            }

            if (x % 2 == 0)
            {
                Console.WriteLine("That is not a prime number!");
                return false;
            }

            double sqrtX = Math.Sqrt(x);

            for (int cont=3; cont <= sqrtX; cont += 2)
            {
                if (x % cont == 0)
                {
                    Console.WriteLine("That is not a prime number!");
                    Console.WriteLine($"Because the remainder of {x} divided by {cont} is 0");
                    return false;
                }
            }

            Console.WriteLine("YOU FOUND A PRIME NUMBER!!!");
            return true;
        }
    }
}
