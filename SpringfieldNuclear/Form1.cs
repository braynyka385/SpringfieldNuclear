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

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void EnableButton_Click(object sender, EventArgs e)
        {
            //if (outputLabel.Text == "Reactor Stable")
            //{
            outputLabel.Text = "Meltdown Imminent!!";
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();

            //}
            /* else
             {
                 outputLabel.Text = "Reactor Stable";
                 reactor1StateLabel.BackColor = Color.LimeGreen;
                 reactor2StateLabel.BackColor = Color.LimeGreen;
             }
             */
        }

    }
}
