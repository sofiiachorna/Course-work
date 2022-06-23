using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
  class data
  {
        public static List<Employee> Employees;
        public static List<Employer> Employers;
        public static List<JobTitle> jobTitles;
        public static User curentUser;//інф про поточного користувача
        public static JobTitle curentJobTitle;//поточна обрана вакансія
        public static Employee curentEmployee;//обраний кандидат

        public static Employee FindEmployee(string name)
        {
            foreach (var i in Employees)
            {
                if (i.Name == name)
                    return i;
            }
            return null;
        }

        public static JobTitle FindJob(string name)
        {
            foreach (var i in jobTitles)
            {
                if(i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
        public static int GetIndex(string name)
        {
            for (int i = 0; i < jobTitles.Count; i++)
            {
                if(jobTitles[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }
  }
}
