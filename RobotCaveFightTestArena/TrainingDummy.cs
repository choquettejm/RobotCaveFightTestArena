using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena {
	internal class TrainingDummy : IRobot {

		public double attack = 10;
		public double defense = 10;
		public double speed = 10;
		public double constitution = 10;

		double health = 100;
		public double GetHealth() => health;

		public double GetMaxHealth() => 100;

		public string GetPrimaryColor() => "#FFC423";

		public string GetSecondaryColor() => "#002D62";

		public string GetRobotName() => "Training Dummy";

		public double GetSpeed() => 10;

		public string GetStats()
		{
			return $"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.";
		}

		public string[] GetStudentNames() => new string[] { "Training", "Dummy" };

		public ActionResult PerformAction(IRobot opponent) => new ActionResult("Stare Menacingly", "None");

		public void Reset() => health = 100;

		public void TakeDamage(double damage) => health -= damage;

		public double GetAttack() => 5;

		public double GetDefense() => 4;

        
    }
}
