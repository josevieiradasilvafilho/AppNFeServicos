namespace App.UI
{
    partial class FrmTipoLogradouros
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
            this.dtG = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Remover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Sair = new System.Windows.Forms.ToolStripButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCidadeName = new System.Windows.Forms.Label();
            this.txtAbreviature = new System.Windows.Forms.TextBox();
            this.lblAbreviatura = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPesqLogradouro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtG
            // 
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(2, 75);
            this.dtG.Name = "dtG";
            this.dtG.Size = new System.Drawing.Size(680, 321);
            this.dtG.TabIndex = 0;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
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
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 28;
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
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(626, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(46, 22);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCidadeName
            // 
            this.lblCidadeName.AutoSize = true;
            this.lblCidadeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeName.Location = new System.Drawing.Point(562, 47);
            this.lblCidadeName.Name = "lblCidadeName";
            this.lblCidadeName.Size = new System.Drawing.Size(66, 16);
            this.lblCidadeName.TabIndex = 27;
            this.lblCidadeName.Text = "Código.:";
            // 
            // txtAbreviature
            // 
            this.txtAbreviature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviature.Location = new System.Drawing.Point(449, 44);
            this.txtAbreviature.Name = "txtAbreviature";
            this.txtAbreviature.Size = new System.Drawing.Size(99, 22);
            this.txtAbreviature.TabIndex = 29;
            this.txtAbreviature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAbreviatura
            // 
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbreviatura.Location = new System.Drawing.Point(354, 47);
            this.lblAbreviatura.Name = "lblAbreviatura";
            this.lblAbreviatura.Size = new System.Drawing.Size(96, 16);
            this.lblAbreviatura.TabIndex = 30;
            this.lblAbreviatura.Text = "Abreviatura.:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(95, 44);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(209, 22);
            this.txtLogradouro.TabIndex = 31;
            this.txtLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Logradouro.:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(554, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 22);
            this.txtID.TabIndex = 33;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID.:";
            this.label2.Visible = false;
            // 
            // btPesqLogradouro
            // 
            this.btPesqLogradouro.Location = new System.Drawing.Point(310, 43);
            this.btPesqLogradouro.Name = "btPesqLogradouro";
            this.btPesqLogradouro.Size = new System.Drawing.Size(27, 24);
            this.btPesqLogradouro.TabIndex = 63;
            this.btPesqLogradouro.Text = "...";
            this.btPesqLogradouro.UseVisualStyleBackColor = true;
            this.btPesqLogradouro.Click += new System.EventHandler(this.btPesqLogradouro_Click);
            // 
            // FrmTipoLogradouros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 399);
            this.Controls.Add(this.btPesqLogradouro);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbreviature);
            this.Controls.Add(this.lblAbreviatura);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCidadeName);
            this.Controls.Add(this.dtG);
            this.Name = "FrmTipoLogradouros";
            this.Load += new System.EventHandler(this.TipoLogradouros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsInserir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_Remover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_Sair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCidadeName;
        private System.Windows.Forms.TextBox txtAbreviature;
        private System.Windows.Forms.Label lblAbreviatura;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPesqLogradouro;
    }
}