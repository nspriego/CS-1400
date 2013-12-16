class Form
{
	Form()
	{
		StreamReader theTextFile = new StreamReader("employees.txt");
		string line = "";
		int count = 0;
		const int SIZE = 10;
		Employee[SIZE] emps;

		while ((line = sr.ReadLine()) != NULL)
		{
			string num = "";
			string name = "";
			string addr = "";
			string[] payLine;
			double wage = 0;
			int hours = 0;

			for (int i = 0; i < 4; i++)
			{
				if (i == 0) num = line;
				if (i == 1) name = line;
				if (i == 2) address = line;
				if (i == 3) 
				{
					payLine = line.Split();
					wage = double.Parse(payLine[0]);
	    			hours = int.Parse(payLine[1]);
				}
			}

			// create the employee object
			Employee e = new Employee(num, name, addr, wage, hours);
			emp[count] = e;
			count++;
		}
	}
}