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
            
        }

        private void lblGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alanerochaa/CalculadoraSemiCientifica");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTituloResumo_Click(object sender, EventArgs e)
        {
        }

        private void lblTituloIntegrantes_Click(object sender, EventArgs e)
        {
        }

        private void lblTituloGitHub_Click(object sender, EventArgs e)
        {
        }


        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void lblIntegrantes_Click(object sender, EventArgs e) { }
    }
}