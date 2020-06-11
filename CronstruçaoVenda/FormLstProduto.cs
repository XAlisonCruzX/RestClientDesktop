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
    public partial class FormLstProduto : System.Windows.Forms.Form
    {
        public FormLstProduto()
        {
            InitializeComponent();
        }

        private void FormLstProduto_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLista();
            }
            catch (Exception)
            {
                lblException.Text = "Sem Conexão";
            }
        }

        public void AtualizarLista()
        {


            lblException.Text = null;

            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await ProdutoController.GetAllProduct();
            });

            t.ContinueWith((x) =>
            {
                LstVProduct.Items.Clear();

                foreach (Product p in x.Result)
                {
                    LstVProduct.Items.Add(p.toListViewItem());
                }

                ProdutoController.LstProduto = x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());

           
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {


            this.BtnDeleteUser.Enabled = false;
            var a = LstVProduct.SelectedItems;
            List<string> c = new List<string>();
            foreach (ListViewItem b in a)
            {
                c.Add(b.Text);

            }

            var t = Task.Factory.StartNew(async () =>
            {

                foreach (string id in c)
                {

                    await ProdutoController.DeleteProductAsync(id);
                }

            });

            t.ContinueWith((x) =>
            {
                lblException.Text = "Deletado!!!";
                AtualizarLista();
                this.BtnDeleteUser.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());



        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            lblException.Text = null;

            var frm = new FormCadProduto(this);
            if (LstVProduct.SelectedItems.Count == 1)
            {
                var a = LstVProduct.SelectedItems;

                List<string> c = new List<string>();
                foreach (ListViewItem b in a)
                {
                    c.Add(b.Text);

                }

                foreach (Product p in ProdutoController.LstProduto)
                {
                    if (p.Id.Equals(c.First<String>()))
                    {

                        frm.txtId.Text = p.Id;
                        frm.txtNome.Text = p.Nome;
                        frm.txtValor.Text = p.Valor;
                        frm.txtUrl.Text = p.UrlImg;
                        frm.txtDesc1.Text = p.Desc;


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

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            var frm = new FormCadProduto(this);



            frm.btnCadSave.Visible = true;
            frm.panelUp.Visible = false;
            frm.Show();
        }
    }
}
