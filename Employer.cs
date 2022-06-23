using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
    class Employer : User
    {
        public List<JobTitle> jobTitles { get; set; }
        public Employer(string Login, string Password) : base(Login, Password, false)
        {
            jobTitles = new List<JobTitle>();
        }

        public JobTitle Find(string name)
        {
            foreach (var i in jobTitles)
            {
                if (i.Name == name)
                    return i;
            }
            return null;
        }
    }
}
