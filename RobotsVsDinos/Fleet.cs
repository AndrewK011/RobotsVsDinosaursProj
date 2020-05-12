using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        public List<Robot> robots;
        public Robot Optimus = new Robot("Optimus","Rockets");
        public Robot Hal = new Robot("Hal", "Superior Intellect");
        public Robot Phil = new Robot("Phil", "Fists");
        public List<Weapon> weapons = new List<Weapon>();
        public Weapon laser = new Weapon("laser", 30);
        public Weapon rocketLauncher = new Weapon("rocket launcher", 50);
        public Weapon sword = new Weapon("sword", 35);
        public Weapon flameThrower = new Weapon("flame thrower", 25);

        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(Optimus);
            robots.Add(Hal);
            robots.Add(Phil);
            
            
        }

        public void CheckRoboRound()
        {
            if (Optimus.health <= 0)
            {
                robots.Remove(Optimus);
            }
            if (Hal.health <= 0)
            {
                robots.Remove(Hal);
            }
            if (Phil.health <= 0)
            {
                robots.Remove(Phil);
            }
        }

        public void CreateWeaponList()
        {
            weapons.Add(laser);
            weapons.Add(rocketLauncher);
            weapons.Add(sword);
            weapons.Add(flameThrower);
        }

        public void ChooseWeapon(Robot robotLoadout)
        {

            int userChoice;
            Console.WriteLine("Choose a weapon for " + robotLoadout.name + ": ");
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine(i + ") " + weapons[i].type + " (" + weapons[i].attackPower + ")");
            }

            userChoice = int.Parse(Console.ReadLine());

            robotLoadout.robotWeapon = weapons[userChoice];
            weapons.RemoveAt(userChoice);
        }






    }
}
