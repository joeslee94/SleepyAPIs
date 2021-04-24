using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace RobustAPIConsumption
{
    enum HTTPMETHODS
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class InitialAPIProcessor
    {
        public string EndPointURI { get; set; }
        public HTTPMETHODS httpMethod { get; set; }

        public InitialAPIProcessor()
        {
            EndPointURI = "";
            httpMethod = HTTPMETHODS.GET;
        }

        public string EndPointToRawJSON()
        {
            string serializedJSON = "";

            HttpWebRequest initialRequestforJSON = (HttpWebRequest)WebRequest.Create(EndPointURI);
            initialRequestforJSON.Method = httpMethod.ToString();

            using (HttpWebResponse responseForInitialRequest = (HttpWebResponse)initialRequestforJSON.GetResponse())
            {
                if (responseForInitialRequest.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Cannot continue. Error Code: {responseForInitialRequest.StatusCode}.");
                }

                using (Stream streamFromResponse = responseForInitialRequest.GetResponseStream())
                {
                    if (streamFromResponse != null)
                    {
                        using(StreamReader sReader = new StreamReader(streamFromResponse))
                        {
                            serializedJSON = sReader.ReadToEnd();
                        }
                    }
                    else
                    {
                        throw new Exception("Stream is null.");
                    }
                }   
            }
            return serializedJSON;
        }
    }
}
