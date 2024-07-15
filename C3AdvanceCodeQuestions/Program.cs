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
        static int Main(string[] args)
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
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result2 = Helper.FindTwoSum(nums, target);

            Console.WriteLine($"Indices: {result2[0]}, {result2[1]}");


            //1.3. Dictionaries and Arrays
            /*Group Anagrams
            Question: Given an array of strings, group anagrams together. For example, 
            given ["eat", "tea", "tan", "ate", "nat", "bat"], return [["eat", "tea", "ate"], 
            ["tan", "nat"], ["bat"]].*/
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result3 = Helper.Group(strs);

            foreach (var group in result3)
            {
                Console.WriteLine(string.Join(", ", group));
            }

            //1.4. Dictionaries and Arrays
            /*Longest Consecutive Sequence
            Question: Given an unsorted array of integers, 
            find the length of the longest consecutive elements sequence. For example, given [100, 4, 200, 1, 3, 2], 
            the longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.*/
            int[] nums4 = { 100, 4, 200, 1, 3, 2 };
            int result4 = Helper.LongestConsecutive(nums);

            Console.WriteLine($"Length of the longest consecutive sequence: {result4}");
    
            //1.5. Dictionaries and Arrays
            /*Find All Duplicates in an Array
            Question: Given an array of integers, find all the duplicates in the array. 
            For example, given [4,3,2,7,8,2,3,1], return [2, 3].*/
            int[] nums5 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            var result5 = Helper.FindAllDuplicates(nums);

            Console.WriteLine($"Duplicates: {string.Join(", ", result5)}");
            
            //1.6. Dictionaries and Arrays
            int[] nums62 = { 1, 2, 2, 1 };
            int[] nums63 = { 2, 2 };
            var result6 = Helper.Intersect(nums63, nums63);

            Console.WriteLine($"Intersection: {string.Join(", ", result)}");



            //2.0
            /*Given a list of integers, write a method that returns a new list containing 
            only the even numbers from the original list using a lambda expression.*/
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = Helper.GetEvenNumbers(numbers);

            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            //2.1
            /*Sorting a List of Strings by Length
            Problem:
            You have a list of integers and you need to filter out all the numbers that are greater than 10.*/

            List<int> numeros = new List<int> { 1, 5, 11, 12, 4, 2, 8, 20, 3};
            List<int> numerosOrdenados = numeros.Where(n => n > 10).ToList();

            System.Console.WriteLine("Numeros > than 10: ");
            numerosOrdenados.ForEach( n => System.Console.WriteLine(n));


            //2.2
            /*Sorting a List of Strings by Length
            Problem:
            You have a list of strings and you need to sort them by their lengths in ascending order.*/
            List<string> words = new List<string> { "apple", "banana", "pear", "grapefruit"};
            List<string> sortwords = words.ForEach( w => w.Length).ToList();

            System.Console.WriteLine("Words sorted by length: ");
            sortwords.ForEach(w => System.Console.WriteLine(w));


            //2.3
            /*Transforming a List of Numbers
            Problem:
            You have a list of integers and you need to transform each number by squaring it.*/
            List<int> numeros1 = new List<int> { 1, 2, 3, 4};
            List<int> numeros2 = numeros1.ForEach( n => n*n).ToList();

            System.Console.WriteLine("Square numbers:");
            numeros2.ForEach( n => System.Console.WriteLine(n));

            //3.0
            /*Create an extension method for the string class that reverses the string.*/
            string original1 = "hello";
            string reverced = Helper.ReverseString(original1);

            System.Console.WriteLine($"Original: {original1}");
            System.Console.WriteLine($"Reverced: {reverced}");

            //3.1
            /**/            
            
            //3.2
            /**/
        }
    }
}