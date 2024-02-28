using System;

namespace inluppg6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            if (isPrimtal(tal))
            {
                Console.WriteLine("Primtal");
            }
            else
            {
                Console.WriteLine("Inte primtal");
            }
        }

        static bool isPrimtal(int x)
        {
            if(x % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i < x; i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }


            return true;
        }
    }
}