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
    public partial class FormLstUsuario : Form
    {
        public FormLstUsuario()
        {
            InitializeComponent();
        }


        public void AtualizarLista()
        {

            lblException.Text = null;

            var t = Task.Run(async () =>
            {
                Thread.Sleep(500);
                return await UsuarioController.GetAllUsuario();
            });


            t.ContinueWith((x) =>
            {

                LstVUsuario.Items.Clear();

                foreach (Usuario p in x.Result)
                {
                    LstVUsuario.Items.Add(p.toListViewItem());
                }

                UsuarioController.LstUsuario = x.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void FormLstUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLista();
            }catch(Exception)
            {
                lblException.Text = "Sem Conexão";
            }
              
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.BtnDeleteUser.Enabled = false;
            var a = LstVUsuario.SelectedItems;
            List<string> c = new List<string>();
            foreach (ListViewItem b in a)
            {
                c.Add(b.Text);

            }

            var t = Task.Factory.StartNew(async () =>
            {

                foreach (string id in c)
                {

                    await UsuarioController.DeleteUsuarioAsync(id);
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
            var frm = new FormCadUsuario(this);

            
            frm.btnCadSave.Visible  = true;
            frm.panelUp.Visible     = false;
            frm.Show();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            lblException.Text = null;

            var frm = new FormCadUsuario(this);
            if (LstVUsuario.SelectedItems.Count == 1)
            {
                var a = LstVUsuario.SelectedItems;

                List<string> c = new List<string>();
                foreach (ListViewItem b in a)
                {
                    c.Add(b.Text);

                }

                foreach (Usuario p in UsuarioController.LstUsuario)
                {
                    if (p.id.Equals(c.First<String>()))
                    {
                        frm.txtEndereco.Text    = p.endereco;
                        frm.txtEmail.Text       = p.email;
                        frm.txtNascimento.Text  = p.nascimento;
                        frm.txtNome.Text        = p.firstName;
                        frm.txtSobrenome.Text   = p.lastName;
                        frm.txtSenha.Text       = p.senha;
                        frm.txtId.Text          = p.id;
                        frm.txtPrivilegio.Text  = p.privilege;


                      
                    }
                }
                frm.lblRSenha.Visible   = false;
                frm.txtRSenha.Visible   = false;
                frm.btnCadSave.Visible  = false;
                frm.panelUp.Visible     = true;
                frm.Show();
            }
            else
            {
                lblException.Text = "Nenhum Item Selecionado";
            }
        }
    }
}
