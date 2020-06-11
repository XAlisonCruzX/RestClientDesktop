namespace CronstruçaoVenda
{
    partial class FormLstProduto
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
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LstVProduct = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrlImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectUser.Location = new System.Drawing.Point(543, 87);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(94, 31);
            this.btnSelectUser.TabIndex = 1;
            this.btnSelectUser.Text = "Select";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(543, 135);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(94, 31);
            this.BtnDeleteUser.TabIndex = 2;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.Location = new System.Drawing.Point(543, 37);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(94, 34);
            this.btnSaveUser.TabIndex = 3;
            this.btnSaveUser.Text = "New";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista De Produto:";
            // 
            // LstVProduct
            // 
            this.LstVProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cName,
            this.cValor,
            this.cDesc,
            this.UrlImg});
            this.LstVProduct.GridLines = true;
            this.LstVProduct.HideSelection = false;
            this.LstVProduct.Location = new System.Drawing.Point(12, 37);
            this.LstVProduct.Name = "LstVProduct";
            this.LstVProduct.Size = new System.Drawing.Size(500, 415);
            this.LstVProduct.TabIndex = 6;
            this.LstVProduct.UseCompatibleStateImageBehavior = false;
            this.LstVProduct.View = System.Windows.Forms.View.Details;
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
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(109, 13);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(0, 13);
            this.lblException.TabIndex = 7;
            // 
            // FormLstProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 464);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.LstVProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.btnSelectUser);
            this.Name = "FormLstProduto";
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.FormLstProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cValor;
        private System.Windows.Forms.ColumnHeader cDesc;
        private System.Windows.Forms.ColumnHeader UrlImg;
        private System.Windows.Forms.Label lblException;
        public System.Windows.Forms.ListView LstVProduct;
    }
}