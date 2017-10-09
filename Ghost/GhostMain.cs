using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedditSharp;
using Ghost.ServiceReferenceGhost;
using Ghost.Properties;

namespace Ghost
{
    public partial class GhostMain : Form
    {
        public GhostMain()
        {
            InitializeComponent();
        }

        private void GhostMain_Load(object sender, EventArgs e)
        {
            txtUser.Text = Settings.Default.user;
            txtPassword.Text = Settings.Default.pass;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            ServiceClient s = new ServiceClient();
            s.GetSub();
        }

        private void btnVerifyUser_Click(object sender, EventArgs e)
        {

        }
    }
}
