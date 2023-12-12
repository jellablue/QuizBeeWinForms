namespace QuizBeeWinForms
{
    partial class quiz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.labelQues = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.userAnswer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDiff = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.QuestionLabel);
            this.panel1.Controls.Add(this.labelQues);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 156);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AllowDrop = true;
            this.QuestionLabel.AutoEllipsis = true;
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuestionLabel.Location = new System.Drawing.Point(18, 18);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(380, 250);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(86, 28);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "label1";
            // 
            // labelQues
            // 
            this.labelQues.AutoSize = true;
            this.labelQues.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelQues.Location = new System.Drawing.Point(12, 12);
            this.labelQues.Name = "labelQues";
            this.labelQues.Size = new System.Drawing.Size(0, 28);
            this.labelQues.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.BackgroundImage = global::QuizBeeWinForms.Properties.Resources._17344d95_d474_4c7a_84f0_c880b176b52f;
            this.buttonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Location = new System.Drawing.Point(156, 345);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(129, 49);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // userAnswer
            // 
            this.userAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userAnswer.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userAnswer.Location = new System.Drawing.Point(60, 293);
            this.userAnswer.Name = "userAnswer";
            this.userAnswer.Size = new System.Drawing.Size(325, 26);
            this.userAnswer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelDiff);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.MaximumSize = new System.Drawing.Size(300, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 48);
            this.panel2.TabIndex = 3;
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.labelDiff.Location = new System.Drawing.Point(3, 9);
            this.labelDiff.MaximumSize = new System.Drawing.Size(100, 50);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(67, 25);
            this.labelDiff.TabIndex = 0;
            this.labelDiff.Text = "label";
            // 
            // quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizBeeWinForms.Properties.Resources.this_is_me_trrying;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(464, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userAnswer);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQues;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox userAnswer;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDiff;
    }
}