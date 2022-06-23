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
    public partial class ShowInfo : Form
    {
        public ShowInfo()
        {
            InitializeComponent();
        }

        private void ShowInfo_Load(object sender, EventArgs e)
        {
            labelName.Text = data.curentJobTitle.Name;
            labelSalary.Text = data.curentJobTitle.Salary.ToString();
            labelJobArea.Text = data.curentJobTitle.jobArea.ToString();
            if (data.curentJobTitle.FullTime == true) labelFullTime.Text = "Yes";
            else labelFullTime.Text = "No";
            if (data.curentJobTitle.Remote == true) labelRemote.Text = "Yes";
            else labelRemote.Text = "No";
            textBox1.Text = data.curentJobTitle.Description;
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
           int i = data.GetIndex(data.curentJobTitle.Name);
            data.jobTitles[i].Candidate.Add((Employee)data.curentUser);

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
