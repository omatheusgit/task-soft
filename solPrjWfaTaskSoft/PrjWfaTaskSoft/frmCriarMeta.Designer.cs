namespace PrjWfaTaskSoft
{
    partial class frmCriarMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarMeta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNomeFunc = new System.Windows.Forms.ComboBox();
            this.dtpPrazoMeta = new System.Windows.Forms.DateTimePicker();
            this.rtbDescricaoMeta = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnInserirMetas = new System.Windows.Forms.Button();
            this.btnLimparMetas = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNomeFunc);
            this.groupBox1.Controls.Add(this.dtpPrazoMeta);
            this.groupBox1.Controls.Add(this.rtbDescricaoMeta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(362, 426);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da meta";
            // 
            // cboNomeFunc
            // 
            this.cboNomeFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeFunc.FormattingEnabled = true;
            this.cboNomeFunc.Location = new System.Drawing.Point(10, 55);
            this.cboNomeFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNomeFunc.Name = "cboNomeFunc";
            this.cboNomeFunc.Size = new System.Drawing.Size(331, 24);
            this.cboNomeFunc.TabIndex = 0;
            // 
            // dtpPrazoMeta
            // 
            this.dtpPrazoMeta.Location = new System.Drawing.Point(10, 130);
            this.dtpPrazoMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPrazoMeta.Name = "dtpPrazoMeta";
            this.dtpPrazoMeta.Size = new System.Drawing.Size(331, 22);
            this.dtpPrazoMeta.TabIndex = 1;
            // 
            // rtbDescricaoMeta
            // 
            this.rtbDescricaoMeta.Location = new System.Drawing.Point(10, 229);
            this.rtbDescricaoMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDescricaoMeta.MaxLength = 400;
            this.rtbDescricaoMeta.Name = "rtbDescricaoMeta";
            this.rtbDescricaoMeta.Size = new System.Drawing.Size(331, 175);
            this.rtbDescricaoMeta.TabIndex = 2;
            this.rtbDescricaoMeta.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Funcionário: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prazo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 10);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label14.Location = new System.Drawing.Point(14, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(364, 28);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cadastro de Metas";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInserirMetas
            // 
            this.btnInserirMetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInserirMetas.BackgroundImage")));
            this.btnInserirMetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserirMetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirMetas.ForeColor = System.Drawing.Color.White;
            this.btnInserirMetas.Location = new System.Drawing.Point(14, 516);
            this.btnInserirMetas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserirMetas.Name = "btnInserirMetas";
            this.btnInserirMetas.Size = new System.Drawing.Size(87, 28);
            this.btnInserirMetas.TabIndex = 0;
            this.btnInserirMetas.Text = "&Inserir";
            this.btnInserirMetas.UseVisualStyleBackColor = true;
            this.btnInserirMetas.Click += new System.EventHandler(this.btnInserirMetas_Click_1);
            // 
            // btnLimparMetas
            // 
            this.btnLimparMetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparMetas.BackgroundImage")));
            this.btnLimparMetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparMetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparMetas.ForeColor = System.Drawing.Color.White;
            this.btnLimparMetas.Location = new System.Drawing.Point(120, 516);
            this.btnLimparMetas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimparMetas.Name = "btnLimparMetas";
            this.btnLimparMetas.Size = new System.Drawing.Size(87, 28);
            this.btnLimparMetas.TabIndex = 1;
            this.btnLimparMetas.Text = "&Limpar";
            this.btnLimparMetas.UseVisualStyleBackColor = true;
            this.btnLimparMetas.Click += new System.EventHandler(this.btnLimparMetas_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(288, 516);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 28);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCriarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 556);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnInserirMetas);
            this.Controls.Add(this.btnLimparMetas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCriarMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnInserirMetas;
        private System.Windows.Forms.Button btnLimparMetas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNomeFunc;
        private System.Windows.Forms.DateTimePicker dtpPrazoMeta;
        private System.Windows.Forms.RichTextBox rtbDescricaoMeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}