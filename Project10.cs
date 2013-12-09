int main()
{
	string fileName;
	string inputString;
	string[ ] factors;
	double t = 0;
	double v = 0;

	Console.Write("Enter file name: ");
	fileName = Console.ReadLine();
	StreamReader theTextFile = new StreamReader(fileName);

    do 
    {
        inputString = theTextFile.ReadLine();

        if (inputString != null)
        {
	        
	    	factors = inputString.Split();
	    	t = double.Parse(factors[0]);
	    	v = double.Parse(factors[1]);
	    	windChillFactor(t, v);
	    }
    } while (inputString != null);

    Console.ReadLine();
}

static void windChillFactor(double t, double v)
{
	const double FACTOR_1 = 35.74;
	const double FACTOR_2 = 0.6215;
	const double FACTOR_3 = 35.75;
	const double FACTOR_4 = 0.16;
	const double FACTOR_5 = 0.4275;

	double w = FACTOR_1 + (FACTOR_2)t - FACTOR_3(Math.Pow(v, FACTOR_4)) + FACTOR_5(t)(Math.Pow(v, FACTOR_4));

	Console.WriteLine("Windchill is {0}", w);
}