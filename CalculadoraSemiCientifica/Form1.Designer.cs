namespace CalculadoraSemiCientifica
{
    partial class Calculadora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnXY = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(31, 103);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(70, 70);
            this.btnPorcentagem.TabIndex = 16;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(109, 103);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(70, 70);
            this.btnRaiz.TabIndex = 15;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnXY
            // 
            this.btnXY.Location = new System.Drawing.Point(187, 103);
            this.btnXY.Name = "btnXY";
            this.btnXY.Size = new System.Drawing.Size(70, 70);
            this.btnXY.TabIndex = 14;
            this.btnXY.Text = "x^y";
            this.btnXY.UseVisualStyleBackColor = true;
            this.btnXY.Click += new System.EventHandler(this.btnXY_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(265, 103);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 70);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.Violet;
            this.btnBackspace.Location = new System.Drawing.Point(343, 103);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(70, 70);
            this.btnBackspace.TabIndex = 20;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(31, 181);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(109, 181);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(187, 181);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Violet;
            this.btnDivisao.Location = new System.Drawing.Point(343, 181);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(70, 70);
            this.btnDivisao.TabIndex = 12;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(31, 259);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(109, 259);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(187, 259);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.Violet;
            this.btnMultiplicacao.Location = new System.Drawing.Point(343, 259);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(70, 70);
            this.btnMultiplicacao.TabIndex = 11;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 337);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(109, 337);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(187, 337);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Violet;
            this.btnSoma.Location = new System.Drawing.Point(265, 337);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(70, 70);
            this.btnSoma.TabIndex = 21;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.Violet;
            this.btnSubtracao.Location = new System.Drawing.Point(343, 337);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(70, 70);
            this.btnSubtracao.TabIndex = 17;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(31, 415);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(109, 415);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(70, 70);
            this.btnPonto.TabIndex = 7;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(187, 415);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(226, 70);
            this.btnIgual.TabIndex = 6;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.Location = new System.Drawing.Point(31, 58);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(388, 22);
            this.txtVisor.TabIndex = 1;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged_1);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(369, 38);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(0, 16);
            this.lblHistorico.TabIndex = 22;
            this.lblHistorico.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(451, 502);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnXY);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorcentagem);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnXY;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Label lblHistorico;
    }
}