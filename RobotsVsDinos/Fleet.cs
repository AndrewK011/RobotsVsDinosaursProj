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
        public Robot Optimus = new Robot("Optimus");
        public Robot Hal = new Robot("Hal");
        public Robot Phil = new Robot("Phil");
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

            if (Optimus.powerLevel <= 40)
            {
                Optimus.powerLevel += 10;

            }

            if (Hal.powerLevel <= 40)
            {
                Hal.powerLevel += 10;

            }

            if (Phil.powerLevel <= 40)
            {
                Phil.powerLevel += 10;

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
            bool validInput = false;
            int userChoice = 0;

            while (!validInput)
            {
                
                Console.WriteLine("Choose a weapon for " + robotLoadout.name + ": ");
                for (int i = 0; i < weapons.Count; i++)
                {
                Console.WriteLine(i + ") " + weapons[i].type + " (" + weapons[i].attackPower + ")");
                }

                if ((int.TryParse(Console.ReadLine(), out userChoice)))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, not an integer.");
                }

                if(userChoice < 0 || userChoice >= weapons.Count)
                {
                    Console.WriteLine("Incorrect input, not a valid choice.");
                    validInput = false;
                }

            }

           

            robotLoadout.robotWeapon = weapons[userChoice];
            weapons.RemoveAt(userChoice);
        }






    }
}
