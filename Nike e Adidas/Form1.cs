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
            label1.Text = "Biografia da Nike";
            textBox1.Text = "Nike é uma empresa estadunidense de calçados, roupas e acessórios fundada em 1972 por Bill Bowerman e Philip Knight. Em 2016, foi considerada a marca de roupas mais valiosa do mundo, segundo o ranking BrandZ da consultoria Millward Brown, avaliada em US$ 37,472 bilhões.";
            Pic_image3.Image = Properties.Resources.Qr_Code_Nike;

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
            label1.Text = "Biografia da Adidas";
            Pic_image3.Image = Properties.Resources.Qr_Code_Adidas;
            textBox1.Text = "Ao longo dos anos, a Adidas se tornou uma gigante que conquistou espaço na moda, cultura e música. A marca se consagrou por entender e antecipar tendências, traduzindo o movimento das ruas e das quadras em peças que transcendem o guarda-roupa. ";




        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image2.Image = Properties.Resources.CamisasNike;
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            label1.Text = "Camisas da Nike";
            Pic_image3.Image = Properties.Resources.Qr_Code_Nike_Camisas;
            textBox1.Text = "Camisa do Barcelona sendo a mais vendida do mundo e a camisa do Corinthians a mais vendida do Brasil";
        }

        private void Pic_image1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.adidas2;
            Pic_image2.Image = Properties.Resources.camisaadidas;
            label1.Text = "Camisas da Adidas";
            Pic_image3.Image = Properties.Resources.Qr_Code_Adidas_Camisas;
            textBox1.Text = "Camisa do Real Madrid sendo a mais vendida do mundo e a camisa do Flamengo a mais vendida do Brasil";
                
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            Pic_image2.Image = Properties.Resources.chuteirank;
            label1.Text = "Chuteiras da Nike";
            Pic_image3.Image = Properties.Resources.Qr_Code_Chuteiras_Nike;
            textBox1.Text = "A chuteira nike tiempo legend e a nike mercurial vapor figuram entre as linhas mais vendidas do mercado.";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.adidas2;
            Pic_image2.Image = Properties.Resources.adidas_chuteira;
            label1.Text = "Chuteiras da Adidas";
            Pic_image3.Image = Properties.Resources.Qr_Code_Chuteiras_Adidas;
            textBox1.Text = "Chuteira Adidas Predator e Chuteira Speedflow são as mais vendidas da Adidas";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            Pic_image2.Image = Properties.Resources.bolasnike;
            label1.Text = "Bolas da Nike";
            Pic_image3.Image = Properties.Resources.Qr_Code_Bolas_Nike;
            textBox1.Text = "Nas imagens são duas bolas Nike Academy";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.adidas2;
            Pic_image2.Image = Properties.Resources.BolasAdidas;
            label1.Text = "Bolas da Adidas";
            Pic_image3.Image = Properties.Resources.Qr_Code_Bolas_Adidas;
            textBox1.Text = "Nas duas imagens são bolas que se usam na competição Champions League";
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            Pic_image2.Image = Properties.Resources.jogadoresnike;
            label1.Text = "Jogadores Nike";
            Pic_image3.Image = Properties.Resources.Qr_Code_Jogadores_Nike;
            textBox1.Text = "Jogadores das imagens como Cristiano Ronaldo,Kyllian Mbappe,Erling Halland e Harry Kane são patrocinados pela Nike";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Pic_image1.Image = Properties.Resources.adidas2;
            Pic_image2.Image = Properties.Resources.jogadores_Adidas;
            label1.Text = "Jogadores Adidas";
            Pic_image3.Image = Properties.Resources.Qr_Code_Jogadores_Adidass;
            textBox1.Text = "Jogadores das imagens como jude Bellingham, Lionel Messi,Mohammed Salah e Sergio Ramos são patrocinados pela Adidas";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Bio_Nike_Click(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            
            label1.Text = "Times da Nike";
            Pic_image2.Image = Properties.Resources.Times_da_Nike;
            Pic_image1.Image = Properties.Resources.nike_ardanın_amk__1_;
            Pic_image3.Image = Properties.Resources.Qr_code_Times_Nike;
            textBox1.Text = "Times como Corinthians,Barcelona,Paris Saint Germain(PSG),Liverpool são clubes patrocinados pela Nike.OBS: Corinthians é patrocinado pela Nike há 21 anos.";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Times da Adidas";
            Pic_image1.Image = Properties.Resources.adidas2;
            Pic_image2.Image = Properties.Resources.Times_da_Adidas;
            Pic_image3.Image = Properties.Resources.Qr_Code_Times_Adidas;
            textBox1.Text = "Times como Real Madrid,Flamengo,Arsenal,Bayern de Munique são clubes patrocinados pela Adidas. OBS: Ao todo a camisa do Real Madrid atinge a marca de 250 milhões de Euros que equivale á 1,3 Bilhoes de Reais por ano.";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}