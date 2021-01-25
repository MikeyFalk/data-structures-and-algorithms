using System;
using System.Collections.Generic;




  public class Stacks<T>
  {
    public Node<T> top { get; set; }

    public bool Peek()
    {
     return top != null;
    }

    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      top = node;
    }

    public Node<T> Pop()
    {
     Node<T> currentTop = top;
     top = currentTop.Next;
     return currentTop;
    }
    
  }

