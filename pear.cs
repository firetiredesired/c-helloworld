using System;

namespace HelloWorld
{
    
  class Pear : Fruit
    {
        public string color;
        public bool ripe = false;

        public Pear (string color) : base("Pear") {
            this.color = color;

        }


        public bool toggleRipe(){
            if (this.ripe == true){
                return this.ripe = false;
            }else{
                return this.ripe = true;
            }
        }

      
        public string eat() {
            if (this.ripe == true){
                this.EatFruit();
                return "yum";
            }else{
                return "eww not ripe yet";
            }
        }
    }
}

