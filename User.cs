using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
    class User
    {
        public string Login;
        public string Password;
        public bool IsEmployee;

        public static User Check(string Login, string Password, ref List<Employer> employers, ref List<Employee> employees)
        {
            foreach (var i in employees)
            {
                if (i.Login == Login && i.Password == Password)
                {
                    return i;
                }
            }
            foreach (var i in employers)
            {
                if (i.Login == Login && i.Password == Password)
                {
                    return i;
                }
            }
            return null;
        }
        public User(string Login, string Password, bool IsEmployee)
        {
            this.Login = Login;
            this.Password = Password;
            this.IsEmployee = IsEmployee;
        }
    }
}
