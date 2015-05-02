namespace MCQ_Answer_Sheet
{
    partial class NewTestOptions
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
            this.lQuestions = new System.Windows.Forms.Label();
            this.lAnswers = new System.Windows.Forms.Label();
            this.lAnswerStyle = new System.Windows.Forms.Label();
            this.nudQuestions = new System.Windows.Forms.NumericUpDown();
            this.nudAnswers = new System.Windows.Forms.NumericUpDown();
            this.rbLet = new System.Windows.Forms.RadioButton();
            this.rbNum = new System.Windows.Forms.RadioButton();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // lQuestions
            // 
            this.lQuestions.AutoSize = true;
            this.lQuestions.Location = new System.Drawing.Point(13, 13);
            this.lQuestions.Name = "lQuestions";
            this.lQuestions.Size = new System.Drawing.Size(106, 13);
            this.lQuestions.TabIndex = 0;
            this.lQuestions.Text = "Number of Questions";
            // 
            // lAnswers
            // 
            this.lAnswers.AutoSize = true;
            this.lAnswers.Location = new System.Drawing.Point(20, 42);
            this.lAnswers.Name = "lAnswers";
            this.lAnswers.Size = new System.Drawing.Size(99, 13);
            this.lAnswers.TabIndex = 2;
            this.lAnswers.Text = "Number of Answers";
            // 
            // lAnswerStyle
            // 
            this.lAnswerStyle.AutoSize = true;
            this.lAnswerStyle.Location = new System.Drawing.Point(51, 69);
            this.lAnswerStyle.Name = "lAnswerStyle";
            this.lAnswerStyle.Size = new System.Drawing.Size(68, 13);
            this.lAnswerStyle.TabIndex = 4;
            this.lAnswerStyle.Text = "Answer Style";
            // 
            // nudQuestions
            // 
            this.nudQuestions.Location = new System.Drawing.Point(126, 13);
            this.nudQuestions.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuestions.Name = "nudQuestions";
            this.nudQuestions.Size = new System.Drawing.Size(120, 20);
            this.nudQuestions.TabIndex = 1;
            this.nudQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAnswers
            // 
            this.nudAnswers.Location = new System.Drawing.Point(126, 40);
            this.nudAnswers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAnswers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnswers.Name = "nudAnswers";
            this.nudAnswers.Size = new System.Drawing.Size(120, 20);
            this.nudAnswers.TabIndex = 3;
            this.nudAnswers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbLet
            // 
            this.rbLet.AutoSize = true;
            this.rbLet.Checked = true;
            this.rbLet.Location = new System.Drawing.Point(126, 67);
            this.rbLet.Name = "rbLet";
            this.rbLet.Size = new System.Drawing.Size(99, 17);
            this.rbLet.TabIndex = 5;
            this.rbLet.TabStop = true;
            this.rbLet.Text = "Letters (a,b,c...)";
            this.rbLet.UseVisualStyleBackColor = true;
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Location = new System.Drawing.Point(126, 91);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(109, 17);
            this.rbNum.TabIndex = 6;
            this.rbNum.Text = "Numbers (1,2,3...)";
            this.rbNum.UseVisualStyleBackColor = true;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(90, 124);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 7;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(171, 124);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // NewTestOptions
            // 
            this.AcceptButton = this.bCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(256, 157);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.rbNum);
            this.Controls.Add(this.rbLet);
            this.Controls.Add(this.nudAnswers);
            this.Controls.Add(this.nudQuestions);
            this.Controls.Add(this.lAnswerStyle);
            this.Controls.Add(this.lAnswers);
            this.Controls.Add(this.lQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewTestOptions";
            this.ShowInTaskbar = false;
            this.Text = "NewTestOptions";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQuestions;
        private System.Windows.Forms.Label lAnswers;
        private System.Windows.Forms.Label lAnswerStyle;
        private System.Windows.Forms.NumericUpDown nudQuestions;
        private System.Windows.Forms.NumericUpDown nudAnswers;
        private System.Windows.Forms.RadioButton rbLet;
        private System.Windows.Forms.RadioButton rbNum;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
    }
}