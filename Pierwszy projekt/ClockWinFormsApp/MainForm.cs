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
    }
}
