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
