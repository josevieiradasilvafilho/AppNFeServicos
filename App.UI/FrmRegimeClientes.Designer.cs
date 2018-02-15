namespace App.UI
{
    partial class FrmRegimeClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegimeClientes));
            this.dtG = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTributo = new System.Windows.Forms.TextBox();
            this.txtDeducoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Remover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Sair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtG
            // 
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(12, 107);
            this.dtG.Name = "dtG";
            this.dtG.Size = new System.Drawing.Size(726, 280);
            this.dtG.TabIndex = 5;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 22);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(134, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(110, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // txtTributo
            // 
            this.txtTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTributo.Location = new System.Drawing.Point(497, 70);
            this.txtTributo.Name = "txtTributo";
            this.txtTributo.Size = new System.Drawing.Size(100, 22);
            this.txtTributo.TabIndex = 3;
            this.txtTributo.TextChanged += new System.EventHandler(this.txtTributo_TextChanged);
            this.txtTributo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            this.txtTributo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTributo_KeyPress);
            // 
            // txtDeducoes
            // 
            this.txtDeducoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeducoes.Location = new System.Drawing.Point(497, 39);
            this.txtDeducoes.Name = "txtDeducoes";
            this.txtDeducoes.Size = new System.Drawing.Size(100, 22);
            this.txtDeducoes.TabIndex = 2;
            this.txtDeducoes.TextChanged += new System.EventHandler(this.txtDeducoes_TextChanged);
            this.txtDeducoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            this.txtDeducoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeducoes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Regime Tributário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deducoes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tributo";
            // 
            // btSearch
            // 
            this.btSearch.Image = global::App.UI.Properties.Resources.if_kfind_7186__1_;
            this.btSearch.Location = new System.Drawing.Point(303, 37);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(29, 27);
            this.btSearch.TabIndex = 23;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(750, 25);
            this.toolStrip1.TabIndex = 74;
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
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click);
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
            this.ts_Remover.Click += new System.EventHandler(this.ts_Remover_Click);
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
            this.ts_Sair.Click += new System.EventHandler(this.ts_Sair_Click);
            // 
            // FrmRegimeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 399);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeducoes);
            this.Controls.Add(this.txtTributo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegimeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegimeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTributo;
        private System.Windows.Forms.TextBox txtDeducoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSearch;
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