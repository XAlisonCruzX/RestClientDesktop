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

    public class Product
    {
        
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("nome")]
        public String Nome { get; set; }
        [JsonProperty("valor")]
        public String Valor { get; set; }
        [JsonProperty("desc")]
        public String Desc { get; set; }
        [JsonProperty("urlImg")]
        public String UrlImg { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public ListViewItem toListViewItem()
        {

            string[] p1 = { Id, Nome, Valor, Desc, UrlImg };
            var list = new ListViewItem(p1);
            return list;
        }

    }

    public class ProdutoController
    {
        static HttpClient client = new HttpClient();

        public static List<Product> LstProduto{ get; set; }
        public static Product SingleProduto { get; set; }
        public static void inicializeClient()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
              "api/cproduto/save", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;

        }

        public static async Task<Product> GetProduct(String id)
        {
            Product product = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/produto/id/{id}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }



        public static async Task<List<Product>> GetAllProduct()
        {
            List<Product> product = null;

            HttpResponseMessage response = await client.GetAsync(
           $"api/produto");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<List<Product>>();
            }
            return product;
        }

        public static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/api/cproduto/update/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }

        public static async Task<HttpStatusCode> DeleteProductAsync(String id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/delete/produto/{id}");
            return response.StatusCode;
        }

        public static async void AttList()
        {

            LstProduto = await GetAllProduct();

        }


        public static async void Cadastro(Product produto)
        {
            await CreateProductAsync(produto);
        }


        public static async void getById(String Id)
        {
            SingleProduto = await GetProduct(Id);
        }


        public static async void update(Product produto)
        {
            SingleProduto = await UpdateProductAsync(produto);
        }

        public static async void delete(String id)
        {
            await DeleteProductAsync(id);
        }
    }
}
