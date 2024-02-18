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

            WinRateObject winRateObject = new WinRateObject();
            winRateObject.numOfTimesOnEnemyTeam = 0;
            winRateObject.numOfTimesOnSameTeam = 0;

            try
            {
                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/Z_cUCRLzm17VIfe0bfdxIuZkIuYsQzNJ52EotIKVh5YVpxKQAveo2WgV3CsHjNMuemEYSzF_9nt3WQ/ids?start=0&count=20&api_key=RGAPI-dc34fd14-5d20-48a7-8665-e8527bf83f1c";
                string responseBody = await httpClient.GetStringAsync(uri);

                Debug.WriteLine(responseBody);

                List<string> listOfGames = JsonSerializer.Deserialize<List<string>>(responseBody);

                CalculateAsync(listOfGames, player1PUUID, player2PUUID, httpClient,winRateObject);
                    
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

        private static async Task<string> CalculateAsync(List<string> listOfGames,string player1PUUID,string player2PUUID, HttpClient httpClient,WinRateObject winRateObject)
        {
            foreach (var gameID in listOfGames)
            {
                await CheckIfPlayer2InGame(gameID, player1PUUID, player2PUUID, httpClient, winRateObject);
                break;
            }


            return "";
        }

        public static async Task<WinRateObject> CheckIfPlayer2InGame(string gameID, string player1PUUID, string player2PUUID, HttpClient httpClient,WinRateObject winRateObject)
        {
            string testP2ID = "5SPhaRkkj1qYMJRmuv8DtMloUPjJPX2ZM1mFlZXbN3esyxOLJiqpOkmdqLOU2j1JUXtYXOt4vX5_cg";
            try
            {

                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/NA1_4926097946?api_key=RGAPI-dc34fd14-5d20-48a7-8665-e8527bf83f1c";
                string responseBody = await httpClient.GetStringAsync(uri);

                MatchDto test = JsonSerializer.Deserialize<MatchDto>(responseBody);

                int indexOfPlayer1 = test.metadata.participants.IndexOf(player1PUUID);
                int indexOfPlayer2 = test.metadata.participants.IndexOf(testP2ID);

                if (indexOfPlayer2 != -1)
                {
                    //check if on same team
                    if (test.info.participants[indexOfPlayer1].teamId == test.info.participants[indexOfPlayer2].teamId)
                    {
                        winRateObject.numOfTimesOnSameTeam++;
                        
                        //same team
                        
                    }
                    else
                    {

                    }
                    Debug.WriteLine(test.info.participants[indexOfPlayer1].teamId);
                    Debug.WriteLine(test.info.participants[indexOfPlayer2].teamId);
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
