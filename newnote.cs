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
    public partial class NewNote : Form
    {
        static int noteID;
        static int ImageID;
        public string Loc = "";
        public byte[] picture = null;
        public NewNote()
        {
            InitializeComponent();
            Note newwnote = new Note();
            //  noteID = newwnote.NoteID;
            //label5.Text = noteID.ToString();
            //label6.Text = ImageID.ToString();
        }
        public void NoteSave()
        {
            try { 
            Note newwnote = new Note();
            User_Info_NoteDataContext newnoteinfo = new User_Info_NoteDataContext();
            newwnote.Title = title_txt.Text;
            newwnote.Description = description_txt.Text;
            newwnote.Date = dateTimePicker1.Value;
            newwnote.Photos = picture;
            newnoteinfo.Notes.InsertOnSubmit(newwnote);
            newnoteinfo.SubmitChanges();
            noteID = newwnote.NoteID;
            label5.Text = noteID.ToString();
            ImageID = noteID + 1;
            label6.Text = ImageID.ToString();
            MessageBox.Show("Note Saved Successfully", "Confirmation");
            this.Hide();
            homewindow home = new homewindow();
            home.Show();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getImageId()
        {
           // label6.Text = ImageID.ToString();
        }

        public void ImageSave()
        {



            try
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    picture = ms.GetBuffer();
                    ms.Close();
                    MessageBox.Show("Image Uploaded");
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //try
            //{

            //    MemoryStream ms = new MemoryStream();
            //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //    byte[] a = ms.GetBuffer();
            //    ms.Close();
            //    //cmd.Parameters.Clear();
            //    //cmd.Parameters.AddWithValue("@picture", a);
            //    // cmd.Parameters.AddWithValue("@noteTitleDescriptionId", nextid);
            //    ///cmd.CommandText = "insert into notePicture (noteTitleDescriptionId,picture) values (@noteTitleDescriptionId,@picture)";
            //    //cn.Open();
            //    //cmd.ExecuteNonQuery();
            //    //cn.Close();
            //    Note imagesave = new Note();
            //    User_Info_NoteDataContext newnoteinfo = new User_Info_NoteDataContext();
            //    imagesave.NoteID = ImageID;
            //    imagesave.Photos = a;
            //    newnoteinfo.Notes.InsertOnSubmit(imagesave);
            //    newnoteinfo.SubmitChanges();
            //    MessageBox.Show("Image Uploaded");
            //    pictureBox1.Image = null;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //try
            //{

            //    FileStream fs = new FileStream(Loc, FileMode.Open, FileAccess.Read);
            //    BinaryReader br = new BinaryReader(fs);
            //    picture = br.ReadBytes((int)fs.Length);

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        public void Upload()
        {
            //try
            //{
            //    OpenFileDialog open = new OpenFileDialog();
            //    open.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
            //    open.Title = "select picture";
            //    if (open.ShowDialog() == DialogResult.OK)
            //    {
            //        Loc = open.FileName.ToString();
            //        pictureBox1.ImageLocation = Loc;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {

                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    label4.Text = f.SafeFileName.ToString();
                }
            }
            catch (Exception ee)
            { }

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            Upload();
        }
        private void picsave_btn_Click(object sender, EventArgs e)
        {
            ImageSave();
           // NoteSave();
            //getImageId();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            NoteSave();

        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            homewindow home = new homewindow();
            home.Show();
            this.Close();
        }

        private void NewNote_Load(object sender, EventArgs e)
        {

        }
    }
}
