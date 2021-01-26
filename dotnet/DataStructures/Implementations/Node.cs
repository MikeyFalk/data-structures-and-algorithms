using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
 public class Node<T>
  {
    public T Value { get; set; }

    public Node<T> Next { get; set; }

    //Constructor
    /// <summary>
    /// Constructor for the Node Class
    /// Usage: Node node = new Node(5);
    /// </summary>
    /// <param name="value"></param>
    public Node( T value )
    {
      Value = value;
    }


  }
}
