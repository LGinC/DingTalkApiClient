using DingTalkApiClient.Dto;
using System.Threading.Tasks;

namespace DingTalkApiClient
{
    public static class TokenApi
    {
        private static IDingTalkApi api;

        public static async Task<AccessToken> GetAccessToken(string appid, string serect)
        {
            return await api.GetAccessToken(appid, serect);
        }
    }
}
