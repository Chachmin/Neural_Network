namespace NeuralNetwork_project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Guess_header = new System.Windows.Forms.Label();
            this.Guess = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Button();
            this.Wrong = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.visual_0 = new System.Windows.Forms.PictureBox();
            this.visual_1 = new System.Windows.Forms.PictureBox();
            this.visual_2 = new System.Windows.Forms.PictureBox();
            this.visual_5 = new System.Windows.Forms.PictureBox();
            this.visual_4 = new System.Windows.Forms.PictureBox();
            this.visual_3 = new System.Windows.Forms.PictureBox();
            this.visual_8 = new System.Windows.Forms.PictureBox();
            this.visual_7 = new System.Windows.Forms.PictureBox();
            this.visual_6 = new System.Windows.Forms.PictureBox();
            this.visual_9 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_9)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(40, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(93, 236);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 33);
            this.Start.TabIndex = 1;
            this.Start.Text = "Пуск";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Guess_header
            // 
            this.Guess_header.AutoSize = true;
            this.Guess_header.Location = new System.Drawing.Point(90, 284);
            this.Guess_header.Name = "Guess_header";
            this.Guess_header.Size = new System.Drawing.Size(102, 13);
            this.Guess_header.TabIndex = 2;
            this.Guess_header.Text = "Я думаю, что это...";
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guess.Location = new System.Drawing.Point(93, 307);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(96, 31);
            this.Guess.TabIndex = 3;
            this.Guess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Right
            // 
            this.Right.Enabled = false;
            this.Right.Location = new System.Drawing.Point(40, 356);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(85, 36);
            this.Right.TabIndex = 4;
            this.Right.Text = "Да, верно!";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Wrong
            // 
            this.Wrong.Enabled = false;
            this.Wrong.Location = new System.Drawing.Point(155, 356);
            this.Wrong.Name = "Wrong";
            this.Wrong.Size = new System.Drawing.Size(85, 36);
            this.Wrong.TabIndex = 5;
            this.Wrong.Text = "Пока нет";
            this.Wrong.UseVisualStyleBackColor = true;
            this.Wrong.Click += new System.EventHandler(this.Wrong_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(287, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(536, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // visual_0
            // 
            this.visual_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_0.Location = new System.Drawing.Point(612, 452);
            this.visual_0.Name = "visual_0";
            this.visual_0.Size = new System.Drawing.Size(50, 50);
            this.visual_0.TabIndex = 8;
            this.visual_0.TabStop = false;
            // 
            // visual_1
            // 
            this.visual_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_1.Location = new System.Drawing.Point(536, 247);
            this.visual_1.Name = "visual_1";
            this.visual_1.Size = new System.Drawing.Size(50, 50);
            this.visual_1.TabIndex = 9;
            this.visual_1.TabStop = false;
            // 
            // visual_2
            // 
            this.visual_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_2.Location = new System.Drawing.Point(612, 247);
            this.visual_2.Name = "visual_2";
            this.visual_2.Size = new System.Drawing.Size(50, 50);
            this.visual_2.TabIndex = 10;
            this.visual_2.TabStop = false;
            // 
            // visual_5
            // 
            this.visual_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_5.Location = new System.Drawing.Point(612, 319);
            this.visual_5.Name = "visual_5";
            this.visual_5.Size = new System.Drawing.Size(50, 50);
            this.visual_5.TabIndex = 13;
            this.visual_5.TabStop = false;
            // 
            // visual_4
            // 
            this.visual_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_4.Location = new System.Drawing.Point(536, 319);
            this.visual_4.Name = "visual_4";
            this.visual_4.Size = new System.Drawing.Size(50, 50);
            this.visual_4.TabIndex = 12;
            this.visual_4.TabStop = false;
            // 
            // visual_3
            // 
            this.visual_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_3.Location = new System.Drawing.Point(686, 247);
            this.visual_3.Name = "visual_3";
            this.visual_3.Size = new System.Drawing.Size(50, 50);
            this.visual_3.TabIndex = 11;
            this.visual_3.TabStop = false;
            // 
            // visual_8
            // 
            this.visual_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_8.Location = new System.Drawing.Point(612, 387);
            this.visual_8.Name = "visual_8";
            this.visual_8.Size = new System.Drawing.Size(50, 50);
            this.visual_8.TabIndex = 16;
            this.visual_8.TabStop = false;
            // 
            // visual_7
            // 
            this.visual_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_7.Location = new System.Drawing.Point(536, 387);
            this.visual_7.Name = "visual_7";
            this.visual_7.Size = new System.Drawing.Size(50, 50);
            this.visual_7.TabIndex = 15;
            this.visual_7.TabStop = false;
            // 
            // visual_6
            // 
            this.visual_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_6.Location = new System.Drawing.Point(686, 319);
            this.visual_6.Name = "visual_6";
            this.visual_6.Size = new System.Drawing.Size(50, 50);
            this.visual_6.TabIndex = 14;
            this.visual_6.TabStop = false;
            // 
            // visual_9
            // 
            this.visual_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visual_9.Location = new System.Drawing.Point(686, 387);
            this.visual_9.Name = "visual_9";
            this.visual_9.Size = new System.Drawing.Size(50, 50);
            this.visual_9.TabIndex = 17;
            this.visual_9.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 525);
            this.Controls.Add(this.visual_9);
            this.Controls.Add(this.visual_8);
            this.Controls.Add(this.visual_7);
            this.Controls.Add(this.visual_6);
            this.Controls.Add(this.visual_5);
            this.Controls.Add(this.visual_4);
            this.Controls.Add(this.visual_3);
            this.Controls.Add(this.visual_2);
            this.Controls.Add(this.visual_1);
            this.Controls.Add(this.visual_0);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Wrong);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.Guess_header);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual_9)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Guess_header;
        private System.Windows.Forms.Label Guess;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Wrong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox visual_0;
        private System.Windows.Forms.PictureBox visual_1;
        private System.Windows.Forms.PictureBox visual_2;
        private System.Windows.Forms.PictureBox visual_5;
        private System.Windows.Forms.PictureBox visual_4;
        private System.Windows.Forms.PictureBox visual_3;
        private System.Windows.Forms.PictureBox visual_8;
        private System.Windows.Forms.PictureBox visual_7;
        private System.Windows.Forms.PictureBox visual_6;
        private System.Windows.Forms.PictureBox visual_9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

