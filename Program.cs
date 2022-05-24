using System;

namespace HelloWorld
{
    
  class Program
  {
    static void Main(string[] args)
    {

        Fruit apple = new Apple("Green");
        
        Console.WriteLine(apple.EatFruit());

    }
  }
}
