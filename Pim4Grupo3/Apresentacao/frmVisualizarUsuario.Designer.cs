namespace Pim4Grupo3.Apresentacao
{
    partial class frmVisualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarUsuario));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(560, 261);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 162;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(30, 261);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 23);
            this.btnOk.TabIndex = 166;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.AllowUserToAddRows = false;
            this.dgvVisualizar.AllowUserToDeleteRows = false;
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(30, 59);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.ReadOnly = true;
            this.dgvVisualizar.Size = new System.Drawing.Size(605, 174);
            this.dgvVisualizar.TabIndex = 164;
            this.dgvVisualizar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizar_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(241, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 21);
            this.lblTitle.TabIndex = 163;
            this.lblTitle.Text = "VISUALIZAR USUARIOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmVisualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 296);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvVisualizar);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisualizarUsuario";
            this.Load += new System.EventHandler(this.frmVisualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvVisualizar;
        private System.Windows.Forms.Label lblTitle;
    }
}