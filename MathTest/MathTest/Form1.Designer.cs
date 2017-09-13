namespace MathTest
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.UserAnswerTextbox = new System.Windows.Forms.TextBox();
            this.EnterAnswerButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(228, 22);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(49, 13);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            // 
            // UserAnswerTextbox
            // 
            this.UserAnswerTextbox.Location = new System.Drawing.Point(166, 84);
            this.UserAnswerTextbox.Name = "UserAnswerTextbox";
            this.UserAnswerTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserAnswerTextbox.TabIndex = 2;
            // 
            // EnterAnswerButton
            // 
            this.EnterAnswerButton.Location = new System.Drawing.Point(273, 80);
            this.EnterAnswerButton.Name = "EnterAnswerButton";
            this.EnterAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.EnterAnswerButton.TabIndex = 3;
            this.EnterAnswerButton.Text = "Enter";
            this.EnterAnswerButton.UseVisualStyleBackColor = true;
            this.EnterAnswerButton.Visible = false;
            this.EnterAnswerButton.Click += new System.EventHandler(this.EnterAnswerButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(13, 43);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(41, 13);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(519, 164);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.EnterAnswerButton);
            this.Controls.Add(this.UserAnswerTextbox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Math Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox UserAnswerTextbox;
        private System.Windows.Forms.Button EnterAnswerButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

