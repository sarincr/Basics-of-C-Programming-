using System;

public delegate void DelegateFunctionPass(string Message);


class MainClass
{
    public static void Main()
    {
        DelegateFunctionPass X = new DelegateFunctionPass(FunctDEL);
        X("Delegate function called");
    }


    public static void FunctDEL(string msg)
    {
        Console.WriteLine(msg);
    }
}