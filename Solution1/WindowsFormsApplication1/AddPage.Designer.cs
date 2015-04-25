namespace WindowsFormsApplication1
{
    partial class AddPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.núcleoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosAtivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosInativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.núcleoToolStripMenuItem1,
            this.membrosAtivosToolStripMenuItem,
            this.membrosInativosToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // núcleoToolStripMenuItem1
            // 
            this.núcleoToolStripMenuItem1.Name = "núcleoToolStripMenuItem1";
            this.núcleoToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.núcleoToolStripMenuItem1.Text = "Núcleo";
            // 
            // membrosAtivosToolStripMenuItem
            // 
            this.membrosAtivosToolStripMenuItem.Name = "membrosAtivosToolStripMenuItem";
            this.membrosAtivosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.membrosAtivosToolStripMenuItem.Text = "Membros Ativos";
            // 
            // membrosInativosToolStripMenuItem
            // 
            this.membrosInativosToolStripMenuItem.Name = "membrosInativosToolStripMenuItem";
            this.membrosInativosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.membrosInativosToolStripMenuItem.Text = "Membros Inativos";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarAdminToolStripMenuItem,
            this.adicionarMembroToolStripMenuItem,
            this.gerarListaToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // alterarAdminToolStripMenuItem
            // 
            this.alterarAdminToolStripMenuItem.Name = "alterarAdminToolStripMenuItem";
            this.alterarAdminToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.alterarAdminToolStripMenuItem.Text = "Alterar Admin";
            // 
            // adicionarMembroToolStripMenuItem
            // 
            this.adicionarMembroToolStripMenuItem.Name = "adicionarMembroToolStripMenuItem";
            this.adicionarMembroToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.adicionarMembroToolStripMenuItem.Text = "Adicionar Membro";
            // 
            // gerarListaToolStripMenuItem
            // 
            this.gerarListaToolStripMenuItem.Name = "gerarListaToolStripMenuItem";
            this.gerarListaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gerarListaToolStripMenuItem.Text = "Gerar Lista";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 407);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddPage";
            this.Text = "AddPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem núcleoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membrosAtivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membrosInativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMembroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarListaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}