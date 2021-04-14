using System;

namespace BaseClass
{

  interface ChileClassOne
  {
    void IntFunct();  
  }
	
  class ChileClassTwo : ChileClassOne
  {
    public void IntFunct() 
    {
	Console.WriteLine(" Int Function Display");
    }
  }

  class StartClass  
  {
    static void Main(string[] args) 
    {
      ChileClassTwo X = new ChileClassTwo(); 
      X.IntFunct();
    }
  }
}
