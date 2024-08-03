using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAbstractionTask
{
    // ▼ Base Class with abstract method for workers ▼
    public abstract class BaseWorker
    {
        // ▼ Base Class properties for all worker ▼
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        // ▼ Abstract method for workers ▼ 
        public abstract void Title();
    }

    // ▼ Worker Baby Class ▼
    public class Worker : BaseWorker 
    {
        // ▼ Constructor of worker with defining properties coming from base class ▼
        public Worker(string name, string surname, string department,string role)
        {
            Name = name;
            Surname = surname;
            Department = department;
            Role = role;
        }
        // ▼ Overriding abstract method coming from base class ▼
        public override void Title()
        {
            Console.WriteLine($"{Name} {Surname} is here. I work in {Department} deparment as {Role}.");
        }
    }
}
