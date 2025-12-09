namespace PrjWfaTaskSoft
{
    partial class frmConsultarUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsu));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbTelefone = new System.Windows.Forms.RadioButton();
            this.rdbCpf = new System.Windows.Forms.RadioButton();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbSet = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAlterarUsu = new System.Windows.Forms.Button();
            this.btnExcluirUsu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(681, 280);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(14, 176);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(952, 348);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(174, 118);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(108, 16);
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Buscar Usuários:";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.BackColor = System.Drawing.Color.Transparent;
            this.rdbNome.Location = new System.Drawing.Point(24, 23);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(60, 20);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = false;
            // 
            // rdbTelefone
            // 
            this.rdbTelefone.AutoSize = true;
            this.rdbTelefone.BackColor = System.Drawing.Color.Transparent;
            this.rdbTelefone.Location = new System.Drawing.Point(93, 23);
            this.rdbTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTelefone.Name = "rdbTelefone";
            this.rdbTelefone.Size = new System.Drawing.Size(73, 20);
            this.rdbTelefone.TabIndex = 2;
            this.rdbTelefone.TabStop = true;
            this.rdbTelefone.Text = "Telefone";
            this.rdbTelefone.UseVisualStyleBackColor = false;
            // 
            // rdbCpf
            // 
            this.rdbCpf.AutoSize = true;
            this.rdbCpf.BackColor = System.Drawing.Color.Transparent;
            this.rdbCpf.Location = new System.Drawing.Point(178, 23);
            this.rdbCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCpf.Name = "rdbCpf";
            this.rdbCpf.Size = new System.Drawing.Size(45, 20);
            this.rdbCpf.TabIndex = 3;
            this.rdbCpf.TabStop = true;
            this.rdbCpf.Text = "Cpf";
            this.rdbCpf.UseVisualStyleBackColor = false;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(10, 47);
            this.txtConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(356, 22);
            this.txtConsultar.TabIndex = 0;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            this.txtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.branquin;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rdbTipo);
            this.groupBox1.Controls.Add(this.rdbSet);
            this.groupBox1.Controls.Add(this.rdbTelefone);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.rdbCpf);
            this.groupBox1.Controls.Add(this.txtConsultar);
            this.groupBox1.Location = new System.Drawing.Point(307, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Busca";
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.BackColor = System.Drawing.Color.Transparent;
            this.rdbTipo.Location = new System.Drawing.Point(299, 23);
            this.rdbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(50, 20);
            this.rdbTipo.TabIndex = 5;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = false;
            // 
            // rdbSet
            // 
            this.rdbSet.AutoSize = true;
            this.rdbSet.BackColor = System.Drawing.Color.Transparent;
            this.rdbSet.Location = new System.Drawing.Point(233, 23);
            this.rdbSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSet.Name = "rdbSet";
            this.rdbSet.Size = new System.Drawing.Size(57, 20);
            this.rdbSet.TabIndex = 4;
            this.rdbSet.TabStop = true;
            this.rdbSet.Text = "Setor";
            this.rdbSet.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consulta de Usuários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAlterarUsu
            // 
            this.btnAlterarUsu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarUsu.BackgroundImage")));
            this.btnAlterarUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarUsu.ForeColor = System.Drawing.Color.White;
            this.btnAlterarUsu.Location = new System.Drawing.Point(120, 551);
            this.btnAlterarUsu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarUsu.Name = "btnAlterarUsu";
            this.btnAlterarUsu.Size = new System.Drawing.Size(133, 28);
            this.btnAlterarUsu.TabIndex = 2;
            this.btnAlterarUsu.Text = "&Alterar Usuário";
            this.btnAlterarUsu.UseVisualStyleBackColor = true;
            this.btnAlterarUsu.Click += new System.EventHandler(this.btnAlterarUsu_Click);
            // 
            // btnExcluirUsu
            // 
            this.btnExcluirUsu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirUsu.BackgroundImage")));
            this.btnExcluirUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsu.ForeColor = System.Drawing.Color.White;
            this.btnExcluirUsu.Location = new System.Drawing.Point(272, 551);
            this.btnExcluirUsu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirUsu.Name = "btnExcluirUsu";
            this.btnExcluirUsu.Size = new System.Drawing.Size(133, 28);
            this.btnExcluirUsu.TabIndex = 3;
            this.btnExcluirUsu.Text = "&Excluir Usuário";
            this.btnExcluirUsu.UseVisualStyleBackColor = true;
            this.btnExcluirUsu.Click += new System.EventHandler(this.btnExcluirUsu_Click);
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
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "&Voltar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmConsultarUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAlterarUsu);
            this.Controls.Add(this.btnExcluirUsu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultarUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuários";
            this.Load += new System.EventHandler(this.frmConsultarUsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbTelefone;
        private System.Windows.Forms.RadioButton rdbCpf;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirUsu;
        private System.Windows.Forms.Button btnAlterarUsu;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbSet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}