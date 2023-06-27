using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // This is a chose your own adventure program that tells a quick story about a mysterious noise

            // Gets the user name and welcomes the user 
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

    // The start of the story, promts the user to make the first choice then binds that choice to a variable made uppercase
     Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or NO");
      string noiseChoice = Console.ReadLine().ToUpper();
      Console.WriteLine(noiseChoice);

      // Checks if the user answered is "NO" or "YES" and sorts those to their respective routes
    if(noiseChoice == "NO"){
        Console.WriteLine("Not much of an adventure if we don't leave our room! THE END");
                //Add some space bellow
        Console.WriteLine();
        Console.WriteLine();
    }else if(noiseChoice == "YES"){
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
        // Telling the user to open or knock, the answer is tied to a variable and made uppercase    
        Console.WriteLine("Type OPEN or KNOCK:");
        string doorChoice = Console.ReadLine().ToUpper();
      
        // Checks if the user inputed knock, open or something else
      if(doorChoice == "KNOCK"){
                    // Gives the user a riddle to a solve, then ties that with a variable made uppercase
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
        Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.Write("Type your answer:");
        string riddleAnswer = Console.ReadLine().ToUpper();

                    // Checks if the user inputed nothing, open or something else
        if(riddleAnswer == "NOTHING"){
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
        }else{
          Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
        }
      }else if(doorChoice == "OPEN"){
                    // Promts the user to chose one of their 3 keys and binds the answer to a variable
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine().ToUpper();

                    // Switch for the different keys chosen
          switch (keyChoice){
              default:
                Console.WriteLine("That is not a key you have...THE END.");
                break;

              case "1": 
               Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
              break;

              case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
              break;

              case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
              break;
          }
      }else{
         Console.WriteLine("The floor spontaneously opens up underneath you and you wake up in your own bed the next morning. THE END");
      }


    }



    }
  }
}



