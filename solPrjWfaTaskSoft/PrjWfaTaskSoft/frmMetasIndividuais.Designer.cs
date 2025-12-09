namespace PrjWfaTaskSoft
{
    partial class frmMetasIndividuais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetasIndividuais));
            this.dgvMetasIndividuais = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDataMetaIndi = new System.Windows.Forms.RadioButton();
            this.rdbDescricaoMetaIndi = new System.Windows.Forms.RadioButton();
            this.txtConsultarMetaIndi = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtChecarMeta = new System.Windows.Forms.Button();
            this.txtFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetasIndividuais)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMetasIndividuais
            // 
            this.dgvMetasIndividuais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetasIndividuais.BackgroundColor = System.Drawing.Color.White;
            this.dgvMetasIndividuais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMetasIndividuais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetasIndividuais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetasIndividuais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetasIndividuais.Location = new System.Drawing.Point(54, 176);
            this.dgvMetasIndividuais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMetasIndividuais.Name = "dgvMetasIndividuais";
            this.dgvMetasIndividuais.RowHeadersWidth = 100;
            this.dgvMetasIndividuais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetasIndividuais.Size = new System.Drawing.Size(869, 348);
            this.dgvMetasIndividuais.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.branquin;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rdbDataMetaIndi);
            this.groupBox1.Controls.Add(this.rdbDescricaoMetaIndi);
            this.groupBox1.Controls.Add(this.txtConsultarMetaIndi);
            this.groupBox1.Location = new System.Drawing.Point(334, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 86);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Buscas";
            // 
            // rdbDataMetaIndi
            // 
            this.rdbDataMetaIndi.AutoSize = true;
            this.rdbDataMetaIndi.BackColor = System.Drawing.Color.Transparent;
            this.rdbDataMetaIndi.Location = new System.Drawing.Point(191, 18);
            this.rdbDataMetaIndi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDataMetaIndi.Name = "rdbDataMetaIndi";
            this.rdbDataMetaIndi.Size = new System.Drawing.Size(53, 20);
            this.rdbDataMetaIndi.TabIndex = 6;
            this.rdbDataMetaIndi.TabStop = true;
            this.rdbDataMetaIndi.Text = "Data";
            this.rdbDataMetaIndi.UseVisualStyleBackColor = false;
            // 
            // rdbDescricaoMetaIndi
            // 
            this.rdbDescricaoMetaIndi.AutoSize = true;
            this.rdbDescricaoMetaIndi.BackColor = System.Drawing.Color.Transparent;
            this.rdbDescricaoMetaIndi.Location = new System.Drawing.Point(99, 18);
            this.rdbDescricaoMetaIndi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDescricaoMetaIndi.Name = "rdbDescricaoMetaIndi";
            this.rdbDescricaoMetaIndi.Size = new System.Drawing.Size(84, 20);
            this.rdbDescricaoMetaIndi.TabIndex = 1;
            this.rdbDescricaoMetaIndi.TabStop = true;
            this.rdbDescricaoMetaIndi.Text = "Descrição";
            this.rdbDescricaoMetaIndi.UseVisualStyleBackColor = false;
            // 
            // txtConsultarMetaIndi
            // 
            this.txtConsultarMetaIndi.Location = new System.Drawing.Point(10, 47);
            this.txtConsultarMetaIndi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultarMetaIndi.Name = "txtConsultarMetaIndi";
            this.txtConsultarMetaIndi.Size = new System.Drawing.Size(356, 22);
            this.txtConsultarMetaIndi.TabIndex = 5;
            this.txtConsultarMetaIndi.TextChanged += new System.EventHandler(this.txtConsultarMetaIndi_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(194, 133);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(93, 16);
            this.lblPesquisa.TabIndex = 25;
            this.lblPesquisa.Text = "Buscar Metas:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(54, 551);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 28);
            this.btnAtualizar.TabIndex = 31;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 10);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtChecarMeta
            // 
            this.txtChecarMeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtChecarMeta.BackgroundImage")));
            this.txtChecarMeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtChecarMeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtChecarMeta.ForeColor = System.Drawing.Color.White;
            this.txtChecarMeta.Location = new System.Drawing.Point(162, 551);
            this.txtChecarMeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChecarMeta.Name = "txtChecarMeta";
            this.txtChecarMeta.Size = new System.Drawing.Size(101, 28);
            this.txtChecarMeta.TabIndex = 28;
            this.txtChecarMeta.Text = "&Checar Meta";
            this.txtChecarMeta.UseVisualStyleBackColor = true;
            this.txtChecarMeta.Click += new System.EventHandler(this.txtChecarMeta_Click);
            // 
            // txtFechar
            // 
            this.txtFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFechar.BackgroundImage")));
            this.txtFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechar.ForeColor = System.Drawing.Color.White;
            this.txtFechar.Location = new System.Drawing.Point(835, 551);
            this.txtFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(87, 28);
            this.txtFechar.TabIndex = 27;
            this.txtFechar.Text = "&Voltar";
            this.txtFechar.UseVisualStyleBackColor = true;
            this.txtFechar.Click += new System.EventHandler(this.txtFechar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Minhas Metas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMetasIndividuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtChecarMeta);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMetasIndividuais);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMetasIndividuais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMetasIndividuais";
            this.Load += new System.EventHandler(this.frmMetasIndividuais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetasIndividuais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMetasIndividuais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDataMetaIndi;
        private System.Windows.Forms.RadioButton rdbDescricaoMetaIndi;
        private System.Windows.Forms.TextBox txtConsultarMetaIndi;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button txtChecarMeta;
        private System.Windows.Forms.Button txtFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}