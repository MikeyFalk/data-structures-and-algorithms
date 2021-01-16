using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
 public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }
    //Constructor
    /// <summary>
    /// Constructor for the Node Class
    /// Usage: Node node = new Node(5);
    /// </summary>
    /// <param name="value"></param>
    public Node( int value )
    {
      Value = value;
    }


  }
}
