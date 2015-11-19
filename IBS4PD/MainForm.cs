using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBS_Solver;

namespace IBS4PD
{
    public partial class MainForm : Form
    {
        int elapsed_s = 0;
        List<int> periods;
        int lcm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\n\nDr.Mesut Yavuz\n\nCJ Guttormsson\n\nStephen Waldrep", "About");
        }

        private void newSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new NewProbForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(string.Join(", ", form.periods));
                    periods = form.periods;
                    lcm = form.period_lcm;
                    startButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Form Did Not Accept");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed_s++;
            timeLabel.Text = String.Format("Elapsed Time: {0}",
                                           (TimeSpan.FromSeconds(elapsed_s)).ToString(@"hh\:mm\:ss"));
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            pauseResumeButton.Enabled = true;

            IBS solver = new IBS(periods, lcm, 10); //placeholder!
            //solver.run(); //put in backgroundWorker

            timer1.Start();
        }

        private void pauseResumeButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            pauseResumeButton.Enabled = false;
            timer1.Stop();
        }
    }
}
