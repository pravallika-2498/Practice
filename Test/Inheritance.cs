using System;

namespace Test
{
    public class Bookstore
    {
        public static void Main()
        {
            Book myStore = new Book();
            myStore.Greet();

            First Fir = new First();
            Fir.Settype(21);
            Fir.Setpublisher("Maple");
            Fir.Publisher();
            Fir.Showtype();
            

           second sec = new second();
            sec.Setpublisher("Disney");
            sec.Settype(10);
            sec.des();
        }
    }

    public class Book
    {
        protected int type;
        private string a;
        public string name
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
        public void Greet()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("       Welcome to Chitrakala books Store!!");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("\nTwo Publishers:");// 
        }

        public void Settype(int n)
        {
            type = n;
        }
        public void Setpublisher(string p)
        {
            name = p;
        }
    }

    public class First : Book//BOOKS
    {
        public void Publisher() // Publisher
        {
            Console.WriteLine("\nPublisher is {0}", name);
        }

        public void Showtype() // TYPES
        {
            Console.WriteLine("{0} types of books  are available", type);
        }
    }

    public class second: Book// 
    {

        public void des()
        {
            Console.WriteLine("\n{0} Publishers:Story books\n{1} types of  story books available ",name,type);
        }

    }
}