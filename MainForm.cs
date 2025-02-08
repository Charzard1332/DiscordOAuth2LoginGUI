using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace DiscordLoginWinForms
{
    public partial class MainForm : Form
    {
        private OAuthHelper oauthHelper;

        public MainForm()
        {
            InitializeComponent();
            oauthHelper = new OAuthHelper(this);
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            await oauthHelper.LoginWithDiscord();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
