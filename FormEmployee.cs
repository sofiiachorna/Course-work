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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            foreach (var i in data.jobTitles)
            {
                listBox.Items.Add(i.Name);
            }
        }

        private bool FilterJobTitle(JobTitle j)
        {
            if (j.Salary >= trackBarMin.Value * 10000)
                if ((checkBoxIt.Checked == true && j.jobArea == JobTitle.JobArea.IT) ||
                    (checkBoxMarketing.Checked == true && j.jobArea == JobTitle.JobArea.Marketing) ||
                    (checkBoxMedicine.Checked == true && j.jobArea == JobTitle.JobArea.Medicine) ||
                    (checkBoxLaw.Checked == true && j.jobArea == JobTitle.JobArea.Law) ||
                    (checkBoxFinance.Checked == true && j.jobArea == JobTitle.JobArea.Finance) ||
                    (checkBoxEducation.Checked == true && j.jobArea == JobTitle.JobArea.Education))
                    if ((checkBoxFull.Checked == true && j.FullTime == true) ||
                        (checkBoxPart.Checked == true && j.FullTime == false))
                        if ((checkBoxRYes.Checked == true && j.Remote == true) ||
                            (checkBoxRNo.Checked == true && j.Remote == false))
                            return true;
            return false;
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (var i in data.jobTitles)
            {
                if (FilterJobTitle(i))
                    listBox.Items.Add(i.Name);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelSalary.Text = (trackBarMin.Value * 10000).ToString();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        { 
            if (listBox.SelectedIndex != -1)
            {
                data.curentJobTitle = data.FindJob(listBox.SelectedItem.ToString());
                ShowInfo showInfo = new ShowInfo();
                showInfo.Show();
            }
        }

        private void checkBoxRYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
