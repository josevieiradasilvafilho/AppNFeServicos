namespace App.UI
{
    partial class FrmCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidades));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidadeCodigo = new System.Windows.Forms.Label();
            this.lblCidadeName = new System.Windows.Forms.Label();
            this.dtGCidades = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Remover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Sair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCidades)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(165, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 22);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(93, 59);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(414, 22);
            this.txtCidade.TabIndex = 11;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            this.txtCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // lblCidadeCodigo
            // 
            this.lblCidadeCodigo.AutoSize = true;
            this.lblCidadeCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCodigo.Location = new System.Drawing.Point(25, 90);
            this.lblCidadeCodigo.Name = "lblCidadeCodigo";
            this.lblCidadeCodigo.Size = new System.Drawing.Size(134, 16);
            this.lblCidadeCodigo.TabIndex = 16;
            this.lblCidadeCodigo.Text = "Código da Cidade";
            // 
            // lblCidadeName
            // 
            this.lblCidadeName.AutoSize = true;
            this.lblCidadeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeName.Location = new System.Drawing.Point(25, 62);
            this.lblCidadeName.Name = "lblCidadeName";
            this.lblCidadeName.Size = new System.Drawing.Size(58, 16);
            this.lblCidadeName.TabIndex = 15;
            this.lblCidadeName.Text = "Cidade";
            // 
            // dtGCidades
            // 
            this.dtGCidades.AllowUserToAddRows = false;
            this.dtGCidades.AllowUserToDeleteRows = false;
            this.dtGCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGCidades.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGCidades.Location = new System.Drawing.Point(12, 125);
            this.dtGCidades.Name = "dtGCidades";
            this.dtGCidades.ReadOnly = true;
            this.dtGCidades.Size = new System.Drawing.Size(655, 266);
            this.dtGCidades.TabIndex = 20;
            this.dtGCidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCidades_CellContentClick);
            this.dtGCidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCidades_CellContentClick);
            this.dtGCidades.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCidades_CellContentClick);
            this.dtGCidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCidades_CellContentClick);
            // 
            // btSearch
            // 
            this.btSearch.Image = global::App.UI.Properties.Resources.if_kfind_7186__1_;
            this.btSearch.Location = new System.Drawing.Point(513, 55);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(31, 30);
            this.btSearch.TabIndex = 21;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(457, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 22);
            this.txtId.TabIndex = 22;
            this.txtId.Visible = false;
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(338, 87);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(40, 22);
            this.txtUF.TabIndex = 23;
            this.txtUF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "UF";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInserir,
            this.toolStripSeparator1,
            this.tsSalvar,
            this.toolStripSeparator2,
            this.ts_Remover,
            this.toolStripSeparator3,
            this.ts_Sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsInserir
            // 
            this.tsInserir.Image = global::App.UI.Properties.Resources.Insert;
            this.tsInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInserir.Name = "tsInserir";
            this.tsInserir.Size = new System.Drawing.Size(59, 22);
            this.tsInserir.Text = "Inserir";
            this.tsInserir.Click += new System.EventHandler(this.tsInserir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSalvar
            // 
            this.tsSalvar.Image = global::App.UI.Properties.Resources.Save_48x48;
            this.tsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalvar.Name = "tsSalvar";
            this.tsSalvar.Size = new System.Drawing.Size(73, 22);
            this.tsSalvar.Text = "&Atualizar";
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_Remover
            // 
            this.ts_Remover.Image = global::App.UI.Properties.Resources.Delete;
            this.ts_Remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Remover.Name = "ts_Remover";
            this.ts_Remover.Size = new System.Drawing.Size(74, 22);
            this.ts_Remover.Text = "&Remover";
            this.ts_Remover.Click += new System.EventHandler(this.ts_Remover_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_Sair
            // 
            this.ts_Sair.Image = global::App.UI.Properties.Resources.Out_48x48;
            this.ts_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Sair.Name = "ts_Sair";
            this.ts_Sair.Size = new System.Drawing.Size(46, 22);
            this.ts_Sair.Text = "&Sair";
            this.ts_Sair.Click += new System.EventHandler(this.ts_Sair_Click_1);
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 399);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidadeCodigo);
            this.Controls.Add(this.lblCidadeName);
            this.Controls.Add(this.dtGCidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGCidades)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidadeCodigo;
        private System.Windows.Forms.Label lblCidadeName;
        private System.Windows.Forms.DataGridView dtGCidades;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsInserir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_Remover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_Sair;
    }
}