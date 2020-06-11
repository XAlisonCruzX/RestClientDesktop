using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CronstruçaoVenda
{


	public class Usuario
	{

		public String id { get; set; }
		[JsonProperty("firstName")]
		public String firstName { get; set; }
		[JsonProperty("lastName")]
		public String lastName { get; set; }
		[JsonProperty("email")]
		public String email { get; set; }
		[JsonProperty("senha")]
		public String senha { get; set; }
		[JsonProperty("nascimento")]
		public String nascimento { get; set; }
		[JsonProperty("endereco")]
		public String endereco { get; set; }
		[JsonProperty("privilege")]
		public String privilege { get; set; }

		public override string ToString()
		{
			return base.ToString();
		}

        public ListViewItem toListViewItem()
        {

            string[] p1 = { id, firstName, lastName, email, nascimento.Substring(0,10), endereco };
            var list = new ListViewItem(p1);
            return list;
        }

    }


	public class UsuarioController
	{

        static HttpClient client = new HttpClient();

        public static List<Usuario> LstUsuario { get; set; }
        public static Usuario SingleUsuario { get; set; }
        public static void inicializeClient()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
       

        public static async Task<Uri> CreateUsuarioAsync(Usuario usuario)
        {


            HttpResponseMessage response = await client.PostAsJsonAsync(
              "api/cusuario/save", usuario);
            response.EnsureSuccessStatusCode();

 
            return response.Headers.Location;

        }

        public static async Task<Usuario> GetUsuario(String id)
        {
            

            Usuario usuario = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/usuario/id/{id}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<Usuario>();
            }
            return usuario;
        }

        public static async Task<List<Usuario>> GetAllUsuario()
        {
          
            List<Usuario> usuarios = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/usuario");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                usuarios= await response.Content.ReadAsAsync<List<Usuario>>();
            }
            return usuarios;
        }

        public static async Task<Usuario> UpdateUsuarioAsync(Usuario usuario)
        {

            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/api/cusuario/update/{usuario.id}", usuario);
            response.EnsureSuccessStatusCode();

           
            usuario = await response.Content.ReadAsAsync<Usuario>();
            return usuario;
        }

        public static async Task<HttpStatusCode> DeleteUsuarioAsync(String id)
        {

            HttpResponseMessage response = await client.DeleteAsync(
                $"api/delete/usuario/{id}");
            return response.StatusCode;
        }



        public static async void AttList()
        {

            LstUsuario = await GetAllUsuario();

        }


        public static async void Cadastro(Usuario usuario)
        {
            await CreateUsuarioAsync(usuario);
        }


        public static async void getById(String Id)
        {
            SingleUsuario = await GetUsuario(Id);
        }


        public static async void update(Usuario usuario)
        {
            SingleUsuario = await UpdateUsuarioAsync(usuario);
        }

        public static async void delete(String id)
        {
            await DeleteUsuarioAsync(id);
        }

    }
}