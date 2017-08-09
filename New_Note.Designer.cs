namespace E_Diary_App
{
    partial class New_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Note));
            this.title = new System.Windows.Forms.Label();
            this.titletext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.notetext = new System.Windows.Forms.TextBox();
            this.uploadimage = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(85, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 28);
            this.title.TabIndex = 1;
            this.title.Text = "Title :";
            // 
            // titletext
            // 
            this.titletext.Location = new System.Drawing.Point(159, 64);
            this.titletext.Name = "titletext";
            this.titletext.Size = new System.Drawing.Size(412, 20);
            this.titletext.TabIndex = 2;
            this.titletext.TextChanged += new System.EventHandler(this.titletext_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write New Note";
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.Transparent;
            this.note.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(85, 122);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(68, 28);
            this.note.TabIndex = 3;
            this.note.Text = "Note :";
            // 
            // notetext
            // 
            this.notetext.ForeColor = System.Drawing.Color.Black;
            this.notetext.Location = new System.Drawing.Point(159, 122);
            this.notetext.Multiline = true;
            this.notetext.Name = "notetext";
            this.notetext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notetext.Size = new System.Drawing.Size(412, 218);
            this.notetext.TabIndex = 4;
            this.notetext.TextChanged += new System.EventHandler(this.notetext_TextChanged);
            // 
            // uploadimage
            // 
            this.uploadimage.BackColor = System.Drawing.Color.Transparent;
            this.uploadimage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadimage.Location = new System.Drawing.Point(43, 385);
            this.uploadimage.Name = "uploadimage";
            this.uploadimage.Size = new System.Drawing.Size(140, 28);
            this.uploadimage.TabIndex = 5;
            this.uploadimage.Text = "Upload Image :";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DarkKhaki;
            this.save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.save.Location = new System.Drawing.Point(613, 241);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 33);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkKhaki;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.back.Location = new System.Drawing.Point(613, 306);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 34);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // New_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.uploadimage);
            this.Controls.Add(this.notetext);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titletext);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "New_Note";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titletext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.TextBox notetext;
        private System.Windows.Forms.Label uploadimage;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
    }
}