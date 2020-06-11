using System;
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
    public partial class FormCadPedido : Form
    {
        FormLstPedido lstPedidoForm;
        FormCarrinho carrinhoForm;
        bool carrinho = false;
        public FormCadPedido()
        {
            InitializeComponent();
        }

        public FormCadPedido(FormLstPedido pai)
        {
            lstPedidoForm = pai;
            InitializeComponent();
            carrinho = false;
        }
        public FormCadPedido(FormCarrinho frmCarrinho)
        {
            carrinhoForm = frmCarrinho;
            InitializeComponent();
            carrinho = true;
        }




        private void btnCadSave_Click(object sender, EventArgs e)
        {
            Pedido pedidoSave = new Pedido();




            pedidoSave.Endereco = txtEndereco.Text;
            pedidoSave.Id_produto = txtIdProd.Text;
            pedidoSave.Id_usuario = txtIdUser.Text;
            pedidoSave.Quantidade = txtQuant.Text;
          
            if (pedidoSave.Endereco != null
               && pedidoSave.Id_produto != null
               && pedidoSave.Id_produto != null
               && pedidoSave.Quantidade != null
               )
            {

                if ((long.TryParse(pedidoSave.Id_produto, out long id2) && id2 >= 1) 
                    && (long.TryParse(pedidoSave.Id_usuario, out long id3) && id3 >= 1) 
                    && (int.TryParse(pedidoSave.Quantidade, out int q ) && q >= 1)

                   )
                {
                    var t = Task.Factory.StartNew(async () =>
                    {
                        await PedidoController.CreatePedidoAsync(pedidoSave);
                    });

                    t.ContinueWith((x) =>
                    {
                        lblCadastro.Text = "Cadastrado!!";
                        this.Close();
                        if(carrinho == false)
                        {
                            lstPedidoForm.AtualizarLista();
                        }
                        
                                
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                   
                }
                else
                {
                    lblCadastro.Text = "Campos Numereicos preenchidos com caracteres ou 0";
                }

            }
            else
            {
                lblCadastro.Text = "Campo Nulo ";
            }

            

        }

        private void btnCadUpdate_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();


            pedido.Endereco = txtEndereco.Text + " "  + txtComplemento.Text;
            pedido.Id = txtId.Text;
            pedido.Id_produto = txtIdProd.Text;
            pedido.Id_usuario = txtIdUser.Text;
            pedido.Quantidade = txtQuant.Text;
        
            if (pedido.Endereco != null
               && pedido.Id_produto != null
               && pedido.Id_produto != null
               && pedido.Quantidade != null
               )          
            {
                
                if((long.TryParse(pedido.Id, out long id)) && id >= 1
                    && (long.TryParse(pedido.Id_produto, out long id2)) && id2 >= 1
                    && (long.TryParse(pedido.Id_usuario, out long id3)) && id3 >= 1
                    && (int.TryParse(pedido.Id, out int q)) && q >= 1)
                {
                    var t  = Task.Factory.StartNew(async () =>
                    {
                        
                        await PedidoController.UpdatePedidosAsync(pedido);
                       
                    });

                    t.ContinueWith((x) =>
                    {
                        
                        lblCadastro.Text = "Atualizado!!";
                        lstPedidoForm.AtualizarLista();
                                         

                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    
                    
                }
                else
                {
                    lblCadastro.Text = "Campos Numereicos preenchidos com caracteres";
                }
                


            }
            else
            {
                lblCadastro.Text = "Campo Nulo ";
            }






        }
    }
}

  