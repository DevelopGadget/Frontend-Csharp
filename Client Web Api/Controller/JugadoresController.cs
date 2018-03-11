using Client_Web_Api.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client_Web_Api.Controller
{
    class JugadoresController
    {
        public List<JugadoresModel> Jugadores { get; set; }
        private string BaseAdress = "http://web-api-net.a3c1.starter-us-west-1.openshiftapps.com/";
        private HttpResponseMessage resp { get; set; }
        private HttpClient client { get; set; }

        public bool Create(JugadoresModel Jugador)
        {
            return Post(Jugador);
        }

        public async Task<List<JugadoresModel>> Read()
        {
            if (await Get()) return Jugadores;
            else return null;
        }

        public async Task<JugadoresModel> Read(string Id)
        {
            if (await Get(Id) != null) return await Get(Id);
            else return null;
        }

        public bool Update(string Id, JugadoresModel Jugador)
        {
            return Put(Id, Jugador);
        }

        public bool Delete(string Id)
        {
            return DeleteHttp(Id);
        }

        private async Task<bool> Get()
        {
            try
            {
                using (client = new HttpClient())
                {
                    Client();
                    resp = await client.GetAsync("api/Jugadores");
                    if (resp.IsSuccessStatusCode)
                    {
                        var json = await resp.Content.ReadAsStringAsync();
                        json = json.TrimStart('\"');
                        json = json.TrimEnd('\"');
                        json = json.Replace("\\", "");
                        Jugadores = JsonConvert.DeserializeObject<List<JugadoresModel>>(json);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<JugadoresModel> Get(string Id)
        {
            try
            {
                using (client = new HttpClient())
                {
                    Client();
                    resp = await client.GetAsync("api/Jugadores/" + Id);
                    if (resp.IsSuccessStatusCode)
                    {
                        var json = await resp.Content.ReadAsStringAsync();
                        json = json.TrimStart('\"');
                        json = json.TrimEnd('\"');
                        json = json.Replace("\\", "");
                        return JsonConvert.DeserializeObject<JugadoresModel>(json);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool Post(JugadoresModel Jugador)
        {
            try
            {
                using (client = new HttpClient())
                {
                    Client();
                    resp = client.PostAsync("api/Jugadores", new StringContent(JsonConvert.SerializeObject(Jugador),
                                           Encoding.UTF8, "application/json")).Result;
                    if (resp.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Put(string Id, JugadoresModel Jugador)
        {
            try
            {
                using (client = new HttpClient())
                {
                    Client();
                    resp = client.PutAsync("api/Jugadores/" + Id, new StringContent(JsonConvert.SerializeObject(Jugador),
                                           Encoding.UTF8, "application/json")).Result;
                    if (resp.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool DeleteHttp(string Id)
        {
            try
            {
                using (client = new HttpClient())
                {
                    Client();
                    resp = client.DeleteAsync("api/Jugadores/" + Id).Result;
                    if (resp.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Client()
        {
            client.BaseAddress = new Uri(BaseAdress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(TimeSpan.TicksPerSecond * 15);
        }

        public bool Validar(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            wresp = null;

            try
            {
                wreq = (HttpWebRequest)HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;
                wresp = (HttpWebResponse)wreq.GetResponse();
                if (wresp.GetResponseStream() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (wresp != null)
                    wresp.Close();
            }

        }

        public bool AccesoInternet()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
