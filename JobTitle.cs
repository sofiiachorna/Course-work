using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
    class JobTitle
    {
        public string Name { get; protected set; }
        public int Salary { get; protected set; }
        public enum JobArea
        {
             IT,
             Marketing,
             Finance,
             Law,
             Education,
             Medicine
        }
        public JobArea jobArea { get; protected set; }
        public bool FullTime { get; protected set; }
        public bool Remote { get; protected set; }
        public string Description { get; protected set; }
        public List<Employee> Candidate;

        public JobTitle(string name, int salary, JobArea jobArea, bool FullTime, bool Remote, string Description)
        {
            Candidate = new List<Employee>();
            this.Name = name;
            this.Salary = salary;
            this.jobArea = jobArea;
            this.FullTime = FullTime;
            this.Remote = Remote;
            this.Description = Description;
        }
    }
}
