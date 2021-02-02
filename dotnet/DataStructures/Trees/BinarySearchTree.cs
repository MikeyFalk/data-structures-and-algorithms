using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
  class BinarySearchTree
  {
    public static bool Contains(BinarySearchTree<int> tree, int value)
        {
            Node<int> node = tree.Root;
            while(node != null)
      {
        if (node.Value == value)
        {
          return true;
        }
        else if (node.Value > value)
        {
          node = node.Left;
        }
        else
        {
          node = node.Right;
        }
        }
      return false;
    
  }
}
