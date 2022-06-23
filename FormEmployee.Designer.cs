
namespace Cours
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxRNo = new System.Windows.Forms.CheckBox();
            this.checkBoxRYes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPart = new System.Windows.Forms.CheckBox();
            this.checkBoxFull = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMedicine = new System.Windows.Forms.CheckBox();
            this.checkBoxEducation = new System.Windows.Forms.CheckBox();
            this.checkBoxLaw = new System.Windows.Forms.CheckBox();
            this.checkBoxFinance = new System.Windows.Forms.CheckBox();
            this.checkBoxMarketing = new System.Windows.Forms.CheckBox();
            this.checkBoxIt = new System.Windows.Forms.CheckBox();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarMin = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 44;
            this.listBox.Location = new System.Drawing.Point(37, 204);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1162, 488);
            this.listBox.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.buttonFind);
            this.groupBox.Controls.Add(this.groupBox3);
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.groupBoxSalary);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox.Location = new System.Drawing.Point(1499, 117);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(377, 759);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filters";
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFind.Location = new System.Drawing.Point(38, 671);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(295, 64);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkBoxRNo);
            this.groupBox3.Controls.Add(this.checkBoxRYes);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 551);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remote";
            // 
            // checkBoxRNo
            // 
            this.checkBoxRNo.AutoSize = true;
            this.checkBoxRNo.Location = new System.Drawing.Point(154, 37);
            this.checkBoxRNo.Name = "checkBoxRNo";
            this.checkBoxRNo.Size = new System.Drawing.Size(69, 36);
            this.checkBoxRNo.TabIndex = 3;
            this.checkBoxRNo.Text = "No";
            this.checkBoxRNo.UseVisualStyleBackColor = true;
            this.checkBoxRNo.CheckedChanged += new System.EventHandler(this.checkBoxRNo_CheckedChanged);
            // 
            // checkBoxRYes
            // 
            this.checkBoxRYes.AutoSize = true;
            this.checkBoxRYes.Location = new System.Drawing.Point(19, 37);
            this.checkBoxRYes.Name = "checkBoxRYes";
            this.checkBoxRYes.Size = new System.Drawing.Size(73, 36);
            this.checkBoxRYes.TabIndex = 0;
            this.checkBoxRYes.Text = "Yes";
            this.checkBoxRYes.UseVisualStyleBackColor = true;
            this.checkBoxRYes.CheckedChanged += new System.EventHandler(this.checkBoxRYes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPart);
            this.groupBox2.Controls.Add(this.checkBoxFull);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Working time";
            // 
            // checkBoxPart
            // 
            this.checkBoxPart.AutoSize = true;
            this.checkBoxPart.Location = new System.Drawing.Point(153, 47);
            this.checkBoxPart.Name = "checkBoxPart";
            this.checkBoxPart.Size = new System.Drawing.Size(133, 36);
            this.checkBoxPart.TabIndex = 3;
            this.checkBoxPart.Text = "Part time";
            this.checkBoxPart.UseVisualStyleBackColor = true;
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Location = new System.Drawing.Point(17, 47);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(130, 36);
            this.checkBoxFull.TabIndex = 0;
            this.checkBoxFull.Text = "Full time";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMedicine);
            this.groupBox1.Controls.Add(this.checkBoxEducation);
            this.groupBox1.Controls.Add(this.checkBoxLaw);
            this.groupBox1.Controls.Add(this.checkBoxFinance);
            this.groupBox1.Controls.Add(this.checkBoxMarketing);
            this.groupBox1.Controls.Add(this.checkBoxIt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Type";
            // 
            // checkBoxMedicine
            // 
            this.checkBoxMedicine.AutoSize = true;
            this.checkBoxMedicine.Location = new System.Drawing.Point(170, 133);
            this.checkBoxMedicine.Name = "checkBoxMedicine";
            this.checkBoxMedicine.Size = new System.Drawing.Size(143, 36);
            this.checkBoxMedicine.TabIndex = 5;
            this.checkBoxMedicine.Text = " Medicine";
            this.checkBoxMedicine.UseVisualStyleBackColor = true;
            // 
            // checkBoxEducation
            // 
            this.checkBoxEducation.AutoSize = true;
            this.checkBoxEducation.Location = new System.Drawing.Point(170, 91);
            this.checkBoxEducation.Name = "checkBoxEducation";
            this.checkBoxEducation.Size = new System.Drawing.Size(142, 36);
            this.checkBoxEducation.TabIndex = 4;
            this.checkBoxEducation.Text = "Education";
            this.checkBoxEducation.UseVisualStyleBackColor = true;
            // 
            // checkBoxLaw
            // 
            this.checkBoxLaw.AutoSize = true;
            this.checkBoxLaw.Location = new System.Drawing.Point(170, 49);
            this.checkBoxLaw.Name = "checkBoxLaw";
            this.checkBoxLaw.Size = new System.Drawing.Size(77, 36);
            this.checkBoxLaw.TabIndex = 3;
            this.checkBoxLaw.Text = "Law";
            this.checkBoxLaw.UseVisualStyleBackColor = true;
            // 
            // checkBoxFinance
            // 
            this.checkBoxFinance.AutoSize = true;
            this.checkBoxFinance.Location = new System.Drawing.Point(11, 133);
            this.checkBoxFinance.Name = "checkBoxFinance";
            this.checkBoxFinance.Size = new System.Drawing.Size(119, 36);
            this.checkBoxFinance.TabIndex = 2;
            this.checkBoxFinance.Text = "Finance";
            this.checkBoxFinance.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarketing
            // 
            this.checkBoxMarketing.AutoSize = true;
            this.checkBoxMarketing.Location = new System.Drawing.Point(11, 91);
            this.checkBoxMarketing.Name = "checkBoxMarketing";
            this.checkBoxMarketing.Size = new System.Drawing.Size(146, 36);
            this.checkBoxMarketing.TabIndex = 1;
            this.checkBoxMarketing.Text = "Marketing";
            this.checkBoxMarketing.UseVisualStyleBackColor = true;
            // 
            // checkBoxIt
            // 
            this.checkBoxIt.AutoSize = true;
            this.checkBoxIt.Location = new System.Drawing.Point(11, 49);
            this.checkBoxIt.Name = "checkBoxIt";
            this.checkBoxIt.Size = new System.Drawing.Size(56, 36);
            this.checkBoxIt.TabIndex = 0;
            this.checkBoxIt.Text = "IT";
            this.checkBoxIt.UseVisualStyleBackColor = true;
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.BackColor = System.Drawing.Color.White;
            this.groupBoxSalary.Controls.Add(this.labelSalary);
            this.groupBoxSalary.Controls.Add(this.label2);
            this.groupBoxSalary.Controls.Add(this.trackBarMin);
            this.groupBoxSalary.Controls.Add(this.label1);
            this.groupBoxSalary.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSalary.Location = new System.Drawing.Point(26, 87);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Size = new System.Drawing.Size(331, 120);
            this.groupBoxSalary.TabIndex = 0;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = "Salary";
            // 
            // labelSalary
            // 
            this.labelSalary.Location = new System.Drawing.Point(116, 67);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(132, 32);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "0";
            this.labelSalary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "грн";
            // 
            // trackBarMin
            // 
            this.trackBarMin.Location = new System.Drawing.Point(78, 25);
            this.trackBarMin.Maximum = 20;
            this.trackBarMin.Name = "trackBarMin";
            this.trackBarMin.Size = new System.Drawing.Size(202, 56);
            this.trackBarMin.TabIndex = 2;
            this.trackBarMin.Tag = "";
            this.trackBarMin.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min:";
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShow.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.buttonShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.Location = new System.Drawing.Point(37, 863);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(234, 57);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Show info";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 942);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBox);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployee_FormClosed);
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSalary.ResumeLayout(false);
            this.groupBoxSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMedicine;
        private System.Windows.Forms.CheckBox checkBoxEducation;
        private System.Windows.Forms.CheckBox checkBoxLaw;
        private System.Windows.Forms.CheckBox checkBoxFinance;
        private System.Windows.Forms.CheckBox checkBoxMarketing;
        private System.Windows.Forms.CheckBox checkBoxIt;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRNo;
        private System.Windows.Forms.CheckBox checkBoxRYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPart;
        private System.Windows.Forms.CheckBox checkBoxFull;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TrackBar trackBarMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
    }
}