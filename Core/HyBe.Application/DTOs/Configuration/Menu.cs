using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyBe.Application.Abstractions.Services.Configurations;

namespace HyBe.Application.DTOs.Configuration
{
    public class Menu
    {
        public string Name { get; set; }
        public List<Action> Actions { get; set; } = new();
    }
}