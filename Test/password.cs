using System;

namespace Test
{
    class password
    {
        static void Main()
        {
            string username, password;
            int ctr = 0, max = 3;
            Console.Write("--------------------------------------------------\n");
            Console.Write("       Please Enter UserName and Password\n");
            Console.Write("--------------------------------------------------\n");

            do
            {
                  if (ctr <= max && ctr !=0)
                    Console.Write("\nInvalid Username or Password\nPlease Try again!!!You have {0} Attempts left \n\n ", max-ctr);
                Console.Write("Username: ");
                username =Console.ReadLine();
                username = username.ToLower() ;
                Console.Write("Password: ");
                password = Console.ReadLine();

                if (username != "outlook" || password != "1234")
                    ctr++;

                else
                    ctr = 1;

            }
            while ((username != "outlook" || password != "1234") && (ctr != max));

            if (ctr == max)
                Console.Write("\nLogin attempt is three or more times. Try later!\n \n");
            else
                Console.Write("\nThe password entered successfully!!!!!\n\n");
        }
    }
}