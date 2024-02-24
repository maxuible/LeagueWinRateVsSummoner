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
        public static async Task<WinRateObject> CalculateWinRateAsync(string player1PUUID, string player2PUUID, HttpClient httpClient,WinRateObject winRateObject, string apiKey,string numOfGames)
        {
            winRateObject.numOfTimes_WithPlayer2_OnEnemyTeam = 0;
            winRateObject.numOfTimes_LostWithPlayer2_OnEnemyTeam = 0;
            winRateObject.numOfTimes_WonWithPlayer2_OnEnemyTeam = 0;

            winRateObject.numOfTimes_WithPlayer2_OnSameTeam = 0;
            winRateObject.numOfTimes_LostWithPlayer2_OnSameTeam = 0;
            winRateObject.numOfTimes_WonWithPlayer2_OnSameTeam = 0;

            List<string> list = new List<string> { };
            winRateObject.error = list;

            try
            {
                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/"+player1PUUID+ "/ids?type=ranked&start=0&count="+numOfGames+"&api_key="+apiKey;
                string responseBody = await httpClient.GetStringAsync(uri);
                Debug.WriteLine(responseBody);

                List<string> listOfGames = JsonSerializer.Deserialize<List<string>>(responseBody);

                await CalculateAsync(listOfGames, player1PUUID, player2PUUID, httpClient,winRateObject,apiKey,numOfGames);
                    
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

        private static async Task<string> CalculateAsync(List<string> listOfGames,string player1PUUID,string player2PUUID, HttpClient httpClient,WinRateObject winRateObject, string apiKey,string numOfGames)
        {
            var formOpen = Application.OpenForms.Cast<MainForm>().FirstOrDefault();
            int i = 0;
            foreach (var gameID in listOfGames)
            {
                i++;
                formOpen.updateProgress(i,numOfGames);
                System.Threading.Thread.Sleep(1000);
                await CheckIfPlayer2InGame(gameID, player1PUUID, player2PUUID, httpClient, winRateObject,apiKey);
            }
            return "";
        }

        public static async Task<WinRateObject> CheckIfPlayer2InGame(string gameID, string player1PUUID, string player2PUUID, HttpClient httpClient,WinRateObject winRateObject,string apiKey)
        {
            try
            {
                string uri = "https://americas.api.riotgames.com/lol/match/v5/matches/"+ gameID + "?api_key="+apiKey;
                string responseBody = await httpClient.GetStringAsync(uri);

                MatchDto test = JsonSerializer.Deserialize<MatchDto>(responseBody);

                int indexOfPlayer1 = test.metadata.participants.IndexOf(player1PUUID);
                int indexOfPlayer2 = test.metadata.participants.IndexOf(player2PUUID);

                if (indexOfPlayer2 != -1)
                {
                    Debug.WriteLine($"FOUND PLAYER2 IN {gameID}");
                    //check if on same team
                    if (test.info.participants[indexOfPlayer1].teamId == test.info.participants[indexOfPlayer2].teamId)
                    {
                        Debug.WriteLine($"PLAYER 2 PUID : {test.info.participants[indexOfPlayer2].puuid}");
                        Debug.WriteLine($"ON SAME TEAM");

                        winRateObject.numOfTimes_WithPlayer2_OnSameTeam++;
                        if (test.info.participants[indexOfPlayer1].win== true)
                        {

                            Debug.WriteLine($"WON WITH PLAYER TWO");
                            winRateObject.numOfTimes_WonWithPlayer2_OnSameTeam++;
                        }
                        else
                        {
                            winRateObject.numOfTimes_LostWithPlayer2_OnSameTeam++;
                        }
                    }
                    else
                    {
                        winRateObject.numOfTimes_WithPlayer2_OnEnemyTeam++;
                        if (test.info.participants[indexOfPlayer1].win == true)
                        {winRateObject.numOfTimes_WonWithPlayer2_OnEnemyTeam++;}
                        else
                        {winRateObject.numOfTimes_LostWithPlayer2_OnEnemyTeam++;}
                    }
                    Debug.WriteLine(test.info.participants[indexOfPlayer1].teamId);
                    Debug.WriteLine(test.info.participants[indexOfPlayer2].teamId);
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
