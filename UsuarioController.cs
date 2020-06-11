using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UsuarioController
{


	public class Usuario
	{

		private String id { get; set; }
		[JsonProperty("first_name")]
		private String firstName { get; set; }
		[JsonProperty("last_name")]
		private String lastName { get; set; }
		[JsonProperty("email")]
		private String email { get; set; }
		[JsonProperty("password")]
		private String senha { get; set; }
		[JsonProperty("birth_date")]
		private String nascimento { get; set; }
		[JsonProperty("address")]
		private String endereco { get; set; }
		[JsonProperty("privilege")]
		private String privilege { get; set; }



		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override string ToString()
		{
			return base.ToString();
		}

	}


	public class UsuarioConnect
	{

        static HttpClient client = new HttpClient();

        static async Task<Uri> CreateProductAsync(Usuario usuario)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
              "api/cusuario/save", usuario);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;

        }

        static async Task<Product> GetUsuario(String id)
        {
           Usuario usuario = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/usuario/id/{id}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<Usuario>();
            }
            return product;
        }



        static async Task<List<Usuario>> GetAllUsuario()
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

        static async Task<Usuario> UpdateUsuarioAsync(Usuario usuario)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/api/cusuario/update/{product.Id}", usuario);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            usuario = await response.Content.ReadAsAsync<Usuario>();
            return product;
        }

        static async Task<HttpStatusCode> DeleteUsuarioAsync(String id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/delete/usuario/{id}");
            return response.StatusCode;
        }




    }
}