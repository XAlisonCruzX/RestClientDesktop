namespace CronstruçaoVenda
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListaPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblNomeSessao = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.LstVOfertas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrlImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSituacao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(290, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 20);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 18);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 56);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(62, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(201, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofertasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.carrinhoToolStripMenuItem,
            this.toolListaUsuarios,
            this.toolListaProdutos,
            this.toolListaPedidos});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 144);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 50, 0, 0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(125, 277);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            this.ofertasToolStripMenuItem.Click += new System.EventHandler(this.ofertasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // carrinhoToolStripMenuItem
            // 
            this.carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            this.carrinhoToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.carrinhoToolStripMenuItem.Text = "Carrinho";
            this.carrinhoToolStripMenuItem.Click += new System.EventHandler(this.carrinhoToolStripMenuItem_Click);
            // 
            // toolListaUsuarios
            // 
            this.toolListaUsuarios.Name = "toolListaUsuarios";
            this.toolListaUsuarios.Size = new System.Drawing.Size(114, 19);
            this.toolListaUsuarios.Text = "ListaUsuarios";
            this.toolListaUsuarios.Visible = false;
            this.toolListaUsuarios.Click += new System.EventHandler(this.listaUsuariosToolStripMenuItem_Click);
            // 
            // toolListaProdutos
            // 
            this.toolListaProdutos.Name = "toolListaProdutos";
            this.toolListaProdutos.Size = new System.Drawing.Size(114, 19);
            this.toolListaProdutos.Text = "ListaProdutos";
            this.toolListaProdutos.Visible = false;
            this.toolListaProdutos.Click += new System.EventHandler(this.listaProdutosToolStripMenuItem_Click);
            // 
            // toolListaPedidos
            // 
            this.toolListaPedidos.Name = "toolListaPedidos";
            this.toolListaPedidos.Size = new System.Drawing.Size(114, 19);
            this.toolListaPedidos.Text = "ListaPedidos";
            this.toolListaPedidos.Visible = false;
            this.toolListaPedidos.Click += new System.EventHandler(this.listaPedidosToolStripMenuItem_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogin.Controls.Add(this.lblResposta);
            this.pnLogin.Controls.Add(this.txtSenha);
            this.pnLogin.Controls.Add(this.button1);
            this.pnLogin.Controls.Add(this.txtEmail);
            this.pnLogin.Controls.Add(this.lblSenha);
            this.pnLogin.Controls.Add(this.lblEmail);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Location = new System.Drawing.Point(410, 1);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(399, 101);
            this.pnLogin.TabIndex = 13;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(287, 76);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(722, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Visible = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(655, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(61, 13);
            this.lblBemVindo.TabIndex = 14;
            this.lblBemVindo.Text = "Bem Vindo:";
            this.lblBemVindo.Visible = false;
            // 
            // lblNomeSessao
            // 
            this.lblNomeSessao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeSessao.AutoSize = true;
            this.lblNomeSessao.Location = new System.Drawing.Point(724, 9);
            this.lblNomeSessao.Name = "lblNomeSessao";
            this.lblNomeSessao.Size = new System.Drawing.Size(0, 13);
            this.lblNomeSessao.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(658, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 23);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CronstruçaoVenda.Properties.Resources.real_estate_and_building_home_logo_vector_png_92135;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(22, 125);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(91, 39);
            this.btnAddCar.TabIndex = 18;
            this.btnAddCar.Text = "Add Carrinho";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // LstVOfertas
            // 
            this.LstVOfertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVOfertas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cName,
            this.cValor,
            this.cDesc,
            this.UrlImg});
            this.LstVOfertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LstVOfertas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LstVOfertas.GridLines = true;
            this.LstVOfertas.HideSelection = false;
            this.LstVOfertas.Location = new System.Drawing.Point(136, 125);
            this.LstVOfertas.Name = "LstVOfertas";
            this.LstVOfertas.Size = new System.Drawing.Size(669, 337);
            this.LstVOfertas.TabIndex = 19;
            this.LstVOfertas.UseCompatibleStateImageBehavior = false;
            this.LstVOfertas.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // cName
            // 
            this.cName.Text = "Nome";
            this.cName.Width = 173;
            // 
            // cValor
            // 
            this.cValor.Text = "Valor";
            this.cValor.Width = 89;
            // 
            // cDesc
            // 
            this.cDesc.Text = "Descrição";
            this.cDesc.Width = 108;
            // 
            // UrlImg
            // 
            this.UrlImg.Text = "Img";
            this.UrlImg.Width = 242;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(133, 109);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(44, 13);
            this.lblSituacao.TabIndex = 20;
            this.lblSituacao.Text = "Ofertas:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.LstVOfertas);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblNomeSessao);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrinhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolListaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem toolListaProdutos;
        private System.Windows.Forms.ToolStripMenuItem toolListaPedidos;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblNomeSessao;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListView LstVOfertas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cValor;
        private System.Windows.Forms.ColumnHeader cDesc;
        private System.Windows.Forms.ColumnHeader UrlImg;
        private System.Windows.Forms.Label lblSituacao;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResposta;
    }
}

