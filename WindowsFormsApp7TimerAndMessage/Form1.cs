using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp7TimerAndMessage
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 10;
            countdownTimer.Start();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdownTimer.Stop();
                lblMessage.Text = "Sorry, you ran out of time";
            }
        }

        private void btnAFour_Click(object sender, EventArgs e)
        {
            seconds = 10;
            countdownTimer.Start();
        }

        private void btnATwo_Click(object sender, EventArgs e)
        {
            seconds = 10;
            countdownTimer.Start();
        }

        private void btnAThree_Click(object sender, EventArgs e)
        {
            seconds = 10;
            countdownTimer.Start();
        }
    }
}
