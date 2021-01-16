using System;
using DataStructures;

namespace LinkedLists
{
    public class Program
    {

    public static void Main(string[] args)
    {

    }
    public static bool linkListActivity()
        {
          LinkedList myList = new LinkedList(5);
          myList.Insert(10);
          Console.WriteLine(myList.Head.Value);
          return true;
        }


    }
}
