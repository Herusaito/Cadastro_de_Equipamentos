namespace Pim4Grupo3.Apresentacao
{
    partial class frmVisualizarEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarEquip));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(229, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 21);
            this.lblTitle.TabIndex = 156;
            this.lblTitle.Text = "VISUALIZAR EQUIPAMENTOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(560, 255);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 155;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(30, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 23);
            this.btnOk.TabIndex = 167;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(30, 75);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.Size = new System.Drawing.Size(605, 174);
            this.dgvVisualizar.TabIndex = 168;
            this.dgvVisualizar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizar_CellContentClick);
            // 
            // frmVisualizarEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 288);
            this.Controls.Add(this.dgvVisualizar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizarEquip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Equipamento";
            this.Load += new System.EventHandler(this.frmVisualizarEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvVisualizar;
    }
}