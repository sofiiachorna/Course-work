using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours
{
    public partial class Sing_up : Form
    {
        public Sing_up()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
           if(radioButtonEmployee.Checked == true)
            {
                data.Employees.Add(new Employee(textBoxLogin.Text, textBoxPassword.Text, textBoxName.Text ,textBoxResume.Text));
            }
           else
            {
                data.Employers.Add(new Employer(textBoxLogin.Text, textBoxPassword.Text));
            }
            this.Close();
        }
    }
}
