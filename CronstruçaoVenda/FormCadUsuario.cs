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
    public partial class FormCadUsuario : Form
    {
        FormLstUsuario UsuarioLstForm;
        bool a = false;
        public FormCadUsuario()
        {
            InitializeComponent();
        }

        public FormCadUsuario(FormLstUsuario UsuarioForm)
        {
            InitializeComponent();

            UsuarioLstForm = UsuarioForm;
            a = true;
        }


        private void btnCadUpdate_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.id = txtId.Text;
            usuario.email = txtEmail.Text;
            usuario.endereco = txtEndereco.Text + " " + txtComplemento.Text;
            usuario.firstName = txtNome.Text;
            usuario.lastName = txtSobrenome.Text;
            usuario.privilege = txtPrivilegio.Text;
            usuario.nascimento = txtNascimento.Text;
            usuario.senha = txtSenha.Text;

            if (txtId.Text          != null
                && txtEmail         != null
                && txtEndereco      != null
                && txtNome          != null
                && txtSobrenome     != null
                && txtPrivilegio    != null
                && txtNascimento    != null)
            {
                if (DateTime.TryParse(txtNascimento.Text, out DateTime a))
                {


                    var t = Task.Factory.StartNew(async () =>
                    {

                        await UsuarioController.UpdateUsuarioAsync(usuario);

                    });

                    t.ContinueWith((x) =>
                    {

                        lblResultado.Text = "Atualizado!!";
                        UsuarioLstForm.AtualizarLista();


                    }, TaskScheduler.FromCurrentSynchronizationContext());

                }
                else
                {
                    lblResultado.Text = "Data Error, Digite denovo";
                }



            }
            else
            {

                lblResultado.Text = "Campo nulo, Digite Novamente";
            }



        }

        private void btnCadSave_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.id          = txtId.Text;
            usuario.email       = txtEmail.Text;
            usuario.endereco    = txtEndereco.Text + " " + txtComplemento.Text;
            usuario.firstName   = txtNome.Text;
            usuario.lastName    = txtSobrenome.Text;
            usuario.privilege   = txtPrivilegio.Text;
            usuario.nascimento  = txtNascimento.Text;
            usuario.senha       = txtSenha.Text;

            if (txtId.Text              != null
                && txtEmail.Text        != null
                && txtEndereco.Text     != null
                && txtNome.Text         != null
                && txtSobrenome.Text    != null
                && txtPrivilegio.Text   != null
                && txtNascimento.Text   != null
                && txtSenha.Text        != null
                && txtRSenha.Text       != null)
            {
                if (DateTime.TryParse(txtNascimento.Text, out DateTime a))
                {
                    if (txtRSenha.Text.Equals(txtSenha.Text))
                    {
                        var t = Task.Factory.StartNew(async () =>
                        {

                            await UsuarioController.CreateUsuarioAsync(usuario);

                        });

                        t.ContinueWith((x) =>
                        {

                            lblResultado.Text = "Cadastrado!!";
                            this.Close();
                            if (this.a == true)
                            {
                                UsuarioLstForm.AtualizarLista();
                            }
                            


                        }, TaskScheduler.FromCurrentSynchronizationContext());
                    }
                    else
                    {
                        lblResultado.Text = "Senhas sem igualdade";
                    }

                   

                }
                else
                {
                    lblResultado.Text = "Data Error, Digite denovo";
                }

            }
            else
            {

                lblResultado.Text = "Campo nulo, Digite Novamente";
            }
        }

    }
}
