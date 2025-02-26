using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_e_Adidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image2.Image = Properties.Resources.nike1;
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            Pic_image1.Left = 680;  //
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image2.Image = Properties.Resources.Adidas1;
            Pic_image1.Image = Properties.Resources.adidas2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image2.Image = Properties.Resources.camisas1;
        }

        private void Pic_image1_Click(object sender, EventArgs e)
        {

        }
    }
}