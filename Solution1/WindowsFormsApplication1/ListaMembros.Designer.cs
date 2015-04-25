namespace WindowsFormsApplication1
{
    partial class frmLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvDados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkInativo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNucleo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVizualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nucleo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvDados);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // grvDados
            // 
            this.grvDados.AllowUserToAddRows = false;
            this.grvDados.AllowUserToDeleteRows = false;
            this.grvDados.AllowUserToResizeColumns = false;
            this.grvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDados.BackgroundColor = System.Drawing.Color.White;
            this.grvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.status,
            this.nucleo});
            this.grvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDados.Location = new System.Drawing.Point(3, 16);
            this.grvDados.Name = "grvDados";
            this.grvDados.ReadOnly = true;
            this.grvDados.RowHeadersVisible = false;
            this.grvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDados.Size = new System.Drawing.Size(812, 259);
            this.grvDados.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtMat);
            this.grpFiltro.Controls.Add(this.label4);
            this.grpFiltro.Controls.Add(this.txtNome);
            this.grpFiltro.Controls.Add(this.label3);
            this.grpFiltro.Controls.Add(this.checkInativo);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.cmbNucleo);
            this.grpFiltro.Controls.Add(this.label2);
            this.grpFiltro.Location = new System.Drawing.Point(16, 297);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(396, 120);
            this.grpFiltro.TabIndex = 2;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtros";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(10, 79);
            this.txtMat.MaxLength = 10;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(205, 20);
            this.txtMat.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // checkInativo
            // 
            this.checkInativo.AutoSize = true;
            this.checkInativo.Location = new System.Drawing.Point(252, 89);
            this.checkInativo.Name = "checkInativo";
            this.checkInativo.Size = new System.Drawing.Size(58, 17);
            this.checkInativo.TabIndex = 12;
            this.checkInativo.Text = "Inativo";
            this.checkInativo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Núcleo";
            // 
            // cmbNucleo
            // 
            this.cmbNucleo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cmbNucleo.FormattingEnabled = true;
            this.cmbNucleo.Items.AddRange(new object[] {
            "NAI",
            "NGCT",
            "NPSP",
            "NE"});
            this.cmbNucleo.Location = new System.Drawing.Point(249, 36);
            this.cmbNucleo.Name = "cmbNucleo";
            this.cmbNucleo.Size = new System.Drawing.Size(132, 21);
            this.cmbNucleo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFiltrar);
            this.groupBox3.Controls.Add(this.btnVizualizar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnAtualizar);
            this.groupBox3.Location = new System.Drawing.Point(419, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ações";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(245, 66);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(131, 40);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnVizualizar
            // 
            this.btnVizualizar.Location = new System.Drawing.Point(245, 20);
            this.btnVizualizar.Name = "btnVizualizar";
            this.btnVizualizar.Size = new System.Drawing.Size(131, 40);
            this.btnVizualizar.TabIndex = 2;
            this.btnVizualizar.Text = "Vizualizar";
            this.btnVizualizar.UseVisualStyleBackColor = true;
            this.btnVizualizar.Click += new System.EventHandler(this.btnVizualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(56, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(56, 68);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(131, 41);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 105;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "name";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 420;
            // 
            // status
            // 
            this.status.DataPropertyName = "ativo";
            this.status.HeaderText = "Stadus";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // nucleo
            // 
            this.nucleo.DataPropertyName = "nucleo";
            this.nucleo.HeaderText = "Núcleo";
            this.nucleo.Name = "nucleo";
            this.nucleo.ReadOnly = true;
            this.nucleo.Width = 185;
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaMembros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeFrm);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView grvDados;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkInativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNucleo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVizualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nucleo;
    }
}