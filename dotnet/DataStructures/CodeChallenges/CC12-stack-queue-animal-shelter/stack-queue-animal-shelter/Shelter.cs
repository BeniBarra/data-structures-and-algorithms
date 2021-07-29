using System;
using DataStructures;
using System.Collections.Generic;

namespace stack_queue_animal_shelter
{
  public class Shelter
  {
    DataStructures.Queue<Animal> catLine = new DataStructures.Queue<Animal>();
    DataStructures.Queue<Animal> dogLine = new DataStructures.Queue<Animal>();

    static void Main(string[] args)
    {
    }

    public void AddAnimal(string name, string type)
    {
      Animal animal = new Animal(name, type);
      if (animal.Type == "dog")
      {
        dogLine.Enqueue(animal);
      }
      else if (animal.Type == "cat")
      {
        catLine.Enqueue(animal);
      }
      else throw new Exception("Sorry, only cats and dogs at this shelter");
    }

    public string TakeAnimal(string choice)
    {
      if (choice.ToLower() == "dog")
      {
        Node<Animal> animal = dogLine.Dequeue();
        return $"You took {animal.Value.Name}";
      }
      else if (choice.ToLower() == "cat")
      {
        Node<Animal> animal = catLine.Dequeue();
        return $"You took {animal.Value.Name}";
      }
      else throw new Exception("Sorry, only cats and dogs at this shelter");
    }
  }
}
