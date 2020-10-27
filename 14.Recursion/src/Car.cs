using System;

namespace CalculatorApplication {

   class NumberManipulator {
   
      public int factorial(int num) {

         int result;
         if (num == 1) {
            return 1;
         }
         else {
            result = factorial(num - 1) * num;
            return result;
         }
      }
      
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
         Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
         Console.ReadLine();
      }
   }
}