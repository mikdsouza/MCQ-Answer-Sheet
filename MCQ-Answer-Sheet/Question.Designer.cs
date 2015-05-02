namespace MCQ_Answer_Sheet
{
    partial class Question
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lQuestion = new System.Windows.Forms.Label();
            this.pOptions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(5, 10);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(73, 13);
            this.lQuestion.TabIndex = 0;
            this.lQuestion.Text = "Question ###";
            // 
            // pOptions
            // 
            this.pOptions.Location = new System.Drawing.Point(84, 4);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(106, 26);
            this.pOptions.TabIndex = 1;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pOptions);
            this.Controls.Add(this.lQuestion);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(197, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Panel pOptions;
    }
}
