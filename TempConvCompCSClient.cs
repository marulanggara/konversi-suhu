
using System;
using TempConv;

class MainApp
{
  public static void Main()
 {
   TempConv.TempConvComp myCSTempConvComp =   new TempConv.TempConvComp();
   double choice;
   double input;
   double output;
   bool next = true;

  while (next)
  {
    Console.WriteLine("Please enter your choice: ");
         Console.WriteLine(            " 1 - Converter from F to C, ");
         Console.WriteLine(            " 2 - from C to F, ");
         Console.WriteLine(            "  3 – exit");
   choice=Double.Parse(Console.ReadLine());
   if (choice == 1)
  {
   Console.WriteLine("Please tell me the temperature in F:");
   input = Double.Parse(Console.ReadLine());
   output = myCSTempConvComp.fToC(input);
   Console.WriteLine(output);
  }
   else if ( choice == 2)
  {
   Console.WriteLine("Please tell me the temperature in C:");
   input = Double.Parse(Console.ReadLine());
   output = myCSTempConvComp.cToF(input);
   Console.WriteLine(output);
  }
  else
 {
  next = false;
  Console.WriteLine (" see u next time");
 }
  }
  
 } 
}
