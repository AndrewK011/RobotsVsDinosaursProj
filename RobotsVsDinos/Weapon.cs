using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Weapon
    {
        //member variables
        public string type;
        public int attackPower;
        

        //constructor
        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }

        
    }
}
