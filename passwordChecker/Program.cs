using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
            // THos program checks the strength of the user inputed password

            // The variables wich we chech the password against
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = ".[]{}()<>*+-=!?^$|";
      int score = 0;
      
          // The user input and password lenght
      Console.WriteLine("Please input the password you want to check: ");
      string password = Console.ReadLine();
      int length = password.Length;

    // If statements checking if the password against the given parameters using a class made in Tools.cs
    if (length >= minLength) {
      score++;
    } 
    if (Tools.Contains(password, uppercase)){
      score++;
    } 
    if (Tools.Contains(password, lowercase)){
      score++;
    }  
    if (Tools.Contains(password, digits)){
      score++;
    } 
    if (Tools.Contains(password, specialChars)){
      score++;
    }
    if(password == "1234"){
      score = 0;
    } 

    // Prints out the result of the test, is the password strong or weak etc
    switch (score){

      case 5: 
    Console.WriteLine("Your password is extremely strong");
      break;

      case 4: 
    Console.WriteLine("Your password is extremely strong");
      break;

      case 3: 
    Console.WriteLine("Your password is strong");
      break;

      case 2: 
    Console.WriteLine("Your password is medium");
      break;

      case 1: 
    Console.WriteLine("Your password is weak");
      break;

      case 0:
    Console.WriteLine("Your password is extremely weak");
      break;

      default:
      break;
    }

    }
  }
}
