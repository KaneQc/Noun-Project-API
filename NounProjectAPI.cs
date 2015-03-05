using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request
{
    class NounProjectAPI
    {
        void SimpleCall()
        {
            var baseUrl = new Uri("http://api.thenounproject.com");
            var client = new RestClient(baseUrl);

            client.Authenticator = OAuth1Authenticator.ForRequestToken("CLIENT_KEY_HERE", "CLIENT_SECRET_HERE");

            var request = new RestRequest("/icon/1", Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }
    }
}
