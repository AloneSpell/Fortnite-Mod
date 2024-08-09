using Loader;
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

namespace RobloxGamePentesting
{
    
    public partial class Main : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }


        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            new SettingWindow().Show();
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
