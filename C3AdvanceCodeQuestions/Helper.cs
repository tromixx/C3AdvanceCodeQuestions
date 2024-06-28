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
}
public class CombinedDemo
{
    public List<T> FilterList<T>(List<T> list, Func<T, bool> predicate)
    {
        return list.Where(predicate).ToList();
    }
}
