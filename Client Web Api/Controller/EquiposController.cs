﻿
using Client_Web_Api.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Web_Api.Controller
{
    class EquiposController
    {
        public List<EquiposModel> Equipos { get; set; }
        private string BaseAdress = "https://out-jskdocjpwr.now.sh/";
        private HttpResponseMessage resp { get; set; }
        private HttpClient client { get; set; }

        public void Create(EquiposModel Equipo)
        {
            
        }

        public async Task<List<EquiposModel>> Read()
        {
            if (await Get()) return Equipos;
            else return null;
        }

        public async Task<EquiposModel> Read(string Id)
        {
            if (await Get(Id) != null) return await Get(Id);
            else return null;
        }

        public void Update(string Id)
        {

        }

        public void Delete(string Id)
        {

        }

        private async Task<bool> Get()
        {
            using (client = new HttpClient())
            {
                Client();
                resp = await client.GetAsync("api/Equipos");
                if (resp.IsSuccessStatusCode)
                {
                    var json = await resp.Content.ReadAsStringAsync();
                    json = json.TrimStart('\"');
                    json = json.TrimEnd('\"');
                    json = json.Replace("\\", "");
                    Equipos = JsonConvert.DeserializeObject<List<EquiposModel>>(json);
                    return true;
                }
                return false;
            }
        }

        private async Task<EquiposModel> Get(string Id)
        {
            using (client = new HttpClient())
            {
                Client();
                resp = await client.GetAsync("api/Equipos/"+Id);
                if (resp.IsSuccessStatusCode)
                {
                    var json = await resp.Content.ReadAsStringAsync();
                    json = json.TrimStart('\"');
                    json = json.TrimEnd('\"');
                    json = json.Replace("\\", "");
                    return JsonConvert.DeserializeObject<EquiposModel>(json);
                }
                return null;
            }
        }

        private void Post()
        {

        }

        private void Put(string Id)
        {

        }

        private void DeleteHttp(string Id)
        {

        }

        private void Client()
        {
            client.BaseAddress = new Uri(BaseAdress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(TimeSpan.TicksPerSecond * 10);
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
    }
}
