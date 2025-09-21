using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSemiCientifica
{
    public partial class Calculadora : Form
    {
        // Variáveis de estado da calculadora
        double primeiroNumero = 0;
        string operacao = "";
        bool novaDigitacao = true;

        public Calculadora()
        {
            InitializeComponent();
            txtVisor.Text = "0";
            lblHistorico.Text = "";

            // Cria o botão "Sobre" ao iniciar
            CriarBotaoSobre();
        }

        // --- BOTÃO SOBRE ---
        private void CriarBotaoSobre()
        {
            Button btnSobre = new Button();
            btnSobre.Text = "Sobre";
            btnSobre.Size = new Size(80, 30);
            btnSobre.Location = new Point(10, 10); // canto superior esquerdo
            btnSobre.Click += BtnSobre_Click;

            this.Controls.Add(btnSobre);
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            FormSobre sobre = new FormSobre();
            sobre.ShowDialog(); // abre como modal
        }

        // --- MÉTODOS PARA OS BOTÕES NUMÉRICOS E OPERACIONAIS ---
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (novaDigitacao)
            {
                txtVisor.Text = "";
                novaDigitacao = false;
            }

            if (btn.Text == "." && txtVisor.Text.Contains(".")) return;

            if (txtVisor.Text == "0" && btn.Text != ".")
                txtVisor.Text = btn.Text;
            else
                txtVisor.Text += btn.Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (operacao != "" && !novaDigitacao)
            {
                double segundoNumero = Convert.ToDouble(txtVisor.Text);
                switch (operacao)
                {
                    case "+": primeiroNumero += segundoNumero; break;
                    case "-": primeiroNumero -= segundoNumero; break;
                    case "x": primeiroNumero *= segundoNumero; break;
                    case "/":
                        if (segundoNumero != 0) primeiroNumero /= segundoNumero;
                        else { txtVisor.Text = "Divisão por Zero"; return; }
                        break;
                    case "x^y": primeiroNumero = Math.Pow(primeiroNumero, segundoNumero); break;
                }
                lblHistorico.Text = primeiroNumero.ToString() + " " + btn.Text;
                txtVisor.Text = primeiroNumero.ToString();
            }
            else
            {
                primeiroNumero = Convert.ToDouble(txtVisor.Text);
                lblHistorico.Text = primeiroNumero.ToString() + " " + btn.Text;
            }

            operacao = btn.Text;
            novaDigitacao = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "") return;

            double segundoNumero = Convert.ToDouble(txtVisor.Text);
            double resultado = 0;
            string expressaoCompleta = lblHistorico.Text + " " + segundoNumero.ToString() + " =";

            switch (operacao)
            {
                case "+": resultado = primeiroNumero + segundoNumero; break;
                case "-": resultado = primeiroNumero - segundoNumero; break;
                case "x": resultado = primeiroNumero * segundoNumero; break;
                case "/":
                    if (segundoNumero != 0) resultado = primeiroNumero / segundoNumero;
                    else { txtVisor.Text = "Divisão por Zero"; return; }
                    break;
                case "x^y": resultado = Math.Pow(primeiroNumero, segundoNumero); break;
            }

            lblHistorico.Text = expressaoCompleta;
            txtVisor.Text = resultado.ToString();
            primeiroNumero = resultado;
            operacao = "";
            novaDigitacao = true;
        }

        // --- OUTROS MÉTODOS ---
        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            lblHistorico.Text = "";
            primeiroNumero = 0;
            operacao = "";
            novaDigitacao = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtVisor.Text);
            lblHistorico.Text = $"√({numero})";
            double resultado = Math.Sqrt(numero);
            txtVisor.Text = resultado.ToString();
            primeiroNumero = resultado;
            novaDigitacao = true;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtVisor.Text);
            lblHistorico.Text = $"{numero}%";
            double resultado = numero / 100;
            txtVisor.Text = resultado.ToString();
            primeiroNumero = resultado;
            novaDigitacao = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 1) txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
            else { txtVisor.Text = "0"; novaDigitacao = true; }
        }

        private void btnXY_Click(object sender, EventArgs e)
        {
            primeiroNumero = Convert.ToDouble(txtVisor.Text);
            operacao = "x^y";
            novaDigitacao = true;
            lblHistorico.Text = primeiroNumero.ToString() + " " + operacao;
        }

        private void btnAoQuadrado_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtVisor.Text);
            lblHistorico.Text = $"{numero}²";
            txtVisor.Text = Math.Pow(numero, 2).ToString();
            primeiroNumero = Convert.ToDouble(txtVisor.Text);
            novaDigitacao = true;
        }

        private void txtVisor_TextChanged(object sender, EventArgs e) { }
        private void lblHistorico_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Calculadora_Load(object sender, EventArgs e) { }
        private void txtVisor_TextChanged_1(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSobre sobre = new FormSobre();

            sobre.ShowDialog();

        }
    }
}
