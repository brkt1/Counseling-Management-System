namespace Counseling_Management_System
{
    partial class form
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
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSessions = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.Panel();
            this.sessionsUserProfile = new System.Windows.Forms.Button();
            this.buttonUserProfile = new System.Windows.Forms.Button();
            this.buttonUserDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nav = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.Black;
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDashboard.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(17, 126);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(209, 75);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Black;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProfile.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(12, 206);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(209, 75);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DimGray;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(12, 682);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(209, 54);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 2;
            // 
            // buttonSessions
            // 
            this.buttonSessions.BackColor = System.Drawing.Color.Black;
            this.buttonSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSessions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSessions.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessions.ForeColor = System.Drawing.Color.White;
            this.buttonSessions.Location = new System.Drawing.Point(12, 283);
            this.buttonSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSessions.Name = "buttonSessions";
            this.buttonSessions.Size = new System.Drawing.Size(209, 75);
            this.buttonSessions.TabIndex = 6;
            this.buttonSessions.Text = "Sessions";
            this.buttonSessions.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Black;
            this.SideBar.Controls.Add(this.sessionsUserProfile);
            this.SideBar.Controls.Add(this.buttonUserProfile);
            this.SideBar.Controls.Add(this.buttonUserDashboard);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.buttonSessions);
            this.SideBar.Controls.Add(this.buttonLogout);
            this.SideBar.Controls.Add(this.buttonDashboard);
            this.SideBar.Controls.Add(this.buttonProfile);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(232, 761);
            this.SideBar.TabIndex = 7;
            // 
            // sessionsUserProfile
            // 
            this.sessionsUserProfile.BackColor = System.Drawing.Color.Black;
            this.sessionsUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sessionsUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sessionsUserProfile.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionsUserProfile.ForeColor = System.Drawing.Color.White;
            this.sessionsUserProfile.Location = new System.Drawing.Point(12, 272);
            this.sessionsUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessionsUserProfile.Name = "sessionsUserProfile";
            this.sessionsUserProfile.Size = new System.Drawing.Size(209, 75);
            this.sessionsUserProfile.TabIndex = 11;
            this.sessionsUserProfile.Text = "Sessions";
            this.sessionsUserProfile.UseVisualStyleBackColor = false;
            // 
            // buttonUserProfile
            // 
            this.buttonUserProfile.BackColor = System.Drawing.Color.Black;
            this.buttonUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUserProfile.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserProfile.ForeColor = System.Drawing.Color.White;
            this.buttonUserProfile.Location = new System.Drawing.Point(17, 202);
            this.buttonUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserProfile.Name = "buttonUserProfile";
            this.buttonUserProfile.Size = new System.Drawing.Size(209, 75);
            this.buttonUserProfile.TabIndex = 10;
            this.buttonUserProfile.Text = "Profile";
            this.buttonUserProfile.UseVisualStyleBackColor = false;
            // 
            // buttonUserDashboard
            // 
            this.buttonUserDashboard.BackColor = System.Drawing.Color.Black;
            this.buttonUserDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUserDashboard.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonUserDashboard.Location = new System.Drawing.Point(-3, 126);
            this.buttonUserDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserDashboard.Name = "buttonUserDashboard";
            this.buttonUserDashboard.Size = new System.Drawing.Size(232, 75);
            this.buttonUserDashboard.TabIndex = 9;
            this.buttonUserDashboard.Text = "Dashboard";
            this.buttonUserDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Counseling_Management_System.Properties.Resources._7106343_men_graph_infographic_data_element_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.Black;
            this.nav.Controls.Add(this.buttonExit);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(232, 0);
            this.nav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(764, 50);
            this.nav.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(712, 5);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.close_Click);
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(232, 50);
            this.body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(764, 711);
            this.body.TabIndex = 0;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 761);
            this.Controls.Add(this.body);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SideBar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form";
            this.Text = "Dashbord";
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonDashboard;
        public System.Windows.Forms.Button buttonProfile;
        public System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonSessions;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Panel body;
        public System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button buttonUserDashboard;
        public System.Windows.Forms.Button buttonUserProfile;
        public System.Windows.Forms.Button sessionsUserProfile;
    }
}