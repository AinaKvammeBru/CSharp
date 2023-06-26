using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a mad lib program that will take user inputed 
      words and inserts them into the mad lib story. 
      This projects is adapted from Codecademy's "Learn C#" course
      Author: Aina Kvamme Bru
      */


      // Letting the user know that the program is running:
      Console.WriteLine("The program is running.");

      //Mad Lib title:
      string title = "Mad lib story";
      Console.WriteLine(title);

      // Defining user input and variables:

      // Name variable 
    Console.WriteLine("Enter a name: ");
    string name = Console.ReadLine();

    // Adjective variables 
    Console.WriteLine("Enter an adjective (for example:a colour,a texture or a feeling) for the mad lib: ");
    string adjective1 = Console.ReadLine();
    
    Console.WriteLine("Enter another adjective for the mad lib: ");
    string adjective2 = Console.ReadLine();
    
    Console.WriteLine("Enter the final adjective for the mad lib: ");
    string adjective3 = Console.ReadLine();

      // Verb variable
   Console.WriteLine("We also need a verb (for example: sit, eat or sleep) for the mad lib: ");
    string verb = Console.ReadLine();

      // Nouns variables
      Console.WriteLine("Enter a noun (for example: person, place or thing) for the mad lib: ");
      string noun1 = Console.ReadLine();

      Console.WriteLine("Enter another noun for the mad lib: ");
      string noun2 = Console.ReadLine();

      // Last bits of information variables 
      Console.WriteLine("For the final part we need an animal, a food, a fruit, a superhero, a country, a dessert and a year.");
      
      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.WriteLine("Enter a food: ");
      string food = Console.ReadLine();

      Console.WriteLine("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("Enter a superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("Enter a country: ");
      string country = Console.ReadLine();

      Console.WriteLine("Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("Enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:
      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}
