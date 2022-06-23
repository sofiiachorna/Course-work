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
    public partial class AddJobTitle : Form
    {
        public AddJobTitle()
        {
            InitializeComponent();
        }

        private void trackBarMin_Scroll(object sender, EventArgs e)
        {
            labelSalary.Text = (trackBarMin.Value * 10000).ToString();  
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            JobTitle.JobArea jobArea;
            if (radioButtonIT.Checked == true) jobArea = JobTitle.JobArea.IT;
            else if (radioButtonMarketing.Checked == true) jobArea = JobTitle.JobArea.Marketing;
            else if (radioButtonFinance.Checked == true) jobArea = JobTitle.JobArea.Finance;
            else if (radioButtonLaw.Checked == true) jobArea = JobTitle.JobArea.Law;
            else if (radioButtonMedicine.Checked == true) jobArea = JobTitle.JobArea.Medicine;
            else  jobArea = JobTitle.JobArea.Education;
            JobTitle job = new JobTitle(textBox1.Text, int.Parse(labelSalary.Text),
                jobArea, radioButtonFull.Checked, radioButtonRYes.Checked, textBoxDescription.Text);
            data.jobTitles.Add(job);
            Employer emp = (Employer)data.curentUser;   
            emp.jobTitles.Add(job);
            this.Close();
        }

        private void AddJobTitle_Load(object sender, EventArgs e)
        {

        }
    }
}
