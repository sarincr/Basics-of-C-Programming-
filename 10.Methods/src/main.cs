using System;

namespace CalculatorTest {
   class AddNumbers{
      public int Add(int x, int y) 
	  {
         return x+y;
      }
      
      static void Main(string[] args) {
         int a = 10;
         int b = 20;
         int sum;
         AddNumbers obj = new AddNumbers();
         sum = obj.Add(a, b);
         Console.WriteLine(" Sum of numbers = : {0}", sum);
         Console.ReadLine();
      }
   }
}