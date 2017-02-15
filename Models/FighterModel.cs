using System;
using System.Collections.Generic;

namespace fightingGame
{
    public class Fighter
    {
        public int health {get; set;}
        public int energy {get; set;}
        public int food {get; set;}
        public string name {get; set;}
        public int strength {get; set;}

        public static int AttackAmount(int strength){
            Random rand = new Random();
            return rand.Next(5,10+strength);
        }
        public void BasicAttack(Fighter fighter){
            fighter.health -= AttackAmount(this.strength);
            energy --;
            
        }

        public void Heal(){
            if(food > 0){
                health += 5;
                energy +=5;
                food --;
            }
        }

        public void BigAttack(Fighter fighter){
            if (energy > 4){
                fighter.health -= 3*AttackAmount(this.strength);
                energy -= 5;
            }
            
        }


    }
}