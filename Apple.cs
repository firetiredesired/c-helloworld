using System;

namespace HelloWorld
{
    
    class Apple : Fruit
    {
        public string color;

        public Apple (string color) : base("Apple") {
            this.color = color;
        }
    }
}
