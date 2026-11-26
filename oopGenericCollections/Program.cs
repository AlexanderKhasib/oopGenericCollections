namespace oopGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 5 Employee objects using Employee construct
            Employee employee1 = new Employee(1, "John", 5000,  "Man");
            Employee employee2 = new Employee(2, "Anna",6000, "Kvinna");
            Employee employee3 = new Employee(3, "Peter", 7000, "Man");
            Employee employee4 = new Employee(4, "Sara", 8000, "Kvinna");
            Employee employee5 = new Employee(5, "Gunnilla", 9000, "Kvinna");


            // Create a generic stack and push the employee objects onto it
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);



            // Loops through all Employee objects in the stack
            // Prints the properties of each Employee object, and the stack count after each row 
            foreach(Employee employees in stack)
            {
                Console.WriteLine($"Id:{employees.Id} - Namn:{employees.Name} - Lön:{employees.Salary}KR - Kön:{employees.Gender}");
                Console.WriteLine($"Kvar i stack = {stack.Count}");
                
            }



            Console.WriteLine("-----------------------------------\n");



            // While loop to Pop (Remove) Employee objects from the stack 
            // Stops looping when stack count reaches zero 
            while (stack.Count > 0)
            {
                Employee employees = stack.Pop();
                Console.WriteLine($"Id:{employees.Id} - Namn:{employees.Name} - Lön:{employees.Salary}KR - Kön:{employees.Gender}");
                Console.WriteLine($"Kvar i stack = {stack.Count}");
            }


            // Re-add Employee objects with push to fill the stack again
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);


            Console.WriteLine("-----------------------------------\n");


            // Uses a for loop with 2 iterations
            // Uses peek() to view the top Employee object in stack twice, without removing any objects 
            for (int i = 0; i < 2; i++)
            {
                Employee employees = stack.Peek();
                Console.WriteLine($"Id:{employees.Id} - Namn:{employees.Name} - Lön:{employees.Salary}KR - Kön:{employees.Gender}");
                Console.WriteLine($"Kvar i stack = {stack.Count}");
               
            }


            // Checks if the stack conatains Employee3
            if (stack.Contains(employee3))
            {
                // Prints if the stack contains employee3
                Console.WriteLine("Employee 3 Finns i stack!");
            }
            else
            {
                // Prints if the stack does not contain employee3
                Console.WriteLine("Employee 3 Finns inte i stack...");
            }



            Console.WriteLine("-----------------------------------\n");



            // Create a list for Employee objects
            List<Employee> empList = new List<Employee>();
            
            // Adds the Empolyee objects to List<Employee>
            empList.Add(employee1);
            empList.Add(employee2);
            empList.Add(employee3);
            empList.Add(employee4);
            empList.Add(employee5);



            // Checks if the list contains employee2
            if (empList.Contains(employee2))
            {
                // Prints if the listcontains employee2
                Console.WriteLine("Employee 2 finns i listan!\n");
            }
            else
            {
                // Prints if list does not contain employee2
                Console.WriteLine("Employee 2 finns inte listan...");
            }
            

            // Searches Employee List and stores the first Employee object with Gender = "Man" 
            Employee firstMan = empList.Find(e => e.Gender == "Man");

            // Checks for a matching Employee was found before printing
            if (firstMan != null)
            {
                // Print the details of the first matching Employee object 
                Console.WriteLine($"Id:{firstMan.Id} - Namn:{firstMan.Name} - Lön:{firstMan.Salary}KR - Kön:{firstMan.Gender}");
            }


            // Searches Employee List and stores all Employee objects with Gender = "Man"
            List<Employee> findAllMen = empList.FindAll(a => a.Gender == "Man");

            // Loop through Employee list, searching for all matching objects
            // Print details of all matching Employee objects 
            foreach (Employee employee in findAllMen)
            {
                Console.WriteLine($"Id:{employee.Id} - Namn:{employee.Name} - Lön:{employee.Salary}KR - Kön:{employee.Gender}");
            }
        }
    }
}
