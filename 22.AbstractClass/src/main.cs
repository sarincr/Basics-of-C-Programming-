using System;  
public abstract class MainClass  
    {  
        public abstract void NameFunct();  
    }  
    public class ChildClassOne : MainClass  
    {  
        public override void NameFunct()  
        {  
            Console.WriteLine("NameFunction override");  
        }  
    }  
    public class ChildClassTwo : MainClass  
    {  
        public override void NameFunct()  
        {  
            Console.WriteLine("NameFunction ChildClassTwo");  
        }  
    }  
    public class AbstractClassMain  
    {  
        public static void Main()  
        {  
            MainClass s;  
            s = new ChildClassOne();  
            s.NameFunct();  
            s = new ChildClassTwo();  
            s.NameFunct();  
        }  
    }  