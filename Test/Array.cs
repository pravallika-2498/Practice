using System;

namespace Test
{
    class Array
    {
        static void Main()
        {
            int[] arr1 = new int[10];
            int i, size, location = 0, newvalue;

            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine()); //convert string into int
            Console.Write("enter {0} elements in the array:\n", size);

            for (i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the New value to be inserted : ");
            newvalue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the location where New value to be inserted : ");
            location = Convert.ToInt32(Console.ReadLine());
            Console.Write("The exist Array list is :\n ");
            for (i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }

            for (i = size; i >= location; i--)
            {
                arr1[i] = arr1[i - 1];
                arr1[location] = newvalue;//insert value at selected location
            }
            Console.Write("\n\nAfter Insert Array list is :\n ");
            for (i = 0; i <= size; i++)
            {   
                Console.Write("{0} ", arr1[i]);
            }
        }
    }
}
