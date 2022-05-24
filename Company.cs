using System;
using System.Collections.Generic;

namespace Chapter12
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> ListOfEmployees {get;}

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string compName, DateTime dayFounded)
        {
            Name = compName;
            CreatedOn = dayFounded;
            ListOfEmployees = new List<Employee>(){};
        }
        public void ListEmployees()
        {
            foreach(Employee item in ListOfEmployees){
                Console.WriteLine($"{item.FirstName} {item.LastName} works for {this.Name} as a {item.Title} since {item.StartDate}");
            }
        }
        public void HireEmployee(Employee newHire)
        {
            ListOfEmployees.Add(newHire);
        }
    }

    public class Employee
    {
        public string FirstName {get; set;}
        public string LastName {get;set;}
        public string Title {get;set;}
        public DateTime StartDate {get;set;}
    }

}