using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Jouets : Form
    {
        public Jouets()
        {
            InitializeComponent();
        }

        private void Jouets_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        String imgPhotoNew,URL;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            admin a = new admin();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG| *.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                imgPhotoNew = f.FileName;
                URL = f.SafeFileName;
            }
        }
    }
}
