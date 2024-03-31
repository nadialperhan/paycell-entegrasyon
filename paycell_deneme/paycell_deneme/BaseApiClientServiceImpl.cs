using Newtonsoft.Json;
using paycell_deneme.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace paycell_deneme
{
    public abstract class BaseApiClientServiceImpl<Trequest,Tresponse>
    {
        protected Tresponse RestClient(string apiUrl,Trequest requestObject)
        {
            using (HttpClient client =new HttpClient())
            {

                client.BaseAddress = new Uri(Constant.API_BASE_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestjson = JsonConvert.SerializeObject(requestObject);
                var content = new StringContent(requestjson, Encoding.UTF8, "application/json");
                var response = client.PostAsync(apiUrl, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responsecontent = response.Content.ReadAsStringAsync().Result;
                                          
                    return JsonConvert.DeserializeObject<Tresponse>(responsecontent);
                    
                   
                }
                else
                {
                    throw new Exception("API request failed");
                }
            }
        }
       
    }
}