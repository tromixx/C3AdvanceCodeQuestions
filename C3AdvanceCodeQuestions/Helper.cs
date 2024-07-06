using System;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

class Helper
{
    public Helper()
    {
        System.Console.WriteLine("Inside Helper");
    }
    //1
    public static char? FindFirstNonRepeatingChar(string word)
    {
        var charCount = new Dictionary<char, int>();
        foreach(char wordChar in word)
        {
            if(charCount.ContainsKey(wordChar))
                charCount[wordChar]++;
            
            else
                charCount[wordChar] = 1;
        }
        foreach(char wordChar in word)
        {
            if(charCount[wordChar] == 1)
            {
                return wordChar;
            }

        }

        return null;
    }

    //2
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            numIndices[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }

    //3
    public static IList<IList<string>> Group(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);

            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        return anagramGroups.Values.ToList<IList<string>>();
    }

    //4
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    //5
    public static IList<int> FindAllDuplicates(int[] nums)
    {
        Dictionary<int, int> numCount = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();

        foreach (int num in nums)
        {
            if (numCount.ContainsKey(num))
            {
                numCount[num]++;
            }
            else
            {
                numCount[num] = 1;
            }
        }

        foreach (var pair in numCount)
        {
            if (pair.Value > 1)
            {
                duplicates.Add(pair.Key);
            }
        }

        return duplicates;
    }

    //6
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> numCount = new Dictionary<int, int>();
        List<int> intersection = new List<int>();

        foreach (int num in nums1)
        {
            if (numCount.ContainsKey(num))
            {
                numCount[num]++;
            }
            else
            {
                numCount[num] = 1;
            }
        }

        foreach (int num in nums2)
        {
            if (numCount.ContainsKey(num) && numCount[num] > 0)
            {
                intersection.Add(num);
                numCount[num]--;
            }
        }

        return intersection.ToArray();
    }

    //2.0
    public static List<int> GetEvenNumbers(List<int> numbers)
    {
        // Using a lambda expression to filter even numbers
        return numbers.Where(n => n % 2 == 0).ToList();
    }
}

//1. Dictionaries and Arrays
public class CombinedDemo
{
    public List<T> FilterList<T>(List<T> list, Func<T, bool> predicate)
    {
        return list.Where(predicate).ToList();
    }
    
}

//2. Dictionaries and Arrays

//3. Dictionaries and Arrays

//4. Dictionaries and Arrays
//5. Dictionaries and Arrays
//6. Dictionaries and Arrays
//7. Dictionaries and Arrays
