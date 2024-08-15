using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShopWindowsForms
{
    internal class ShopRestClient
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly string _apiBaseUrl;

        public ShopRestClient(string apiBaseUrl)
        {
            _apiBaseUrl = apiBaseUrl;
        }

        public async Task<Response<T>> Get<T>(string url)
        {
            var responce = await _client.GetAsync(GetUrl(url));
            return await ToResponseObject<T>(responce);
        }

        public async Task<Response<T>> Delete<T>(string url)
        {
            var responce = await _client.DeleteAsync(GetUrl(url));
            return await ToResponseObject<T>(responce);
        }

        public async Task<Response<T>> Post<T>(string url, T request)
        {
            var responce = await _client.PostAsync(GetUrl(url), ToBytes(request));
            return await ToResponseObject<T>(responce);
        }

        public async Task<Response<TResponse>> Post<TRequest, TResponse>(string url, TRequest request)
        {
            var responce = await _client.PostAsync(GetUrl(url), ToBytes(request));
            return await ToResponseObject<TResponse>(responce);
        }

        public async Task<Response<T>> Put<T>(string url, T request)
        {
            var finalurl = GetUrl(url);
            var body = ToBytes(request);
            var response = await _client.PutAsync(finalurl, body);
            var result = await ToResponseObject<T>(response);
            return result;
        }

        //public async Task<Response<TResponse>> Put<TRequest, TResponse>(string url, TRequest request)
        //{
        //    var responce = await _client.PutAsync(url, ToBytes(request));
        //    return await ToObject<TResponse>(responce);
        //}

        private ByteArrayContent ToBytes<T>(T obj)
        {
            var myContent = JsonConvert.SerializeObject(obj);
            var buffer = Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return byteContent;
        }

        private async Task<Response<T>> ToResponseObject<T>(HttpResponseMessage response)
        {
            var dataString = await response.Content.ReadAsStringAsync();

            return new Response<T>(dataString, response.StatusCode);
        }

        private async Task<T> ToObject<T>(HttpResponseMessage response)
        {
            var dataString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(dataString);
        }


        public string GetUrl(string path)
        {
            return $"{_apiBaseUrl}/{path}";
        }
    }

    public class Response<T>
    {
        public Response(string content, T data, HttpStatusCode statusCode)
        {
            Content = content;
            Data = data;
            StatusCode = statusCode;
        }

        public Response(string content, HttpStatusCode statusCode)
            : this(content, JsonConvert.DeserializeObject<T>(content), statusCode)
        {
        }

        public string Content { get; set; }
        public T Data {  get; set; }
        public HttpStatusCode StatusCode { get; }
    }
}
