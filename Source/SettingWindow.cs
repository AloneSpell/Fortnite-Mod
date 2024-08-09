using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Loader
{
    public partial class SettingWindow : Form
    {
        ExploitAPI api = new ExploitAPI();

        public SettingWindow()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MattLawz/Roblox-Game-Pentesting-App");
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MattLawz/Roblox-Game-Pentesting-App/tree/main/scripts");

        }
    }
}
