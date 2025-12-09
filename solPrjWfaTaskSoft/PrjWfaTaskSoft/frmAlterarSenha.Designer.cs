namespace PrjWfaTaskSoft
{
    partial class frmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenhaA = new System.Windows.Forms.Label();
            this.lblSenhaN = new System.Windows.Forms.Label();
            this.lblSenhaC = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaA = new System.Windows.Forms.TextBox();
            this.txtSenhaN = new System.Windows.Forms.TextBox();
            this.txtSenhaC = new System.Windows.Forms.TextBox();
            this.gpbSenha = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(100, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenhaA
            // 
            this.lblSenhaA.AutoSize = true;
            this.lblSenhaA.Location = new System.Drawing.Point(69, 84);
            this.lblSenhaA.Name = "lblSenhaA";
            this.lblSenhaA.Size = new System.Drawing.Size(88, 16);
            this.lblSenhaA.TabIndex = 2;
            this.lblSenhaA.Text = "Senha antiga:";
            // 
            // lblSenhaN
            // 
            this.lblSenhaN.AutoSize = true;
            this.lblSenhaN.Location = new System.Drawing.Point(75, 128);
            this.lblSenhaN.Name = "lblSenhaN";
            this.lblSenhaN.Size = new System.Drawing.Size(79, 16);
            this.lblSenhaN.TabIndex = 3;
            this.lblSenhaN.Text = "Nova senha:";
            // 
            // lblSenhaC
            // 
            this.lblSenhaC.AutoSize = true;
            this.lblSenhaC.Location = new System.Drawing.Point(54, 174);
            this.lblSenhaC.Name = "lblSenhaC";
            this.lblSenhaC.Size = new System.Drawing.Size(106, 16);
            this.lblSenhaC.TabIndex = 4;
            this.lblSenhaC.Text = "Confirmar senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(166, 37);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenhaA
            // 
            this.txtSenhaA.Location = new System.Drawing.Point(166, 80);
            this.txtSenhaA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenhaA.MaxLength = 10;
            this.txtSenhaA.Name = "txtSenhaA";
            this.txtSenhaA.Size = new System.Drawing.Size(143, 22);
            this.txtSenhaA.TabIndex = 1;
            this.txtSenhaA.UseSystemPasswordChar = true;
            // 
            // txtSenhaN
            // 
            this.txtSenhaN.Location = new System.Drawing.Point(166, 124);
            this.txtSenhaN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenhaN.MaxLength = 10;
            this.txtSenhaN.Name = "txtSenhaN";
            this.txtSenhaN.Size = new System.Drawing.Size(143, 22);
            this.txtSenhaN.TabIndex = 2;
            this.txtSenhaN.UseSystemPasswordChar = true;
            // 
            // txtSenhaC
            // 
            this.txtSenhaC.Location = new System.Drawing.Point(166, 170);
            this.txtSenhaC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenhaC.MaxLength = 10;
            this.txtSenhaC.Name = "txtSenhaC";
            this.txtSenhaC.Size = new System.Drawing.Size(143, 22);
            this.txtSenhaC.TabIndex = 3;
            this.txtSenhaC.UseSystemPasswordChar = true;
            // 
            // gpbSenha
            // 
            this.gpbSenha.Controls.Add(this.txtSenhaN);
            this.gpbSenha.Controls.Add(this.lblUsuario);
            this.gpbSenha.Controls.Add(this.txtSenhaC);
            this.gpbSenha.Controls.Add(this.lblSenhaA);
            this.gpbSenha.Controls.Add(this.lblSenhaN);
            this.gpbSenha.Controls.Add(this.txtSenhaA);
            this.gpbSenha.Controls.Add(this.lblSenhaC);
            this.gpbSenha.Controls.Add(this.txtUsuario);
            this.gpbSenha.Location = new System.Drawing.Point(14, 55);
            this.gpbSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbSenha.Name = "gpbSenha";
            this.gpbSenha.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbSenha.Size = new System.Drawing.Size(402, 230);
            this.gpbSenha.TabIndex = 0;
            this.gpbSenha.TabStop = false;
            this.gpbSenha.Text = "Dados da Conta";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Alterar Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(149, 305);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 28);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(14, 305);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 28);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "&Alterar Senha";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(331, 305);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 28);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&Voltar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 10);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(430, 348);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpbSenha);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.frmAlterarSenha_Load);
            this.gpbSenha.ResumeLayout(false);
            this.gpbSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenhaA;
        private System.Windows.Forms.Label lblSenhaN;
        private System.Windows.Forms.Label lblSenhaC;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenhaA;
        private System.Windows.Forms.TextBox txtSenhaN;
        private System.Windows.Forms.TextBox txtSenhaC;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}