namespace Jogo_Da_Velha_LucasF
{
    public partial class Form1 : Form
    {
        //Variaveis de Controlhe
        String JogadorVez = "O";
        bool Vitoria = false;
        String Ganhador = "";

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            if (!Vitoria)
            {
                Button button = (Button)sender;
                if (button.Text == "")
                    button.Text = JogadorDaVez();
            }
        }

        private string JogadorDaVez()
        {
            if (JogadorVez == "X")
            {
                JogadorVez = "O";
                return "O";
            }
            JogadorVez = "X";
            return "X";

        }

        private void Restart_Game(object sender, EventArgs e)
        {
            Restart_Celuna(Bt01);
            Restart_Celuna(Bt02);
            Restart_Celuna(Bt03);
            Restart_Celuna(Bt04);
            Restart_Celuna(Bt05);
            Restart_Celuna(Bt06);
            Restart_Celuna(Bt07);
            Restart_Celuna(Bt08);
            Restart_Celuna(Bt09);
            Vitoria = false;
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Restart_Celuna(Button btn00)
        {
            btn00.Text = "";

        }

        private bool VerificarCasos(Button btn00, Button btn01, Button btn02)
        {
            if (btn00.Text == btn01.Text && btn01.Text == btn02.Text)
            {
                if (btn01.Text != "")
                {
                    Vitoria = true;
                    label1.Visible = true;
                    Ganhador = "Ganhador - |" + btn01.Text + "|";
                    label1.Text = Ganhador;
                    return true;
                }
            }
            return false;
        }

        private void verificar(object sender, EventArgs e)
        {
            //Caso 01 - Linhas
            VerificarCasos(Bt01, Bt02, Bt03);
            VerificarCasos(Bt04, Bt05, Bt06);
            VerificarCasos(Bt07, Bt08, Bt09);

            //Caso 02 - Colunas
            VerificarCasos(Bt01, Bt04, Bt07);
            VerificarCasos(Bt02, Bt05, Bt08);
            VerificarCasos(Bt03, Bt06, Bt09);

            //Caso 03 - Diagonais
            VerificarCasos(Bt01, Bt05, Bt09);
            VerificarCasos(Bt03, Bt05, Bt07);





        }
    }
}