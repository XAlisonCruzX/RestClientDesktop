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
    public partial class FormPrincipal : Form
    {

        public FormCarrinho carrinho = new FormCarrinho();

        public bool login = false;
        public Usuario usuarioLogin;
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await UsuarioController.GetAllUsuario();
            });

            t.ContinueWith((x) =>
            {
                foreach (Usuario u in x.Result)
                {
                    if(u.email.Equals(txtEmail.Text) && u.senha.Equals(txtSenha.Text))
                    {
                        usuarioLogin = u;
                        
                        pnLogin.Visible     = false;
                        lblUsuario.Visible  = true;
                        lblBemVindo.Visible = true;
                        lblUsuario.Text = usuarioLogin.firstName;
                        btnLogout.Visible   = true;
                        login               = true;

                        if (usuarioLogin.privilege.Equals("Admin"))
                        {
                            toolListaPedidos.Visible    = true;
                            toolListaProdutos.Visible   = true;
                            toolListaUsuarios.Visible   = true;


                        }


                    }
                }
                if(login != true)
                {
                    lblResposta.Visible = true;
                    lblResposta.Text = "Erro no login";
                }
                else
                {
                    lblResposta.Visible = false;
                }
                UsuarioController.LstUsuario= x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void listaPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar um novo formulário de Cadastro de clientes
            var frm = new FormLstPedido();

            // Exibindo o formulário
            frm.Show();
            

        }

        private void listaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar um novo formulário de Cadastro de clientes
            var frm = new FormLstProduto();

            // Definindo qual é o form pai dessa nova janela

            


            // Exibindo o formulário
            frm.Show();
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar um novo formulário de Cadastro de clientes
            var frm = new FormLstUsuario();

            // Definindo qual é o form pai dessa nova janela
            

            // Exibindo o formulário
            frm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AttOfertas();



        }

        public void AttProduct()
        {           

            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await ProdutoController.GetAllProduct();
            });

            t.ContinueWith((x) =>
            {
                LstVOfertas.Items.Clear();

                foreach (Product p in x.Result)
                {
                    LstVOfertas.Items.Add(p.toListViewItem());
                }

                ProdutoController.LstProduto = x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void AttOfertas()
        {



            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await ProdutoController.GetAllProduct();
            });

            t.ContinueWith((x) =>
            {
                LstVOfertas.Items.Clear();

                for(int i = 0 ; i < x.Result.Count; i += 2)
                {
                    
                    x.Result.RemoveAt(i);
                }



                foreach (Product p in x.Result)
                {
                    LstVOfertas.Items.Add(p.toListViewItem());
                }

                ProdutoController.LstProduto = x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttProduct();
            lblSituacao.Text = "Produtos:";
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "Ofertas:";
            AttOfertas();
        }


        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var pedido = LstVOfertas.SelectedItems;

            foreach(ListViewItem lvi in pedido)
            {

                
                carrinho.LstVProduct.Items.Add((ListViewItem)lvi.Clone());
            }
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new FormCarrinho(this);
            var tamanho = carrinho.LstVProduct.Items.Count;

            ListViewItem[] list = new ListViewItem[tamanho]; ;
            for (int i = 0; i < tamanho ; i++)
            {
                list[i] = (ListViewItem)carrinho.LstVProduct.Items[i].Clone();
            }


            c.LstVProduct.Items.AddRange(list);

            c.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login                       = false;
            usuarioLogin                = null;
            lblUsuario.Text             = null;
            lblUsuario.Visible          = false;
            lblBemVindo.Visible         = false;
            btnLogout.Visible           = false;
            pnLogin.Visible             = true;                    
            toolListaPedidos.Visible    = false;
            toolListaProdutos.Visible   = false;
            toolListaUsuarios.Visible   = false;


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormCadUsuario();


            frm.btnCadSave.Visible = true;
            frm.panelUp.Visible = false;
            frm.Show();
        }
    }
}
