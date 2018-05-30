namespace Pim4Grupo3.Apresentacao
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSair = new System.Windows.Forms.Button();
            this.llbSenha = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.btnCadastrarUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(318, 238);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 133;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // llbSenha
            // 
            this.llbSenha.AutoSize = true;
            this.llbSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.llbSenha.Location = new System.Drawing.Point(5, 275);
            this.llbSenha.Name = "llbSenha";
            this.llbSenha.Size = new System.Drawing.Size(104, 13);
            this.llbSenha.TabIndex = 132;
            this.llbSenha.TabStop = true;
            this.llbSenha.Text = "Esqueceu a Senha?";
            this.llbSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSenha_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(92, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 21);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "CONTROLE DE HARDWARE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrar.Location = new System.Drawing.Point(12, 238);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 130;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(8, 138);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(235, 20);
            this.txbSenha.TabIndex = 129;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(8, 88);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(235, 20);
            this.txbUsuario.TabIndex = 128;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.Black;
            this.lblTitle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle2.Location = new System.Drawing.Point(5, 70);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(47, 15);
            this.lblTitle2.TabIndex = 127;
            this.lblTitle2.Text = "LOGIN:";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.Black;
            this.lblTitle3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle3.Location = new System.Drawing.Point(5, 120);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(49, 15);
            this.lblTitle3.TabIndex = 126;
            this.lblTitle3.Text = "SENHA:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(8, 193);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(143, 21);
            this.cmbTipoUsuario.TabIndex = 135;
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo4.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo4.Location = new System.Drawing.Point(5, 175);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(142, 15);
            this.lblTitulo4.TabIndex = 137;
            this.lblTitulo4.Text = "PERMISSÃO DE ACESSO:";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(190, 53);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(241, 161);
            this.btnCadastrarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCadastrarUsuario.TabIndex = 134;
            this.btnCadastrarUsuario.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(405, 297);
            this.Controls.Add(this.lblTitulo4);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.llbSenha);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.LinkLabel llbSenha;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTitulo4;
        private System.Windows.Forms.PictureBox btnCadastrarUsuario;
    }
}