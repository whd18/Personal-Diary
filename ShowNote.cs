using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project_Test
{
    public partial class ShowNote : Form
    {
        int noteID;
        public ShowNote()
        {
            InitializeComponent();
        }
        public void LoadData(int i, string t = " ", string d = " ", string date = " ")
        {
            //loading data to showcase the note
            show_title_txt.Text = t;
            show_descrip_txt.Text = d;
            label5.Text = date;
            noteID = i;
            label1.Text = noteID.ToString();
            this.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            All_Notes allnote = new All_Notes();
            allnote.Show();
            this.Hide();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //checks the NoteID and deletes the corresponding Note
            User_Info_NoteDataContext selectcontext = new User_Info_NoteDataContext();
            Note selectnote = selectcontext.Notes.SingleOrDefault(x => x.NoteID == noteID);
            selectcontext.Notes.DeleteOnSubmit(selectnote);
            selectcontext.SubmitChanges();
            MessageBox.Show("Selected Information Has Been Deleted..");
            All_Notes allnotes = new All_Notes();
            allnotes.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            Note selectnote = new Note();
            User_Info_NoteDataContext selectcontext = new User_Info_NoteDataContext();
            Update_Note updatenote = new Update_Note();
            string id = selectnote.NoteID.ToString();
            //sending values to update corresponding note
            updatenote.update(noteID, show_title_txt.Text, show_descrip_txt.Text);
            this.Hide();

        }
    }
}
