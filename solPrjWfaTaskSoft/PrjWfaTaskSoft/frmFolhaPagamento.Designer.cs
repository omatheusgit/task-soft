namespace PrjWfaTaskSoft
{
    partial class frmFolhaPagamento
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
            this.dgvConsultaSalario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtComissão = new System.Windows.Forms.TextBox();
            this.btnGerarSalComissionado = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaSalario
            // 
            this.dgvConsultaSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSalario.Location = new System.Drawing.Point(12, 25);
            this.dgvConsultaSalario.Name = "dgvConsultaSalario";
            this.dgvConsultaSalario.Size = new System.Drawing.Size(720, 214);
            this.dgvConsultaSalario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "% de comissão";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Enabled = false;
            this.txtSalBruto.Location = new System.Drawing.Point(12, 281);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalBruto.TabIndex = 6;
            // 
            // txtComissão
            // 
            this.txtComissão.Location = new System.Drawing.Point(129, 281);
            this.txtComissão.Name = "txtComissão";
            this.txtComissão.Size = new System.Drawing.Size(100, 20);
            this.txtComissão.TabIndex = 7;
            // 
            // btnGerarSalComissionado
            // 
            this.btnGerarSalComissionado.Location = new System.Drawing.Point(254, 279);
            this.btnGerarSalComissionado.Name = "btnGerarSalComissionado";
            this.btnGerarSalComissionado.Size = new System.Drawing.Size(145, 23);
            this.btnGerarSalComissionado.TabIndex = 8;
            this.btnGerarSalComissionado.Text = "Gerar salário comissionado";
            this.btnGerarSalComissionado.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(415, 279);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorio.TabIndex = 9;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(662, 278);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 313);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnGerarSalComissionado);
            this.Controls.Add(this.txtComissão);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsultaSalario);
            this.Name = "frmFolhaPagamento";
            this.Text = "frmFolhaPagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.TextBox txtComissão;
        private System.Windows.Forms.Button btnGerarSalComissionado;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnFechar;
    }
}