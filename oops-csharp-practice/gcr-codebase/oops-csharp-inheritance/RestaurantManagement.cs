using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //defining the interface for multiple inheritance
    interface Worker
    {
        void PerformDuties();
    }

   
    class Persons
    {
        //using getter and setters for fields
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Chef : Persons, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Chef cooks food");
        }
    }

    class Waiter : Persons, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Waiter serves customers");
        }
    }

}
