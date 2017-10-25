using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace testeAPIGoogle.APIs
{
    class ConsumirGeoAPI
    {
        public string[] consumirGeoAPI(string end)
        {
            try {
                string urlJson = "http://maps.googleapis.com/maps/api/geocode/json?address=" + end ;
                string resultadosJson = new WebClient { Encoding = Encoding.UTF8 }.DownloadString(urlJson);
                RootObject dados = JsonConvert.DeserializeObject<RootObject>(resultadosJson);
                string[] retorna = { dados.results.First().formatted_address.ToString(), dados.results.First().geometry.location.lng.ToString(), dados.results.First().geometry.location.lat.ToString() };
                return retorna;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.Message);
                string[] retorna = { "","",""};
                return retorna;
            }
        }
    }
}
