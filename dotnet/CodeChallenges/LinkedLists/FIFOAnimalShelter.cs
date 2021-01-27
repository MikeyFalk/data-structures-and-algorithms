using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class AnimalShelter
{

  public class AnimalShelter<T>
  {
    public Node<T> Front { get; set; }

    public bool Peek()
    {
      return Front != null;
    }

    public void Enqueue(T animal)
    {
      Node<T> node = new Node<T>(animal);

      if (Front == null)
      {
        Front = node;
        return;
      }
      Node<T> current = Front;
      while (current.Next != null)
      {
        current = current.Next;
      }
    }
    public Node<T> Dequeue()
    {
      Node<T> front = Front;

      Front = front.Next;
      return front;
    }


  }
}


    

    public Animal()
	{

    public string Cat { get; set; }

    public string Dog { get; set; }
		//
		// TODO: Add constructor logic here
		//
	}
}
