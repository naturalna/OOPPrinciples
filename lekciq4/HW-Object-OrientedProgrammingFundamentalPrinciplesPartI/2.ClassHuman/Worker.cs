using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Worker : Human
{
    //property
    private decimal weekSalary;
    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set { this.weekSalary = value; }
    }
    private int workHoursPerDay;
    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set { this.workHoursPerDay = value; }
    }
    //method
    public decimal MoneyPerHour()
    {
        return WeekSalary / (7 * WorkHoursPerDay);
    }
    public IEnumerable<Worker> SortPeople(List<Worker> people)
    {
        var sortWorkers = people.OrderByDescending(x => x.MoneyPerHour()).ThenByDescending(x => x.FirstName);
        return sortWorkers;
    }
    //constructor
    public Worker(string firstName, string secondName, decimal weekSalary, int workHoursPerDay)
        : base(firstName, secondName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
}

