using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoExemplo1
{
    public partial class Form1 : Form
    {
      //  private Button botaozinho;
       // private Label labelzinho;
       // private TextBox caixinhaDeTexto;
        private Button[,] botoes;

        public void iniciarComponentes()
        {
            #region Parte1
          /*  botaozinho = new Button();
            labelzinho = new Label();
            caixinhaDeTexto = new TextBox();

         
            botaozinho.Parent = this;
            botaozinho.Top = 150;
            botaozinho.Left = 100;
            botaozinho.Text = "Ok";
            botaozinho.Click += new EventHandler(clicouNoBotaozinho);

            labelzinho.Parent = this;
            labelzinho.Top = 150;
            labelzinho.Left = 200;
            labelzinho.Text = "AAAAAAAA";

            caixinhaDeTexto.Parent = this;
            caixinhaDeTexto.Top = 150;
            caixinhaDeTexto.Left = 250;
            caixinhaDeTexto.Text = "Digite o texto aqui";
            caixinhaDeTexto.Width = 100;*/
            #endregion

            #region Parte2
            botoes = new Button[4,25];

            for (int x = 0; x < 4; ++x)
            {
                for(int y = 0; y < 25; ++y)
                {
                    
                    botoes[x, y] = new Button();
                    botoes[x, y].Parent = this;
                    botoes[x, y].Top = 25 * x ;
                    botoes[x, y].Left = 30 * y;
                    botoes[x, y].Text = "L" + (x + 1 ).ToString();
                    botoes[x, y].Click += new EventHandler(clicouEmAlgumBotao);
                    botoes[x, y].Width = 25;
                }
            }
            #endregion
        }

        public Form1()
        {
            InitializeComponent();
            iniciarComponentes();
        }

        public void clicouNoBotaozinho(object sender, EventArgs e)
        {
           // labelzinho.Text = caixinhaDeTexto.Text;
        }

        public void clicouEmAlgumBotao(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no " + ((Button)sender).Text);
        }
    }

}
