using System;

namespace MyApplication
{
  class Program
  {
  
    static void Main(string[] args)
    {
      Person myObj = new Person();
      myObj.Name = "C# Programming";
      Console.WriteLine(myObj.Name);
    }
  }
}