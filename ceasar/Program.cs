using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    Console.WriteLine("Please give the secret message");
    string input = Console.ReadLine().ToLower();
    
    char[] secretMessage = input.ToCharArray(); 

    char[] encryptedMessage = new char[secretMessage.Length];
    
    for(int i = 0; i < secretMessage.Length; i++){
      char letter = secretMessage[i];
      int index = Array.IndexOf(alphabet, letter);
      int encIndex = (index + 3) % alphabet.Length;
      char newLetter = alphabet[encIndex];
      encryptedMessage[i] = newLetter;
      
    }
string encrypted = String.Join("",encryptedMessage);
      Console.WriteLine(encrypted);
    }
  }
}