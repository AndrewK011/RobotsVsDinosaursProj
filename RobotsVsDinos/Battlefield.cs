﻿using System;
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
        

        public Battlefield()
        {
            dinoHerd = new Herd();
            robotFleet = new Fleet();
            
        }

        
        public void StartBattle()
        {

           DinoAttack();
            Console.WriteLine();
           RoboAttack();
        }

        public void DinoAttack()
        {
            Console.WriteLine("With which dinosaur do you want to attack?");
            for(int i = 0; i < dinoHerd.dinos.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(dinoHerd.dinos[i].type);
            }

            attackerIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Which robot do you want to attack?");
            for (int i = 0; i < robotFleet.robots.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(robotFleet.robots[i].name);
            }

            enemyIndex = int.Parse(Console.ReadLine());


            dinoHerd.dinos[attackerIndex].Attack(dinoHerd.dinos[attackerIndex], robotFleet.robots[enemyIndex]);
                     
        }

        public void RoboAttack()
        {
            Console.WriteLine("With which robot do you want to attack?");
            for (int i = 0; i < robotFleet.robots.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(robotFleet.robots[i].name);
            }

            attackerIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Which dinosaur do you want to attack?");
            for (int i = 0; i < dinoHerd.dinos.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(dinoHerd.dinos[i].type);
            }

            enemyIndex = int.Parse(Console.ReadLine());


            robotFleet.robots[attackerIndex].Attack(robotFleet.robots[attackerIndex], dinoHerd.dinos[enemyIndex]);
        }









    }
}
