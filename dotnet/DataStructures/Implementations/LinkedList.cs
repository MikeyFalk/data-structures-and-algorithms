using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    /// <summary>
    /// Plain empty linked list
    /// Head will be null
    /// Usage: LinkedList myList = new LinkedList();

    /// </summary>
    /// 
    public LinkedList() {  }

    /// <summary>
    /// Linked List constructor that creates a head node
    /// Usage: LinkedList myList = new LinkedList()
    /// </summary>
    /// <param name="value"></param>
    public LinkedList(T value)
    {
      Node<T> node = new Node<T>(value);
      Head = node;

    }
    public void Insert(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Head;
      Head = node;
    }

    public string Print()
    {

      string outPut = ""; 
      Node<T> current = Head;

      while (current != null)
      {
        System.Console.Write($"[{current.Value}] => ");
        outPut += ($"{current.Value} => ");
        current = current.Next;
        return outPut;
      }
     
      System.Console.WriteLine("Null");
      outPut += ($"Null");
      return outPut;
    }

    public void PrintR(Node<T> node)
    {
      if (node == null)
      {
        System.Console.WriteLine("Null");
          return;
      }
      System.Console.WriteLine($"[{node.Value}] => ");

      PrintR(node.Next);
    }


/*
    public bool Includes(T checkValue)
    {
      Node<T> current = Head;
      while (current != null)
      {
        if (checkValue == current.Value)
        {
          return true;
        }
        current = current.Next;
        
      }
      return false;
    }
*/
/*
    public void Append(T value)
    {
      Node<T> currentNode = Head;
      while (currentNode.Next != null)
      {
        if (currentNode.Next == null)
        {
          Node<T> newNode = new Node<T>(value);
          currentNode.Next = newNode;
         }
      }
    }
*/
/*
    public void InsertBefore(int value, int newVal)
    {
      Node currentNode = Head;
      Node NewNode = LinkedList.Head;

      while (current != null)
        {

      }

      Node node = new Node(value);
      node.Next = Head;
      Head = node;
    }
*/
/*
    public void insertAfter(int value, int newVal)
    {

    }
*/
    /*
  public void KthFromEnd(int k)
    {
      int listLength = 0;
      int modifiedListLength = 0;
      Node current = Head;

            while (Node.Next != null)
            {
                current = current. Next
                    listLength ++;
            }
        modifiedListLength = listLength - k;

            for (int i = 1; i < modifiedListLength; i++)
            {
                current = current.Next
            }
            return Node.Value;
    }	
    */
  } 
   

}
