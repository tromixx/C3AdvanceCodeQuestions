using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CompileCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Create a generic method that takes a list of items and a predicate, 
            //and returns a new list of items that match the predicate. Use a lambda expression to define the predicate.
            var demo2 = new CombinedDemo();

            var intList2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers2 = demo2.FilterList(intList2, n => n % 2 == 0);

            foreach (var number in evenNumbers2)
            {
                Console.WriteLine(number); // 2, 4, 6, 8, 10
            }

            var stringList2 = new List<string> { "apple", "banana", "cherry", "date" };
            var longStrings2 = demo2.FilterList(stringList2, s => s.Length > 5);

            foreach (var str in longStrings2)
            {
                Console.WriteLine(str); // banana, cherry
            }
        }
    }
}