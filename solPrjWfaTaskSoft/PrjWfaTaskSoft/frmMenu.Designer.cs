namespace PrjWfaTaskSoft
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.tspMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbMenu = new System.Windows.Forms.PictureBox();
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuGerUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGerUsuSubCriarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGerUsuSubConsultarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSetor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSetorSubDesen = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasMetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGerMetas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGerMetasSubCriarMetas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGerMetasSubConsulMetas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmpSubGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfgSubAlterSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.tssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbMenu)).BeginInit();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMenu
            // 
            this.tmrMenu.Enabled = true;
            this.tmrMenu.Interval = 1;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // tspMensagem
            // 
            resources.ApplyResources(this.tspMensagem, "tspMensagem");
            this.tspMensagem.ForeColor = System.Drawing.Color.White;
            this.tspMensagem.Name = "tspMensagem";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // tspData
            // 
            resources.ApplyResources(this.tspData, "tspData");
            this.tspData.ForeColor = System.Drawing.Color.White;
            this.tspData.Name = "tspData";
            // 
            // toolStripStatusLabel2
            // 
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            // 
            // tspHora
            // 
            resources.ApplyResources(this.tspHora, "tspHora");
            this.tspHora.ForeColor = System.Drawing.Color.White;
            this.tspHora.Name = "tspHora";
            // 
            // tssStatus
            // 
            resources.ApplyResources(this.tssStatus, "tssStatus");
            this.tssStatus.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.tssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMensagem,
            this.toolStripStatusLabel1,
            this.tspData,
            this.toolStripStatusLabel2,
            this.tspHora,
            this.toolStripStatusLabel3});
            this.tssStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // pgbMenu
            // 
            this.pgbMenu.Image = global::PrjWfaTaskSoft.Properties.Resources.Logo_01;
            resources.ApplyResources(this.pgbMenu, "pgbMenu");
            this.pgbMenu.Name = "pgbMenu";
            this.pgbMenu.TabStop = false;
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            resources.ApplyResources(this.mnsPrincipal, "mnsPrincipal");
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGerUsu,
            this.MnuSetor,
            this.minhasMetasToolStripMenuItem,
            this.mnuGerMetas,
            this.mnuEmpresa,
            this.mnuConfg,
            this.mnuLogoff});
            this.mnsPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // mnuGerUsu
            // 
            this.mnuGerUsu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGerUsuSubCriarUsu,
            this.MnuGerUsuSubConsultarUsu});
            resources.ApplyResources(this.mnuGerUsu, "mnuGerUsu");
            this.mnuGerUsu.ForeColor = System.Drawing.Color.White;
            this.mnuGerUsu.Name = "mnuGerUsu";
            // 
            // MnuGerUsuSubCriarUsu
            // 
            this.MnuGerUsuSubCriarUsu.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.MnuGerUsuSubCriarUsu.ForeColor = System.Drawing.Color.White;
            this.MnuGerUsuSubCriarUsu.Name = "MnuGerUsuSubCriarUsu";
            resources.ApplyResources(this.MnuGerUsuSubCriarUsu, "MnuGerUsuSubCriarUsu");
            this.MnuGerUsuSubCriarUsu.Click += new System.EventHandler(this.MnuGerUsuSubCriarUsu_Click);
            // 
            // MnuGerUsuSubConsultarUsu
            // 
            this.MnuGerUsuSubConsultarUsu.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.MnuGerUsuSubConsultarUsu.ForeColor = System.Drawing.Color.White;
            this.MnuGerUsuSubConsultarUsu.Name = "MnuGerUsuSubConsultarUsu";
            resources.ApplyResources(this.MnuGerUsuSubConsultarUsu, "MnuGerUsuSubConsultarUsu");
            this.MnuGerUsuSubConsultarUsu.Click += new System.EventHandler(this.MnuGerUsuSubConsultarUsu_Click);
            // 
            // MnuSetor
            // 
            this.MnuSetor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSetorSubDesen,
            this.consultarFuncionarioToolStripMenuItem});
            resources.ApplyResources(this.MnuSetor, "MnuSetor");
            this.MnuSetor.ForeColor = System.Drawing.Color.White;
            this.MnuSetor.Name = "MnuSetor";
            // 
            // MnuSetorSubDesen
            // 
            this.MnuSetorSubDesen.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.MnuSetorSubDesen.ForeColor = System.Drawing.Color.White;
            this.MnuSetorSubDesen.Name = "MnuSetorSubDesen";
            resources.ApplyResources(this.MnuSetorSubDesen, "MnuSetorSubDesen");
            this.MnuSetorSubDesen.Click += new System.EventHandler(this.MnuSetorSubDesen_Click);
            // 
            // consultarFuncionarioToolStripMenuItem
            // 
            this.consultarFuncionarioToolStripMenuItem.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.consultarFuncionarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarFuncionarioToolStripMenuItem.Name = "consultarFuncionarioToolStripMenuItem";
            resources.ApplyResources(this.consultarFuncionarioToolStripMenuItem, "consultarFuncionarioToolStripMenuItem");
            this.consultarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionarioToolStripMenuItem_Click);
            // 
            // minhasMetasToolStripMenuItem
            // 
            resources.ApplyResources(this.minhasMetasToolStripMenuItem, "minhasMetasToolStripMenuItem");
            this.minhasMetasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minhasMetasToolStripMenuItem.Name = "minhasMetasToolStripMenuItem";
            this.minhasMetasToolStripMenuItem.Click += new System.EventHandler(this.minhasMetasToolStripMenuItem_Click);
            // 
            // mnuGerMetas
            // 
            this.mnuGerMetas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGerMetasSubCriarMetas,
            this.mnuGerMetasSubConsulMetas});
            resources.ApplyResources(this.mnuGerMetas, "mnuGerMetas");
            this.mnuGerMetas.ForeColor = System.Drawing.Color.White;
            this.mnuGerMetas.Name = "mnuGerMetas";
            // 
            // mnuGerMetasSubCriarMetas
            // 
            this.mnuGerMetasSubCriarMetas.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.mnuGerMetasSubCriarMetas.ForeColor = System.Drawing.Color.White;
            this.mnuGerMetasSubCriarMetas.Name = "mnuGerMetasSubCriarMetas";
            resources.ApplyResources(this.mnuGerMetasSubCriarMetas, "mnuGerMetasSubCriarMetas");
            this.mnuGerMetasSubCriarMetas.Click += new System.EventHandler(this.mnuGerMetasSubCriarMetas_Click);
            // 
            // mnuGerMetasSubConsulMetas
            // 
            this.mnuGerMetasSubConsulMetas.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.mnuGerMetasSubConsulMetas.ForeColor = System.Drawing.Color.White;
            this.mnuGerMetasSubConsulMetas.Name = "mnuGerMetasSubConsulMetas";
            resources.ApplyResources(this.mnuGerMetasSubConsulMetas, "mnuGerMetasSubConsulMetas");
            this.mnuGerMetasSubConsulMetas.Click += new System.EventHandler(this.mnuGerMetasSubConsulMetas_Click);
            // 
            // mnuEmpresa
            // 
            this.mnuEmpresa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEmpSubGastos});
            this.mnuEmpresa.ForeColor = System.Drawing.Color.White;
            this.mnuEmpresa.Name = "mnuEmpresa";
            resources.ApplyResources(this.mnuEmpresa, "mnuEmpresa");
            // 
            // MnuEmpSubGastos
            // 
            this.MnuEmpSubGastos.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.MnuEmpSubGastos.ForeColor = System.Drawing.Color.White;
            this.MnuEmpSubGastos.Name = "MnuEmpSubGastos";
            resources.ApplyResources(this.MnuEmpSubGastos, "MnuEmpSubGastos");
            this.MnuEmpSubGastos.Click += new System.EventHandler(this.MnuEmpSubGastos_Click);
            // 
            // mnuConfg
            // 
            this.mnuConfg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfgSubAlterSenha});
            resources.ApplyResources(this.mnuConfg, "mnuConfg");
            this.mnuConfg.ForeColor = System.Drawing.Color.White;
            this.mnuConfg.Name = "mnuConfg";
            // 
            // mnuConfgSubAlterSenha
            // 
            this.mnuConfgSubAlterSenha.BackgroundImage = global::PrjWfaTaskSoft.Properties.Resources.banner1;
            this.mnuConfgSubAlterSenha.ForeColor = System.Drawing.Color.White;
            this.mnuConfgSubAlterSenha.Name = "mnuConfgSubAlterSenha";
            resources.ApplyResources(this.mnuConfgSubAlterSenha, "mnuConfgSubAlterSenha");
            this.mnuConfgSubAlterSenha.Click += new System.EventHandler(this.mnuConfgSubAlterSenha_Click);
            // 
            // mnuLogoff
            // 
            resources.ApplyResources(this.mnuLogoff, "mnuLogoff");
            this.mnuLogoff.ForeColor = System.Drawing.Color.White;
            this.mnuLogoff.Name = "mnuLogoff";
            this.mnuLogoff.Click += new System.EventHandler(this.mnuLogoff_Click);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.pgbMenu);
            this.Controls.Add(this.tssStatus);
            this.Controls.Add(this.mnsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tssStatus.ResumeLayout(false);
            this.tssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbMenu)).EndInit();
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuGerUsu;
        private System.Windows.Forms.ToolStripMenuItem MnuGerUsuSubCriarUsu;
        private System.Windows.Forms.ToolStripMenuItem MnuGerUsuSubConsultarUsu;
        private System.Windows.Forms.ToolStripMenuItem MnuSetor;
        private System.Windows.Forms.ToolStripMenuItem mnuGerMetas;
        private System.Windows.Forms.ToolStripMenuItem mnuGerMetasSubCriarMetas;
        private System.Windows.Forms.ToolStripMenuItem mnuGerMetasSubConsulMetas;
        private System.Windows.Forms.ToolStripMenuItem mnuConfg;
        private System.Windows.Forms.ToolStripMenuItem mnuLogoff;
        private System.Windows.Forms.Timer tmrMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuConfgSubAlterSenha;
        private System.Windows.Forms.PictureBox pgbMenu;
        private System.Windows.Forms.ToolStripStatusLabel tspMensagem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tspData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tspHora;
        private System.Windows.Forms.StatusStrip tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem MnuSetorSubDesen;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasMetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem MnuEmpSubGastos;
    }
}