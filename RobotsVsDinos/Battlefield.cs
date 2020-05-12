using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Battlefield
    { 
        public Herd dinoHerd;
        public Fleet robotFleet;
        public int enemyIndex;
        public int attackerIndex;
        public bool gameOver = false;
        public bool dinoWin = false;
        
        public bool playerTurn;
        public Random randomBool = new Random();
        

        public Battlefield()
        {
            dinoHerd = new Herd();
            robotFleet = new Fleet();
            
        }

        
        public void StartBattle()
        {
            robotFleet.CreateWeaponList();
            robotFleet.ChooseWeapon(robotFleet.Optimus);
            robotFleet.ChooseWeapon(robotFleet.Hal);
            robotFleet.ChooseWeapon(robotFleet.Phil);

           
            if(randomBool.Next(2) == 1)
            {
                playerTurn = true;
                Console.WriteLine();
                Console.WriteLine("Dinos go first!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Robots go first!");
                Console.WriteLine();
            }

            while (gameOver == false)
            {
                if (playerTurn)
                {
                    DinoAttack();
                    CheckRoundResult();
                    Console.WriteLine();
                    playerTurn = !playerTurn;
                }
                else
                { 
                    RoboAttack();
                    Console.WriteLine();
                    CheckRoundResult();
                    playerTurn = !playerTurn;
                }
            }

            Console.WriteLine("Game Over");
            if(dinoWin)
            {
                Console.WriteLine("Dinosaurs win!");
            }
            else
            {
                Console.WriteLine("Robots win!");
            }

        }

        public void DinoAttack()
        {
            bool validInput = false;
            
            while (!validInput)
            {
               
            Console.WriteLine("Pick a dinosaur to attack with:");
            for(int i = 0; i < dinoHerd.dinos.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(dinoHerd.dinos[i].type);
            }

                if (int.TryParse(Console.ReadLine(), out attackerIndex))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, must be an integer.");
                }

                if (attackerIndex < 0 || attackerIndex >= dinoHerd.dinos.Count)
                {
                    Console.WriteLine("Incorrect input, not a valid choice.");
                    validInput = false;
                }

            }

            

            validInput = false;


            while (!validInput)
            {
               
                Console.WriteLine("Choose your target: ");

                for (int i = 0; i < robotFleet.robots.Count; i++)
                {
                    Console.Write(i + ") ");
                    Console.WriteLine(robotFleet.robots[i].name);
                }

                if (int.TryParse(Console.ReadLine(), out enemyIndex))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, must be an integer.");
                }

                if (enemyIndex < 0 || enemyIndex >= robotFleet.robots.Count)
                {
                    Console.WriteLine("Incorrect input, not a valid choice.");
                    validInput = false;
                }

            }


            if (HitChance(dinoHerd.dinos[attackerIndex].attackPower))
            {
               
                dinoHerd.dinos[attackerIndex].Attack(robotFleet.robots[enemyIndex]);

            }

            else
            {
                Console.WriteLine("The attack missed!");
            }

                     
        }

        public void RoboAttack()
        {

            bool validInput = false;


            while (!validInput)
            {
                Console.WriteLine("Pick a robot to attack with: ");
                for (int i = 0; i < robotFleet.robots.Count; i++)
                {
                    Console.Write(i + ") ");
                    Console.WriteLine(robotFleet.robots[i].name + " [" + robotFleet.robots[i].robotWeapon.type + "]" +
                        " (" + robotFleet.robots[i].robotWeapon.attackPower + ") ");

                }

                if (int.TryParse(Console.ReadLine(), out attackerIndex))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, must be an integer.");
                }

                if (attackerIndex < 0 || attackerIndex >= robotFleet.robots.Count)
                {
                    Console.WriteLine("Incorrect input, not a valid choice.");
                    validInput = false;
                }
            }

            validInput = false;


            while (!validInput)
            {

                Console.WriteLine("Choose your target: ");
                for (int i = 0; i < dinoHerd.dinos.Count; i++)
                {
                    Console.Write(i + ") ");
                    Console.WriteLine(dinoHerd.dinos[i].type);
                }

                if (int.TryParse(Console.ReadLine(), out enemyIndex))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input, must be an integer.");
                }

                if (enemyIndex < 0 || enemyIndex >= dinoHerd.dinos.Count)
                {
                    Console.WriteLine("Incorrect input, not a valid choice.");
                    validInput = false;
                }
            }

            

            if (HitChance(robotFleet.robots[attackerIndex].robotWeapon.attackPower))
            {
                robotFleet.robots[attackerIndex].Attack(dinoHerd.dinos[enemyIndex]);

            }

            else
            {
                Console.WriteLine("The attack missed!");
            }
            

            
        }

        public bool CheckRoundResult()
        {
            dinoHerd.CheckDinoRound();
            robotFleet.CheckRoboRound();
            if(dinoHerd.dinos.Count == 0)
            {
                gameOver = true;
                
            }
            else if(robotFleet.robots.Count == 0)
            {
                gameOver = true;
                dinoWin = true;
            }
            return gameOver;
        }

        public bool HitChance(int attackPower)
        {
            if (randomBool.Next(110) > attackPower )
            {
                return true;
            }
            else
            {
                return false;
            }
        }







    }
}
