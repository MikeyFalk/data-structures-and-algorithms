namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

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
    public LinkedList(int value)
    {
      Node node = new Node(value);
      Head = node;

    }
    public void Insert(int value)
    {
      Node node = new Node(value);
      node.Next = Head;
      Head = node;
    }

    public string Print()
    {

      string outPut = ""; 
      Node current = Head;

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

    public void PrintR(Node node)
    {
      if (node == null)
      {
        System.Console.WriteLine("Null");
          return;
      }
      System.Console.WriteLine($"[{node.Value}] => ");

      PrintR(node.Next);
    }
    public bool Includes(int checkValue)
    {
      Node current = Head;
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
    public void Append(int value)
    {
      Node currentNode = Head;
      while (currentNode.Next != null)
      {
        if (currentNode.Next == null)
        {
          Node newNode = new Node(value);
          currentNode.Next = newNode;
         }
      }
    }

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

    public void insertAfter(int value, int newVal)
    {

    }
  }
}
