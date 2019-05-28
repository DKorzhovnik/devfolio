using Unsplasharp;
using Unsplasharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using System;


namespace gtbweb.Services
{
  public class Unsplash
  {
    const string BaseUrl = "https://api.unsplash.com/";

    readonly IRestClient _client;

    string _client_id;
    public Unsplash(string client_id, string secretKey)
    {
        _client = new RestClient(BaseUrl);
       //_client.Authenticator = new HttpBasicAuthenticator(client_id, secretKey);
        _client_id= client_id;
    }
  
public T Execute<T>(RestRequest request) where T : new()
    {
        request.AddParameter("client_id",_client_id, ParameterType.UrlSegment); // used on every request
        var response = _client.Execute<T>(request);

        if (response.ErrorException != null)
        {
            const string message = "Error retrieving response.  Check inner details for more info.";
            var twilioException = new ApplicationException(message, response.ErrorException);
            throw twilioException;
        }
        return response.Data;
    }

 public Photo GetCall() 
{
    var request = new RestRequest("photos/random");
    request.RootElement = "Photo";

//request.AddParameter("CallSid", callSid, ParameterType.UrlSegment);

    return Execute<Photo>(request);
}
 }
}