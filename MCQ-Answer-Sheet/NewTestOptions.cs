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
    public enum AnswerStyle { Letters, Numbers }

    public partial class NewTestOptions : Form
    {
        public int NumQuestions { get { return (int)nudQuestions.Value; } }
        public int NumAnswers { get { return (int)nudAnswers.Value; } }
        public AnswerStyle AnswerStyle
        {
            get
            {
                if (rbLet.Checked)
                    return AnswerStyle.Letters;
                else if (rbNum.Checked)
                    return AnswerStyle.Numbers;
                else
                    throw new ArgumentException("No answer type was selected");
            }
        }

        public NewTestOptions()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
