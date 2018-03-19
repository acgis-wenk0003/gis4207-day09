using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoordConverterBLL;


namespace CoordConverterWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //int deg = int.Parse(textBox1_TextChanged.Text);
            DMSCoord Coords = new DMSCoord();
            Coords.deg = Convert.ToInt16(tbxDeg.Text);
            Coords.min = Convert.ToInt16(tbxMin.Text);
            Coords.sec = Convert.ToDouble(tbxSec.Text);
            Coords.quadrant = 0;
            DMSConverter target = new DMSConverter();
            
            DecDegoutput.Text = Convert.ToString(target.Dms2Dd(Coords));
        }

        private void cboQuadrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DecDegoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSec_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
