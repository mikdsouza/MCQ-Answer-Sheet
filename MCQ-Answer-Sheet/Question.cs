using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ_Answer_Sheet
{
    public partial class Question : UserControl
    {
        private int options = 0;
        private AnswerStyle style;

        public Question(int questionNumber, int options, AnswerStyle answerStyle)
        {
            InitializeComponent();

            lQuestion.Text = String.Format("Question {0,-3}", questionNumber);

            for (int i = 1; i <= options; i++)
            {
                RadioButton rb = AddOption(i, answerStyle);
                pOptions.Controls.Add(rb);
                rb.BringToFront();
            }

            pOptions.AutoSize = true;

            this.options = options;
            style = answerStyle;
        }

        public void EndTest()
        {
            for (int i = 1; i <= options; i++)
            {
                Button b = AddAnswer(i, style);
                pOptions.Controls.Add(b);
                b.BringToFront();
            }
        }

        private RadioButton AddOption(int optionNumber, AnswerStyle optionStyle)
        {
            RadioButton option = new RadioButton();

            switch (optionStyle)
            {
                case AnswerStyle.Letters:
                    option.Text = ((Char)('a' - 1 + optionNumber)).ToString();
                    break;

                case AnswerStyle.Numbers:
                    option.Text = optionNumber.ToString();
                    break;
            }

            option.AutoSize = true;
            option.Dock = DockStyle.Left;
            return option;
        }

        private Button AddAnswer(int optionNumber, AnswerStyle optionStyle)
        {
            Button option = new Button();

            switch (optionStyle)
            {
                case AnswerStyle.Letters:
                    option.Text = ((Char)('a' - 1 + optionNumber)).ToString();
                    break;

                case AnswerStyle.Numbers:
                    option.Text = optionNumber.ToString();
                    break;
            }

            option.AutoSize = true;
            option.Dock = DockStyle.Left;
            return option;
        }
    }
}
