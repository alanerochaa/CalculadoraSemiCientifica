namespace CalculadoraSemiCientifica
{
    partial class FormSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloSobre = new System.Windows.Forms.Label();
            this.lblTituloResumo = new System.Windows.Forms.Label();
            this.lblResumo = new System.Windows.Forms.Label();
            this.lblTituloIntegrantes = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblTituloGitHub = new System.Windows.Forms.Label();
            this.lblGitHub = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // lblTituloSobre
            // 
            this.lblTituloSobre.AutoSize = true;
            this.lblTituloSobre.BackColor = System.Drawing.Color.Violet;
            this.lblTituloSobre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSobre.Location = new System.Drawing.Point(252, 9);
            this.lblTituloSobre.Name = "lblTituloSobre";
            this.lblTituloSobre.Size = new System.Drawing.Size(135, 18);
            this.lblTituloSobre.TabIndex = 1;
            this.lblTituloSobre.Text = "💡 Sobre o Projeto";
            this.lblTituloSobre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTituloResumo
            // 
            this.lblTituloResumo.AutoSize = true;
            this.lblTituloResumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTituloResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResumo.Location = new System.Drawing.Point(29, 57);
            this.lblTituloResumo.Name = "lblTituloResumo";
            this.lblTituloResumo.Size = new System.Drawing.Size(157, 16);
            this.lblTituloResumo.TabIndex = 2;
            this.lblTituloResumo.Text = "📝 Resumo do Projeto";
            this.lblTituloResumo.Click += new System.EventHandler(this.lblTituloResumo_Click);
            // 
            // lblResumo
            // 
            this.lblResumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblResumo.Location = new System.Drawing.Point(45, 113);
            this.lblResumo.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(499, 272);
            this.lblResumo.TabIndex = 3;
            this.lblResumo.Text = resources.GetString("lblResumo.Text");
            this.lblResumo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTituloIntegrantes
            // 
            this.lblTituloIntegrantes.AutoSize = true;
            this.lblTituloIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTituloIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIntegrantes.Location = new System.Drawing.Point(27, 437);
            this.lblTituloIntegrantes.Name = "lblTituloIntegrantes";
            this.lblTituloIntegrantes.Size = new System.Drawing.Size(101, 16);
            this.lblTituloIntegrantes.TabIndex = 4;
            this.lblTituloIntegrantes.Text = "👩‍💻 Integrantes";
            this.lblTituloIntegrantes.Click += new System.EventHandler(this.lblTituloIntegrantes_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIntegrantes.Location = new System.Drawing.Point(45, 494);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(272, 68);
            this.lblIntegrantes.TabIndex = 5;
            this.lblIntegrantes.Text = "Alane Rocha Da Silva - RM561052\r\n\r\nMaria Eduarda Araujo Penas - RM560944\r\n\r\n";
            this.lblIntegrantes.Click += new System.EventHandler(this.lblIntegrantes_Click);
            // 
            // lblTituloGitHub
            // 
            this.lblTituloGitHub.AutoSize = true;
            this.lblTituloGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTituloGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGitHub.Location = new System.Drawing.Point(27, 607);
            this.lblTituloGitHub.Name = "lblTituloGitHub";
            this.lblTituloGitHub.Size = new System.Drawing.Size(199, 16);
            this.lblTituloGitHub.TabIndex = 8;
            this.lblTituloGitHub.Text = "🔗 Link do projeto no GitHub";
            this.lblTituloGitHub.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblGitHub.ForeColor = System.Drawing.Color.Blue;
            this.lblGitHub.Location = new System.Drawing.Point(45, 655);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(211, 34);
            this.lblGitHub.TabIndex = 9;
            this.lblGitHub.Text = "[https://github.com/alanerochaa]\r\n\r\n";
            this.lblGitHub.Click += new System.EventHandler(this.lblGitHub_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(588, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(72, 24);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(662, 718);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.lblTituloGitHub);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblTituloIntegrantes);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lblTituloResumo);
            this.Controls.Add(this.lblTituloSobre);
            this.Controls.Add(this.label1);
            this.Name = "FormSobre";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.FormSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloSobre;
        private System.Windows.Forms.Label lblTituloResumo;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblTituloIntegrantes;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblTituloGitHub;
        private System.Windows.Forms.Label lblGitHub;
        private System.Windows.Forms.Button btnFechar;
    }
}