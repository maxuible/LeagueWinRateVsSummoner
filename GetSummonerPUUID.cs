using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueWinRateVsSummoner
{
    internal class GetSummonerPUUID
    {

        public static async Task<string> RiotAPIAccount(string SummonerName, string Tag, HttpClient httpClient, string apiKey)
        {
            try
            {
                string responseBody = await httpClient.GetStringAsync("https://americas.api.riotgames.com/riot/account/v1/accounts/by-riot-id/" + SummonerName + "/" + Tag + "?api_key="+apiKey);

                Debug.WriteLine(responseBody);
                AccountDto accountDto = JsonSerializer.Deserialize<AccountDto>(responseBody);
                if (accountDto == null || string.IsNullOrEmpty(accountDto.puuid))
                {
                    return "ERROR : account is NULL";
                }
                return accountDto.puuid;
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);
                return "ERROR";
            }
        }

    }
}
