namespace CronstruçaoVenda
{
    partial class FormLstPedido
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
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.LstVPedido = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista De Pedidos:";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.Location = new System.Drawing.Point(588, 46);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(94, 34);
            this.btnSaveUser.TabIndex = 8;
            this.btnSaveUser.Text = "New";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(588, 141);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(94, 31);
            this.BtnDeleteUser.TabIndex = 7;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectUser.Location = new System.Drawing.Point(588, 95);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(94, 31);
            this.btnSelectUser.TabIndex = 6;
            this.btnSelectUser.Text = "Select";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // LstVPedido
            // 
            this.LstVPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.idUsuario,
            this.endereco,
            this.idProduto,
            this.quant});
            this.LstVPedido.GridLines = true;
            this.LstVPedido.HideSelection = false;
            this.LstVPedido.Location = new System.Drawing.Point(27, 46);
            this.LstVPedido.Name = "LstVPedido";
            this.LstVPedido.Size = new System.Drawing.Size(526, 412);
            this.LstVPedido.TabIndex = 11;
            this.LstVPedido.UseCompatibleStateImageBehavior = false;
            this.LstVPedido.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id Pedido";
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "Id Usuario";
            // 
            // endereco
            // 
            this.endereco.Text = "Endereço";
            this.endereco.Width = 234;
            // 
            // idProduto
            // 
            this.idProduto.Text = "Id Produto";
            this.idProduto.Width = 77;
            // 
            // quant
            // 
            this.quant.Text = "Quantidade";
            this.quant.Width = 224;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(121, 23);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(0, 13);
            this.lblException.TabIndex = 12;
            // 
            // FormLstPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 491);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.LstVPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.btnSelectUser);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FormLstPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FormLstPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader endereco;
        private System.Windows.Forms.ColumnHeader idProduto;
        private System.Windows.Forms.ColumnHeader quant;
        public System.Windows.Forms.ListView LstVPedido;
        public System.Windows.Forms.Label lblException;
    }
}