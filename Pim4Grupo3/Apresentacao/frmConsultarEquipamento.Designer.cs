namespace Pim4Grupo3.Apresentacao
{
    partial class frmConsultarEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEquipamento));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txbAtivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisarAtivo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarStatus = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.mtxbPreventiva = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxbAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em Uso",
            "Em Conserto",
            "Preventiva Marcada"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 353);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(234, 21);
            this.cmbStatus.TabIndex = 236;
            // 
            // txbSerial
            // 
            this.txbSerial.Location = new System.Drawing.Point(12, 312);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.Size = new System.Drawing.Size(234, 20);
            this.txbSerial.TabIndex = 235;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(12, 170);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(234, 80);
            this.txbDescricao.TabIndex = 234;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Computador",
            "Impressora",
            "Periférico",
            "Outros"});
            this.cmbTipo.Location = new System.Drawing.Point(12, 128);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(234, 21);
            this.cmbTipo.TabIndex = 233;
            // 
            // txbAtivo
            // 
            this.txbAtivo.Location = new System.Drawing.Point(12, 87);
            this.txbAtivo.Name = "txbAtivo";
            this.txbAtivo.Size = new System.Drawing.Size(234, 20);
            this.txbAtivo.TabIndex = 232;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 231;
            this.label10.Text = "Tipo de Equipamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 230;
            this.label9.Text = "Ativo Fixo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 229;
            this.label8.Text = "Data de Aquisição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 228;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 227;
            this.label3.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 226;
            this.label2.Text = "Descrição do Equipamento:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(360, 213);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 23);
            this.btnExcluir.TabIndex = 225;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(360, 170);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 23);
            this.btnSalvar.TabIndex = 224;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Editar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisarAtivo
            // 
            this.btnPesquisarAtivo.Location = new System.Drawing.Point(360, 85);
            this.btnPesquisarAtivo.Name = "btnPesquisarAtivo";
            this.btnPesquisarAtivo.Size = new System.Drawing.Size(137, 23);
            this.btnPesquisarAtivo.TabIndex = 221;
            this.btnPesquisarAtivo.TabStop = false;
            this.btnPesquisarAtivo.Text = "Pesquisar por Ativo Fixo";
            this.btnPesquisarAtivo.UseVisualStyleBackColor = true;
            this.btnPesquisarAtivo.Click += new System.EventHandler(this.btnPesquisarAtivo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(147, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(230, 21);
            this.lblTitle.TabIndex = 220;
            this.lblTitle.Text = "CONSULTAR EQUIPAMENTOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(360, 416);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 23);
            this.btnVoltar.TabIndex = 223;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mstMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(510, 24);
            this.mstMenu.TabIndex = 218;
            this.mstMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuario,
            this.toolStripSeparator2,
            this.tsmCadastrar,
            this.tsmConsultar,
            this.toolStripSeparator1,
            this.tsmSair});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.Size = new System.Drawing.Size(187, 22);
            this.tsmUsuario.Text = "Cadastrar / Excluir Usuario";
            this.tsmUsuario.Click += new System.EventHandler(this.tsmUsuario_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(187, 22);
            this.tsmCadastrar.Text = "Cadastrar Novo Equipamento";
            this.tsmCadastrar.Click += new System.EventHandler(this.tsmCadastrar_Click);
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(187, 22);
            this.tsmConsultar.Text = "Consultar Equipamentos";
            this.tsmConsultar.Click += new System.EventHandler(this.tsmConsultar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(187, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // btnPesquisarStatus
            // 
            this.btnPesquisarStatus.Location = new System.Drawing.Point(360, 128);
            this.btnPesquisarStatus.Name = "btnPesquisarStatus";
            this.btnPesquisarStatus.Size = new System.Drawing.Size(137, 23);
            this.btnPesquisarStatus.TabIndex = 222;
            this.btnPesquisarStatus.TabStop = false;
            this.btnPesquisarStatus.Text = "Pesquisar por Status";
            this.btnPesquisarStatus.UseVisualStyleBackColor = true;
            this.btnPesquisarStatus.Click += new System.EventHandler(this.btnPesquisarStatus_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(236, 393);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(10, 20);
            this.txbId.TabIndex = 238;
            this.txbId.Visible = false;
            // 
            // mtxbPreventiva
            // 
            this.mtxbPreventiva.Location = new System.Drawing.Point(12, 393);
            this.mtxbPreventiva.Mask = "00/00/0000";
            this.mtxbPreventiva.Name = "mtxbPreventiva";
            this.mtxbPreventiva.Size = new System.Drawing.Size(75, 20);
            this.mtxbPreventiva.TabIndex = 240;
            this.mtxbPreventiva.ValidatingType = typeof(System.DateTime);
            this.mtxbPreventiva.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxbPreventiva_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 239;
            this.label1.Text = "Data de Preventiva:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtxbAquisicao
            // 
            this.mtxbAquisicao.Location = new System.Drawing.Point(12, 270);
            this.mtxbAquisicao.Mask = "00/00/0000";
            this.mtxbAquisicao.Name = "mtxbAquisicao";
            this.mtxbAquisicao.Size = new System.Drawing.Size(75, 20);
            this.mtxbAquisicao.TabIndex = 241;
            this.mtxbAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // frmConsultarEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 460);
            this.Controls.Add(this.mtxbAquisicao);
            this.Controls.Add(this.mtxbPreventiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txbSerial);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txbAtivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisarAtivo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.mstMenu);
            this.Controls.Add(this.btnPesquisarStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Equipamento";
            this.Load += new System.EventHandler(this.frmConsultarEquipamento_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txbAtivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisarAtivo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.Button btnPesquisarStatus;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.MaskedTextBox mtxbPreventiva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxbAquisicao;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}