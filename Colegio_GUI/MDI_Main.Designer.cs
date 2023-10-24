namespace Colegio_GUI
{
    partial class MDI_Main
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            enrollmentsToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            enrollmentToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem = new ToolStripMenuItem();
            listAllStudentsToolStripMenuItem = new ToolStripMenuItem();
            listAllTeachersToolStripMenuItem = new ToolStripMenuItem();
            listAllEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            closeTheProgramToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSystem = new ToolStripStatusLabel();
            lblSession = new ToolStripStatusLabel();
            lblUser = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operationsToolStripMenuItem, searchToolStripMenuItem, listsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, teachersToolStripMenuItem, enrollmentsToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(77, 20);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Image = Properties.Resources.dude4;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(180, 22);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Image = Properties.Resources.users4;
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(180, 22);
            teachersToolStripMenuItem.Text = "Teachers";
            // 
            // enrollmentsToolStripMenuItem
            // 
            enrollmentsToolStripMenuItem.Image = Properties.Resources.cabinet;
            enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            enrollmentsToolStripMenuItem.Size = new Size(180, 22);
            enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, teacherToolStripMenuItem, enrollmentToolStripMenuItem });
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Image = Properties.Resources.dude4;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(132, 22);
            studentToolStripMenuItem.Text = "Student";
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.Image = Properties.Resources.users4;
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(132, 22);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // enrollmentToolStripMenuItem
            // 
            enrollmentToolStripMenuItem.Image = Properties.Resources.cabinet;
            enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            enrollmentToolStripMenuItem.Size = new Size(132, 22);
            enrollmentToolStripMenuItem.Text = "Enrollment";
            // 
            // listsToolStripMenuItem
            // 
            listsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listAllStudentsToolStripMenuItem, listAllTeachersToolStripMenuItem, listAllEnrollmentsToolStripMenuItem });
            listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            listsToolStripMenuItem.Size = new Size(42, 20);
            listsToolStripMenuItem.Text = "Lists";
            // 
            // listAllStudentsToolStripMenuItem
            // 
            listAllStudentsToolStripMenuItem.Image = Properties.Resources.dude4;
            listAllStudentsToolStripMenuItem.Name = "listAllStudentsToolStripMenuItem";
            listAllStudentsToolStripMenuItem.Size = new Size(173, 22);
            listAllStudentsToolStripMenuItem.Text = "List all Students";
            // 
            // listAllTeachersToolStripMenuItem
            // 
            listAllTeachersToolStripMenuItem.Image = Properties.Resources.users4;
            listAllTeachersToolStripMenuItem.Name = "listAllTeachersToolStripMenuItem";
            listAllTeachersToolStripMenuItem.Size = new Size(173, 22);
            listAllTeachersToolStripMenuItem.Text = "List all Teachers";
            // 
            // listAllEnrollmentsToolStripMenuItem
            // 
            listAllEnrollmentsToolStripMenuItem.Image = Properties.Resources.cabinet;
            listAllEnrollmentsToolStripMenuItem.Name = "listAllEnrollmentsToolStripMenuItem";
            listAllEnrollmentsToolStripMenuItem.Size = new Size(173, 22);
            listAllEnrollmentsToolStripMenuItem.Text = "List all Enrollments";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeTheProgramToolStripMenuItem });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // closeTheProgramToolStripMenuItem
            // 
            closeTheProgramToolStripMenuItem.Image = Properties.Resources.Cancelar;
            closeTheProgramToolStripMenuItem.Name = "closeTheProgramToolStripMenuItem";
            closeTheProgramToolStripMenuItem.Size = new Size(172, 22);
            closeTheProgramToolStripMenuItem.Text = "Close the program";
            closeTheProgramToolStripMenuItem.Click += closeTheProgramToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystem, lblSession, lblUser });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystem
            // 
            lblSystem.Name = "lblSystem";
            lblSystem.Size = new Size(51, 17);
            lblSystem.Text = "System: ";
            // 
            // lblSession
            // 
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(52, 17);
            lblSession.Text = "Session: ";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(36, 17);
            lblUser.Text = "User: ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MDI_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.COLEGIO_DE_CUSCO_SANTIAGO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDI_Main";
            Text = "Interfaz de Colegio";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDI_Main_FormClosing;
            FormClosed += MDI_Main_FormClosed;
            Load += MDI_Main_Load;
            Resize += MDI_Main_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem enrollmentToolStripMenuItem;
        private ToolStripMenuItem listAllStudentsToolStripMenuItem;
        private ToolStripMenuItem listAllTeachersToolStripMenuItem;
        private ToolStripMenuItem listAllEnrollmentsToolStripMenuItem;
        private ToolStripMenuItem closeTheProgramToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSystem;
        private ToolStripStatusLabel lblSession;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblUser;
    }
}