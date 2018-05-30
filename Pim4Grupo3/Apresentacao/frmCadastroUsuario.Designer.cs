namespace Pim4Grupo3.Apresentacao
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblpermicao = new System.Windows.Forms.Label();
            this.cmbPermicao = new System.Windows.Forms.ComboBox();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mstMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(615, 24);
            this.mstMenu.TabIndex = 142;
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
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(187, 22);
            this.tsmConsultar.Text = "Consultar Equipamentos";
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
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(433, 185);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(156, 23);
            this.btnExcluir.TabIndex = 140;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(433, 98);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 23);
            this.btnPesquisar.TabIndex = 139;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = "Pesquisar por Nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(27, 185);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(304, 20);
            this.txbEmail.TabIndex = 138;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(27, 226);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(304, 20);
            this.txbSenha.TabIndex = 137;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 136;
            this.label10.Text = "Login:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "E-mail:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(198, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 21);
            this.lblTitle.TabIndex = 133;
            this.lblTitle.Text = "CADASTRO DE USUÁRIO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(514, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 132;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 23);
            this.btnSalvar.TabIndex = 131;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Senha:";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(27, 143);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(304, 20);
            this.txbLogin.TabIndex = 129;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(27, 101);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(304, 20);
            this.txbNome.TabIndex = 128;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(433, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 23);
            this.btnEditar.TabIndex = 146;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(24, 62);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(10, 20);
            this.txbId.TabIndex = 147;
            this.txbId.Visible = false;
            // 
            // lblpermicao
            // 
            this.lblpermicao.AutoSize = true;
            this.lblpermicao.Location = new System.Drawing.Point(24, 254);
            this.lblpermicao.Name = "lblpermicao";
            this.lblpermicao.Size = new System.Drawing.Size(97, 13);
            this.lblpermicao.TabIndex = 150;
            this.lblpermicao.Text = "Tipo de Permissão:";
            // 
            // cmbPermicao
            // 
            this.cmbPermicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermicao.FormattingEnabled = true;
            this.cmbPermicao.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbPermicao.Location = new System.Drawing.Point(27, 270);
            this.cmbPermicao.Name = "cmbPermicao";
            this.cmbPermicao.Size = new System.Drawing.Size(156, 21);
            this.cmbPermicao.TabIndex = 151;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.cmbPermicao);
            this.Controls.Add(this.lblpermicao);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.mstMenu);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblpermicao;
        private System.Windows.Forms.ComboBox cmbPermicao;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}