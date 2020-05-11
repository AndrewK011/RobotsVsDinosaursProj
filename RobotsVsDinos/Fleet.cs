using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        List<Robot> robots = new List<Robot>();
        Robot Optimus = new Robot("Optimus","Rockets");
        Robot Hal = new Robot("Hal", "Superior Intellect");
        Robot Phil = new Robot("Phil", "Fists");

        public Fleet()
        {
            robots.Add(Optimus);
            robots.Add(Hal);
            robots.Add(Phil);
        }
        
        
        
    }
}
