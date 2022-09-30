using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class Cliente
    {
        private string name;
        int edad;

        public string Name { get => name; set => name = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}