using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a salesperson name");
    var x = Console.ReadLine();

    Console.WriteLine("Enter sales amount");
    var y = Console.ReadLine();  

    double y1 = Convert.ToDouble(y);

    Console.Write("Sales commission for ");
    Console.Write(x + " is $");
    Console.WriteLine(y1*0.09+200);
     

    if ( y1 <=2999)
    {Console.WriteLine("Performance is poor");
    }
    else if ( y1 <=4999)
    {
      Console.WriteLine("Performance is average");
    }
    else if ( y1 <=9999)
    {
      Console.WriteLine("Performance is good");
    }
    else if (y1<=14999)
    {
      Console.WriteLine("Performance is excellent");
    }
    else if (y1>=15000)
    {
      Console.WriteLine("Performance is outstanding");
    }

  }
}