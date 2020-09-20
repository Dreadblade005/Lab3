using System;

namespace part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean lamp;
            Boolean plugged;
            Boolean bulb;


            if (lamp = true)
            {
                Console.WriteLine("The lamp works");
            }
                else
            { 
            if (plugged = false)
            {
                    Console.WriteLine("Please Plug in lamp");
            }
                else 
                {
            if (bulb = false)
               {
                      Console.WriteLine("The Bulb is dead, it does not work");
               }
                else
                    {
                        Console.WriteLine("The lamp should be working");
                    }
               
               

                }
            }
        }
    }
}
