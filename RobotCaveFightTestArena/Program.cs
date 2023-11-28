namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
			//Create bots
			TrainingDummy trainingDummy = new TrainingDummy();
			TrainingDummy trainingDummy1 = new TrainingDummy();
			//Smasher smasher = new Smasher();

			Console.WriteLine(trainingDummy.GetStats());
			Console.WriteLine(trainingDummy.GetRobotName());


			//Create a new arena
			Arena arena = new Arena(trainingDummy, trainingDummy1);

			arena.RunBattle();
		}
	}
}