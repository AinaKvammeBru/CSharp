using System;

namespace ArchitectArithmetic
{
  class Program
  {

  public static double Rect(double length, double width){
  return length * width;
  }
  public static double Circle(double radius){
  double raised = 2;
  return Math.PI * Math.Pow(radius, raised);
  }

  public static double Triangle(double bottom, double height){
  return 0.5 * bottom * height;
  }
  
  public static void CalculateTotalCost(){

    double rectAmount = 1;
    double circleAmount = 1;
    double triangleAmount = 1;
    double rectLength = 0;
    double rectWidth = 0;
    double radius = 0;
    double triangleBottom = 0;
    double triangleHeight = 0;

    double rect = 0;
    double circle = 0;
    double triangle = 0;
    double totalArea = 0;
    double totalCost = Math.Round(totalArea * 180);


    Console.WriteLine("What monument would you like to work with?");
    string project = Console.ReadLine().ToLower();
    //Console.WriteLine(project);



    switch(project){
      default:
      Console.WriteLine("You have to chose a project, try again");
      break;

      case "taj mahal":
      rectLength = 90.5;
      rectWidth = 90.5;
      triangleBottom = 24;
      triangleHeight = 24;
      triangleAmount = -4;
      rect = Rect(rectLength,rectWidth)*rectAmount;
      circle = Circle(radius)*circleAmount;
      triangle = Triangle(triangleBottom,triangleHeight)*triangleAmount;

      totalArea = rect + circle + triangle;
      totalCost = Math.Round(totalArea * 180);
      Console.WriteLine($"The plan for that monument costs {totalCost} pesos");

      break;

      case "great mosque of mecca":
      rectLength = 284;
      rectWidth = 264;
      double rectLength2 = 180;
      double rectWidth2 = 106;
      double rectAmount2 = 1;
      triangleBottom = 264;
      triangleHeight = 84;
      triangleAmount = -1;
      
      rect = Rect(rectLength,rectWidth)*rectAmount;
      circle = Circle(radius)*circleAmount;
      triangle = Triangle(triangleBottom,triangleHeight)*triangleAmount;
      double rect2 = Rect(rectLength2,rectWidth2)*rectAmount2;

      double totalArea2 = rect + circle + triangle + rect2;
      totalCost = Math.Round(totalArea2 * 180);
      Console.WriteLine($"The plan for that monument costs {totalCost} pesos");

      break;


    }

  }

  public static void Main(string[] args)
    {
      CalculateTotalCost(); 
    }
  }
}
