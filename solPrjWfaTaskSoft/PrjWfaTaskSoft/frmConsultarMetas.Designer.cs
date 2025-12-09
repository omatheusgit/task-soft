namespace PrjWfaTaskSoft
{
    partial class frmConsultarMetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarMetas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDataMeta = new System.Windows.Forms.RadioButton();
            this.rdbNomeMeta = new System.Windows.Forms.RadioButton();
            this.txtConsultarMeta = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvMetas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarMetas = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluirMetas = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.branquin;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rdbDataMeta);
            this.groupBox1.Controls.Add(this.rdbNomeMeta);
            this.groupBox1.Controls.Add(this.txtConsultarMeta);
            this.groupBox1.Location = new System.Drawing.Point(333, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 86);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Buscas";
            // 
            // rdbDataMeta
            // 
            this.rdbDataMeta.AutoSize = true;
            this.rdbDataMeta.BackColor = System.Drawing.Color.Transparent;
            this.rdbDataMeta.Location = new System.Drawing.Point(208, 18);
            this.rdbDataMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDataMeta.Name = "rdbDataMeta";
            this.rdbDataMeta.Size = new System.Drawing.Size(53, 20);
            this.rdbDataMeta.TabIndex = 6;
            this.rdbDataMeta.TabStop = true;
            this.rdbDataMeta.Text = "Data";
            this.rdbDataMeta.UseVisualStyleBackColor = false;
            // 
            // rdbNomeMeta
            // 
            this.rdbNomeMeta.AutoSize = true;
            this.rdbNomeMeta.BackColor = System.Drawing.Color.Transparent;
            this.rdbNomeMeta.Location = new System.Drawing.Point(115, 18);
            this.rdbNomeMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNomeMeta.Name = "rdbNomeMeta";
            this.rdbNomeMeta.Size = new System.Drawing.Size(84, 20);
            this.rdbNomeMeta.TabIndex = 1;
            this.rdbNomeMeta.TabStop = true;
            this.rdbNomeMeta.Text = "Descrição";
            this.rdbNomeMeta.UseVisualStyleBackColor = false;
            // 
            // txtConsultarMeta
            // 
            this.txtConsultarMeta.Location = new System.Drawing.Point(10, 47);
            this.txtConsultarMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultarMeta.Name = "txtConsultarMeta";
            this.txtConsultarMeta.Size = new System.Drawing.Size(356, 22);
            this.txtConsultarMeta.TabIndex = 5;
            this.txtConsultarMeta.TextChanged += new System.EventHandler(this.txtConsultarMeta_TextChanged);
            this.txtConsultarMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarMeta_KeyPress);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(199, 114);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(93, 16);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Buscar Metas:";
            // 
            // dgvMetas
            // 
            this.dgvMetas.AllowUserToAddRows = false;
            this.dgvMetas.AllowUserToDeleteRows = false;
            this.dgvMetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMetas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetas.Location = new System.Drawing.Point(14, 176);
            this.dgvMetas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMetas.Name = "dgvMetas";
            this.dgvMetas.ReadOnly = true;
            this.dgvMetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetas.Size = new System.Drawing.Size(952, 348);
            this.dgvMetas.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 10);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(421, 551);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(133, 28);
            this.btnRelatorio.TabIndex = 24;
            this.btnRelatorio.Text = "Imprimir &Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Consulta de Metas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlterarMetas
            // 
            this.btnAlterarMetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarMetas.BackgroundImage")));
            this.btnAlterarMetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarMetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarMetas.ForeColor = System.Drawing.Color.White;
            this.btnAlterarMetas.Location = new System.Drawing.Point(120, 551);
            this.btnAlterarMetas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarMetas.Name = "btnAlterarMetas";
            this.btnAlterarMetas.Size = new System.Drawing.Size(133, 28);
            this.btnAlterarMetas.TabIndex = 20;
            this.btnAlterarMetas.Text = "&Alterar Meta";
            this.btnAlterarMetas.UseVisualStyleBackColor = true;
            this.btnAlterarMetas.Click += new System.EventHandler(this.btnAlterarMetas_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(14, 551);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 28);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluirMetas
            // 
            this.btnExcluirMetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirMetas.BackgroundImage")));
            this.btnExcluirMetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirMetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirMetas.ForeColor = System.Drawing.Color.White;
            this.btnExcluirMetas.Location = new System.Drawing.Point(272, 551);
            this.btnExcluirMetas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirMetas.Name = "btnExcluirMetas";
            this.btnExcluirMetas.Size = new System.Drawing.Size(133, 28);
            this.btnExcluirMetas.TabIndex = 19;
            this.btnExcluirMetas.Text = "&Excluir Meta";
            this.btnExcluirMetas.UseVisualStyleBackColor = true;
            this.btnExcluirMetas.Click += new System.EventHandler(this.btnExcluirMetas_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(878, 551);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 28);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "&Voltar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // frmConsultarMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarMetas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluirMetas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvMetas);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultarMetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConsultarMetas_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarMetas;
        private System.Windows.Forms.Button btnExcluirMetas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDataMeta;
        private System.Windows.Forms.RadioButton rdbNomeMeta;
        private System.Windows.Forms.TextBox txtConsultarMeta;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvMetas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}