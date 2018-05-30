namespace Pim4Grupo3.Apresentacao
{
    partial class frmCadastroEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEquip));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbAtivo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxbAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.mtxbPreventiva = new System.Windows.Forms.MaskedTextBox();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 145;
            this.label3.Text = "Serial Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Descrição do Equipamento:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(33, 459);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 147;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(192, 459);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 148;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(29, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 21);
            this.lblTitle.TabIndex = 149;
            this.lblTitle.Text = "CADASTRO DE EQUIPAMENTO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 150;
            this.label8.Text = "Data de Aquisição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 151;
            this.label9.Text = "Ativo Fixo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 152;
            this.label10.Text = "Tipo de Equipamento:";
            // 
            // txbAtivo
            // 
            this.txbAtivo.Location = new System.Drawing.Point(33, 96);
            this.txbAtivo.Name = "txbAtivo";
            this.txbAtivo.Size = new System.Drawing.Size(234, 20);
            this.txbAtivo.TabIndex = 156;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Computador",
            "Impressora",
            "Periférico",
            "Outros"});
            this.cmbTipo.Location = new System.Drawing.Point(33, 137);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(234, 21);
            this.cmbTipo.TabIndex = 157;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(33, 178);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(234, 80);
            this.txbDescricao.TabIndex = 158;
            // 
            // txbSerial
            // 
            this.txbSerial.Location = new System.Drawing.Point(33, 321);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.Size = new System.Drawing.Size(234, 20);
            this.txbSerial.TabIndex = 160;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em Uso",
            "Em Conserto",
            "Preventiva Marcada"});
            this.cmbStatus.Location = new System.Drawing.Point(33, 362);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(234, 21);
            this.cmbStatus.TabIndex = 161;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuario,
            this.toolStripSeparator1,
            this.tsmCadastrar,
            this.tsmConsultar,
            this.tsmSair,
            this.toolStripSeparator3});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.Size = new System.Drawing.Size(187, 22);
            this.tsmUsuario.Text = "Cadastrar/Excluir Usuario";
            this.tsmUsuario.Click += new System.EventHandler(this.tsmUsuario_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
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
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(187, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mstMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(302, 24);
            this.mstMenu.TabIndex = 162;
            this.mstMenu.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 165;
            this.label1.Text = "Data de Preventiva:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtxbAquisicao
            // 
            this.mtxbAquisicao.Location = new System.Drawing.Point(33, 279);
            this.mtxbAquisicao.Mask = "00/00/0000";
            this.mtxbAquisicao.Name = "mtxbAquisicao";
            this.mtxbAquisicao.Size = new System.Drawing.Size(75, 20);
            this.mtxbAquisicao.TabIndex = 168;
            this.mtxbAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // mtxbPreventiva
            // 
            this.mtxbPreventiva.Location = new System.Drawing.Point(33, 404);
            this.mtxbPreventiva.Mask = "00/00/0000";
            this.mtxbPreventiva.Name = "mtxbPreventiva";
            this.mtxbPreventiva.Size = new System.Drawing.Size(75, 20);
            this.mtxbPreventiva.TabIndex = 169;
            this.mtxbPreventiva.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadastroEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 494);
            this.Controls.Add(this.mtxbPreventiva);
            this.Controls.Add(this.mtxbAquisicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mstMenu);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txbSerial);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txbAtivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamento";
            this.Load += new System.EventHandler(this.frmCadastroEquip_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbAtivo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxbAquisicao;
        private System.Windows.Forms.MaskedTextBox mtxbPreventiva;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}