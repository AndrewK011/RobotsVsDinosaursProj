using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Herd
    {
        
        List<Dinosaur> dinos = new List<Dinosaur>();
        Dinosaur raptor = new Dinosaur("Raptor", 20);
        Dinosaur trex = new Dinosaur("T-Rex", 25);
        Dinosaur pterodactyl = new Dinosaur("Pterodactyl", 15);

        public Herd()
        {
            dinos.Add(raptor);
            dinos.Add(trex);
            dinos.Add(pterodactyl);
        }
    }
}
