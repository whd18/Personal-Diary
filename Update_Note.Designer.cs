namespace OOP2_Project_Test
{
    partial class Update_Note
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
            this.dateTimePicker_update = new System.Windows.Forms.DateTimePicker();
            this.back_btn = new System.Windows.Forms.Button();
            this.update_description_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_note_btn = new System.Windows.Forms.Button();
            this.update_title_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update_picsave_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update_upload_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_update
            // 
            this.dateTimePicker_update.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker_update.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_update.Location = new System.Drawing.Point(83, 57);
            this.dateTimePicker_update.Name = "dateTimePicker_update";
            this.dateTimePicker_update.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker_update.TabIndex = 15;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(172, 416);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 32);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_description_txt
            // 
            this.update_description_txt.BackColor = System.Drawing.Color.LavenderBlush;
            this.update_description_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_description_txt.Location = new System.Drawing.Point(80, 99);
            this.update_description_txt.Multiline = true;
            this.update_description_txt.Name = "update_description_txt";
            this.update_description_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.update_description_txt.Size = new System.Drawing.Size(348, 300);
            this.update_description_txt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description :";
            // 
            // update_note_btn
            // 
            this.update_note_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_note_btn.Location = new System.Drawing.Point(80, 416);
            this.update_note_btn.Name = "update_note_btn";
            this.update_note_btn.Size = new System.Drawing.Size(75, 32);
            this.update_note_btn.TabIndex = 11;
            this.update_note_btn.Text = "Update";
            this.update_note_btn.UseVisualStyleBackColor = true;
            this.update_note_btn.Click += new System.EventHandler(this.update_note_btn_Click);
            // 
            // update_title_txt
            // 
            this.update_title_txt.BackColor = System.Drawing.Color.LavenderBlush;
            this.update_title_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_title_txt.Location = new System.Drawing.Point(80, 25);
            this.update_title_txt.Multiline = true;
            this.update_title_txt.Name = "update_title_txt";
            this.update_title_txt.Size = new System.Drawing.Size(348, 26);
            this.update_title_txt.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.update_picsave_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.update_upload_btn);
            this.panel1.Location = new System.Drawing.Point(450, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 279);
            this.panel1.TabIndex = 9;
            // 
            // update_picsave_btn
            // 
            this.update_picsave_btn.Location = new System.Drawing.Point(17, 231);
            this.update_picsave_btn.Name = "update_picsave_btn";
            this.update_picsave_btn.Size = new System.Drawing.Size(75, 23);
            this.update_picsave_btn.TabIndex = 9;
            this.update_picsave_btn.Text = "Save";
            this.update_picsave_btn.UseVisualStyleBackColor = true;
            this.update_picsave_btn.Click += new System.EventHandler(this.update_picsave_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // update_upload_btn
            // 
            this.update_upload_btn.Location = new System.Drawing.Point(107, 231);
            this.update_upload_btn.Name = "update_upload_btn";
            this.update_upload_btn.Size = new System.Drawing.Size(93, 23);
            this.update_upload_btn.TabIndex = 7;
            this.update_upload_btn.Text = "Upload Image";
            this.update_upload_btn.UseVisualStyleBackColor = true;
            this.update_upload_btn.Click += new System.EventHandler(this.update_upload_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Updated On :";
            // 
            // Update_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_update);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.update_description_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_note_btn);
            this.Controls.Add(this.update_title_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Update_Note";
            this.Text = "Update_Note";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_update;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox update_description_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_note_btn;
        private System.Windows.Forms.TextBox update_title_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_picsave_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update_upload_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}