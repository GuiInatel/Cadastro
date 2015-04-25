namespace WindowsFormsApplication1
{
    partial class frmFisrtPage
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMembros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeAtividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMembros = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.e;
            this.pictureBox2.Location = new System.Drawing.Point(276, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.LogoCP2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuOpcoes,
            this.sobreToolStripMenuItem,
            this.sairaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(754, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.addMembros,
            this.listaMembros});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "Membros";
            // 
            // listaMembros
            // 
            this.listaMembros.Name = "listaMembros";
            this.listaMembros.Size = new System.Drawing.Size(168, 22);
            this.listaMembros.Text = "Lista de Membros";
            this.listaMembros.Click += new System.EventHandler(this.listaMembros_Click);
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.gerarCertificadoToolStripMenuItem,
            this.históricoDeAtividadesToolStripMenuItem});
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(75, 20);
            this.menuOpcoes.Text = "Operações";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem3.Text = "Gerar Lista de Membros";
            // 
            // gerarCertificadoToolStripMenuItem
            // 
            this.gerarCertificadoToolStripMenuItem.Name = "gerarCertificadoToolStripMenuItem";
            this.gerarCertificadoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gerarCertificadoToolStripMenuItem.Text = "Gerar Certificado";
            // 
            // históricoDeAtividadesToolStripMenuItem
            // 
            this.históricoDeAtividadesToolStripMenuItem.Name = "históricoDeAtividadesToolStripMenuItem";
            this.históricoDeAtividadesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.históricoDeAtividadesToolStripMenuItem.Text = "Histórico de Atividades";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairaToolStripMenuItem
            // 
            this.sairaToolStripMenuItem.Name = "sairaToolStripMenuItem";
            this.sairaToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairaToolStripMenuItem.Text = "Sair";
            // 
            // addMembros
            // 
            this.addMembros.Name = "addMembros";
            this.addMembros.Size = new System.Drawing.Size(168, 22);
            this.addMembros.Text = "Adicionar";
            this.addMembros.Click += new System.EventHandler(this.addMembros_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // frmFisrtPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 429);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFisrtPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro CP2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFisrtPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMembros;
        private System.Windows.Forms.ToolStripMenuItem listaMembros;
        private System.Windows.Forms.ToolStripMenuItem menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gerarCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeAtividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;


    }
}