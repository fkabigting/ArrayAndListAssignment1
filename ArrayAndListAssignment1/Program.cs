using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)

        {
            String[] SportList = new string[] { "Basketball", "Volleyball", "Soccer", "Golf", "Bowling" };
            Console.WriteLine("Please select a number from 1 to 4: ");
            int YouChose = Convert.ToInt32(Console.ReadLine());
            

            while (YouChose < 5)


            {
            Console.WriteLine("This number represents: " + SportList[YouChose]);
            Console.ReadLine();
            YouChose = 10;
            }

            Console.Write("You Entered an Invalid Selection");
            


        }
    }
}
