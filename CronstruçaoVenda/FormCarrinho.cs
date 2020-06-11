using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronstruçaoVenda
{   

    
    public partial class FormCarrinho : Form
    {
        FormPrincipal formPri;
        public FormCarrinho()
        {
            InitializeComponent();
        }
    

   
        public FormCarrinho(FormPrincipal frm)
        {
            InitializeComponent();
            formPri = frm;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem lsv in LstVProduct.SelectedItems)
            {
                lsv.Remove();
                
            }
            var tamanho = LstVProduct.Items.Count;

            ListViewItem[] list = new ListViewItem[tamanho]; ;
            for (int i = 0; i < tamanho; i++)
            {
                list[i] = (ListViewItem)LstVProduct.Items[i].Clone();
            }

            formPri.carrinho.LstVProduct.Items.Clear();
            formPri.carrinho.LstVProduct.Items.AddRange(list);

        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            if (formPri.login)
            {
                var frm = new FormCadPedido(this);

                frm.txtIdUser.Text = formPri.usuarioLogin.id;
                frm.txtIdProd.Text = LstVProduct.SelectedItems[0].SubItems[0].Text;
                frm.txtIdUser.ReadOnly = true;
                frm.txtIdProd.ReadOnly = true;
                frm.btnCadSave.Visible = true;
                frm.panelUp.Visible = false;
                frm.Show();
            }
            else
            {
                lblException.Text = "Faço Login primeiro";
            }
            
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }
    }
}
