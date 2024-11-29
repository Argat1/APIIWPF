using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIIWPF
{
    public static class Porada
    {
        public static async Task<string> LosuPorade()
        {
            string apiUrl = "https://api,adviceslip.com/advice";
            using (HttpClient klient = new HttpClient())
            {
                HttpResponseMessage odpowiedz = await klient.GetAsync(apiUrl);
                odpowiedz.EnsureSuccessStatusCode();
                string odp = await odpowiedz.Content.ReadAsStringAsync();
                var json = JObject.Parse(odp);
                string porada = json["slip"]["advice"].ToString();
                return porada;
            }
    }
}
