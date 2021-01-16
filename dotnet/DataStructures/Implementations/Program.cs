using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
          LinkedList myList = new LinkedList(1);
          myList.Insert(2);
          myList.Insert(3);
          myList.Insert(4);
          myList.Insert(5);
          myList.Insert(6);
          myList.Insert(7);
          myList.Insert(8);

          myList.Print();
          myList.PrintR(myList.Head);

        }
    }
}
