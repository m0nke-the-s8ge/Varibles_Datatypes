using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
   //Declare Values
   int litterSize ;
   int yearlyLitters;
   int annualMice;
   //Assign Values
   litterSize = 14;
   yearlyLitters = 10;
   
   
   annualMice = litterSize * yearlyLitters;
   
   Console.WriteLine("one female mouse may give birth to");
   
   Console.WriteLine(annualMice);
   
   Console.WriteLine("to");
   
   
   annualMice = litterSize * yearlyLitters;
   
   Console.WriteLine(annualMice);
   
   Console.WriteLine("mice per year");
    }
  }
}