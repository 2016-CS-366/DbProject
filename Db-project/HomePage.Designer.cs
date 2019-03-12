namespace ProjectA
{
    partial class HomePage
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
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInstructorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateIndividualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // addStudentToolStripMenuItem1
            // 
            this.addStudentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seToolStripMenuItem,
            this.searchStudentsToolStripMenuItem});
            this.addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            this.addStudentToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.addStudentToolStripMenuItem1.Text = "Student ";
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.seToolStripMenuItem.Text = "Add Students";
            this.seToolStripMenuItem.Click += new System.EventHandler(this.seToolStripMenuItem_Click);
            // 
            // searchStudentsToolStripMenuItem
            // 
            this.searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            this.searchStudentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchStudentsToolStripMenuItem.Text = "Student\'s Record";
            this.searchStudentsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentsToolStripMenuItem_Click);
            // 
            // addInstructorToolStripMenuItem1
            // 
            this.addInstructorToolStripMenuItem1.Name = "addInstructorToolStripMenuItem1";
            this.addInstructorToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.addInstructorToolStripMenuItem1.Text = "Instructor";
            this.addInstructorToolStripMenuItem1.Click += new System.EventHandler(this.addInstructorToolStripMenuItem1_Click);
            // 
            // evaluateGroupsToolStripMenuItem
            // 
            this.evaluateGroupsToolStripMenuItem.Name = "evaluateGroupsToolStripMenuItem";
            this.evaluateGroupsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.evaluateGroupsToolStripMenuItem.Text = "Evaluation";
            // 
            // evaluateIndividualsToolStripMenuItem
            // 
            this.evaluateIndividualsToolStripMenuItem.Name = "evaluateIndividualsToolStripMenuItem";
            this.evaluateIndividualsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.evaluateIndividualsToolStripMenuItem.Text = "Evaluate Individuals";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.addStudentToolStripMenuItem1,
            this.addInstructorToolStripMenuItem1,
            this.evaluateGroupsToolStripMenuItem,
            this.evaluateIndividualsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 363);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evaluateGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateIndividualsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}