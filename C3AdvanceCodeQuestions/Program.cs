using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design.Serialization;

namespace CompileCs
{
    public delegate int MathOperation(int a, int b);

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    internal static class Program
    {
        static Task<int> Main(string[] args)
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

            Console.WriteLine("Numeros > than 10: ");
            numerosOrdenados.ForEach( n => Console.WriteLine(n));


            //2.2
            /*Sorting a List of Strings by Length
            Problem:
            You have a list of strings and you need to sort them by their lengths in ascending order.*/
            List<string> words = new List<string> { "apple", "banana", "pear", "grapefruit"};
            //List<string> sortwords = words.ForEach( w => w.Length).ToList();

            Console.WriteLine("Words sorted by length: ");
            //sortwords.ForEach(w => Console.WriteLine(w));


            //2.3
            /*Transforming a List of Numbers
            Problem:
            You have a list of integers and you need to transform each number by squaring it.*/
            List<int> numeros1 = new List<int> { 1, 2, 3, 4};
            //List<int> numeros2 = numeros1.ForEach( n => n * n).ToList();

            Console.WriteLine("Square numbers:");
            //numeros2.ForEach( n => Console.WriteLine(n));

            //3.0
            /*Create an extension method for the string class that reverses the string.*/
            string original1 = "hello";
            //string reverced = Helper.ReverseString(original1);

            Console.WriteLine($"Original: {original1}");
            //Console.WriteLine($"Reverced: {reverced}");

            //3.1
            /*Checking if a Number is Even
            Problem:
            Create an extension method for the int class that checks if a number is even.*/            
            int number = 4;
            //bool isEven = number.IsEven();
        
            //Console.WriteLine($"{number} is even: {isEven}");

            
            //3.2
            /*Problem: Converting List of Strings to Uppercase
            Problem:
            Create an extension method for List<string> that converts all strings in the list to uppercase.*/
            //List<string> words = new List<string> { "apple", "banana", "cherry" };
            //List<string> upperCaseWords = words.ToUpperCase();
            
            Console.WriteLine("Words in uppercase:");
            //upperCaseWords.ForEach(word => Console.WriteLine(word));


            //4.0
            //Create a Button class that has a Click event. 
            //Define a Program class that subscribes to this Click event and prints "Button clicked!" to the 
            //console when the event is raised. Implement the Button class and demonstrate how to subscribe and raise the event.
            // Create an instance of the Button class
            Button button = new Button();

            // Subscribe to the Click event
            button.Click += Button_Click;

            // Simulate a button click
            button.PerformClick();

            //4.1 DELEGATES
            /*
            Write a C# program that defines a delegate named MathOperation which takes two integers as 
            parameters and returns an integer. Implement three methods Add, 
            Subtract, and Multiply that match the delegate signature. Use the delegate to invoke each of these methods.
            */
            MathOperation operation;

            operation = Add;
            Console.WriteLine($"Add: 5 + 3 = {operation(5, 3)}");

            operation = Subtract;
            Console.WriteLine($"Subtract: 5 - 3 = {operation(5, 3)}");

            operation = Multiply;
            Console.WriteLine($"Multiply: 5 * 3 = {operation(5, 3)}");

            //6.0 LINQ
            //Given a list of integers, write a LINQ query to find all the even numbers and sort 
            //them in ascending order. Return the result as a list.
            List<int> numbers3 = new List<int> {1,4,5,6,7,8,9};
            List<int> evenNumbers3 = GetEvenNumber(numbers);

            System.Console.WriteLine("Even num" + string.Join( " , ", evenNumbers3));

            //6.1 LINQ
            //Given a list of students, where each student has a name and a score, write a LINQ 
            //query to find the names of students who scored more than 80, 
            //sorted by their names in descending order.
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Score = 85 },
                new Student { Name = "Bob", Score = 90 },
                new Student { Name = "Charlie", Score = 75 },
                new Student { Name = "David", Score = 95 }
            };

            List<string> topStudents = GetTopStudents(students);

            Console.WriteLine("Top Students: " + string.Join(", ", topStudents));  // Output: David, Bob, Alice
    
            return default;

            //7.0 Async and Await
            /*
            How do you use async and await in C# to make an asynchronous HTTP request and handle the response?
            Answer:
            In C#, async and await are used to work with asynchronous programming. 
            Here's an example of how to make an asynchronous HTTP request using HttpClient and handle the response.
            */

            string url = "https://jsonplaceholder.typicode.com/posts/1";
            // Call the asynchronous method
            //string result7 = await GetHttpResponseAsync7(url);
            // Print the result to the console
            Console.WriteLine(result);

            //8.0 How do you implement a basic Binary Search Tree (BST) and an AVL Tree in C#? 
            //Provide an example with insertion methods for both.
            /*
            Binary Search Tree (BST)
            A Binary Search Tree is a binary tree where each node has at most two children, 
            and the left child's value is less than the parent node's value, while the right child's value is greater.
            
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("InOrder Traversal of BST:");
            bst.InOrderTraversal(bst.Root);
            */

            //8.0 AVL TREE
            /*
            An AVL Tree is a self-balancing Binary Search Tree where the difference
            in heights between the left and right subtrees of any node is at most 1.
            
            AVLTree avlTree = new AVLTree();
            avlTree.Root = avlTree.Insert(avlTree.Root, 10);
            avlTree.Root = avlTree.Insert(avlTree.Root, 20);
            avlTree.Root = avlTree.Insert(avlTree.Root, 30);
            avlTree.Root = avlTree.Insert(avlTree.Root, 40);
            avlTree.Root = avlTree.Insert(avlTree.Root, 50);
            avlTree.Root = avlTree.Insert(avlTree.Root, 25);

            Console.WriteLine("InOrder Traversal of AVL Tree:");
            avlTree.InOrderTraversal(avlTree.Root);
            */


        }
        
        //3.0
        public static string ReverseString(this string str)
        {
        return new string(str.Reverse().ToArray());
        }

        //3.1
        public static bool IsEven(this int number)
        {
        return number % 2 == 0;
        }

        //3.2
        public static List<string> ToUpperCase(this List<string> list)
        {
            return list.Select(s => s.ToUpper()).ToList();
        }

        //4.0
        private static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }

        //4.1
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //6.0
        public static List<int> GetEvenNumber(List<int> numbers)
        {
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              orderby number
                              select number;

            return evenNumbers.ToList();
        }

        //6.1
        public static List<string> GetTopStudents(List<Student> students)
        {
            var topStudents = from student in students
                            where student.Score > 80
                            orderby student.Name descending
                            select student.Name;

            return topStudents.ToList();
        }

        //7.0
        public static async Task<string> GetHttpResponseAsync7(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Send an asynchronous GET request to the specified URL
                HttpResponseMessage response = await client.GetAsync(url);
                // Ensure the response status code is successful
                response.EnsureSuccessStatusCode();
                // Read the response content asynchronously as a string
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        //8.0 Binary Tree
        class BinarySearchTree
        {
            public BSTNode Root;

            public void Insert(int value)
            {
                Root = InsertRec(Root, value);
            }

            private BSTNode InsertRec(BSTNode root, int value)
            {
                if (root == null)
                {
                    root = new BSTNode(value);
                    return root;
                }

                if (value < root.Value)
                    root.Left = InsertRec(root.Left, value);
                else if (value > root.Value)
                    root.Right = InsertRec(root.Right, value);

                return root;
            }

            public void InOrderTraversal(BSTNode root)
            {
                if (root != null)
                {
                    InOrderTraversal(root.Left);
                    Console.WriteLine(root.Value);
                    InOrderTraversal(root.Right);
                }
            }
        }

        class BSTNode
        {
            public int Value;
            public BSTNode Left;
            public BSTNode Right;

            public BSTNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        
        
        //8.0 AVL TREE
        class AVLTree
        {
            public AVLNode Root;

            public int GetHeight(AVLNode node)
            {
                return node == null ? 0 : node.Height;
            }

            public int GetBalance(AVLNode node)
            {
                return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
            }

            public AVLNode RightRotate(AVLNode y)
            {
                AVLNode x = y.Left;
                AVLNode T2 = x.Right;

                x.Right = y;
                y.Left = T2;

                y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
                x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

                return x;
            }

            public AVLNode LeftRotate(AVLNode x)
            {
                AVLNode y = x.Right;
                AVLNode T2 = y.Left;

                y.Left = x;
                x.Right = T2;

                x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
                y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

                return y;
            }

            public AVLNode Insert(AVLNode node, int value)
            {
                if (node == null)
                    return new AVLNode(value);

                if (value < node.Value)
                    node.Left = Insert(node.Left, value);
                else if (value > node.Value)
                    node.Right = Insert(node.Right, value);
                else
                    return node;

                node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

                int balance = GetBalance(node);

                // Left Left Case
                if (balance > 1 && value < node.Left.Value)
                    return RightRotate(node);

                // Right Right Case
                if (balance < -1 && value > node.Right.Value)
                    return LeftRotate(node);

                // Left Right Case
                if (balance > 1 && value > node.Left.Value)
                {
                    node.Left = LeftRotate(node.Left);
                    return RightRotate(node);
                }

                // Right Left Case
                if (balance < -1 && value < node.Right.Value)
                {
                    node.Right = RightRotate(node.Right);
                    return LeftRotate(node);
                }

                return node;
            }

            public void InOrderTraversal(AVLNode node)
            {
                if (node != null)
                {
                    InOrderTraversal(node.Left);
                    Console.WriteLine(node.Value);
                    InOrderTraversal(node.Right);
                }
            }
        }

        class AVLNode
        {
            public int Value;
            public AVLNode Left;
            public AVLNode Right;
            public int Height;

            public AVLNode(int value)
            {
                Value = value;
                Left = null;
                Right = null;
                Height = 1;
            }
        }


    }
}