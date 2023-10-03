using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      //RandomMode();
      //BuildACreature("bug","bug");
      ChooseMode();
    }

    static void BuildACreature(string head ="", string body = "", string feet = ""){
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
    
     SwitchCase(headNum,bodyNum,feetNum);

    }

    static void RandomMode(){
      Random randomNumber = new Random();
      int head = randomNumber.Next(1,4);
      int body = randomNumber.Next(1,4);
      int feet = randomNumber.Next(1,4);
      SwitchCase(head,body,feet);
    }

    static void SwitchCase(int head, int body, int feet){

      switch(head){
        case 1:
        GhostHead();
        break;

        case 2:
        BugHead();
        break;

        case 3:
        MonsterHead();
        break;

      } 

      switch(body){

        case 1:
        GhostBody();
        break;

        case 2:
        BugBody();
        break;

        case 3:
        MonsterBody();
        break;

      } 

      switch(feet){
        case 1:
        GhostFeet();
        break;

        case 2:
        BugFeet();
        break;

        case 3:
        MonsterFeet();
        break;

      } 

    }

    static int TranslateToNumber(string creature){
      creature = creature.ToLower();
      Random randomDefault = new Random();

      switch(creature){
        default:
        return randomDefault.Next(1,4);

        case "ghost":
        return 1;

        case "bug":
        return 2;

        case "monster":
        return 3;

      }
    }

    static void PromtCreature(){
      Console.WriteLine("Please select either a ghost, bug, monster or random head to use for the creature:");
      string headChosen = Console.ReadLine().ToLower();

      Console.WriteLine("Please select either a ghost, bug, monster or random body to use for the creature:");
      string bodyChosen = Console.ReadLine().ToLower();
      
      Console.WriteLine("Please select either ghost, bug, monster or random feet to use for the creature:");
      string feetChosen = Console.ReadLine().ToLower();
      
      BuildACreature(headChosen,bodyChosen,feetChosen);

    }

    static void ChooseMode(){
      Console.WriteLine("Do you want to generate a random creature or make one manually?");
      string choice = Console.ReadLine().ToLower();

      switch(choice){
        default:
        Console.WriteLine("Please type in 'random' or 'manual'");
        Restart();
        break;

        case "manual":
        PromtCreature();
        break;

        case "random":
        RandomMode();
        break;

      }



    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
