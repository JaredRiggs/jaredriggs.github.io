using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headsortails
{
    public partial class HeadsorTails : Form
    {
        public HeadsorTails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            Close();
        }
    }
}
