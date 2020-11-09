using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment1.Data;
using Models;

namespace Assignment1.Cloud
{
    public class CloudFamilyService : IService
    {
        private IList<Adult> Adults { get;  set; }
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://dnp.metamate.me/");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync("http://dnp.metamate.me/", content);
            
        }

        public async Task RemoveAdultAsync(Adult adult)
        {
            HttpClient client = new HttpClient();
            await client.DeleteAsync($"{"http://dnp.metamate.me/"}/todos/{adult.Id}");
        }

        public async Task UpdateAsync(Adult adult)
        {
            HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{"http://dnp.metamate.me/"}/todos/{adult.Id}", content);
        }
    }
}