namespace CronstruçaoVenda
{
    partial class FormCadPedido
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
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCadSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(35, 187);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(252, 20);
            this.txtComplemento.TabIndex = 50;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(35, 144);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(252, 20);
            this.txtEndereco.TabIndex = 49;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(35, 79);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(65, 13);
            this.labelUrl.TabIndex = 47;
            this.labelUrl.Text = "Quantidade:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(35, 95);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(75, 20);
            this.txtQuant.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Endereço:";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(175, 44);
            this.txtIdUser.Multiline = true;
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(100, 20);
            this.txtIdUser.TabIndex = 44;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(35, 44);
            this.txtIdProd.Multiline = true;
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(101, 20);
            this.txtIdProd.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Id do Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id do Produto:";
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.label9);
            this.panelUp.Controls.Add(this.btnCadUpdate);
            this.panelUp.Controls.Add(this.txtId);
            this.panelUp.Location = new System.Drawing.Point(165, 220);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(134, 40);
            this.panelUp.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID:";
            // 
            // btnCadUpdate
            // 
            this.btnCadUpdate.Location = new System.Drawing.Point(2, 9);
            this.btnCadUpdate.Name = "btnCadUpdate";
            this.btnCadUpdate.Size = new System.Drawing.Size(53, 31);
            this.btnCadUpdate.TabIndex = 18;
            this.btnCadUpdate.Text = "Update";
            this.btnCadUpdate.UseVisualStyleBackColor = true;
            this.btnCadUpdate.Click += new System.EventHandler(this.btnCadUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 20;
            // 
            // btnCadSave
            // 
            this.btnCadSave.Location = new System.Drawing.Point(34, 229);
            this.btnCadSave.Name = "btnCadSave";
            this.btnCadSave.Size = new System.Drawing.Size(125, 31);
            this.btnCadSave.TabIndex = 51;
            this.btnCadSave.Text = "Save";
            this.btnCadSave.UseVisualStyleBackColor = true;
            this.btnCadSave.Click += new System.EventHandler(this.btnCadSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Complemento:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(35, 214);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(0, 13);
            this.lblCadastro.TabIndex = 55;
            // 
            // FormCadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 280);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.btnCadSave);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadPedido";
            this.Text = "CadPedido";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCadastro;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtQuant;
        public System.Windows.Forms.TextBox txtIdUser;
        public System.Windows.Forms.TextBox txtIdProd;
        public System.Windows.Forms.Panel panelUp;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Button btnCadSave;
    }
}