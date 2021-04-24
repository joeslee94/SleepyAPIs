using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SimpleAPIConsumption
{
    enum HTTPMETHODS
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class APIProcessor
    {
        public string EndPointURI { get; set; }
        public HTTPMETHODS HTTPMethod { get; set; }

        public APIProcessor()
        {
            EndPointURI = "";
            HTTPMethod = HTTPMETHODS.GET;
        }

        public string GetRequest()
        {
            string apiResponseValue = "";

            HttpWebRequest uriRequest = (HttpWebRequest)WebRequest.Create(EndPointURI);
            uriRequest.Method = HTTPMethod.ToString();
            
            using(HttpWebResponse rawResponse = (HttpWebResponse)uriRequest.GetResponse())
            {
                if (rawResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Error Code: {rawResponse.StatusCode}.");
                } //done checking the status code of the request
                
                using(Stream responseStream = rawResponse.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader sReader = new StreamReader(responseStream))
                        {
                            apiResponseValue = sReader.ReadToEnd();
                        }
                    }
                }
            }

            return apiResponseValue;
        }
    }
}
