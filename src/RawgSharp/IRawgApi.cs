using RawgSharp.Models;
using RawgSharp.Responses;

namespace RawgSharp
{
    public interface IRawgApi
    {
        Task<Game> GetGameDetails(int id);

        Task<PageResponse> GetListOfGames();

        Task<PageResponse> GetListOfGamesAsync(int page, int pageSize, string search = default);
    }
}
