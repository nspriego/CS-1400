class Employee
{
	private string name = "";
 	private string number = "";
	private string address = "";
	private double wage = 0;
	private int hoursWorked = 0;

	const double FED_TAX = .2;
	const double STATE_TAX = .075;
	const int WORKING_HOURS = 40;

	public Employee(string n, string num, string addr, double w, int hours)
	{
		name = n;
		number = num;
		adress = addr;
		wage = w;
		hoursWorked = hours;
	}

	// getters
	public string getName() { return name; }
	public string getNumber() { return number; }
	public string getAddress() { return address; }
	public double getWage() { return wage; }
	public int getHoursWorked() { return hoursWorked; }

	// setters
	public void setName( string n){ name = n; }
	public void setNumber( string num ){ number = num; }
	public void setAddress( string addr ){ adress = addr; }
	public void setWage( double w ){ wage = w; }
	public void setHoursWorked( int hours ){ hoursWorked = hours; }

	public double CalcSalary() 
	{
		double grossPay = 0;

		if (hoursWorked > WORKING_HOURS)
		{
			int overtime = hoursWorked - WORKING_HOURS;
			grossPay = (WORKING_HOURS * wage) + (overtime * (wage + (wage * .5)));
		}
		else	
		{
			grossPay = WORKING_HOURS * wage;
		}
		return (grossPay - (grossPay * FED_TAX)) - (grossPay * STATE_TAX);
	}
}