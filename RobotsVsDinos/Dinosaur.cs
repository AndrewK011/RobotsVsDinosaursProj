using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Dinosaur
    {
        //member variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 50;
            this.attackPower = attackPower;
        }

        public void Attack(Dinosaur attackByDino, Robot enemy)
        {
            enemy.health -= attackByDino.attackPower;
            Console.WriteLine(enemy.name + " takes " + attackByDino.attackPower + " points of damage from " + attackByDino.type + ".");
        }
    }
}
