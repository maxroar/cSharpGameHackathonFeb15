using System;
using System.Collections.Generic;

namespace fightingGame
{
    public class Enemy : Fighter{
        public Enemy(string name) : base(name){

        }

        public void Turn(Fighter fighter){
            Random rand = new Random();
            int healChance = rand.Next(1,4);
            if (healChance == 1){
                Heal();
            }else if (healChance == 4){
                BigAttack(fighter);
            }else{
                BasicAttack(fighter);
            }
        }

    }

}