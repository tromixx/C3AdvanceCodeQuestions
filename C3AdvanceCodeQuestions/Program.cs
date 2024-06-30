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
            //1.0 Create a generic method that takes a list of items and a predicate, 
            //and returns a new list of items that match the predicate. Use a lambda expression to define the predicate.
            var demo2 = new CombinedDemo();

            var intList2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers2 = demo2.FilterList(intList2, n => n % 2 == 0);

            // foreach (var number in evenNumbers2)
            // {
            //     Console.WriteLine(number); // 2, 4, 6, 8, 10
            // }

            var stringList2 = new List<string> { "apple", "banana", "cherry", "date" };
            var longStrings2 = demo2.FilterList(stringList2, s => s.Length > 5);

            // foreach (var str in longStrings2)
            // {
            //     Console.WriteLine(str); // banana, cherry
            // }

            /*1.1. Dictionaries and Arrays
            Find the First Non-Repeating Character in a String
            Question: Given a string, find the first non-repeating character. 
            For example, in the string "swiss", 
            the first non-repeating character is 'w'.*/
            string input = "papos";
            char? result = Helper.FindFirstNonRepeatingChar(input);
            Console.WriteLine(result.HasValue ? result.Value.ToString() : "No non-repeating character found");
    

            //1.2. Dictionaries and Arrays
            /*Two Sum Problem
            Question: Given an array of integers and a target sum, 
            return the indices of the two numbers that add up to the target sum.*/
            

            //1.3. Dictionaries and Arrays
            /*Group Anagrams
            Question: Given an array of strings, group anagrams together. For example, 
            given ["eat", "tea", "tan", "ate", "nat", "bat"], return [["eat", "tea", "ate"], 
            ["tan", "nat"], ["bat"]].*/

            //1.4. Dictionaries and Arrays
            /*Longest Consecutive Sequence
            Question: Given an unsorted array of integers, 
            find the length of the longest consecutive elements sequence. For example, given [100, 4, 200, 1, 3, 2], 
            the longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.*/

            //1.5. Dictionaries and Arrays
            /*Find All Duplicates in an Array
            Question: Given an array of integers, find all the duplicates in the array. 
            For example, given [4,3,2,7,8,2,3,1], return [2, 3].*/

            //1.6. Dictionaries and Arrays
        }
    }
}