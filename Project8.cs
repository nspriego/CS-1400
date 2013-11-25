int main()
{
	const int SIZE = 10;
	int count = 0;
	string[] names = new string[SIZE];
	int[] scores = new int[SIZE];
	string userInput;
	string[] parsedInput;

	Console.WriteLine("Saturday Coder's Bowling Team");
	Console.WriteLine("Enter in a name and a score for each person on the team.");
	Console.WriteLine("For example \"Mary 123\". Just hit enter when you are done");

	for (int i = 0; i < SIZE; i ++)
	{ 
		Console.Write("Enter a name and a score: ");
		userInput = Console.Readline();
		parsedInput = userInput.Split();
		names[i] = parsedInput[0];
		scores[i] = int.Parse(parsedInput[1]);
		count++;
	}

	int highScoreIndex  = getHighScoreIndex(scores);
	int lowScoreIndex   = getLowScoreIndex(scores);

	Console.WriteLine("------------- Input Complete --------------");
	Console.WriteLine("Here are the scores for this game:");
	for (int i = 0; i < count; i++)
	{
		Console.WriteLine("#{0}'s score was #{1}", names[i], scores[i]);
	}
	
	Console.WriteLine("Congratulations #{0}, your score of #{1} was the highest.", names[highScoreIndex], scores[highScoreIndex]);
	Console.WriteLine("#{0}, your score of #{1} was the lowest, bette get some practice.", names[lowScoreIndex], scores[lowScoreIndex]);
	Console.WriteLine("The average score for this game was #{0}", getAverageScore(scores));
}

static int getHighScoreIndex(int[] nums)
{
	int high = nums[0];
	foreach (int num in nums)
	{
		if (num > high)
		{
			high = num;
		}
	}
	return high;
}

static int getLowScoreIndex(int[] nums)
{
	int low = nums[0];
	foreach (int num in nums)
	{
		if (num < low)
		{
			low = num;
		}
	}
	return low;
}

static double getAverageScore(int[] nums)
{
	int count = 0;
	double sum = 0;
	foreach (int num in nums)
	{
		sum += num;
		count++;
	}
	return sum / count;
}