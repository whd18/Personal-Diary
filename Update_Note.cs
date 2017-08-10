using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project_Test
{
    public partial class Update_Note : Form
    {
        int noteID;
        public string Loc = "";
        public byte[] picture = null;
        public Update_Note()
        {
            InitializeComponent();
        }
        public void update(int i, string t = " ", string d = " ")//noteid in constructor parameter
        {
            update_title_txt.Text = t;
            update_description_txt.Text = d;
            noteID = i;
            this.Show();
        }

        private void update_note_btn_Click(object sender, EventArgs e)
        {
            try
            {
                User_Info_NoteDataContext selectcontext = new User_Info_NoteDataContext();
                Note selectnote = selectcontext.Notes.SingleOrDefault(x => x.NoteID == noteID);
                selectnote.Title = update_title_txt.Text;
                selectnote.Description = update_description_txt.Text;
                selectnote.Date = dateTimePicker_update.Value;
                selectcontext.SubmitChanges();
                MessageBox.Show("Note Has Been Updated", "Confirmation");
                All_Notes allnote = new All_Notes();
                allnote.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_upload_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
                open.Title = "select picture";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Loc = open.FileName.ToString();
                    pictureBox1.ImageLocation = Loc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_picsave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    picture = ms.GetBuffer();
                    ms.Close();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            All_Notes allnote = new All_Notes();
            allnote.Show();
            this.Hide();
        }
    }
}
