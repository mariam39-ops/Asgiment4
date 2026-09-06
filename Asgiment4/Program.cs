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
        //answer 4
        public static string PrintBookTitle(string title)
        {
            return $"book title : {title}";
        }
        //answer 5
        public static int AddBounsPages(int pages)
        {
            return pages += 50;
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
            //answer 4
            Console.WriteLine(PrintBookTitle("Clean code"));
            //answer 5
            int pages = 400;
            AddBounsPages(pages);
            Console.WriteLine(pages);//مفيش زياده لان دى value type بياخد copy منالvariable passing by value


        }
    }
}
