using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena
{
    internal class Smasher : IRobot
    {
        public string robotName { get; set; }
        public string[] studentNames { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public double speed { get; set; }
        public double constitution { get; set; }
        public double health { get; set; }
        public string primaryColor { get; set; }
        public string secondaryColor { get; set; }



        public double GetHealth()
        {
            return GetMaxHealth();
        }

        public double GetMaxHealth()
        {
            return 10 * constitution;
        }

        public string GetPrimaryColor()
        {
            return primaryColor;
        }

        public string GetRobotName()
        {
            return robotName;
        }

        public string GetSecondaryColor()
        {
            return secondaryColor;
        }

        public double GetSpeed()
        {
            return speed;   
        }

        public string GetStats()
        {

            attack = 10;
            defense = 10;
            speed = 10;
            constitution = 10;
            health = 10 * constitution;
            primaryColor = "";
            secondaryColor = "";

            return ($"Current Health: {health}, Attack: { attack}, Defense: { defense}, Speed: { speed}");
        }

        public string[] GetStudentNames()
        {
            return studentNames;
        }

        public ActionResult PerformAction(IRobot opponent)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }

        public double GetAttack() => 0;


        public double GetDefense() => 0;



    }
}
