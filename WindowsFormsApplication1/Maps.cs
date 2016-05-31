using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Maps : Form
    {
        double x, y;
        public Maps(double X, double Y)
        {
            InitializeComponent();
            x = X;
            y = Y;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            wbMaps.Navigate("https://www.google.ch/maps/place/" + x + "+" + y);
        }
    }
}
