using System;
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
       public Dinosaur pterodactyl = new Dinosaur("Pterodactyl", 15);
       

        public Herd()
        {
            dinos.Add(raptor);
            dinos.Add(trex);
            dinos.Add(pterodactyl);
        }

        public int Attack(int dinoSelection)
        {           
            return dinos[dinoSelection].attackPower;
        }

        public void TakeDamage(int robotTargeted, int damageTaken)
        {
            dinos[robotTargeted].health -= damageTaken;
        }

    }
}
