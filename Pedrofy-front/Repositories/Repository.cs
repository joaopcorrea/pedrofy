using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pedrofy_front.Repositories
{
    internal class Repository
    {
        HttpClient client;

        string url = "https://localhost:9651/track";


        public Repository()
        {
            client = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string filter = "", string resource = "")
        {
            var endpoint = url;
            if (!string.IsNullOrEmpty(resource)) endpoint += "/" + resource;
            if (!string.IsNullOrEmpty(filter)) endpoint += $"?filter={filter}";
            var response = await client.GetAsync(endpoint);

            T obj;

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                obj = JsonSerializer.Deserialize<T>(json);
            }
            else
            {
                return default(T);
            }

            return obj;
        }

        public async Task<T> PostAsync<T>(string endpoint)
        {
            var response = await client.PostAsync(url + "/" + endpoint, null);

            T obj;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                obj = JsonSerializer.Deserialize<T>(content);
            }
            else
            {
                return default(T);
            }

            return obj;
        }

        public async Task<bool> PostAsync<T>(string endpoint, T body)
        {
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url + "/" + endpoint, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string endpoint)
        {
            var response = await client.DeleteAsync(url + "/" + endpoint);
            return response.IsSuccessStatusCode;
        }
    }
}
