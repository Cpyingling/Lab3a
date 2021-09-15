/*Author Charles Yingling       Date 9/14/2021
1. Write a program in C# to convert Celsius to Farehneit. 
*/
using System;

class Program {
  public static void Main (string[] args) {
    //ask for temp in Celsius
    Console.WriteLine ("Enter temperature in Celsius");
    double cel = Convert.ToDouble(Console.ReadLine());
    //convert Celsius to Farehneit
    double far = (cel * 9/5) + 32;
    //display Farehneit
    Console.WriteLine ($"Farenheit equivalent for {cel} degree Celsius is {far}");
    if (far < 32) {
    Console.WriteLine ("This temperature is below freezing of 32 degrees Farenheit");
    } 
   if (far > 212) {
    Console.WriteLine ("This temperature is above boiling point of 212 degrees Farenheit");
    } 
  }
}