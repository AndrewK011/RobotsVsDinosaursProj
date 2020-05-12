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
        public string[] dinoAttacks = new string[3] {"light attack x1", "heavy attack x1.5", "special attack x2"};

        //constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 50;
            this.attackPower = attackPower;
        }

        public void Attack(Robot enemy)
        {
            bool validInput = false;
            int userInput = 0;
            double attackMult;
            

            while (!validInput)
            {
                Console.WriteLine("Choose your type of attack: ");
                for (int i = 0; i < dinoAttacks.Length; i++)
                {
                    Console.WriteLine(i + ") " + dinoAttacks[i]);
                }

                if(int.TryParse(Console.ReadLine(), out userInput))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
                
            }

            switch(userInput)
            {
                case 0:
                    attackMult = 1.0;
                    break;
                case 1:
                    attackMult = 1.5;
                    break;
                case 2:
                    attackMult = 2.0;
                    break;

                default:
                    attackMult = 1.0;
                    break;


            }

            attackPower *= (int)attackMult;
            
            enemy.health -= attackPower;
            Console.WriteLine(enemy.name + " takes " + attackPower + " damage from " + type + "'s " + dinoAttacks[userInput]);
            if (enemy.health <= 0)
            {
                Console.WriteLine(enemy.name + " has been defeated.");              
            }
            else
            {
                Console.WriteLine(enemy.name + " now has " + enemy.health + " health remaining.");
            }
        }
    }
}
