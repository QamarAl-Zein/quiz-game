namespace QuizGAme
{
    partial class Game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Peru;
            this.pictureBox1.Image = global::QuizGAme.Properties.Resources.Gemini_Generated_Image_glbnkpglbnkpglbn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1352, 740);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblQuestionNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lblQuestionNumber.Location = new System.Drawing.Point(615, 96);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(98, 46);
            this.lblQuestionNumber.TabIndex = 1;
            this.lblQuestionNumber.Text = "1/10";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.lblQuestion.Location = new System.Drawing.Point(435, 241);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(479, 38);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "------------------------------------------";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnChoice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice1.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnChoice1.FlatAppearance.BorderSize = 0;
            this.btnChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.btnChoice1.Location = new System.Drawing.Point(471, 348);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(395, 66);
            this.btnChoice1.TabIndex = 3;
            this.btnChoice1.Tag = "1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnChoice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice2.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnChoice2.FlatAppearance.BorderSize = 0;
            this.btnChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.btnChoice2.Location = new System.Drawing.Point(471, 445);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(395, 66);
            this.btnChoice2.TabIndex = 4;
            this.btnChoice2.Tag = "2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.btnChoice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice3.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnChoice3.FlatAppearance.BorderSize = 0;
            this.btnChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.btnChoice3.Location = new System.Drawing.Point(471, 542);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(395, 66);
            this.btnChoice3.TabIndex = 5;
            this.btnChoice3.Tag = "3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(1174, 103);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(49, 36);
            this.lbltimer.TabIndex = 6;
            this.lbltimer.Text = "60";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 740);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
    }
}