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
    public partial class FormEmployer : Form
    {

        public FormEmployer()
        {
            InitializeComponent();
        }

        Employer employer;

        private void FormEmployer_Load(object sender, EventArgs e)
        {
            employer = (Employer)data.curentUser;
            foreach (var i in employer.jobTitles)
            {
                listBoxJobTitles.Items.Add(i.Name);
            }
        }

        private void listBoxJobTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCandidate.Items.Clear();
            List<Employee> c = data.FindJob(listBoxJobTitles.SelectedItem.ToString()).Candidate;
            foreach (var i in c)
            {
                listBoxCandidate.Items.Add(i.Name);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxJobTitles.SelectedIndex != -1)
            {
                employer.jobTitles.Remove(employer.Find(listBoxJobTitles.SelectedItem.ToString()));
                data.jobTitles.Remove(employer.Find(listBoxJobTitles.SelectedItem.ToString()));
                listBoxJobTitles.Items.Clear();
                listBoxCandidate.Items.Clear();
                foreach (var i in employer.jobTitles)
                {
                    listBoxJobTitles.Items.Add(i.Name);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddJobTitle addJobTitle = new AddJobTitle();
            addJobTitle.Show();
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            listBoxJobTitles.Items.Clear();
            listBoxCandidate.Items.Clear();
            foreach (var i in employer.jobTitles)
            {
                listBoxJobTitles.Items.Add(i.Name);
            }
        }

        private void FormEmployer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(listBoxCandidate.SelectedIndex != -1)
            {
                MessageBox.Show(data.FindEmployee(listBoxCandidate.SelectedItem.ToString()).Resume);
            }
        }
    }
}
