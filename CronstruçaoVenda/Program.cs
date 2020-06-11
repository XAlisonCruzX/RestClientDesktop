using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronstruçaoVenda
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        public static Pedido loginOn;

        [STAThread]
        static void Main()
        {
            UsuarioController.inicializeClient();
            ProdutoController.inicializeClient();
            PedidoController.inicializeClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
