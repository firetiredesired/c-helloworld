using System;

namespace HelloWorld
{
    
  class Program
  {
    static void Main(string[] args)
    {

        Fruit apple = new Apple("Green");
        Fruit pear = new Pear("lightGreen");
        
        Console.WriteLine(apple.EatFruit());
        Console.WriteLine(pear.EatFruit());
        Console.WriteLine(pear.notconsumed());
        Console.WriteLine(apple.notconsumed());
        ((Pear)pear).toggleRipe();
        Console.WriteLine(((Pear)pear).eat());
        ((Pear)pear).toggleRipe();
        Console.WriteLine(((Pear)pear).eat());
    }
  }
}
