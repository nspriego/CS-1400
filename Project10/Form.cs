class Form
{
	Form()
	{
		StreamReader theTextFile = new StreamReader("employees.txt");
		string line = "";
		const int SIZE = 10;
		Employee[] emps = new Employee[SIZE];
		string num = "";
		string name = "";
		string addr = "";
		string[] payLine;
		double wage = 0;
		int hours = 0;
		int count = 0; 

		for (int i = 1; (line = sr.ReadLine()) != null; i++)
		{
			
			if (i % 4 == 1) num = line;
			if (i % 4 == 2) name = line;
			if (i % 4 == 3) addr = line;
			if (i % 4 == 0) 
			{
				payLine = line.Split();
				wage = double.Parse(payLine[0]);
    			hours = int.Parse(payLine[1]);

				// create the employee object
				Employee e = new Employee(num, name, addr, wage, hours);
				emps[count] = e;
				count++;
			}
		}
	}
}