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
            
            dinoHerd.dinos[attackerIndex].Attack(dinoHerd.dinos[attackerIndex], robotFleet.robots[enemyIndex]);
                     
        }

        public void RoboAttack()
        {
            robotFleet.robots[attackerIndex].Attack(robotFleet.robots[attackerIndex], dinoHerd.dinos[enemyIndex]);
        }









    }
}
