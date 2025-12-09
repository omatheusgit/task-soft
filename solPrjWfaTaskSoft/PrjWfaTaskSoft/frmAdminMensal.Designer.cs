namespace PrjWfaTaskSoft
{
    partial class frmAdminMensal
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
            this.dgvGastosA = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbBusca = new System.Windows.Forms.GroupBox();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbSetor = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastosA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGastosA
            // 
            this.dgvGastosA.AllowUserToAddRows = false;
            this.dgvGastosA.AllowUserToDeleteRows = false;
            this.dgvGastosA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastosA.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastosA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGastosA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvGastosA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastosA.Location = new System.Drawing.Point(148, 175);
            this.dgvGastosA.Name = "dgvGastosA";
            this.dgvGastosA.ReadOnly = true;
            this.dgvGastosA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGastosA.Size = new System.Drawing.Size(679, 340);
            this.dgvGastosA.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(194, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Buscar Gastos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.Logo_VERDE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 10);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // gpbBusca
            // 
            this.gpbBusca.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.branquin;
            this.gpbBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbBusca.Controls.Add(this.rdbValor);
            this.gpbBusca.Controls.Add(this.rdbData);
            this.gpbBusca.Controls.Add(this.rdbSetor);
            this.gpbBusca.Controls.Add(this.txtFiltro);
            this.gpbBusca.Location = new System.Drawing.Point(324, 84);
            this.gpbBusca.Name = "gpbBusca";
            this.gpbBusca.Size = new System.Drawing.Size(344, 85);
            this.gpbBusca.TabIndex = 26;
            this.gpbBusca.TabStop = false;
            this.gpbBusca.Text = "Tipos de Busca";
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.BackColor = System.Drawing.Color.Transparent;
            this.rdbValor.Location = new System.Drawing.Point(223, 21);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(94, 20);
            this.rdbValor.TabIndex = 3;
            this.rdbValor.TabStop = true;
            this.rdbValor.Text = "Valor Gasto";
            this.rdbValor.UseVisualStyleBackColor = false;
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.BackColor = System.Drawing.Color.Transparent;
            this.rdbData.Location = new System.Drawing.Point(130, 21);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(53, 20);
            this.rdbData.TabIndex = 2;
            this.rdbData.TabStop = true;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = false;
            // 
            // rdbSetor
            // 
            this.rdbSetor.AutoSize = true;
            this.rdbSetor.BackColor = System.Drawing.Color.Transparent;
            this.rdbSetor.Location = new System.Drawing.Point(31, 21);
            this.rdbSetor.Name = "rdbSetor";
            this.rdbSetor.Size = new System.Drawing.Size(57, 20);
            this.rdbSetor.TabIndex = 1;
            this.rdbSetor.TabStop = true;
            this.rdbSetor.Text = "Setor";
            this.rdbSetor.UseVisualStyleBackColor = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(20, 47);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(307, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(878, 551);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 28);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.label1.Text = "Consulta de Gastos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbBusca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvGastosA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminMensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMensal";
            this.Load += new System.EventHandler(this.frmAdminMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastosA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbBusca.ResumeLayout(false);
            this.gpbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGastosA;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rdbSetor;
        private System.Windows.Forms.RadioButton rdbValor;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}