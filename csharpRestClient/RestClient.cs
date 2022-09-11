using System.Text;
using System.Net;

namespace csharpRestClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum AuthenticationType
    {
        Basic,
        NTLM
    }

    public enum AuthenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    internal class RestClient
    {
        public string EndPoint { get; set; }

        public HttpVerb HttpMethod { get; set; }

        public AuthenticationType AuthType { get; set; }

        public AuthenticationTechnique AuthTechnique { get; set; }

        public string UserName { get; set; }
        
        public string Password{ get; set; }

        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
        }

        public string MakeRequest()
        {
            string responseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            HttpWebResponse response = null;

            string authHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{UserName}:{Password}"));

            request.Method = HttpMethod.ToString();
            request.Headers.Add("Authorization", AuthType.ToString() + " " + authHeader);

            try
            {
                response = (HttpWebResponse)request.GetResponse();

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
            catch (Exception ex)
            {
                responseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return responseValue;
        }
    }
}
