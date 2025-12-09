namespace PrjWfaTaskSoft
{
    partial class frmAlterarGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarGasto));
            this.gpbGasto = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGasto
            // 
            this.gpbGasto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbGasto.Controls.Add(this.txtData);
            this.gpbGasto.Controls.Add(this.txtValor);
            this.gpbGasto.Controls.Add(this.txtCodigo);
            this.gpbGasto.Controls.Add(this.lblValor);
            this.gpbGasto.Controls.Add(this.lblData);
            this.gpbGasto.Controls.Add(this.lblCodigo);
            this.gpbGasto.Location = new System.Drawing.Point(14, 58);
            this.gpbGasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbGasto.Name = "gpbGasto";
            this.gpbGasto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbGasto.Size = new System.Drawing.Size(478, 130);
            this.gpbGasto.TabIndex = 1;
            this.gpbGasto.TabStop = false;
            this.gpbGasto.Text = "Gastos";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(198, 69);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.MaxLength = 13;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(116, 22);
            this.txtValor.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(54, 69);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(195, 37);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 28);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(338, 37);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 28);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(50, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 28);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(341, 69);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(79, 22);
            this.txtData.TabIndex = 2;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 10);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(405, 212);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 28);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "&Voltar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(14, 212);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 28);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Alterar Gastos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAlterarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(506, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbGasto);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarGasto";
            this.gpbGasto.ResumeLayout(false);
            this.gpbGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGasto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}