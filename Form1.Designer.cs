namespace E_Diary_App
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.title = new System.Windows.Forms.Label();
            this.newnote = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.Button();
            this.setreminder = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(275, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(139, 33);
            this.title.TabIndex = 0;
            this.title.Text = "E-Diary";
            // 
            // newnote
            // 
            this.newnote.BackColor = System.Drawing.Color.DarkKhaki;
            this.newnote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newnote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.newnote.Location = new System.Drawing.Point(534, 121);
            this.newnote.Name = "newnote";
            this.newnote.Size = new System.Drawing.Size(116, 39);
            this.newnote.TabIndex = 1;
            this.newnote.Text = "New Note";
            this.newnote.UseVisualStyleBackColor = false;
            this.newnote.Click += new System.EventHandler(this.newnote_Click);
            // 
            // review
            // 
            this.review.BackColor = System.Drawing.Color.DarkKhaki;
            this.review.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.review.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.review.Location = new System.Drawing.Point(534, 190);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(116, 37);
            this.review.TabIndex = 2;
            this.review.Text = "Review";
            this.review.UseVisualStyleBackColor = false;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // setreminder
            // 
            this.setreminder.BackColor = System.Drawing.Color.DarkKhaki;
            this.setreminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.setreminder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setreminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.setreminder.Location = new System.Drawing.Point(534, 254);
            this.setreminder.Name = "setreminder";
            this.setreminder.Size = new System.Drawing.Size(116, 38);
            this.setreminder.TabIndex = 3;
            this.setreminder.Text = "Set Reminder";
            this.setreminder.UseVisualStyleBackColor = false;
            this.setreminder.Click += new System.EventHandler(this.setreminder_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exit.Location = new System.Drawing.Point(534, 315);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 32);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.DarkKhaki;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.about.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(625, -2);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(46, 23);
            this.about.TabIndex = 5;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.DarkKhaki;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(663, -2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 23);
            this.help.TabIndex = 6;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 457);
            this.Controls.Add(this.help);
            this.Controls.Add(this.about);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.setreminder);
            this.Controls.Add(this.review);
            this.Controls.Add(this.newnote);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Diary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button newnote;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button setreminder;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button help;
    }
}

