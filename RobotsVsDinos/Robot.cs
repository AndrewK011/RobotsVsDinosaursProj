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

        public void Attack(Weapon robotWeapon, int enemyHealth)
        {
            enemyHealth -= robotWeapon.attackPower;
        }

    }
}
