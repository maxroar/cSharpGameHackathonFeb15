using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace fightingGame
{
    public class Enemy : Fighter{
        public Enemy() : base(){

        }

        public string Turn(Fighter fighter){
            Random rand = new Random();
            int healChance = rand.Next(1,4);
            if (healChance == 1){
                Heal();
                return "The enemy Healed!";
            }else if (healChance == 4){
                BigAttack(fighter);
                return "The enemy attacked you with a Big Attack!";
            }else{
                BasicAttack(fighter);
                return "The enemy attacked you!";
            }
            
        }

    }

}