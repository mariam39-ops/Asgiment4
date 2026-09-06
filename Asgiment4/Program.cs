using System.Security.Cryptography.X509Certificates;

namespace Asgiment4
{
    internal class Program

    {
        //answer 3
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the library!");
        }
        static void Main(string[] args)
        {
            //answer 1
            double[] arr = new double[] { 25.5, 40.0, 33.75 };
            Console.WriteLine(arr[1]);
            //answer 2
            int[,] ShelfCopies =
           {
                {3,5 },
                {1,4 }
            }; Console.WriteLine(ShelfCopies[1, 0]);
            //answer 3
            PrintWelcomeMessage();

        }
    }
}
