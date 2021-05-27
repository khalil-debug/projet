using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj.Caissier
{
    public partial class ConsulterVentes : Form
    {
        public ConsulterVentes()
        {
            InitializeComponent();
        }

        private void ConsulterVentes_Load(object sender, EventArgs e)
        {
            label2.Text = "Les ventes du: " + System.DateTime.Now;
            label4.Text = "(total)";
        }
    }
}
