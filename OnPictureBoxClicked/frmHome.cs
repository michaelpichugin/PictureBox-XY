using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnPictureBoxClicked
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void picMain_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            txtCout.Clear();
            txtCout.Text = "X: " + location.X.ToString() + " Y: " + location.Y.ToString();
            if (location.X >= 300 && location.Y >= 300 && location.X <= 400 && location.Y <= 400)
            {
                frmOpening go = new frmOpening();
                go.ShowDialog();
            }
        }
    }
}
