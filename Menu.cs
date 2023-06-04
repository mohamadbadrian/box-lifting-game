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
    public partial class Menubox : Form
    {
        public Menubox()
        {
            InitializeComponent();
        }

      
        private void Menu_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(Screen.PrimaryScreen.Bounds.Width+40, Screen.PrimaryScreen.Bounds.Height);
 
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\singleUp.png");
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\MultiUp.png");
            pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\gamePlayUp.png");

        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            singlePlayer sp = new singlePlayer();
            sp.Show();
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\singleDown.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\singleUp.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinToServer js = new JoinToServer();
            js.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\MultiDown.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\MultiUp.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\gamePlayDown.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\gamePlayUp.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\AboutDown.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\AboutUp.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\ExitDown.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\ExitUp.png");
        }
    }
}
