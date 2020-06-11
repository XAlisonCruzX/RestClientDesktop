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
    public partial class FormCadProduto : System.Windows.Forms.Form
    {

        FormLstProduto ProdutoLstForm { get; set; }
        public FormCadProduto()
        {
            InitializeComponent();
        }

        public FormCadProduto(FormLstProduto ProdutoForm)
        {
            InitializeComponent();
            ProdutoLstForm = ProdutoForm;

        }

        private void btnCadUpdate_Click(object sender, EventArgs e)
        {
            Product produto = new Product();

            produto.Desc = txtDesc1.Text + " " + txtDesc2.Text + " " + txtDesc3.Text;
            produto.Valor = txtValor.Text;
            produto.UrlImg = txtUrl.Text;
            produto.Nome = txtNome.Text;


            if(txtNome.Text != null
               && txtDesc1 != null
               && txtUrl != null
               && txtValor != null)
            {
                if ((float.TryParse(txtValor.Text, out float a) && a >= 0.1f))
                {


                    var t = Task.Factory.StartNew(async () =>
                    {

                        await ProdutoController.UpdateProductAsync(produto);

                    });


                    t.ContinueWith((x) =>
                    {

                        lblResultado.Text = "Atualizado!!";
                        ProdutoLstForm.AtualizarLista();


                    }, TaskScheduler.FromCurrentSynchronizationContext());

                }
                else
                {
                    lblResultado.Text = "Campo numerico contem Char";
                }
            }
            else
            {
                lblResultado.Text = "Preencha campos nulos";
            }
           
        }

        private void btnCadSave_Click(object sender, EventArgs e)
        {
            Product produto = new Product();

            produto.Desc = txtDesc1.Text + " " + txtDesc2.Text + " " + txtDesc3.Text;
            produto.Valor = txtValor.Text;
            produto.UrlImg = txtUrl.Text;
            produto.Nome = txtNome.Text;


            if (txtNome.Text != null
               && txtDesc1 != null
               && txtUrl != null
               && txtValor != null)
            {
                if ((float.TryParse(txtValor.Text, out float a) && a >= 0.1f))
                {


                    var t = Task.Factory.StartNew(async () =>
                    {

                        await ProdutoController.CreateProductAsync(produto);

                    });


                    t.ContinueWith((x) =>
                    {

                        lblResultado.Text = "Atualizado!!";
                        this.Close();
                        ProdutoLstForm.AtualizarLista();


                    }, TaskScheduler.FromCurrentSynchronizationContext());

                }
                else
                {
                    lblResultado.Text = "Campo numerico contem Char";
                }
            }
            else
            {
                lblResultado.Text = "Preencha campos nulos";
            }




        }
    }
}
