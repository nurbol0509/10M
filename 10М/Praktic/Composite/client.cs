using System;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Alice", "Developer", 80000);
        Employee employee2 = new Employee("Bob", "Designer", 70000);
        Employee employee3 = new Employee("Charlie", "Manager", 90000);

        Contractor contractor1 = new Contractor("Dave", 50000);
        Contractor contractor2 = new Contractor("Eve", 60000);

        Department devDepartment = new Department("Development Department");
        devDepartment.Add(employee1);
        devDepartment.Add(employee2);
        devDepartment.Add(contractor1);

        Department mainDepartment = new Department("Main Department");
        mainDepartment.Add(devDepartment);
        mainDepartment.Add(employee3);
        mainDepartment.Add(contractor2);

        Console.WriteLine("Организационная структура:");
        mainDepartment.Display();

        Console.WriteLine($"\nОбщий бюджет компании: {mainDepartment.GetBudget()}");
        Console.WriteLine($"Общее количество сотрудников: {mainDepartment.GetEmployeeCount()}");

        employee1.SetSalary(85000);
        Console.WriteLine($"\nНовая зарплата {employee1.Name}: {employee1.Salary}");
        Console.WriteLine($"Обновленный бюджет компании: {mainDepartment.GetBudget()}");

        string searchName = "Alice";
        Employee foundEmployee = mainDepartment.FindEmployeeByName(searchName);
        if (foundEmployee != null)
        {
            Console.WriteLine($"\nНайден сотрудник: {foundEmployee.Name}, {foundEmployee.Position}, Salary: {foundEmployee.Salary}");
        }
        else
        {
            Console.WriteLine($"\nСотрудник с именем {searchName} не найден.");
        }

        Console.WriteLine("\nСписок всех сотрудников:");
        mainDepartment.ListAllEmployees();
    }
}
