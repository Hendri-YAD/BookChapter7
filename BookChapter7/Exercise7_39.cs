using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter7
{
    class Exercise7_39
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            bool cont = true; bool isCorr = false;
            int x, y;
            int ans;

            while (cont)
            {
                isCorr = false;
                x = rnd.Next(1, 10);
                y = rnd.Next(1, 10);
                Console.WriteLine("How much is {0} times {1}?", x, y);

                while (!isCorr)
                {
                    ans = Convert.ToInt32(Console.ReadLine());
                    if (ans == x * y)
                    {
                        isCorr = true;
                        Console.WriteLine("Very good!");
                    }
                    else
                        Console.WriteLine("No. Please try again");
                }

                Console.WriteLine("To continue, enter yes. To quit, enter no.");
                if (Console.ReadLine() == "no")
                    cont = false;
            }                        

        }
    }
}
