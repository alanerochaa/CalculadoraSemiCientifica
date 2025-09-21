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
            // O código de inicialização do formulário já é gerado
            // automaticamente pelo InitializeComponent().
            // Você pode deixar este método vazio ou adicionar código
            // adicional, se necessário.
        }

        // Os métodos de evento abaixo são essenciais para o funcionamento.
        // Mantenha apenas aqueles que estão vinculados a um componente.
        // lblGitHub_Click, btnFechar_Click, lblTituloResumo_Click,
        // lblTituloIntegrantes_Click, lblTituloGitHub_Click.

        private void lblGitHub_Click(object sender, EventArgs e)
        {
            // Este evento abre o link do GitHub.
            System.Diagnostics.Process.Start("https://github.com/alanerochaa/CalculadoraSemiCientifica");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Este evento fecha o formulário.
            this.Close();
        }

        // Os métodos a seguir estavam no seu Designer.cs, então foram mantidos.
        private void lblTituloResumo_Click(object sender, EventArgs e)
        {
            // Este evento está vazio no seu código.
        }

        private void lblTituloIntegrantes_Click(object sender, EventArgs e)
        {
            // Este evento está vazio no seu código.
        }

        private void lblTituloGitHub_Click(object sender, EventArgs e)
        {
            // Este evento está vazio no seu código.
        }

        // **IMPORTANTE**: Os eventos label2_Click, label3_Click e label4_Click
        // devem ser removidos, pois não estão vinculados a nenhum componente
        // no Designer.cs e causam o erro.

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void lblIntegrantes_Click(object sender, EventArgs e) { }
    }
}