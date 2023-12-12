using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCodeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenericValueCollection<int> genericValueCollection = new GenericValueCollection<int>();

            genericValueCollection.AddItem(10);
            genericValueCollection.AddItem(5);
            genericValueCollection.AddItem(13);
            genericValueCollection.AddItem(3);


            int item = genericValueCollection.GetItem(3);

            Console.WriteLine($"\nItem at index 3: {item}");

            Console.WriteLine("\nSorted Descending Collections are Below:");

            CollectionOutput(genericValueCollection.GetSortedDescendingCollection());
               
        }

       public static void CollectionOutput<T>(List<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
        }

    }
}