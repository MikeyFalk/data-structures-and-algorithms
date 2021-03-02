using System;


namespace DataStructures
{
  class Vertex<T>
  {
    public T Value { get; set; }
    public Vertex(T value)
    {
       Value = value;
    }
  }

 class Edge<T>
   {
      public int Weight { get; set;}
      public Vertex<T> Vertex { get; set; }
   }

  class Graph<T>
  {
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
    private int _size = 0;
    public Graph()
    {
      AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
    }


    public Vertex<T> AddVertex(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjacencyList.Add(node, new List<Edge<T>>());
      _size++;
      return node;
    }

    public void AddSirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AjacencyList[a].Add(
          new Edge<T>
          {
            weight = 0,
            Vertex = b,
          }
         );
    }

    public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AddDirectedEdge(a, b);
      AddDirectedEdge(b, a);
    }

    public List<Edge<T>> GetNeighbors(Vertex<T> node)
    {
      return AdjacencyList[node];
    }

    public void Print()
    {
      foreach (var item in AdjacencyList)
      {
        Console.Write($"Vertex {item.key.Value} => ");
        foreach (var edge in item.Value)
        {
          Console.Write($"{edge.Vertex.Value} -> ")
            }
        Console.WriteLine("");
      }
    }

  }

}
