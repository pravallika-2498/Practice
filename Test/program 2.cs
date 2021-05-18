using System;

namespace Test
{
    class Greet
    {
      static void Main()
        {
            Console.WriteLine("Please enter your username");
            string Username = Console.ReadLine();
            time(Username);
        }
       static void time(string name)
        {
            string[] t = DateTime.Now.ToString("HH:mm:ss").Split(":");// removing date and converting  time into 24hr format
            int hour = Int32.Parse(t[0]);
            int minutes = Int32.Parse(t[1]);
            int seconds = Int32.Parse(t[2]);


            if (hour >= 5 && hour <= 12)
            {
                Console.WriteLine("Good Morning {0} \nTime : {1}", name, DateTime.Now.ToString("hh:mm tt"));
            }
            else if (hour >= 13 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon {0} \nTime : {1}", name, DateTime.Now.ToString("hh:mm tt"));
            }
            else if (hour >= 17 && hour <= 20)
            {
                Console.WriteLine("Good Evening {0} \nTime : is {1}", name, DateTime.Now.ToString("hh:mm tt"));
            }
            else if (hour >= 20 && hour <= 24)
            {
                Console.WriteLine("Good Night {0} \nTime : {1}", name, DateTime.Now.ToString("hh:mm tt"));
            }
            else
            {
                Console.WriteLine("Have Good day{0}",name);
            }

        }

        
    }


}
