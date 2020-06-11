using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronstruçaoVenda
{
    public partial class FormLstPedido : Form
    {

        public FormLstPedido()
        {
            
            InitializeComponent();
          

        }

    

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {

            this.BtnDeleteUser.Enabled = false;
            var a = LstVPedido.SelectedItems;
            List<string> c = new List<string>();
            foreach (ListViewItem b in a)
            {
                c.Add(b.Text);

            }

            var t = Task.Factory.StartNew(async () =>
            {
               
                foreach (string id in c)
                {
                    
                    await PedidoController.DeletePedidoAsync(id);
                }

            });
          
            t.ContinueWith((x) => 
            {
                lblException.Text = "Deletado!!!";               
                AtualizarLista();
                this.BtnDeleteUser.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());           
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            var frm = new FormCadPedido(this);



            frm.btnCadSave.Visible = true;
            frm.panelUp.Visible = false;
            frm.Show();


        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            lblException.Text = null;

            var frm = new FormCadPedido(this);
            if(LstVPedido.SelectedItems.Count == 1)
            {
                var a = LstVPedido.SelectedItems;

                List<string> c = new List<string>();
                foreach (ListViewItem b in a)
                {
                    c.Add(b.Text);

                }

                foreach (Pedido p in PedidoController.LstPedido)
                {
                    if (p.Id.Equals(c.First<String>()))
                    {
                        frm.txtEndereco.Text = p.Endereco;
                        frm.txtIdProd.Text = p.Id_produto;
                        frm.txtIdUser.Text = p.Id_usuario;
                        frm.txtId.Text = p.Id;
                        frm.txtQuant.Text = p.Quantidade;
                    }
                }
                frm.btnCadSave.Visible = false;
                frm.panelUp.Visible = true;
                frm.Show();
            }
            else
            {
                lblException.Text = "Nenhum Item Selecionado";
            }
            

        }


        public void AtualizarLista()
        {
            lblException.Text = null;

            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await PedidoController.GetAllPedidos();
            });


            t.ContinueWith((x) =>
            { 

                LstVPedido.Items.Clear();

                foreach (Pedido p in x.Result)
                {
                    LstVPedido.Items.Add(p.toListViewItem());
                }

                PedidoController.LstPedido = x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());
           
        }

        private void FormLstPedido_Load(object sender, EventArgs e)
        {
            try {
                AtualizarLista(); 
            }catch(Exception)
            {
                lblException.Text = "Sem Conexão";
            }
            

        }
    }
}
