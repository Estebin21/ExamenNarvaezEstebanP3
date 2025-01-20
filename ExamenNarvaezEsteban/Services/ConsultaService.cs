using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExamenNarvaezEsteban.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenNarvaezEsteban.Services
{
   
    public class ConsultaService : IConsultaService
    {
        HttpClient client = new HttpClient();

        public async Task<Consulta> Obtener(string Nombre)
        {
            string urlLink = "https://restcountries.com/v3.1/name/" + Nombre + "?fields=name,region,maps";
            client.BaseAddress = new Uri(urlLink);
            var cliente = new HttpClient();
            var ConsultaApi = new Consulta();
            HttpResponseMessage respuestaApi = await client.GetAsync("");
            if (respuestaApi.IsSuccessStatusCode)
            {
                var ResponsePais = await respuestaApi.Content.ReadAsStringAsync();
                JsonNode nodo = JsonNode.Parse(ResponsePais);
                JsonNode result = nodo["result"];
                ConsultaApi = JsonConvert.DeserializeObject<Consulta>(result.ToString());
            }
            return ConsultaApi;

        }
    }
}
