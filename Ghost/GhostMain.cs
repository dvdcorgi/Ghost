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
using System.IO;
using System.Security.Cryptography;

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
            logItem();
        }

        private void timerSync_Tick(object sender, EventArgs e)
        {
            ServiceClient c = new ServiceClient();
            Console.Write(c.GetSync());
            logItem();
        }

        private void btnLogClient_Click(object sender, EventArgs e)
        {
            logItem();
        }

        private async Task logItem()
        {
            try
            {
                await Task.Delay(0);
                var filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                var deskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var strDate = Convert.ToString(DateTime.Now);
                var intStr = Convert.ToString(randItem());
                var hashed = sha256_hash(strDate + intStr);

                File.AppendAllText(filePath + "\\logs.txt", strDate + " " + hashed + Environment.NewLine);
            }
            catch (Exception ex)
            {
                var filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                var strDate = Convert.ToString(DateTime.Now);
                File.AppendAllText(filePath + "\\logs.txt", strDate + " " + ex.Message + Environment.NewLine);
            }
        }

        public static String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }

        private int randItem()
        {
            Random r = new Random();
            return r.Next(1, 10000);
        }
    }
}
