using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ComputerScienceDemo
{
    public partial class titleLabel : Form
    {
        public titleLabel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reactor1Statelabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert__1_);

            alertPlayer.Play();

            startButton.Text = "Stop";

            Reactor1StateLabel.BackColor = Color.Red;
            Reactor2Statelabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            Reactor1StateLabel.BackColor = Color.White;
            Reactor2Statelabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            Reactor1StateLabel.BackColor = Color.Red;
            Reactor2Statelabel.BackColor = Color.Red;
        }
    }
}
