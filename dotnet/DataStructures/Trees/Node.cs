using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
  class Node<T>
  {
    public Node<T> LeftNode { get; set; }
    public Node<T> RightNode { get; set; }

    public int Data { get; set; }
  }
}




/// how to turn a list into an array List.ToArray()
/// Tree tree = new Tree();

//tree.Root = new Node(1,
//    new Node(2,
//        new Node(4,
//            new Node(8, null, null), null),
//        new Node(6,
 //           new Node(10, null, null),
  //          new Node(12, null, null))),
//    new Node(3,
//        new Node(5,
 //           new Node(9, null, null),
 //           new Node(11, null, null)),
  //      new Node(7,
  //          new Node(13, null, null), null)));
