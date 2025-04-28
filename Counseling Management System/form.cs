using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Management_System
{
    public partial class form : Form
    {
        string UserRole;

        public form(string user)
        {
            InitializeComponent();
            UserRole = user;
            SetupSidebar();
        }

        private void SetupSidebar()
        {
            if (UserRole == "admin")
            {
                buttonDashboard.Visible = true;
                buttonProfile.Visible = true;
                buttonSessions.Visible = true;
                buttonUserDashboard.Visible = false;
                buttonUserProfile.Visible = false;
                sessionsUserProfile.Visible = false;
            }
            else if (UserRole == "user")
            {
                buttonDashboard.Visible = false;
                buttonProfile.Visible = false;
                buttonSessions.Visible = false;
                buttonUserDashboard.Visible = true;
                buttonUserProfile.Visible = true;
                sessionsUserProfile.Visible = true;
            }
        }

        private void LoadForm(Form form)
        {
            if (this.body.Controls.Count > 0)
                this.body.Controls.RemoveAt(0);

            if (form != null)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.body.Controls.Add(form);
                this.body.Tag = form;
                form.Show();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new Profile());
        }

        private void buttonSessions_Click(object sender, EventArgs e)
        {
            LoadForm(new Sessions());
        }

        private void buttonUserDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new UserDashboard());
        }

        private void buttonUserProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new UserProfile());
        }

        private void sessionsUserProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new SessionsUser());
        }

       

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // OPTIONAL: If you want to handle Form Load event separately
        private void form_Load(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            var loginform = new login();
            loginform.Show();
            this.Hide();

        }
    }
}
