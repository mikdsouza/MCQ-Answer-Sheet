namespace MCQ_Answer_Sheet
{
    partial class MCQAnsSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bNewTest = new System.Windows.Forms.Button();
            this.bEndTest = new System.Windows.Forms.Button();
            this.lTimeDisplay = new System.Windows.Forms.Label();
            this.pAnswers = new System.Windows.Forms.Panel();
            this.tStopwatch = new System.Windows.Forms.Timer(this.components);
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.lTimeDisplay);
            this.pButtons.Controls.Add(this.bEndTest);
            this.pButtons.Controls.Add(this.bNewTest);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(304, 46);
            this.pButtons.TabIndex = 0;
            // 
            // bNewTest
            // 
            this.bNewTest.Location = new System.Drawing.Point(12, 12);
            this.bNewTest.Name = "bNewTest";
            this.bNewTest.Size = new System.Drawing.Size(75, 23);
            this.bNewTest.TabIndex = 0;
            this.bNewTest.Text = "New Test";
            this.bNewTest.UseVisualStyleBackColor = true;
            this.bNewTest.Click += new System.EventHandler(this.bNewTest_Click);
            // 
            // bEndTest
            // 
            this.bEndTest.Enabled = false;
            this.bEndTest.Location = new System.Drawing.Point(93, 12);
            this.bEndTest.Name = "bEndTest";
            this.bEndTest.Size = new System.Drawing.Size(75, 23);
            this.bEndTest.TabIndex = 1;
            this.bEndTest.Text = "End Test";
            this.bEndTest.UseVisualStyleBackColor = true;
            this.bEndTest.Click += new System.EventHandler(this.bEndTest_Click);
            // 
            // lTimeDisplay
            // 
            this.lTimeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lTimeDisplay.AutoSize = true;
            this.lTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeDisplay.Location = new System.Drawing.Point(222, 12);
            this.lTimeDisplay.Name = "lTimeDisplay";
            this.lTimeDisplay.Size = new System.Drawing.Size(70, 24);
            this.lTimeDisplay.TabIndex = 2;
            this.lTimeDisplay.Text = "0:00:00";
            this.lTimeDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pAnswers
            // 
            this.pAnswers.AutoScroll = true;
            this.pAnswers.AutoSize = true;
            this.pAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAnswers.Location = new System.Drawing.Point(0, 46);
            this.pAnswers.Name = "pAnswers";
            this.pAnswers.Size = new System.Drawing.Size(304, 465);
            this.pAnswers.TabIndex = 1;
            // 
            // tStopwatch
            // 
            this.tStopwatch.Interval = 1000;
            this.tStopwatch.Tick += new System.EventHandler(this.tStopwatch_Tick);
            // 
            // MCQAnsSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(304, 511);
            this.Controls.Add(this.pAnswers);
            this.Controls.Add(this.pButtons);
            this.MinimumSize = new System.Drawing.Size(320, 550);
            this.Name = "MCQAnsSheet";
            this.Text = "Answer Sheet";
            this.pButtons.ResumeLayout(false);
            this.pButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Label lTimeDisplay;
        private System.Windows.Forms.Button bEndTest;
        private System.Windows.Forms.Button bNewTest;
        private System.Windows.Forms.Panel pAnswers;
        private System.Windows.Forms.Timer tStopwatch;
    }
}

