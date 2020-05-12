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
        
        


        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 50;                    
        }


        public void Attack(Dinosaur enemy)
        {
            if(powerLevel >= (robotWeapon.attackPower / 2))
            {
                enemy.health -= robotWeapon.attackPower;
                powerLevel -= robotWeapon.attackPower / 2;

                Console.WriteLine(enemy.type + " takes " + robotWeapon.attackPower + " damage from " + name + "'s " + robotWeapon.type + ".");

                if (enemy.health <= 0)
                {
                    Console.WriteLine(enemy.type + " has been defeated.");

                }
                else
                {
                    Console.WriteLine(enemy.type + " now has " + enemy.health + " health remaining.");
                }

            }

            else
            {
                Console.WriteLine("Power cells depleted, need to recharge.");
            }

            
            
        }


    }
}
