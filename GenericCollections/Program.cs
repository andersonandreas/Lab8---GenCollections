namespace GenericCollections
{
    internal class Program
    {

        static void Main(string[] args)
        {



            //------------------ Del 1 – Stack ------------------


            Employee employee1 = new Employee(1001, "Andreas", "male", 70000);
            Employee employee2 = new Employee(1002, "Daniel", "male", 25800);
            Employee employee3 = new Employee(1003, "Sofia", "female", 43000);
            Employee employee4 = new Employee(1004, "Linnea", "female", 59300);
            Employee employee5 = new Employee(1005, "Linus", "male", 385000);


            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            // i dont know this one maybe save in the same Stack?
            Stack<Employee> employees2 = new Stack<Employee>();


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

                employees2.Push(emp);

            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrive using Peek method");


            if (employees2.Count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Employee emp = employees2.Peek();
                    Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                    Console.WriteLine($"Items left in the stack = {employees2.Count}");
                }
            }

            Console.WriteLine("---------------------------------");

            if (employees2.Contains(employee3))
            {
                Console.WriteLine("Emp3 is in the stack");
            }


            // ------------------ Del 2 – List ------------------

            //Employee employee1 = new Employee(1001, "Andreas", "male", 70000);
            //Employee employee2 = new Employee(1002, "Daniel", "male", 25800);
            //Employee employee3 = new Employee(1003, "Sofia", "female", 43000);
            //Employee employee4 = new Employee(1004, "Linnea", "female", 59300);
            //Employee employee5 = new Employee(1005, "Linus", "male", 385000);

            //List<Employee> EmployeeList = new List<Employee>();

            //EmployeeList.Add(employee1);
            //EmployeeList.Add(employee2);
            //EmployeeList.Add(employee3);
            //EmployeeList.Add(employee4);
            //EmployeeList.Add(employee5);



            //if (EmployeeList.Contains(employee2))
            //{
            //    Console.WriteLine("Employee2 object exists in the list\n");
            //}
            //else
            //{
            //    Console.WriteLine("Employee2 object does not exist in the list");
            //}

            //// find the first male in the list
            //Employee? finded = EmployeeList.Find(emp => emp.Gender == "male");
            //Console.WriteLine("The first employee that is male:");

            //if (finded != null)
            //{
            //    Console.WriteLine($"ID = {finded.Id}, Name = {finded.Name}, Gender = {finded.Gender}, Salary = {finded.Salary} \n");
            //}
            //else
            //{
            //    Console.WriteLine("No match in the list \n");
            //}


            //Console.WriteLine("All the males in the list:");


            //// list with all the items that match my search in this case "male"
            //List<Employee> results = EmployeeList.FindAll(GenderSearch);

            //foreach (Employee emp in results)
            //{

            //    Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            //}




            //static bool GenderSearch(Employee Emp)
            //{
            //    return Emp.Gender == "male";
            //}


        }

    }


}
