namespace CronstruçaoVenda
{
    partial class FormLstUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.LstVUsuario = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Usuarios:";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.Location = new System.Drawing.Point(767, 37);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 33);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "New";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectUser.Location = new System.Drawing.Point(767, 95);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(75, 33);
            this.btnSelectUser.TabIndex = 3;
            this.btnSelectUser.Text = "Select";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(767, 151);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(75, 34);
            this.BtnDeleteUser.TabIndex = 4;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // LstVUsuario
            // 
            this.LstVUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cNome,
            this.cSobrenome,
            this.cEmail,
            this.cNascimento,
            this.cEndereco});
            this.LstVUsuario.GridLines = true;
            this.LstVUsuario.HideSelection = false;
            this.LstVUsuario.Location = new System.Drawing.Point(12, 37);
            this.LstVUsuario.Name = "LstVUsuario";
            this.LstVUsuario.Size = new System.Drawing.Size(728, 401);
            this.LstVUsuario.TabIndex = 6;
            this.LstVUsuario.UseCompatibleStateImageBehavior = false;
            this.LstVUsuario.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 49;
            // 
            // cNome
            // 
            this.cNome.Text = "Nome";
            this.cNome.Width = 108;
            // 
            // cSobrenome
            // 
            this.cSobrenome.Text = "Sobrenome";
            this.cSobrenome.Width = 150;
            // 
            // cEmail
            // 
            this.cEmail.Text = "Email";
            this.cEmail.Width = 194;
            // 
            // cNascimento
            // 
            this.cNascimento.Text = "Nascimento";
            this.cNascimento.Width = 122;
            // 
            // cEndereco
            // 
            this.cEndereco.Text = "Endereco";
            this.cEndereco.Width = 421;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(111, 13);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(0, 13);
            this.lblException.TabIndex = 7;
            // 
            // FormLstUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.LstVUsuario);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.label1);
            this.Name = "FormLstUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormLstUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cNome;
        private System.Windows.Forms.ColumnHeader cSobrenome;
        private System.Windows.Forms.ColumnHeader cEmail;
        private System.Windows.Forms.ColumnHeader cNascimento;
        private System.Windows.Forms.ColumnHeader cEndereco;
        private System.Windows.Forms.Label lblException;
        public System.Windows.Forms.ListView LstVUsuario;
    }
}