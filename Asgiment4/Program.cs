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
        //answer 6
        public static double ApplyDiscount(double[] price)
        {
            return price[0] = price[0] - 5;
        }
        //answer 7
        public static int AddBounsPages1(ref int pages)
        {
            return pages += 50;
        }
        //answer 8
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        //answer9
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "clean code")
            {
                price = 25.5;

                return true;
            }
            else
            {
                price = 0;
                return false;

            }

        }//answer 10 
        public static void PrintBookInfo(string title, int pages = 300)
        {
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
            //answer 6
            double[] price = { 25.5, 40.0 };
            ApplyDiscount(price);
            Console.WriteLine(price[0]);
            //answer 7
            AddBounsPages1(ref pages);
            Console.WriteLine(pages);//لانه بيشير لنفس المكان بيروح لنفس الvarمش زي المره الى فاتت بياخد copyمن الvalue

            //answer 8
            double[] prices = { 10.0, 12.5, 15.0 };
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
            //answer 9
            double pre;
            Console.WriteLine(TryGetPrice("clean code", out pre));
            //answer 10
            PrintBookInfo("learn english");
            PrintBookInfo("learn english", 700);
            //answer 11
            PrintBookInfo( pages:700,  title:"learn");


        }
    }
}
