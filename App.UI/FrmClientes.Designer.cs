namespace App.UI
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        public string oFrmClientetxtId { get; set; }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.dtG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientes_Nome = new System.Windows.Forms.TextBox();
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.txtClientes_CNPJorCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientes_Inscricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientes_TipoLogradouro = new System.Windows.Forms.TextBox();
            this.Logradouro = new System.Windows.Forms.Label();
            this.txtClientes_NumLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientes_Complemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientes_Bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidades_Codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidades_Nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btProcurarFrmCidade = new System.Windows.Forms.Button();
            this.txtClientes_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoClientes_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidades_UF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegimeClientes_Nome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegimeClientes_Codigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientes_NomeServico = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRegimeClientes_Tributacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCidades_Id = new System.Windows.Forms.TextBox();
            this.btProcurarFrmTipoClientes = new System.Windows.Forms.Button();
            this.btProcurarRegimeClientes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTipoClientes_Id = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRegimeClientes_Id = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtClientes_ID = new System.Windows.Forms.TextBox();
            this.txtClientes_Valor = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtClientes_Cep = new System.Windows.Forms.TextBox();
            this.Cep = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Remover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Sair = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTipoLogradouroAbreviatura = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtG
            // 
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(15, 299);
            this.dtG.Name = "dtG";
            this.dtG.Size = new System.Drawing.Size(1020, 181);
            this.dtG.TabIndex = 60;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            this.dtG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razão Social";
            // 
            // txtClientes_Nome
            // 
            this.txtClientes_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Nome.Location = new System.Drawing.Point(119, 107);
            this.txtClientes_Nome.Name = "txtClientes_Nome";
            this.txtClientes_Nome.Size = new System.Drawing.Size(463, 22);
            this.txtClientes_Nome.TabIndex = 4;
            this.txtClientes_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaFisica.Location = new System.Drawing.Point(15, 49);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(126, 20);
            this.chkPessoaFisica.TabIndex = 0;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            this.chkPessoaFisica.CheckedChanged += new System.EventHandler(this.chkPessoaFisica_CheckedChanged);
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaJuridica.Location = new System.Drawing.Point(160, 49);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(139, 20);
            this.chkPessoaJuridica.TabIndex = 1;
            this.chkPessoaJuridica.Text = "Pessoa Jurídica";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkPessoaJuridica.CheckedChanged += new System.EventHandler(this.chkPessoaJuridica_CheckedChanged);
            // 
            // txtClientes_CNPJorCPF
            // 
            this.txtClientes_CNPJorCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_CNPJorCPF.Location = new System.Drawing.Point(85, 75);
            this.txtClientes_CNPJorCPF.Name = "txtClientes_CNPJorCPF";
            this.txtClientes_CNPJorCPF.Size = new System.Drawing.Size(151, 22);
            this.txtClientes_CNPJorCPF.TabIndex = 2;
            this.txtClientes_CNPJorCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_CNPJorCPF.TextChanged += new System.EventHandler(this.txtClientes_CNPJorCPF_TextChanged);
            this.txtClientes_CNPJorCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cnpj/Cpf";
            // 
            // txtClientes_Inscricao
            // 
            this.txtClientes_Inscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Inscricao.Location = new System.Drawing.Point(315, 74);
            this.txtClientes_Inscricao.Name = "txtClientes_Inscricao";
            this.txtClientes_Inscricao.Size = new System.Drawing.Size(208, 22);
            this.txtClientes_Inscricao.TabIndex = 3;
            this.txtClientes_Inscricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Inscricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "I.E.";
            // 
            // txtClientes_TipoLogradouro
            // 
            this.txtClientes_TipoLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_TipoLogradouro.Location = new System.Drawing.Point(106, 139);
            this.txtClientes_TipoLogradouro.Name = "txtClientes_TipoLogradouro";
            this.txtClientes_TipoLogradouro.Size = new System.Drawing.Size(359, 22);
            this.txtClientes_TipoLogradouro.TabIndex = 6;
            this.txtClientes_TipoLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_TipoLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSize = true;
            this.Logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logradouro.Location = new System.Drawing.Point(12, 142);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(88, 16);
            this.Logradouro.TabIndex = 26;
            this.Logradouro.Text = "Logradouro";
            // 
            // txtClientes_NumLogradouro
            // 
            this.txtClientes_NumLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_NumLogradouro.Location = new System.Drawing.Point(509, 138);
            this.txtClientes_NumLogradouro.Name = "txtClientes_NumLogradouro";
            this.txtClientes_NumLogradouro.Size = new System.Drawing.Size(108, 22);
            this.txtClientes_NumLogradouro.TabIndex = 7;
            this.txtClientes_NumLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_NumLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "No.";
            // 
            // txtClientes_Complemento
            // 
            this.txtClientes_Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Complemento.Location = new System.Drawing.Point(121, 170);
            this.txtClientes_Complemento.Name = "txtClientes_Complemento";
            this.txtClientes_Complemento.Size = new System.Drawing.Size(210, 22);
            this.txtClientes_Complemento.TabIndex = 8;
            this.txtClientes_Complemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Complemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Complemento";
            // 
            // txtClientes_Bairro
            // 
            this.txtClientes_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Bairro.Location = new System.Drawing.Point(401, 170);
            this.txtClientes_Bairro.Name = "txtClientes_Bairro";
            this.txtClientes_Bairro.Size = new System.Drawing.Size(387, 22);
            this.txtClientes_Bairro.TabIndex = 9;
            this.txtClientes_Bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Bairro";
            // 
            // txtCidades_Codigo
            // 
            this.txtCidades_Codigo.Enabled = false;
            this.txtCidades_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades_Codigo.Location = new System.Drawing.Point(754, 107);
            this.txtCidades_Codigo.Name = "txtCidades_Codigo";
            this.txtCidades_Codigo.Size = new System.Drawing.Size(53, 22);
            this.txtCidades_Codigo.TabIndex = 36;
            this.txtCidades_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Codigo Cidade:";
            // 
            // txtCidades_Nome
            // 
            this.txtCidades_Nome.Enabled = false;
            this.txtCidades_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades_Nome.Location = new System.Drawing.Point(700, 138);
            this.txtCidades_Nome.Name = "txtCidades_Nome";
            this.txtCidades_Nome.Size = new System.Drawing.Size(335, 22);
            this.txtCidades_Nome.TabIndex = 38;
            this.txtCidades_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cidade:";
            // 
            // btProcurarFrmCidade
            // 
            this.btProcurarFrmCidade.Location = new System.Drawing.Point(813, 106);
            this.btProcurarFrmCidade.Name = "btProcurarFrmCidade";
            this.btProcurarFrmCidade.Size = new System.Drawing.Size(27, 24);
            this.btProcurarFrmCidade.TabIndex = 5;
            this.btProcurarFrmCidade.Text = "...";
            this.btProcurarFrmCidade.UseVisualStyleBackColor = true;
            this.btProcurarFrmCidade.Click += new System.EventHandler(this.btnProcurarFrmCidade_Click);
            this.btProcurarFrmCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // txtClientes_Email
            // 
            this.txtClientes_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Email.Location = new System.Drawing.Point(65, 200);
            this.txtClientes_Email.Name = "txtClientes_Email";
            this.txtClientes_Email.Size = new System.Drawing.Size(438, 22);
            this.txtClientes_Email.TabIndex = 11;
            this.txtClientes_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Email";
            // 
            // txtTipoClientes_Name
            // 
            this.txtTipoClientes_Name.Enabled = false;
            this.txtTipoClientes_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoClientes_Name.Location = new System.Drawing.Point(595, 200);
            this.txtTipoClientes_Name.Name = "txtTipoClientes_Name";
            this.txtTipoClientes_Name.Size = new System.Drawing.Size(315, 22);
            this.txtTipoClientes_Name.TabIndex = 45;
            this.txtTipoClientes_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Tipo";
            // 
            // txtCidades_UF
            // 
            this.txtCidades_UF.Enabled = false;
            this.txtCidades_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades_UF.Location = new System.Drawing.Point(901, 107);
            this.txtCidades_UF.Name = "txtCidades_UF";
            this.txtCidades_UF.Size = new System.Drawing.Size(38, 22);
            this.txtCidades_UF.TabIndex = 46;
            this.txtCidades_UF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(867, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "UF:";
            // 
            // txtRegimeClientes_Nome
            // 
            this.txtRegimeClientes_Nome.Enabled = false;
            this.txtRegimeClientes_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegimeClientes_Nome.Location = new System.Drawing.Point(130, 263);
            this.txtRegimeClientes_Nome.Name = "txtRegimeClientes_Nome";
            this.txtRegimeClientes_Nome.Size = new System.Drawing.Size(487, 22);
            this.txtRegimeClientes_Nome.TabIndex = 48;
            this.txtRegimeClientes_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegimeClientes_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Reg. Tributário:";
            // 
            // txtRegimeClientes_Codigo
            // 
            this.txtRegimeClientes_Codigo.Enabled = false;
            this.txtRegimeClientes_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegimeClientes_Codigo.Location = new System.Drawing.Point(836, 263);
            this.txtRegimeClientes_Codigo.Name = "txtRegimeClientes_Codigo";
            this.txtRegimeClientes_Codigo.Size = new System.Drawing.Size(106, 22);
            this.txtRegimeClientes_Codigo.TabIndex = 51;
            this.txtRegimeClientes_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(774, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Código:";
            // 
            // txtClientes_NomeServico
            // 
            this.txtClientes_NomeServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_NomeServico.Location = new System.Drawing.Point(79, 230);
            this.txtClientes_NomeServico.Name = "txtClientes_NomeServico";
            this.txtClientes_NomeServico.Size = new System.Drawing.Size(510, 22);
            this.txtClientes_NomeServico.TabIndex = 13;
            this.txtClientes_NomeServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_NomeServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Serviço";
            // 
            // txtRegimeClientes_Tributacao
            // 
            this.txtRegimeClientes_Tributacao.Enabled = false;
            this.txtRegimeClientes_Tributacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegimeClientes_Tributacao.Location = new System.Drawing.Point(745, 263);
            this.txtRegimeClientes_Tributacao.Name = "txtRegimeClientes_Tributacao";
            this.txtRegimeClientes_Tributacao.Size = new System.Drawing.Size(23, 22);
            this.txtRegimeClientes_Tributacao.TabIndex = 57;
            this.txtRegimeClientes_Tributacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(656, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Tributacao:";
            // 
            // txtCidades_Id
            // 
            this.txtCidades_Id.Enabled = false;
            this.txtCidades_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades_Id.Location = new System.Drawing.Point(982, 107);
            this.txtCidades_Id.Name = "txtCidades_Id";
            this.txtCidades_Id.Size = new System.Drawing.Size(53, 22);
            this.txtCidades_Id.TabIndex = 58;
            this.txtCidades_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCidades_Id.Visible = false;
            // 
            // btProcurarFrmTipoClientes
            // 
            this.btProcurarFrmTipoClientes.Location = new System.Drawing.Point(916, 199);
            this.btProcurarFrmTipoClientes.Name = "btProcurarFrmTipoClientes";
            this.btProcurarFrmTipoClientes.Size = new System.Drawing.Size(27, 24);
            this.btProcurarFrmTipoClientes.TabIndex = 12;
            this.btProcurarFrmTipoClientes.Text = "...";
            this.btProcurarFrmTipoClientes.UseVisualStyleBackColor = true;
            this.btProcurarFrmTipoClientes.Click += new System.EventHandler(this.btProcurarFrmTipoClientes_Click);
            this.btProcurarFrmTipoClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // btProcurarRegimeClientes
            // 
            this.btProcurarRegimeClientes.Location = new System.Drawing.Point(623, 262);
            this.btProcurarRegimeClientes.Name = "btProcurarRegimeClientes";
            this.btProcurarRegimeClientes.Size = new System.Drawing.Size(27, 24);
            this.btProcurarRegimeClientes.TabIndex = 15;
            this.btProcurarRegimeClientes.Text = "...";
            this.btProcurarRegimeClientes.UseVisualStyleBackColor = true;
            this.btProcurarRegimeClientes.Click += new System.EventHandler(this.btProcurarRegimeClientes_Click);
            this.btProcurarRegimeClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(588, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 24);
            this.button4.TabIndex = 61;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 62;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(953, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 63;
            this.label14.Text = "ID:";
            this.label14.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(953, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 16);
            this.label17.TabIndex = 65;
            this.label17.Text = "ID:";
            this.label17.Visible = false;
            // 
            // txtTipoClientes_Id
            // 
            this.txtTipoClientes_Id.Enabled = false;
            this.txtTipoClientes_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoClientes_Id.Location = new System.Drawing.Point(982, 200);
            this.txtTipoClientes_Id.Name = "txtTipoClientes_Id";
            this.txtTipoClientes_Id.Size = new System.Drawing.Size(53, 22);
            this.txtTipoClientes_Id.TabIndex = 64;
            this.txtTipoClientes_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoClientes_Id.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(953, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 16);
            this.label18.TabIndex = 67;
            this.label18.Text = "ID:";
            this.label18.Visible = false;
            // 
            // txtRegimeClientes_Id
            // 
            this.txtRegimeClientes_Id.Enabled = false;
            this.txtRegimeClientes_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegimeClientes_Id.Location = new System.Drawing.Point(982, 262);
            this.txtRegimeClientes_Id.Name = "txtRegimeClientes_Id";
            this.txtRegimeClientes_Id.Size = new System.Drawing.Size(53, 22);
            this.txtRegimeClientes_Id.TabIndex = 66;
            this.txtRegimeClientes_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegimeClientes_Id.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(545, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 16);
            this.label19.TabIndex = 69;
            this.label19.Text = "ID:";
            this.label19.Visible = false;
            // 
            // txtClientes_ID
            // 
            this.txtClientes_ID.Enabled = false;
            this.txtClientes_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_ID.Location = new System.Drawing.Point(574, 74);
            this.txtClientes_ID.Name = "txtClientes_ID";
            this.txtClientes_ID.Size = new System.Drawing.Size(53, 22);
            this.txtClientes_ID.TabIndex = 68;
            this.txtClientes_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_ID.Visible = false;
            // 
            // txtClientes_Valor
            // 
            this.txtClientes_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Valor.Location = new System.Drawing.Point(891, 171);
            this.txtClientes_Valor.Name = "txtClientes_Valor";
            this.txtClientes_Valor.Size = new System.Drawing.Size(144, 22);
            this.txtClientes_Valor.TabIndex = 10;
            this.txtClientes_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClientes_Valor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(833, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 70;
            this.label20.Text = "Valor:";
            // 
            // txtClientes_Cep
            // 
            this.txtClientes_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes_Cep.Location = new System.Drawing.Point(660, 230);
            this.txtClientes_Cep.Name = "txtClientes_Cep";
            this.txtClientes_Cep.Size = new System.Drawing.Size(128, 22);
            this.txtClientes_Cep.TabIndex = 14;
            this.txtClientes_Cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PulaProxCampoTabIndex);
            // 
            // Cep
            // 
            this.Cep.AutoSize = true;
            this.Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep.Location = new System.Drawing.Point(622, 234);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(36, 16);
            this.Cep.TabIndex = 72;
            this.Cep.Text = "Cep";
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
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 73;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 74;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTipoLogradouroAbreviatura
            // 
            this.txtTipoLogradouroAbreviatura.Enabled = false;
            this.txtTipoLogradouroAbreviatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLogradouroAbreviatura.Location = new System.Drawing.Point(791, 74);
            this.txtTipoLogradouroAbreviatura.Name = "txtTipoLogradouroAbreviatura";
            this.txtTipoLogradouroAbreviatura.Size = new System.Drawing.Size(53, 22);
            this.txtTipoLogradouroAbreviatura.TabIndex = 76;
            this.txtTipoLogradouroAbreviatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(636, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 16);
            this.label21.TabIndex = 75;
            this.label21.Text = "Tipo de Logradouro.:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTipoLogradouroAbreviatura);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtClientes_Cep);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.txtClientes_Valor);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtClientes_ID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtRegimeClientes_Id);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTipoClientes_Id);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btProcurarRegimeClientes);
            this.Controls.Add(this.btProcurarFrmTipoClientes);
            this.Controls.Add(this.txtCidades_Id);
            this.Controls.Add(this.txtRegimeClientes_Tributacao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtClientes_NomeServico);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRegimeClientes_Codigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRegimeClientes_Nome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidades_UF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTipoClientes_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtClientes_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btProcurarFrmCidade);
            this.Controls.Add(this.txtCidades_Nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidades_Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClientes_Bairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClientes_Complemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClientes_NumLogradouro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientes_TipoLogradouro);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.txtClientes_Inscricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientes_CNPJorCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkPessoaJuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.Controls.Add(this.txtClientes_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientes_Nome;
        private System.Windows.Forms.CheckBox chkPessoaFisica;
        private System.Windows.Forms.CheckBox chkPessoaJuridica;
        private System.Windows.Forms.TextBox txtClientes_CNPJorCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientes_Inscricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientes_TipoLogradouro;
        private System.Windows.Forms.Label Logradouro;
        private System.Windows.Forms.TextBox txtClientes_NumLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientes_Complemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientes_Bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidades_Codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidades_Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btProcurarFrmCidade;
        private System.Windows.Forms.TextBox txtClientes_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipoClientes_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidades_UF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegimeClientes_Nome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRegimeClientes_Codigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientes_NomeServico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRegimeClientes_Tributacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCidades_Id;
        private System.Windows.Forms.Button btProcurarFrmTipoClientes;
        private System.Windows.Forms.Button btProcurarRegimeClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTipoClientes_Id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRegimeClientes_Id;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtClientes_ID;
        private System.Windows.Forms.TextBox txtClientes_Valor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtClientes_Cep;
        private System.Windows.Forms.Label Cep;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsInserir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_Remover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_Sair;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTipoLogradouroAbreviatura;
        private System.Windows.Forms.Label label21;
    }
}