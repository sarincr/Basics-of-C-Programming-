using System;

namespace MyApplication
{
  class main
  { 
    static void Main(string[] args)
    {
   
      Car myCar = new Car();

     
      myCar.honk();

     Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}
