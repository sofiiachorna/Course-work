
namespace Cours
{
    partial class FormEmployer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployer));
            this.listBoxJobTitles = new System.Windows.Forms.ListBox();
            this.listBoxCandidate = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxJobTitles
            // 
            this.listBoxJobTitles.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxJobTitles.FormattingEnabled = true;
            this.listBoxJobTitles.ItemHeight = 31;
            this.listBoxJobTitles.Location = new System.Drawing.Point(127, 259);
            this.listBoxJobTitles.Name = "listBoxJobTitles";
            this.listBoxJobTitles.Size = new System.Drawing.Size(610, 593);
            this.listBoxJobTitles.TabIndex = 0;
            this.listBoxJobTitles.SelectedIndexChanged += new System.EventHandler(this.listBoxJobTitles_SelectedIndexChanged);
            // 
            // listBoxCandidate
            // 
            this.listBoxCandidate.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCandidate.FormattingEnabled = true;
            this.listBoxCandidate.ItemHeight = 31;
            this.listBoxCandidate.Location = new System.Drawing.Point(1143, 272);
            this.listBoxCandidate.Name = "listBoxCandidate";
            this.listBoxCandidate.Size = new System.Drawing.Size(386, 593);
            this.listBoxCandidate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(331, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOUR JOBTITLES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1245, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "CANDIDATES";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Salmon;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(197, 880);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(209, 55);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(437, 880);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(209, 55);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add new";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.Location = new System.Drawing.Point(1314, 880);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(201, 61);
            this.buttonShow.TabIndex = 7;
            this.buttonShow.Text = "Show resume";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonRefill.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.buttonRefill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefill.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.buttonRefill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonRefill.Location = new System.Drawing.Point(1173, 880);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(113, 61);
            this.buttonRefill.TabIndex = 8;
            this.buttonRefill.Text = "Refill";
            this.buttonRefill.UseVisualStyleBackColor = false;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // FormEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1839, 1008);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCandidate);
            this.Controls.Add(this.listBoxJobTitles);
            this.Name = "FormEmployer";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployer_FormClosed);
            this.Load += new System.EventHandler(this.FormEmployer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxJobTitles;
        private System.Windows.Forms.ListBox listBoxCandidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonRefill;
    }
}