using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class CustomHttpClient
    {
        public static string ApiDefaultUsername => "TestUser";
        public static string ApiDefaultPassword => "8566435F-B5CF-4285-9A44-E9F2A810C44D";
        public static async Task<HttpResponseMessage> SecuredGetAsync(this HttpClient httpClient, string ApiPath)
        {
            ApiPath = $" {ApiPath}".Replace(" /", "").Trim();
            return await httpClient.GetAsync(ApiPath);
        }
        public static async Task<HttpResponseMessage> SecuredPostAsync(this HttpClient httpClient, string ApiPath, HttpContent content)
        {
            ApiPath = $" {ApiPath}".Replace(" /", "").Trim();
            return await httpClient.PostAsync(ApiPath, content);
        }
        public static async Task<HttpResponseMessage> SecuredMultiPartPostAsync(this HttpClient httpClient, string ApiPath, MultipartContent content)
        {
            ApiPath = $" {ApiPath}".Replace(" /", "").Trim();
            return await httpClient.PostAsync(ApiPath, content);
        }
        public static async Task<HttpResponseMessage> SecuredPutAsync(this HttpClient httpClient, string ApiPath, HttpContent content)
        {
            ApiPath = $" {ApiPath}".Replace(" /", "").Trim();
            return await httpClient.PutAsync(ApiPath, content);
        }
        public static async Task<HttpResponseMessage> SecuredDeleteAsync(this HttpClient httpClient, string ApiPath)
        {
            ApiPath = $" {ApiPath}".Replace(" /", "").Trim();
            return await httpClient.DeleteAsync(ApiPath);
        }

        public static HttpClient SecuredSecure(this HttpClient httpClient, string Username = "", string Password = "")
        {
            var username = string.IsNullOrEmpty(Username) ? ApiDefaultUsername : Username;
            var password = string.IsNullOrEmpty(Password) ? ApiDefaultPassword : Password;
            httpClient.SetBasicAuthentication(username, password);
            httpClient.Timeout = TimeSpan.FromMinutes(20);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

    }
}
