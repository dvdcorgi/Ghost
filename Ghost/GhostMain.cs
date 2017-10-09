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

        private void btnDebug_ClickAsync(object sender, EventArgs e)
        {
            timerAsync.Start();
            timerSync.Start();
        }

        private async Task doWork()
        {
            var r = new ClassReddit();
            await r.ActReddit();
        }

        private void btnVerifyUser_Click(object sender, EventArgs e)
        {
            var x = new ClassReddit();
            x.GetSync();
        }

        private void timerAsync_Tick(object sender, EventArgs e)
        {
            ServiceClient c = new ServiceClient();
            var x = c.GetAsync();
            Console.WriteLine(x.Result);
        }

        private void timerSync_Tick(object sender, EventArgs e)
        {
            ServiceClient c = new ServiceClient();
            Console.Write(c.GetSync());
        }
    }
}
