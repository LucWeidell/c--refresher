using System.Collections.Generic;

namespace csharp_day_1.Models
{
    public class Shelter
    {

    public List<Cat> Cats { get; private set; }
    public List<Dog> Dogs { get; private set; }
    // Method 2
    public List<Dog> ExampleConstruct { get; private set; } = new List<Dog>();

    public void AddPet(Cat cat){
        Cats.Add(cat);
    }

    // NOTE Method overloading: allows the use of the same method name with a different parameter signature
    public void AddPet(Dog dog)
    {
        Dogs.Add(dog);
    }

    public string Adopt(Dog dog){
        Dogs.Remove(dog);
        return "Have fun with " + dog.Name;
    }

    public string Adopt(Cat cat){
        Cats.Remove(cat);
        return "Good luck with " + cat.Name;
    }

     public Shelter()
    {
    // Makrs preferred method
      Cats = new List<Cat>();
      Dogs = new List<Dog>();
    }
    }
}