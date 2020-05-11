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
        public Robot Optimus = new Robot("Optimus","Rockets");
        public Robot Hal = new Robot("Hal", "Superior Intellect");
        public Robot Phil = new Robot("Phil", "Fists");

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
        }






    }
}
