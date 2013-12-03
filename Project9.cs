int main()
{
	BowlingTeam team = new BowlingTeam();
	string userInput;
	string[] parsedInput;

	Console.WriteLine("Saturday Coder's Bowling Team");
	Console.WriteLine("Enter in a name and a score for each person on the team.");
	Console.WriteLine("For example \"Mary 123\". Just hit enter when you are done");

	for (int i = 0; i < team.SIZE; i ++)
	{ 
		Console.Write("Enter a name and a score: ");
		userInput = Console.Readline();
		parsedInput = userInput.Split();
		team.addName(parsedInput[0], i);
		team.addScore(int.Parse(parsedInput[1]), i);
		team.incrementTeamSize();
	}

	Console.WriteLine("------------- Input Complete --------------");
	
	team.sortScores();
	team.printScores();
	
	Console.Readline();
}