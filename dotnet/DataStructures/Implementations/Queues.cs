using System;
using System.Collections.Generic;
using DataStructures;

/// <summary>
/// Summary description for Queues
/// </summary>
namespace DataStructures
{
public class Queues
{
	

    public class Stacks<T>
    {
        public Node<T> front { get; set; }

        public bool Peek()
        {
          return front != null;
        }

        public void Enqueue(T value)
        {
          Node<T> node = new Node<T>(value);
          front = node;
        }

        public Node<T> Dequeue()
        {
          Node<T> currentFront = front;
          front = currentFront.Next;
          return currentFront;
        }

    }
  
  }
}

