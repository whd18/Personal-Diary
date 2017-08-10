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
    public partial class All_Notes : Form
    {
        public All_Notes()
        {
            InitializeComponent();
            allnotes();
        }

        public void allnotes()
        {
            Note selectnote = new Note();
            User_Info_NoteDataContext selectcontext = new User_Info_NoteDataContext();
            dataGridView1.DataSource = selectcontext.Notes.GetNewBindingList();
            this.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            homewindow home = new homewindow();
            home.Show();
            this.Hide();
        }

        private void All_Notes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataDataSet1.Note' table. You can move, or remove it, as needed.
            this.noteTableAdapter1.Fill(this.projectDataDataSet1.Note);
            // TODO: This line of code loads data into the 'projectDataDataSet.Note' table. You can move, or remove it, as needed.
            this.noteTableAdapter.Fill(this.projectDataDataSet.Note);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //match title and show the note
            try
            {
                var item = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                string i = item.ToString();
                int id = Int32.Parse(i);
                Note selectnote = new Note();
                User_Info_NoteDataContext selectcontext = new User_Info_NoteDataContext();
                selectnote = selectcontext.Notes.SingleOrDefault(x => x.NoteID == id);
                ShowNote show = new ShowNote();
                show.LoadData(selectnote.NoteID, selectnote.Title, selectnote.Description, selectnote.Date.ToString());
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Search(string title=" ")
        {
            try
            {

                IEnumerable<DataGridViewRow> rows =
         from DataGridViewRow row in dataGridView1.Rows
         where row.Cells[0].Value.ToString().StartsWith(title)
         select row;

                foreach (DataGridViewRow r in rows)
                    r.Selected = true;

                //        DataGridViewRow row2 =
                //(from DataGridViewRow r in dataGridView1.Rows
                // where r.Cells[0].Value.ToString().StartsWith(search_txt.Text)
                // select r).FirstOrDefault();

                //        if (row2 != null)
                //            row2.Selected = true;
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {

                IEnumerable<DataGridViewRow> rows =
         from DataGridViewRow row in dataGridView1.Rows
         where row.Cells[0].Value.ToString().StartsWith(search_txt.Text)
         select row;

                foreach (DataGridViewRow r in rows)
                    r.Selected = true;

                //        DataGridViewRow row2 =
                //(from DataGridViewRow r in dataGridView1.Rows
                // where r.Cells[0].Value.ToString().StartsWith(search_txt.Text)
                // select r).FirstOrDefault();

                //        if (row2 != null)
                //            row2.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try {
                //Note searchnote = new Note();
               // User_Info_NoteDataContext searchcontext = new User_Info_NoteDataContext();
                //searchnote = searchcontext.Notes.SingleOrDefault(x => x.Title == search_txt.Text);
        //        IEnumerable<DataGridViewRow> rows =
        // from DataGridViewRow row in dataGridView1.Rows
        // where row.Cells[0].Value.ToString().Equals(search_txt.Text)
        // select row;

        //        foreach (DataGridViewRow r in rows)
        //            r.Selected = true;
        //        DataGridViewRow row2 =
        //(from DataGridViewRow r in dataGridView1.Rows
        // where r.Cells[0].Value.ToString().Equals(search_txt.Text)
        // select r).FirstOrDefault();

        //        if (row2 != null)
        //            row2.Selected = true;



                //dataGridView1.DataSource = searchnote;

                // dataGridView1.BindingContext.ToString();
                // dataGridView1.DataSource = searchcontext.Notes.GetNewBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void searchbydate_btn_Click(object sender, EventArgs e)
        {
            try {
                IEnumerable<DataGridViewRow> rows =
            from DataGridViewRow row in dataGridView1.Rows
            where row.Cells["Date"].Value.ToString().StartsWith(search_txt.Text)
            select row;

                foreach (DataGridViewRow r in rows)
                    r.Selected = true;


                DataGridViewRow row2 =
        (from DataGridViewRow r in dataGridView1.Rows
         where r.Cells["Date"].Value.ToString().StartsWith(search_txt.Text)
         select r).FirstOrDefault();
                if (row2 != null)
                    row2.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
