using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronstruçaoVenda
{
    public class Pedido
    {
		public String Id;
		[JsonProperty("id_usuario")]
		public String Id_usuario;
		[JsonProperty("quantidade")]
		public String Quantidade;
		[JsonProperty("id_produto")]
		public String Id_produto;
		[JsonProperty("endereco")]
		public String Endereco;

        public Pedido(string id, string id_usuario, string quantidade, string id_produto, string endereco)
        {
            Id = id;
            Id_usuario = id_usuario;
            Quantidade = quantidade;
            Id_produto = id_produto;
            Endereco = endereco;
        }

        public Pedido()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public ListViewItem toListViewItem()
        {

            string[] p1 = {Id, Id_usuario, Endereco, Id_produto, Quantidade };
            var list = new ListViewItem(p1);
            return list;
        }
    }


    public class PedidoController
    {
        static HttpClient client = new HttpClient();
        public static List<Pedido> LstPedido { get; set; }
        public static Pedido SinglePedido { get; set; }

        public static void inicializeClient()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Uri> CreatePedidoAsync(Pedido pedido)
        {
           
            HttpResponseMessage response = await client.PostAsJsonAsync(
              "api/cpedido/save", pedido);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;

        }

        public static async Task<Pedido> GetPedido(String id)
        {

            Pedido pedido = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/pedido/id/{id}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                pedido = await response.Content.ReadAsAsync<Pedido>();
            }
            return pedido;
        }



        public static async Task<List<Pedido>> GetAllPedidos()
        {
          
            List<Pedido> pedidos = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/pedido");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                pedidos = await response.Content.ReadAsAsync<List<Pedido>>();
            }

          
            return pedidos;
        }

        public static async Task<Pedido> UpdatePedidosAsync(Pedido pedido)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/api/cpedido/update/{pedido.Id}", pedido);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            pedido = await response.Content.ReadAsAsync<Pedido>();
            return pedido;
        }

        public static async Task<HttpStatusCode> DeletePedidoAsync(String id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/delete/pedido/{id}");
            return response.StatusCode;
        }


        public static async void AttList()
        {

           LstPedido = await GetAllPedidos();

        }


        public static async void Cadastro(Pedido pedido)
        {
            await CreatePedidoAsync(pedido);
        }


        public static async void getById(String Id)
        {
            SinglePedido = await GetPedido(Id);
        }
        

        public static async void update(Pedido pedido)
        {
           SinglePedido = await UpdatePedidosAsync(pedido);
        }

        public static async void delete(String id)
        {
            await DeletePedidoAsync(id);
        }


    }


}
