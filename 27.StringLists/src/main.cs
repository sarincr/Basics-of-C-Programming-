using System;
using System.Collections.Generic;

public class ProgramClass
{
	public static void Main()
	{
		List<string> lst = new List<string>();
		lst.Add("John");
		lst.Add("Adam");
		lst.Add("George");
		int i = 0;
		foreach(string j in lst)
        {
            Console.Write("Name {0}: ", i);
            Console.WriteLine(j);
            i++;
        }
  
  

	}
}

