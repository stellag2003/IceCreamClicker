namespace Jogo2
{
    public partial class Form1 : Form
    {

        int sorvete = 0;
        int gerador_por_segundo = 0;
        int custo_pinguim = 10;
        int custo_urso_polar = 50;
        int custo_carrinho = 600;
        int custo_sorveteria = 1000;
        int addP = 0;
        int addU = 0;
        int addC = 0;
        int addS = 0;


        public Form1()
        {
            InitializeComponent();
        }

        void atualizaInterface()
        {
            label2.Text = sorvete.ToString();
            label4.Text = gerador_por_segundo.ToString();
            label6.Text = custo_pinguim.ToString();
            label8.Text = custo_urso_polar.ToString();
            label10.Text = custo_carrinho.ToString();
            label16.Text = custo_sorveteria.ToString();

        }

        void temporizadorTick()
        {

        }

        void geradorSorvetes()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sorvete += 1;


            if (sorvete >= 50)
            {
                pictureBox4.Visible = false;

            }

            if (sorvete >= 600)
            {
                pictureBox3.Visible = false;
            }

            if (sorvete >= 1000)
            {
                pictureBox7.Visible = false;
            }
            atualizaInterface();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sorvete += gerador_por_segundo;
            atualizaInterface();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sorvete += 1;


            if (sorvete >= 50)
            {
                pictureBox4.Visible = false;

            }
            if (sorvete >= 600)
            {
                pictureBox3.Visible = false;
            }

            if (sorvete >= 1000)
            {
                pictureBox7.Visible = false;
            }
            atualizaInterface();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (sorvete >= custo_pinguim)
            {
                sorvete -= custo_pinguim;
                gerador_por_segundo += 1;

                custo_pinguim *= 2;

                addP += 1;
                label12.Text = addP.ToString();
            }

            else
            {
                MessageBox.Show("Sorvetes insuficientes :(");
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgPinguim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Sr. Pinguim produz mais sorvetes para você!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



            if (sorvete >= custo_urso_polar)
            {
                sorvete -= custo_urso_polar;

                gerador_por_segundo += 3;

                custo_urso_polar *= 2;
                addU += 1;
                label13.Text = addU.ToString();
            }
            else
            {
                MessageBox.Show("Sorvetes insuficientes :(");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Sr. Urso produz +3 sorvetes por segundo!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sorvete >= custo_carrinho)
            {
                sorvete -= custo_carrinho;

                sorvete += 40;

                custo_carrinho *= 2;
                addC += 1;
                label14.Text = addC.ToString();
            }
            else
            {
                MessageBox.Show("Sorvetes insuficientes :(");
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O carrinho de sorvete aumenta o valor do seu clique para 40 sorvetes a cada clique!");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sorvete >= custo_sorveteria)
            {
                sorvete -= custo_sorveteria;

                gerador_por_segundo += 100;

                custo_sorveteria *= 2;
                addS += 1;
                label17.Text = addS.ToString();
            }
            else
            {
                MessageBox.Show("Sorvetes insuficientes :(");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sorveteria produz 100 sorvetes por segundo!");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}