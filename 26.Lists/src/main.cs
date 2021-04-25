using System;
namespace testNameSpace {
class test {
public delegate void addfun(int a, int b);
public delegate void subfun(int a, int b);
	public void sum(int a, int b)
	{
		Console.WriteLine("a + b ", a + b);
	}
	public void subfuntract(int a, int b)
	{
		Console.WriteLine(" a- b ", a - b);
	}
public static void Main(String []args)
{
	test obj = new test();
	addfun del_obj1 = new addfun(obj.sum);
	subfun del_obj2 = new subfun(obj.subfuntract);
	del_obj1(100, 40);
	del_obj2(100, 60);
}
}
}
