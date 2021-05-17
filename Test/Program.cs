using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string Username = Console.ReadLine();
            string[] t = DateTime.Now.ToString("HH:mm:ss").Split(":");// removing date and converting  time into 24hr format
            int hour = Int32.Parse(t[0]);
            int minutes = Int32.Parse(t[1]);
            int seconds = Int32.Parse(t[2]);


            if (hour >= 5 && hour <= 12)
            {
                Console.WriteLine("good morning {0} ", Username);
            }
            else if (hour >= 13 && hour <= 18)
            {
                Console.WriteLine("good afternoon {0} n", Username);
            }
            else if (hour >= 18 && hour <= 24)
            {
                Console.WriteLine("good night {0} now time is {1}", Username, DateTime.Now.ToString("hh:mm tt"));
            }
            else
            {
                Console.WriteLine("good bye"); }

        
        }
        }

        
     
    }

