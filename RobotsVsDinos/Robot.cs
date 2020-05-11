using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon robotWeapon;


        public Robot(string name, string weapon)
        {
            this.name = name;
            health = 100;
            powerLevel = 50;
            robotWeapon = new Weapon(weapon);
        }

        public void Attack(Robot attackByRobot, Dinosaur enemy)
        {
            enemy.health -= attackByRobot.robotWeapon.attackPower;
            Console.WriteLine(enemy.type + " takes " + attackByRobot.robotWeapon.attackPower + " points of damage from " + attackByRobot.name + ".");

            if (enemy.health <= 0)
            {
                Console.WriteLine(enemy.type + " has been defeated.");
                
            }
            else
            {
                Console.WriteLine(enemy.type + " now has " + enemy.health + " health points remaining.");
            }
            
        }

    }
}
