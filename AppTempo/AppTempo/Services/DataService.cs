using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppTempo.Model;

namespace AppTempo.Services
{
    internal class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "cab61427ed149de6b87cd8b50e0076d2";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;
            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            if (resultado["tempo"] !=null)
            {
                Tempo previsao = new Tempo();
                previsao.Titulo = (string)resultado["name"];
                previsao.Temperatura = (string)resultado["main"]["temp"] + " C";
                previsao.Vento = (string)resultado["wind"]["speed"] + " mph";
                previsao.Umidade = (string)resultado["main"]["humidity"] + " %";
                previsao.Visibilidade = (string)resultado["weather"][0]["main"];
                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime NascerSol = time.AddSeconds((double)resultado["sys"]["sunrise"]);
                DateTime PorSol = time.AddSeconds((double)resultado["sys"]["sunset"]);
                previsao.NascerSol = String.Format("{0:d/MM/yyyy HH:mm:ss}", NascerSol);
                previsao.PorSol = String.Format("{0:d/MM/yyyy HH:mm:ss}", PorSol);
                return previsao;
            }
            else
            {
                return null;
            }
        }

        public static async Task<dynamic> getDataFromServiceByCity(string city)
        {
            string appID = "cab61427ed149de6b87cd8b50e0076d2";

            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt='&APPID={1}", city.Trim)
        }
    }
}
