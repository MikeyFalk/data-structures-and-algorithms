using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
  class Tree
  {
    /// preOrder
   public void PreOrder(Node parent)
    {
      if (parent != null)
      {
        List<int> preOrderTreeList = new List<int>(); 

        preOrderTreeList.Add(parent.Data);
        PreOrder(parent.LeftNode);
        PreOrder(parent.RightNode);

        preOrderTreeList.ToArray();
       }
    }

    public void InOrder(Node<T> parent)
    {
      if (parent != null)
      {
        List<int> inOrderTreeList = new List<int>();

        InOrder(parent.LeftNode);
        inOrderTreeList.Add(parent.Data);
        InOrder(parent.RightNode);

        inOrderTreeList.ToArray();
        
      }
    }

    public void PostOrder(Node parent)
    {
      if (parent != null)
      {
        List<int> postOrderTreeList = new List<int>();

        PostOrder(parent.LeftNode);
        PostOrder(parent.RightNode);

        postOrderTreeList.Add(parent.Data);

        postOrderTreeList.ToArray();
      }



    }

    public void Breadthfirst(Tree<int> tree)
    {
      Queue container<-new Queue()
      container.enqueue(tree.root)

      While (container.peek())
      {
        Node front = container.dequeue();
      }
          List.add (front.value)
        if (front.left !=  null)
        {
        Container.enqueue(front.left);
        }
      if (front.right != null)
      {
        Container.enqueue(front.right);
      }

    }
  }
}
