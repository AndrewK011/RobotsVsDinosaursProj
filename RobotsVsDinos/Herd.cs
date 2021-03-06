﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Herd
    {

        public List<Dinosaur> dinos = new List<Dinosaur>();
        public Dinosaur raptor = new Dinosaur("Raptor", 20);
        public Dinosaur trex = new Dinosaur("T-Rex", 25);
        public Dinosaur pterodactyl = new Dinosaur("Pterodactyl", 20);

        
       

        public Herd()
        {
            dinos.Add(raptor);
            dinos.Add(trex);
            dinos.Add(pterodactyl);
        }

        public void CheckDinoRound()
        {
            
            if (raptor.health <= 0)
            {
                dinos.Remove(raptor);
            }
            if(trex.health <= 0)
            {
                dinos.Remove(trex);
            }
            if(pterodactyl.health <= 0)
            {
                dinos.Remove(pterodactyl);
            }

            if(raptor.energy <= 40)
            {
                raptor.energy += 10;

            }
            
            if(trex.energy <= 40)
            {
                trex.energy += 10;

            }

            if (pterodactyl.energy <= 40)
            {
                pterodactyl.energy += 10;

            }
        }

    }
}
