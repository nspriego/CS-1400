class BowlingTeam
{
	public const int SIZE = 10;
	private string[] names = new string[SIZE];
	private int[] scores = new int[SIZE];
	private int teamSize = 0;

	public void addName(string name, int index)
	{
		names[index] = name;
	}

	public void addScore(int score, int index)
	{
		score[index] = score;
	}

	public void incrementTeamSize()
	{
		teamSize++;
	}

	public double getAverageScore()
	{
		double sum = 0;
		foreach (int score in scores)
		{
			sum += score;
		}
		return sum / teamSize;
	}

	public void printAverageScore()
	{
		Console.WriteLine("The team average for this game was #{0}", getAverageScore());
	}

	public void printScores()
	{
		Console.WriteLine("Here are the scores for this game from highest to lowest:");
		for (int i = 0; i < teamSize; i++)
		{
			Console.WriteLine("#{0}'s score was #{1}", names[i], scores[i]);
		}
	}

	public void sortScores()
	{}
}