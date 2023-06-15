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
        public static bool stop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void btnATwo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAThree_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            seconds = 3;
            miniCountdown.Start();
            if (stop == true)
            {
                countdownTimer.Start();
            }
        }

        private void miniCountdown_Tick(object sender, EventArgs e)
        {
            lblMini.Text = seconds--.ToString();
            if (seconds < 0)
            {
                miniCountdown.Stop();
                lblMini.Visible = false;
                countdownTimer.Start();
                seconds = 60;
            }
        }
    }
}
