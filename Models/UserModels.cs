using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace fightingGame.Models
{
    public class User
    {
        public string name {get; set;}
        public string highscore {get; set;}
    }
}