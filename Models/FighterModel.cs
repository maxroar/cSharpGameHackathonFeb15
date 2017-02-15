using System;
using System.Collections.Generic;

namespace fightingGame
{
    public class Fighter
    {
        public int health {get; set;}
        public int energy {get; set;}
        public int food {get; set;}
        public int strength {get; set;}
        public int level {get;set;}

        public Fighter(){
            health = 100;
            energy = 10;
            food = 3;
            strength = 0;
            level = 1;
        }

        public void SetStrength(){
            strength = (int)Math.Floor((double)level/2);
        }
        public void LevelUp(){
            level ++;
            SetStrength();
        }

        public static int AttackAmount(int strength){
            Random rand = new Random();
            return rand.Next(5,10+strength);
        }
        public void BasicAttack(Fighter fighter){
            fighter.health -= AttackAmount(this.strength);
            energy --;
            
        }
        public void BasicAttack(Enemy fighter){
            fighter.health -= AttackAmount(this.strength);
            energy --;
            
        }

        public void Heal(){
            health += 10;
            energy -= 3;
                
        }

        public void Eat(){
            if(food > 0){
                energy += 5;
                food --;
            }
        }

        public void BigAttack(Fighter fighter){
            if (energy > 4){
                fighter.health -= 3*AttackAmount(this.strength+1);
                energy -= 5;
            }
            
        }

        public void BigAttack(Enemy fighter){
            if (energy > 4){
                fighter.health -= 3*AttackAmount(this.strength+1);
                energy -= 5;
            }
            
        }


    }
}
