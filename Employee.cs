using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
   class Employee : User
    {
        public string Name { get; set; }
        public string Resume { get; set; }

        public Employee(string Login, string Password, string Name, string Resume) :
            base (Login, Password, true)
        {
            this.Name = Name;
            this.Resume = Resume;
        }
    }
}
