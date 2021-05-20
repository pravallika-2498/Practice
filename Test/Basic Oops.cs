using System;

namespace Test
{
    
 
public class Basic_Oops    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];// created Object array
            

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\nEnter Name {0}\n",i+1);
                persons[i] = new Person()
                {
                    Name = Console.ReadLine() // 
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());// converting object to string by calling tostring() method
            }

            Console.ReadLine();
        }

        public class Person
        {
            private string N = "JOHN";// Cannot Access because variable is private

            public string Name { get; set; }// Encapusulation
            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }
        }
    }
}
