using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> testList = new LinkedList<string>();
            testList.Add("123");
            testList.Add("456");
            testList.Add("789");
            testList.Insert("6.5", 2);
            Console.WriteLine(testList.GetDataAt(0));
            Console.WriteLine(testList.GetDataAt(1));
            Console.WriteLine(testList.GetDataAt(2));
            Console.WriteLine(testList.GetDataAt(3));
            Console.WriteLine(testList.Contains("123"));
            testList.Remove("123");
            Console.WriteLine(testList.Contains("123"));
            Console.ReadLine();
        }
    }
}