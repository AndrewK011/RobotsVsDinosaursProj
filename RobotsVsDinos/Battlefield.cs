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

        public Battlefield()
        {
            dinoHerd = new Herd();
            robotFleet = new Fleet();  
        }

        public void StartBattle()
        {
            DinoAttack();
            RoboAttack();
        }

        public void DinoAttack()
        {
            robotFleet.TakeDamage(0, dinoHerd.Attack(0));
            robotFleet.TakeDamage(0, dinoHerd.Attack(1));
            robotFleet.TakeDamage(0, dinoHerd.Attack(2));          
        }

        public void RoboAttack()
        {
            dinoHerd.TakeDamage(0, robotFleet.Attack(0));
            dinoHerd.TakeDamage(0, robotFleet.Attack(1));
            dinoHerd.TakeDamage(0, robotFleet.Attack(2));
        }







    }
}
