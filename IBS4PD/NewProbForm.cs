using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBS4PD
{
    public partial class NewProbForm : Form
    {
        public List<int> periods { get; private set; }
        public int period_lcm { get; private set; }

        public NewProbForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                try
                {
                    //Parse Ints from file
                    string alltext = File.ReadAllText(filename);
                    string[] valStrings = alltext.Split(new char[] { ',', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    periods = (from s in valStrings select int.Parse(s)).ToList();

                    //If no error occured, it should be okay to return
                    if (periods.Count > 1)
                    {
                        acceptButton.Enabled = true;
                        period_lcm = LCM(periods);
                        fileStatusLabel.Text = String.Format("File Read Succesfully, LCM: {0}", period_lcm);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("An error occured while trying to read the selected file. Please try again.",
                        "Error in opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("The file you selected appears to be malformed.\n" +
                                    "Please ensure that it contains only numbers delimitted by\n" +
                                    "whitespace or commas.",
                                    "Error in processing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static int LCM(List<int> periods)
        {
            return periods.Aggregate((x, y) => (x * y / GCD(x, y)));
        }

        static int GCD(int x, int y)
        {
            return y == 0 ? x : GCD(y, x % y);
        }
    }
}
