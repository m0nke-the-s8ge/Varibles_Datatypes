using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     //Declare Values 
     int x;
     int y;
     int z;
     
     
     //Assign values
     x = 5;
     y = x;
     z = x + 2;
     x = 3;
     
     //Output Values 
     Console.WriteLine(x);
     Console.WriteLine(y);
     Console.WriteLine(z);
     }
  }
}