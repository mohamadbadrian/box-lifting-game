using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoxLifting
{
    public partial class JoinToServer : Form
    {
        public JoinToServer()
        {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            MultiPlayerGame mp = new MultiPlayerGame();
            if (checkBox1.Checked == false)
            {
              MultiPlayerGame.serverSide = checkBox1.Checked;

            }
            else
            {
                MultiPlayerGame.ip = textBox1.Text.ToString();
                
            }
            MultiPlayerGame.playerName = textBox2.Text.ToString();
            this.Hide();
            mp.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { textBox1.Enabled = false; }
            else { textBox1.Enabled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
