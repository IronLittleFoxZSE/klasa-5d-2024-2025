using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockWinFormsApp
{
    public partial class MainForm : Form
    {
        private int timeStopWatch;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonReadTime_Click(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonStopWatchStart_Click(object sender, EventArgs e)
        {
            timeStopWatch = 0;
            timerStopWatch.Enabled = true;
        }

        private void buttonStopWatchStop_Click(object sender, EventArgs e)
        {
            timerStopWatch.Enabled = false;
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            timeStopWatch++;
            labelStopWatch.Text = timeStopWatch.ToString();
        }


        private DateTime timeStart;

        private void buttonStopWatchDeltaStart_Click(object sender, EventArgs e)
        {
            timeStart = DateTime.Now;
            timerStopWatchDelta.Enabled = true;
        }

        private void buttonStopWatchDeltaStop_Click(object sender, EventArgs e)
        {
            timerStopWatchDelta.Enabled = false;
        }

        private void timerStopWatchDelta_Tick(object sender, EventArgs e)
        {
            TimeSpan deltaTime = DateTime.Now - timeStart;
            labelStopWatchDelta.Text = deltaTime.Hours + ":" +
                                       deltaTime.Minutes + ":" +
                                       deltaTime.Seconds + ":" +
                                       deltaTime.Milliseconds;
        }
    }
}
