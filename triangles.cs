using System;

class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  public bool CheckTriangle()
  {
    if((SideA + SideB) < SideC || (SideA + SideC) < SideB || (SideB + SideC) < SideA)
    {
      return false;
    }
    else
    {
      return true;
    }
  }
  public string TriangleType()
  {
    if ((SideA == SideB) && (SideA == SideC)) {
      return "equilateral";
    }
    else if ((SideA == SideB) || (SideA == SideC) || (SideB == SideC)) {
      return "isosceles";
    }
    else
    {
      return "scalene";
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter length for Side A");
    int FirstSide = int.Parse(Console.ReadLine());
    myTriangle.SideA = FirstSide;

    Console.WriteLine("Enter length for Side B");
    int SecondSide = int.Parse(Console.ReadLine());
    myTriangle.SideB = SecondSide;

    Console.WriteLine("Enter length for Side C");
    int ThirdSide = int.Parse(Console.ReadLine());
    myTriangle.SideC = ThirdSide;

    if(myTriangle.CheckTriangle())
    {
      Console.WriteLine("This is a " + myTriangle.TriangleType() + "!");
    }
    else
    {
      Console.WriteLine("This is not a triangle");
    }

  }
}
