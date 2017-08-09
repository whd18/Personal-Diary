using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Diary_App
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void newnote_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Note nw = new New_Note();
            nw.Show();
        }

        private void review_Click(object sender, EventArgs e)
        {

        }

        private void setreminder_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the initial version (v-0.1.0) of E-Diary./n"+" Developed By Sawkat & Wahid. Many More new features are coming in the upcoming versions. So, Stay Tuned with us. Thank You. ","About");
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can create new note by clicking on NOTE. You can review your notes by clicking on REVIEW. Also you can set reminder by Clicking SET REMINDER. If you want to exit simply Click EXIT. Thank You. ","Help");
        }

      
    }
}
