using System;
using System.IO;
using System.Net;
using System.Text;

namespace csharpRestClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    internal class RestClient
    {
        public string EndPoint { get; set; }

        public HttpVerb HttpMethod { get; set; }

        public RestClient()
        {
            // https://dry-cliffs-19849.herokuapp.com/users.json

            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
        }

        public string MakeRequest()
        {
            string responseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);

            request.Method = HttpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }

                // processar a resposta do servidor (poderia ser JSON, XML, HTML, etc...)

                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return responseValue;
        }
    }
}
