using System;
using System.Collections.Generic;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            Product tinkerToys = new Product()
            {
                Title = "Tinker Toys",
                Description = "You can build anything you want",
                Price = 32.49,
                Quantity = 25
            };

            Customer marcus = new Customer()
            {
                FirstName = "Marcus",
                LastName = "Fulbright",
                IsLocal = false
            };

            DeliveryService UPS = new DeliveryService()
            {
                Name = "UPS",
                TransitType = "train"
            };

            // Ship the tinker toys to Marcus using UPS
            tinkerToys.Ship(marcus, UPS);

            //Box.cs contributes to this
            Box box = new Box();
            Console.WriteLine(box.GetSecret("please"));

            //examples of a constructor in action
            List<string> inventory = new List<string>();
            inventory.Add("batteries");
            inventory.Add("golf tees");
            inventory.Add("zippers");
            inventory.Add("cabin accessories");

            // Make a new instance of a Store
            Store myStore = new Store("Stuff 'n' Things", inventory);
            myStore.Welcome();

            // Create an instance of a company. Name it whatever you like.
            DateTime today = DateTime.Now;
            Company company1 = new Company("Better Mouse Traps Inc.", today);

            // Create three employees

            Employee dana = new Employee()
            {
                FirstName = "Dana",
                LastName = "Richards",
                Title = "Trap Engineer",
                StartDate = today
            };

            Employee bob = new Employee()
            {
                FirstName = "Bob",
                LastName = "Bobertson",
                Title = "Sales Lead",
                StartDate = today
            };

            Employee kyle = new Employee()
            {
                FirstName = "Kyle",
                LastName = "Conners",
                Title = "Head of Cheese Accquisition",
                StartDate = today
            };

            // Assign the employees to the company
            company1.HireEmployee(dana);
            company1.ListOfEmployees.Add(bob);
            company1.ListOfEmployees.Add(kyle);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company1.ListEmployees();
        }
        
    }
}
