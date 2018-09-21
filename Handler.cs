using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System;
using Newtonsoft.Json;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
       public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request)
       {
          var body = new { message  = "hello!", request = request };
          return new Response(JsonConvert.SerializeObject(body));
       }
    }

    public class Response : APIGatewayProxyResponse
    {
      public Response(string body){
        Body = body;
        StatusCode = System.Net.HttpStatusCode.OK.GetHashCode();
      }
    }

    public class Request
    {
      public string Key1 {get; set;}
      public string Key2 {get; set;}
      public string Key3 {get; set;}

      public Request(string key1, string key2, string key3){
        Key1 = key1;
        Key2 = key2;
        Key3 = key3;
      }
    }
}
