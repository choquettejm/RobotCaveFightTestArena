using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena
{
    public class Smasher : IRobot
    {
        public string robotName { get; private set; }
        public string[] studentNames { get; private set; }
        public double attack { get; private set; }
        public double defense { get; private set; }
        public double speed { get; private set; }
        public double constitution { get; private set; }
        public double health { get; private set; }
        public string primaryColor { get; private set; }
        public string secondaryColor { get; private set; }

        public Smasher()
        {
            robotName = "Smasher";
            studentNames = new string[] { "Training", "Dummy" };
            attack = 10;
            defense = 10;
            speed = 10;
            constitution = 10;
            health = 10 * constitution;
            primaryColor = "#0000FF";  //Blue
            secondaryColor = "#FFFF00";  //Yellow
        }

        string IRobot.GetRobotName()
        {
            return robotName;
        }

        void IRobot.Reset()
        {
            attack = 10;
            defense = 10;
            speed = 10;
            constitution = 10;
            health = 10 * constitution;
        }

        string[] IRobot.GetStudentNames()
        {
            return studentNames;
        }
        double IRobot.GetAttack()
        {
            return attack;
        }

        double IRobot.GetDefense()
        {
            return defense;
        }
        string IRobot.GetStats()
        {
            return $"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.";
        }

        double IRobot.GetSpeed()
        {
            return speed;
        }

        double IRobot.GetHealth()
        {
            return health;
        }

        double IRobot.GetMaxHealth()
        {
            return 10 * constitution;
        }

        string IRobot.GetPrimaryColor()
        {
            return primaryColor;
        }

        string IRobot.GetSecondaryColor()
        {
            return secondaryColor;
        }

        void IRobot.TakeDamage(double damage)
        {
            double damageDealt = damage - (defense / 100 * damage);
            health -= damageDealt;
        }

        global::ActionResult IRobot.PerformAction(IRobot opponent)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= 50)
            {
               return Attack(opponent);
               
            }
            else if (randomNumber <= 80)
            {
                return ExplosiveDiarrhea(opponent);
            }
            else
            {
                return SuckFace(opponent);
            }

        }

        public ActionResult Attack(IRobot opponent)
        {
            opponent.TakeDamage(attack);
            return new ActionResult
            {
                ActionName = "Attack",
                ActionAnimation = "Punch"
            };
        }

        public ActionResult ExplosiveDiarrhea(IRobot opponent)
        {
            double damage = 0.6 * attack + 0.4 * defense;
            opponent.TakeDamage(damage);
            return new ActionResult
            {
                ActionName = "Explosive Diarrhea",
                ActionAnimation = "Power Up"
            };
        }

        public ActionResult SuckFace(IRobot opponent)
        {
            double healthRegained = 3 * (health - speed);
            health += healthRegained;
            speed -= 2.5;
            return new ActionResult
            {
                ActionName = "Suck Face",
                ActionAnimation = "Heal"
            };
        }

    }

    public class ActionResult
    {
        public string ActionName { get; set; }
        public string ActionAnimation { get; set; }
    }
}
