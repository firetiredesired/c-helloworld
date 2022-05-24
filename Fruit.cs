using System;

namespace HelloWorld
{
    
    class Fruit
    {

        public string name;
        public bool eaten;

        public Fruit (string name) {
            this.name = name;
        }

        public string EatFruit() {
            this.eaten = true;
            return "";
        }
        public string notconsumed() {
            return "noconsumed";
        }
    }
}
