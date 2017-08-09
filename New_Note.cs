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
    public partial class New_Note : Form
    {
        public New_Note()
        {
            InitializeComponent();
        }

        private void titletext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void notetext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home hm = new home();
            hm.Show();
        }
    }
}
