namespace GenericCollections
{
    internal class Program
    {
        // Andreas Anderson .NET23

        static void Main(string[] args)
        {

            //------------------------------------ Part 1– Stack ------------------------------------

            Employee employee1 = new Employee(1001, "Andreas", "male", 70000);
            Employee employee2 = new Employee(1002, "Daniel", "male", 25800);
            Employee employee3 = new Employee(1003, "Sofia", "female", 43000);
            Employee employee4 = new Employee(1004, "Linnea", "female", 59300);
            Employee employee5 = new Employee(1005, "Linus", "male", 385000);


            Stack<Employee> employees = new Stack<Employee>();

            // adding the poped Employees
            Stack<Employee> popedEmployees = new Stack<Employee>();

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);


            foreach (Employee emp in employees)
            {

                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine($"Items left in the stack = {employees.Count}");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrive using Pop method");

            while (employees.Count > 0)
            {
                Employee emp = employees.Pop();
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine($"Items left in the stack = {employees.Count}");

                popedEmployees.Push(emp);

            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrive using Peek method");


            if (popedEmployees.Count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Employee emp = popedEmployees.Peek();
                    Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                    Console.WriteLine($"Items left in the stack = {popedEmployees.Count}");
                }
            }

            Console.WriteLine("---------------------------------");

            if (popedEmployees.Contains(employee3))
            {
                Console.WriteLine("Emp3 is in the stack");
            }


            // ------------------------------------ Part 2 – List ------------------------------------

            Console.WriteLine("\n-------------Part 2----------------\n");

            Employee employee6 = new Employee(1001, "Andreas", "male", 70000);
            Employee employee7 = new Employee(1002, "Daniel", "male", 25800);
            Employee employee8 = new Employee(1003, "Sofia", "female", 43000);
            Employee employee9 = new Employee(1004, "Linnea", "female", 59300);
            Employee employee10 = new Employee(1005, "Linus", "male", 385000);

            List<Employee> EmployeeList = new List<Employee>();

            EmployeeList.Add(employee6);
            EmployeeList.Add(employee7);
            EmployeeList.Add(employee8);
            EmployeeList.Add(employee9);
            EmployeeList.Add(employee10);



            if (EmployeeList.Contains(employee7))
            {
                Console.WriteLine("Employee7 object exists in the list\n");
            }
            else
            {
                Console.WriteLine("Employee7 object does not exist in the list");
            }

            // find the first male in the list
            Employee? finded = EmployeeList.Find(emp => emp.Gender == "male");
            Console.WriteLine("The first employee that is male:");

            if (finded != null)
            {
                Console.WriteLine($"ID = {finded.Id}, Name = {finded.Name}, Gender = {finded.Gender}, Salary = {finded.Salary} \n");
            }
            else
            {
                Console.WriteLine("No match in the list \n");
            }


            Console.WriteLine("All the males in the list:");


            // Find all the males in the list
            List<Employee> results = EmployeeList.FindAll(emp => emp.Gender == "male");

            foreach (Employee emp in results)
            {

                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }





        }

    }


}
