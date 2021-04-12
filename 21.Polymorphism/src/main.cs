using System;
class Parent 
{
  public void ParentFunct() 
  {
    Console.WriteLine("The Parent class is on run");
  }
}

class ChildClassOne : Parent
{
  public void ParentFunct() 
  {
    Console.WriteLine("The ChildClassOne on run");
  }
}

class ChildClassTwo : Parent  
{
  public void ParentFunct() 
  {
    Console.WriteLine("The ChildClassTwo is on run");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Parent ObjParent = new Parent();   
    Parent ObjChildClassOne = new ChildClassOne();   
    Parent ObjChildClassTwo = new ChildClassTwo(); 

    ObjParent.ParentFunct();
    ObjChildClassOne.ParentFunct();
    ObjChildClassTwo.ParentFunct();
  }
}