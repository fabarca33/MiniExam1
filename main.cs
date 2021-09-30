using System;

class Program {
  public static void Main (string[] args) {

    
    for (int counter = 1; counter <= 10; counter++)
    {
    Console.WriteLine ("What is your name?");

    var name = Console.ReadLine();

    Console.WriteLine("What is your height in inches");
    double height = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is your weight in pounds?");
    double weight = Convert.ToDouble(Console.ReadLine());

    double bmi = (703 * weight)/(height*height);

    Console.WriteLine(name +"'s BMI is " +bmi);

    if (bmi >= 30.0)
    {
    Console.WriteLine("You are Obese");
    }
    
    else if (bmi <= 29.9 && bmi >= 25.0)
    {
      Console.WriteLine("You are Overweight");
    }

    else if (bmi <= 24.9 && bmi >= 18.5)
    {
      Console.WriteLine("You have a normal or healthy weight");
    }

    else
    {
      Console.WriteLine("You are Underweight");
    }

    }
  }
}