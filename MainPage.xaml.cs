using System.Security.Principal;

namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        private string jogador = "X";
        private string vencedor = "O";
        int contador = 0;
        bool fim=false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnJogar_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (jogador == "X")
            {
                btn.Text = "X";
                jogador = "O";
                vencedor = "X";
            }
            else
            {
                btn.Text = "O";
                jogador = "X";
                vencedor = "O";
            }
            contador += 1;

            btn.IsEnabled = false;
            ChecarFim();
            
        }
       private void ChecarFim()
        {
            fim = false;
            if (btn10.Text == btn11.Text && btn10.Text == btn12.Text && btn10.Text != "")
            {
                fim = true;
            }
            if (btn20.Text == btn21.Text && btn20.Text == btn22.Text && btn20.Text != "")
            {
                fim = true;
            }
            if (btn30.Text == btn31.Text && btn30.Text == btn32.Text && btn30.Text != "")
            {
                fim = true;
            }
            if (btn10.Text == btn20.Text && btn10.Text == btn30.Text && btn10.Text != "")
            {
                fim = true;
            }
            if (btn11.Text == btn21.Text && btn11.Text == btn31.Text && btn11.Text != "")
            {
                fim = true;
            }
            if (btn12.Text == btn22.Text && btn12.Text == btn32.Text && btn12.Text != "")
            {
                fim = true;
            }
            if (btn10.Text == btn21.Text && btn10.Text == btn32.Text && btn10.Text != "")
            {
                fim = true;
            }
            if (btn12.Text == btn21.Text && btn12.Text == btn30.Text && btn12.Text != "")
            {
                fim = true;
            }
            if (fim)
            {
                DisplayAlertAsync("PARABENS!", "Vitória do jogador " + vencedor, "Ok");
                fim = false;
            }
            else
            {
                if (contador == 9)
                {
                    DisplayAlertAsync("PARABENS!", "Vitória da Velha", "Ok");
                }
            }
        }
        private void Limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true;
            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;
            btn31.Text = "";
            btn31.IsEnabled = true;
            btn32.Text = "";
            btn32.IsEnabled = true;

            jogador = "X";
            vencedor = "O";
            contador = 0;
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
