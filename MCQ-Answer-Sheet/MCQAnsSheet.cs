using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ_Answer_Sheet
{
    public partial class MCQAnsSheet : Form
    {
        private DateTime startTime = DateTime.Now;

        public MCQAnsSheet()
        {
            InitializeComponent();
        }

        private void bNewTest_Click(object sender, EventArgs e)
        {
            NewTestOptions testOptions = new NewTestOptions();

            if (testOptions.ShowDialog() == DialogResult.OK)
            {
                startTime = DateTime.Now;
                lTimeDisplay.Text = "0:00:00";

                bNewTest.Enabled = false;
                bEndTest.Enabled = true;
                tStopwatch.Enabled = true;
                pAnswers.Controls.Clear();

                for (int i = 1; i <= testOptions.NumQuestions; i++)
                {
                    Question q = new Question(i, testOptions.NumAnswers, testOptions.AnswerStyle);
                    pAnswers.Controls.Add(q);
                    q.Dock = DockStyle.Top;
                    q.BringToFront();
                }
            }
        }

        private void bEndTest_Click(object sender, EventArgs e)
        {
            foreach(Control c in pAnswers.Controls)
            {
                if (c is Question)
                {
                    ((Question)c).EndTest();
                }
            }
            bEndTest.Enabled = false;
            bNewTest.Enabled = true;
            tStopwatch.Enabled = false;
        }

        private void tStopwatch_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now.Subtract(startTime);

            lTimeDisplay.Text = elapsed.ToString(@"h\:mm\:ss");
        }
    }
}
