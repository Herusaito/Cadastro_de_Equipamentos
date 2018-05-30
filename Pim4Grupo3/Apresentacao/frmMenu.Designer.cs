namespace Pim4Grupo3.Apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(195, 228);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 135;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(37, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(199, 23);
            this.btnCadastrar.TabIndex = 131;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar Novo Equipamento";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // tsmConsultar
            // 
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(187, 22);
            this.tsmConsultar.Text = "Consultar Equipamentos";
            this.tsmConsultar.Click += new System.EventHandler(this.tsmConsultar_Click);
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(187, 22);
            this.tsmCadastrar.Text = "Cadastrar Novo Equipamento";
            this.tsmCadastrar.Click += new System.EventHandler(this.tsmCadastrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.Size = new System.Drawing.Size(187, 22);
            this.tsmUsuario.Text = "Cadastrar / Excluir Usuário";
            this.tsmUsuario.Click += new System.EventHandler(this.tsmUsuario_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuario,
            this.toolStripSeparator2,
            this.tsmCadastrar,
            this.tsmConsultar,
            this.toolStripSeparator3,
            this.tsmSair});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(33, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 21);
            this.lblTitle.TabIndex = 140;
            this.lblTitle.Text = "CONTROLE DE HARDWARE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsuario.Location = new System.Drawing.Point(37, 87);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(199, 23);
            this.btnUsuario.TabIndex = 139;
            this.btnUsuario.TabStop = false;
            this.btnUsuario.Text = "Cadastrar / Excluir Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConsultar.Location = new System.Drawing.Point(37, 177);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(199, 23);
            this.btnConsultar.TabIndex = 138;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Text = "Consultar Equipamentos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mstMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(282, 24);
            this.mstMenu.TabIndex = 136;
            this.mstMenu.Text = "menuStrip1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 265);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MenuStrip mstMenu;
    }
}