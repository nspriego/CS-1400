class Employee
{
	private string name = "";
 	private string number = "";
	private string address = "";
	private double wage = 0;
	private int hoursWorked;

	public Employee(string n, string num, string addr, double w, int hours)
	{
		name = n;
		number = num;
		adress = addr;
		wage = w;
		hoursWorked = hours;
	}

	public string getName() { return name; }
	public string getNumber() { return number; }
	public string getAddress() { return address; }
	public double getWage() { return wage; }
	public int getHoursWorked() { return hoursWorked; }

	public void setName( string n){ name = n; }
	public void setNumber( string num ){ number = num; }
	public void setAddress( string addr ){ adress = addr; }
	public void setWage( double w ){ wage = w; }
	public void setHoursWorked( int hours ){ hoursWorked = hours; }

}