using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class HashMap
  {
    private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
    public HashMap(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    public int Hash(string key)
    {
      int hashValue = 0;

      char[] letters = key.ToCharArray();

      for (int i = 0; i < letters.Length; i++)
      {
        hashValue += letters[i];
      }

      hashValue = (hashValue * 599) % Map.Length;

      return hashValue;
    }

    public void Set(string key, string value)
    {
      int hashKey = Hash(key);

      if (Map[hashKey] == null)
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
      Map[hashKey].Insert(entry);
    }

    public bool Contains(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey!] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key) { return true; }
          current = current.Next;
        }
      }
      return false;
    }

    public string Get(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey!] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key)
          {
            string got = $"{current.Value.Value}";
            return got;
          }
          current = current.Next;
        }
      }
      string missingItem = $"Item: {key}, not found";
      return missingItem;
    }

    public static List<string[]> LeftJoin(HashMap left, HashMap right)
    {
      List<string[]> joined = new();
      for (int i = 0; i < left.Map.Length; i++)
      {
        if (left.Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = left.Map[i].Head;
          while (current != null)
          {
            string[] newArray = new string[3];
            newArray[0] = current.Value.Key;
            newArray[1] = current.Value.Value;
            if (right.Contains(current.Value.Key))
            {
              newArray[2] = right.Get(current.Value.Key);
            }
            joined.Add(newArray);
            current = current.Next;
          }
        }
       }
      return joined;
    }


    public static string FindRepeats(string sentence)
    {
      string noRepeats = "There are no repeats in this sentence";
      string[] words = sentence.Split(" ");
      HashMap check = new(31);
      foreach (string word in words)
      {
        if (check.Contains($"{word}"))
        {
          return word;
        }
        check.Set($"{word}", $"{1}");
      }
      return noRepeats;
    }

    public void Print()
    {
      for (int i = 0; i < Map.Length; i++)
      {
        Console.Write($"{i} --");
        if (Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while (current != null)
          {
            Console.Write($"[{current.Value.Key}: {current.Value.Value}] =>");
            current = current.Next;
          }
        }
        Console.WriteLine();
      }
    }
  }
}
