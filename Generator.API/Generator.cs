using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generator.API
{
    public class Generator
    {
        #region Fields
        private const string url = "https://api.pipefy.com/graphql";
        #endregion

        #region Properties
        #endregion


        public Generator()
        { }

        public void GeneratorAuth(string token)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", $"Bearer {token}");
            request.AddParameter("application/json", "{\"query\":\"{ me { id email } }\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(response.StatusDescription);
        }

    }
}
