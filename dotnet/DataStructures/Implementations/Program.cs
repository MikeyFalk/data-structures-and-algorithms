using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
         //LinkedListStuff();
         StackStuff();
        }

        static void LinkedListStuff()
        {
             LinkedList<int> myNumbers = new LinkedList<int>(1);
          myNumbers.Insert(2);
          myNumbers.Insert(3);
          myNumbers.Insert(4);
          myNumbers.Insert(5);
          myNumbers.Insert(6);
          myNumbers.Insert(7);
          myNumbers.Insert(8);

          myNumbers.Print();
          myNumbers.PrintR(myNumbers.Head);

          LinkedList<string> myFamily = new LinkedList<string>();
            myFamily.Insert("Mike");
            myFamily.Insert("Mary");
            myFamily.Insert("Max");
            myFamily.Insert("2BNamed");
            myFamily.Insert("Kitty");
            myFamily.Insert("Chloe");

            myFamily.Print();

        }

        static void StackStuff()
        {
          Stacks<string> myFamily = new Stacks<string>();
            myFamily.Push("Mike");
            myFamily.Push("Mary");
            myFamily.Push("Max");
            myFamily.Push("Kitty");
            myFamily.Push("Chloe");
            Console.WriteLine(myFamily.Peek());
            
            while (!myFamily.Peek())
            {
                Node<string> person = myFamily.Pop();
                
                Console.WriteLine(person.Value);

            }
            

        }

    }
}
