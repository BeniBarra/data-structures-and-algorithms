using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Vertex<T>
  {
    public T Value { get; set; }

    public Vertex(T value)
    {
      Value = value;
    }
  }

  public class Edge<T>
  {
    public int Weight { get; set; }
    public Vertex<T> Vertex { get; set; }

    public Edge(Vertex<T> vertex, int weight)
    {
      Vertex = vertex;
      Weight = weight;
    }
  }

  public class Graph<T>
  {
    private int _size;

    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

    public Graph()
    {
      AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
      _size = 0;
    }

    public Vertex<T> AddNode(T value)
    {
      Vertex<T> Vertex = new(value);
      AdjacencyList.Add(Vertex, new List<Edge<T>>());
      _size++;

      return Vertex;
    }

    public void AddEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
    {
      AddDirectionalEdge(sourceVertex, destVertex, weight);
      AddDirectionalEdge(destVertex, sourceVertex, weight);
    }
    public void AddDirectionalEdge(Vertex<T> sourceVertex, Vertex<T> destVertex, int weight)
    {
      List<Edge<T>> edges = AdjacencyList[sourceVertex];
      edges.Add(
        new Edge<T>(destVertex, weight)
    );
    }

    public List<Vertex<T>> GetNodes()
    {
      int listNum = 1;
      List<Vertex<T>> allVertex = new();

        foreach(Vertex<T> vertex in AdjacencyList.Keys)
        {
          Console.Write($"Vertex {listNum}: {vertex.Value} => ");
          allVertex.Add(vertex);
          listNum++;
        }
        if(allVertex.Count <= 0) { return null; }
        else
        return allVertex;
    }

    public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)
    {
      var neighborAdjacencyList = AdjacencyList[vertex];
      List<Vertex<T>> neighborList = new List<Vertex<T>>();

      foreach(Edge<T> edge in neighborAdjacencyList)
      {
        neighborList.Add(edge.Vertex);
      }

      return neighborList;
    }

    public int GetSize()
    {
      return _size;
    }

    public void Print()
    {
      foreach(var key in AdjacencyList)
      {
        Console.Out.Write($"{ key.Key.Value} ->");

        var adjacencyList = AdjacencyList[key.Key];

        foreach( Edge<T> edge in adjacencyList)
        {
          Console.Out.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
        }
        Console.Out.WriteLine("null");
      }
    }
  }
}
