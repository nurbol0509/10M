using System;
using System.Collections.Generic;

public abstract class OrganizationComponent
{
    public string Name { get; set; }

    public abstract decimal GetBudget();
    public abstract int GetEmployeeCount();
    public abstract void Display(int depth = 0);

    public virtual Employee FindEmployeeByName(string name) => null;
}


public class Employee : OrganizationComponent
{
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override decimal GetBudget() => Salary;

    public override int GetEmployeeCount() => 1;

    public override void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + $" {Name}, {Position}, Salary: {Salary}");
    }

    public void SetSalary(decimal newSalary)
    {
        Salary = newSalary;
    }

    public override Employee FindEmployeeByName(string name)
    {
        return Name == name ? this : null;
    }
}

public class Department : OrganizationComponent
{
    private List<OrganizationComponent> _components = new List<OrganizationComponent>();

    public Department(string name)
    {
        Name = name;
    }

    public void Add(OrganizationComponent component)
    {
        _components.Add(component);
    }

    public void Remove(OrganizationComponent component)
    {
        _components.Remove(component);
    }

    public override decimal GetBudget()
    {
        decimal totalBudget = 0;
        foreach (var component in _components)
        {
            totalBudget += component.GetBudget();
        }
        return totalBudget;
    }

    public override int GetEmployeeCount()
    {
        int totalEmployees = 0;
        foreach (var component in _components)
        {
            totalEmployees += component.GetEmployeeCount();
        }
        return totalEmployees;
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + $" {Name} (Department)");
        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }

    public override Employee FindEmployeeByName(string name)
    {
        foreach (var component in _components)
        {
            var found = component.FindEmployeeByName(name);
            if (found != null) return found;
        }
        return null;
    }

    public void ListAllEmployees()
    {
        foreach (var component in _components)
        {
            if (component is Employee employee)
            {
                Console.WriteLine($"{employee.Name}, {employee.Position}");
            }
            else if (component is Department department)
            {
                department.ListAllEmployees();
            }
        }
    }
}


public class Contractor : OrganizationComponent
{
    public decimal ContractPay { get; set; }

    public Contractor(string name, decimal pay)
    {
        Name = name;
        ContractPay = pay;
    }

    public override decimal GetBudget() => 0; // Контракторы не входят в бюджет

    public override int GetEmployeeCount() => 1;

    public override void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + $" {Name} (Contractor), Pay: {ContractPay}");
    }
}
