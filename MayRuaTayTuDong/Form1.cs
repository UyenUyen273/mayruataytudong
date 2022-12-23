using System.Runtime.CompilerServices;
using System.IO.Ports;

namespace MayRuaTayTuDong
{
    public partial class Form1 : Form
    {

        SerialPort port = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_textmayruataytudong_Click(object sender, EventArgs e)
        {

        }

        private void lbl_image2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mayruataytudong_Click(object sender, EventArgs e)
        {
        }

        private void lbl_dungdich2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_dungdichchuadu_Click(object sender, EventArgs e)
        {
            
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_dungdichchuadu.BringToFront();
            lbl_image2.BringToFront();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_dungdichday.BringToFront();
            label1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}