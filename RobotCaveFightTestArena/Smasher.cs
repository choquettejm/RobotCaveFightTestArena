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

            robotName = "Smasher";
            studentNames = new string[] { "Reece", "Jason" };
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

        //public ActionResult PerformAction(IRobot opponent)
        //{
            //Random random = new Random();

            // Generate a random number between 1 and 4
            //int randomNumber = random.Next(1, 5);

            //switch (randomNumber)
            //{
            //    case 1:
            //        explosiveDiahrea(5);
            //        break;
            //    case 2:
            //        faceSlap(5);
            //        break;
            //    default:
            //        break;

            //}
        //}

        public void Reset()
        {
            attack = default(double);
            defense = default(double);
            speed = default(double);
            constitution = default(double);
            health = default(double);
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }

        public double GetAttack()
        {
            return attack;
        }


        public double GetDefense()
        {
            return defense;
        }

        //public static double explosiveDiahrea(double damage)
        //{
        //    Smasher smasher = new Smasher();

        //    ActionResult result = new ActionResult();

        //    result.ActionName = "Explosive Diahrea";
        //    result.AnimationName = "Punch";

        //    damage = .8 * smasher.attack + .2 * smasher.defense;

        //    //return damage;
        //    return result;
        //}





    }
}
