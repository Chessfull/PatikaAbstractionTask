using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAbstractionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Instance for Worker with constructor defining props ▼
            BaseWorker worker1 = new Worker("Mert","Topcu","Strategy","KPI & Performance Executive");

            // ▼ Calling abstract method from base class that displaying worker1 role and department in console ▼
            worker1.Title(); // -> "Mert Topcu is here. I work in Strategy deparment as KPI & Performance Executive".

            // ▼ Instance for Worker with constructor defining props ▼
            BaseWorker worker2 = new Worker("Sertan", "Bozkuş", "Learning", "Technical Coordinator");

            // ▼ Calling abstract method from base class that displaying worker1 role and d"epartment in console ▼
            worker2.Title(); // -> "Sertan Bozkuş is here. I work in Learning deparment as Technical Coordinator."

        }
    }
}
