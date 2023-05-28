using Microsoft.Extensions.Configuration;
using RawgSharp.Models;
using RawgSharp.Responses;
using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Web;

namespace RawgSharp
{
    public class RawgApi : IRawgApi
    {
        private readonly string _apiKey;

        private readonly HttpClient _httpClient;

        public RawgApi(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["Rawg:ApiKey"];
        }

        public async Task<Game> GetGameDetails(int id)
        {            
            return 
                await _httpClient.GetFromJsonAsync<Game>(
                    $"games/{id}?{Query()}");
        }

        public async Task<PageResponse> GetListOfGames()
        {
            return 
                await _httpClient.GetFromJsonAsync<PageResponse>(
                    $"games?{Query()}");            
        }

        public async Task<PageResponse> GetListOfGamesAsync(int page, int pageSize, string search = default)
        {
            var query = Query();
            
            if (!string.IsNullOrWhiteSpace(search))
                query["search"] = search;

            query["page"] = page.ToString();
            query["page_size"] = pageSize.ToString();

           return 
                await _httpClient.GetFromJsonAsync<PageResponse>(
                    $"games?{query}");            
        }

        private NameValueCollection Query()
        {
            var query = HttpUtility.ParseQueryString("");
            query["key"] = _apiKey;

            return query;
        }
    }
}