using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Cours
{

    public partial class Form1 : Form
    {
        readonly string pathEmployers = @"Employers.json";
        readonly string pathEmployees = @"Employees.json";
        readonly string pathJobs = @"Jobs.json";
        data Data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//десералізує збережену інформацію про користувача та вакансію
        {
            Data = new data();
            data.Employees = new List<Employee>();
            data.Employers = new List<Employer>();   
            data.jobTitles = new List<JobTitle>();

            string jsonEmploees = File.ReadAllText(pathEmployees);
            string jsonEmploers = File.ReadAllText(pathEmployers);
            string jsonJobs = File.ReadAllText(pathJobs);

            data.Employees = JsonConvert.DeserializeObject<List<Employee>>(jsonEmploees);
            data.Employers = JsonConvert.DeserializeObject<List<Employer>>(jsonEmploers);
            data.jobTitles = JsonConvert.DeserializeObject<List<JobTitle>>(jsonJobs);

            if(data.Employers == null) data.Employers = new List<Employer>();
            if (data.Employees == null) data.Employees = new List<Employee>();
            if (data.jobTitles == null) data.jobTitles = new List<JobTitle>();
        }



        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            User user = User.Check(textBoxLogin.Text, textBoxPassword.Text, ref data.Employers, ref data.Employees);
            if (user == null)
            {
                MessageBox.Show("Invalid login or password!");
            }
            else if(user is Employee)
            {
                data.curentUser = user;
                FormEmployee formEmployee = new FormEmployee();
                formEmployee.Show();
                this.Hide();
            }
            else
            {
                data.curentUser = user;
                FormEmployer formEmployer = new FormEmployer();
                formEmployer.Show();
                this.Hide();
            }
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            Sing_up sing_Up = new Sing_up();
            sing_Up.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Employee> tmpEmployees = data.Employees;
            List<Employer> tmpEmployers = data.Employers;
            List<JobTitle> tmpJobs = data.jobTitles;
            string jsonEmployees = JsonConvert.SerializeObject(tmpEmployees);
            string jsonEmployers = JsonConvert.SerializeObject(tmpEmployers);
            string jsonJobs = JsonConvert.SerializeObject(tmpJobs);
            File.WriteAllText(pathEmployees, jsonEmployees);
            File.WriteAllText(pathEmployers, jsonEmployers);
            File.WriteAllText(pathJobs, jsonJobs);
        }
    }
}
