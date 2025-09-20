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
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void FormSobre_Load(object sender, EventArgs e)
        {
            // Título da janela
            this.Text = "Sobre o Projeto";

            // Cor de fundo
            this.BackColor = Color.Lavender;

            // Criando e configurando os Labels para as informações
            // Título do Resumo
            Label lblTituloResumo = new Label();
            lblTituloResumo.Text = "Resumo do Projeto";
            lblTituloResumo.Location = new Point(20, 20);
            lblTituloResumo.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTituloResumo.AutoSize = true;
            this.Controls.Add(lblTituloResumo);

            // Resumo do projeto
            Label lblResumo = new Label();
            lblResumo.Text = "Este projeto consiste em uma calculadora semi-científica desenvolvida em C# utilizando o Visual Studio 2022. A aplicação do tipo Windows Forms foi criada para executar operações aritméticas básicas como soma, subtração, multiplicação e divisão. Além disso, a calculadora inclui funcionalidades semi-científicas como raiz quadrada e potência (x^y). O design foi pensado para ser intuitivo e profissional, com uma interface que separa o histórico da operação do resultado principal.";
            lblResumo.Location = new Point(20, 50);
            lblResumo.Font = new Font("Arial", 10, FontStyle.Regular);
            lblResumo.MaximumSize = new Size(360, 0); // Ajusta a largura para o texto quebrar a linha
            lblResumo.AutoSize = true;
            this.Controls.Add(lblResumo);

            // Título dos Integrantes
            Label lblTituloIntegrantes = new Label();
            lblTituloIntegrantes.Text = "Integrantes";
            lblTituloIntegrantes.Location = new Point(20, 150);
            lblTituloIntegrantes.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTituloIntegrantes.AutoSize = true;
            this.Controls.Add(lblTituloIntegrantes);

            // Nomes dos integrantes
            Label lblIntegrantes = new Label();
            lblIntegrantes.Text = "Alane Rocha Da Silva - RM561052\nMaria Eduarda Araujo Penas - RM560944";
            lblIntegrantes.Location = new Point(20, 180);
            lblIntegrantes.Font = new Font("Arial", 10, FontStyle.Regular);
            lblIntegrantes.AutoSize = true;
            this.Controls.Add(lblIntegrantes);

            // Título do GitHub
            Label lblTituloGitHub = new Label();
            lblTituloGitHub.Text = "Link para o GitHub";
            lblTituloGitHub.Location = new Point(20, 240);
            lblTituloGitHub.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTituloGitHub.AutoSize = true;
            this.Controls.Add(lblTituloGitHub);

            // Link do GitHub
            Label lblGitHub = new Label();
            lblGitHub.Text = "[INSERIR LINK DO GITHUB AQUI]";
            lblGitHub.Location = new Point(20, 270);
            lblGitHub.Font = new Font("Arial", 10, FontStyle.Underline);
            lblGitHub.Cursor = Cursors.Hand;
            lblGitHub.ForeColor = Color.Blue;
            lblGitHub.AutoSize = true;
            this.Controls.Add(lblGitHub);

            // Adicionando um evento de clique para abrir o link
            lblGitHub.Click += (s, ev) => System.Diagnostics.Process.Start("https://github.com/SEU_USUARIO/SEU_REPOSITORIO");
        }
    }
}