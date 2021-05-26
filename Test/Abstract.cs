using System;

namespace Test
{
    abstract class Name
    {
       
        private string a;
        public string s
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
       
        public abstract void setname();  // Abstract method (does not have a body)
        public void displayname()     // Regular method
        {
            
            Console.WriteLine(s);
        }
    }

    // Derived class (inherit from Name)
    class Lastname : Name
    {
        public override void setname()
        {
            Console.WriteLine("Enter Last name:");

           s = Console.ReadLine();
            
        }
    }

    class Firstname : Name
    {
        public override void setname()
        {

            Console.WriteLine("Enter First name:");

           s = Console.ReadLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Firstname F = new Firstname();
            F.setname();//Call the abstract method

            Lastname L = new Lastname();
            L.setname();//Call the abstract method

            F.displayname();  // Call the regular method
            L.displayname();  // Call the regular method 



        }
    }
}
