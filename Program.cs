class Employee
{
    public string Name;
    public int Age;
    public int Salary;
    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
    }

    public static void Main1(string[] args)
    {
        Employee emp = new Employee("John Doe", 30, 50000);
        emp.Display();
    }
}