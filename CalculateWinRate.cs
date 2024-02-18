using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeagueWinRateVsSummoner
{
    internal class CalculateWinRate
    {
        public static async Task<WinRateObject> CalculateWinRateAsync(string player1PUUID, string player2PUUID, HttpClient httpClient)
        {

            WinRateObject winRateObject = null;

            try
            {
                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/Z_cUCRLzm17VIfe0bfdxIuZkIuYsQzNJ52EotIKVh5YVpxKQAveo2WgV3CsHjNMuemEYSzF_9nt3WQ/ids?start=0&count=20&api_key=RGAPI-dc34fd14-5d20-48a7-8665-e8527bf83f1c";
                string responseBody = await httpClient.GetStringAsync(uri);

                Debug.WriteLine(responseBody);

                List<string> listOfGames = JsonSerializer.Deserialize<List<string>>(responseBody);

                CalculateAsync(listOfGames, player1PUUID, player2PUUID, httpClient);
                    
                return winRateObject;

            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);

                winRateObject.error.Add(e.Message);

                return winRateObject;
            }
        }

        private static async Task<string> CalculateAsync(List<string> listOfGames,string player1PUUID,string player2PUUID, HttpClient httpClient)
        {
            foreach (var gameID in listOfGames)
            {
                await CheckIfPlayer2InGame(gameID, player1PUUID, player2PUUID, httpClient);
                break;
            }


            return "";
        }

        public static async Task<WinRateObject> CheckIfPlayer2InGame(string gameID, string player1PUUID, string player2PUUID, HttpClient httpClient)
        {
            string testP2ID = "5SPhaRkkj1qYMJRmuv8DtMloUPjJPX2ZM1mFlZXbN3esyxOLJiqpOkmdqLOU2j1JUXtYXOt4vX5_cg";
                WinRateObject winRateObject = null;
            try
            {

                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/NA1_4926097946?api_key=RGAPI-dc34fd14-5d20-48a7-8665-e8527bf83f1c";
                string responseBody = await httpClient.GetStringAsync(uri);

                MatchDto test = JsonSerializer.Deserialize<MatchDto>(responseBody);

                if (test.metadata.participants.IndexOf(testP2ID) != -1)
                {
                    Debug.WriteLine("FOUND PLAYER2");
                }
                else
                {
                    Debug.WriteLine("NOT FOUND PLAYER2");
                }

                Debug.WriteLine(responseBody);

                return winRateObject;
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);

                winRateObject.error.Add(e.Message);

                return winRateObject;
            }
        }


    }
}
