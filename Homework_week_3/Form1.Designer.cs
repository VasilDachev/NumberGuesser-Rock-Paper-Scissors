namespace Homework_week_3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.Button();
            this.attempts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.cheat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Choose a difficulty",
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.comboBox1.Location = new System.Drawing.Point(8, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choose a difficulty";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(8, 58);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(125, 47);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start a new game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            this.label1.Visible = false;
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(8, 151);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(125, 47);
            this.guess.TabIndex = 4;
            this.guess.Text = "Guess";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // attempts
            // 
            this.attempts.AutoSize = true;
            this.attempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attempts.Location = new System.Drawing.Point(83, 210);
            this.attempts.Name = "attempts";
            this.attempts.Size = new System.Drawing.Size(38, 31);
            this.attempts.TabIndex = 7;
            this.attempts.Text = " 0";
            this.attempts.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attempts:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // picBox2
            // 
            this.picBox2.ErrorImage = global::Homework_week_3.Properties.Resources.gameover;
            this.picBox2.InitialImage = global::Homework_week_3.Properties.Resources.thumUp;
            this.picBox2.Location = new System.Drawing.Point(148, 125);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(93, 73);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 6;
            this.picBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Image = global::Homework_week_3.Properties.Resources.arrowUp;
            this.picBox1.Location = new System.Drawing.Point(148, 31);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(93, 74);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 5;
            this.picBox1.TabStop = false;
            this.picBox1.Visible = false;
            // 
            // cheat
            // 
            this.cheat.Location = new System.Drawing.Point(183, 215);
            this.cheat.Name = "cheat";
            this.cheat.Size = new System.Drawing.Size(42, 23);
            this.cheat.TabIndex = 9;
            this.cheat.Text = "cheat";
            this.cheat.UseVisualStyleBackColor = true;
            this.cheat.Click += new System.EventHandler(this.cheat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 277);
            this.Controls.Add(this.cheat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attempts);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the number";
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label attempts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cheat;
    }
}

