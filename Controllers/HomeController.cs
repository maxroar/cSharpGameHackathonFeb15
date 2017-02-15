using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace fightingGame.Controllers
{

    
    public class HomeController : Controller
    {
        private Fighter player;
        private Enemy enemy;

        public HomeController (Fighter fighter, Enemy em) {
            player = fighter;
            enemy = em;
        }
  

        public void SetVB(Fighter player, Enemy enemy){
            ViewBag.playerHealth = player.health;
            ViewBag.playerEnergy = player.energy;
            ViewBag.playerFood = player.food;

            ViewBag.enemyHealth = enemy.health;
            ViewBag.enemyEnergy = enemy.energy;
            ViewBag.enemyFood = enemy.food;

            ViewBag.message = HttpContext.Session.GetString("message");
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // if(player == null){
            //     NewGame();
                
            // }
            SetVB(player, enemy);

            
            return View();
        }

        [HttpPost]
        [RouteAttribute("attack")]
        public IActionResult Attack(){
            player.BasicAttack(enemy);
            string mess = enemy.Turn(player);
            HttpContext.Session.SetString("message", mess);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [RouteAttribute("bigAttack")]
        public IActionResult BigAttack(){
            player.BigAttack(enemy);
            string mess = enemy.Turn(player);
            HttpContext.Session.SetString("message", mess);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [RouteAttribute("heal")]
        public IActionResult Heal(){
            player.Heal();
            string mess = enemy.Turn(player);
            HttpContext.Session.SetString("message", mess);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [RouteAttribute("eat")]
        public IActionResult Eat(){
            player.Eat();
            string mess = enemy.Turn(player);
            HttpContext.Session.SetString("message", mess);
            return RedirectToAction("Index");
        }
    }
}