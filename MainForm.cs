using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net.NetworkInformation;

namespace LeagueWinRateVsSummoner
{


    public partial class MainForm : Form
    {
        public string apiKey;

        public static HttpClient httpClient = new();

        public string numOfGames;
        public MainForm()
        {
            InitializeComponent();

            txtPlayer1PUUID.ReadOnly = true;
            txtPlayer2PUUID.ReadOnly = true;

            //rank 1 player at the time
            txtPlayer1Name.Text = "Spica";
            txtPlayer1Tag.Text = "001";
            txtPlayer1PUUID.Text = "b5tcxQa5hGO7TRYnwg1tw_VWJLwjvCorLfVnJnCP857N0eVu2c3NZ7QLw0P4u7HtDFVdkMKfbW9j2w";

            //rank 2 player at the time
            txtPlayer2Name.Text = "Kenvi";
            txtPlayer2Tag.Text = "NA1";
            txtPlayer2PUUID.Text = "FGa8XSP6_naho5tK4ScfNkfa38R61S_k-qC-fzebkiPGAwZLYNyaCi0qp-hJJbvD1zXO9SdZvfdXcg";

            txtAPIKey.Text = "RGAPI-6354b575-73ff-44be-b59d-7a0b7e3a54f7";
            txtAPIKey.ReadOnly = true;
            apiKey = txtAPIKey.Text;

            txtNumOfGames.Text = "10";
            numOfGames = txtNumOfGames.Text;
        }

        private async void btnPlayer1GetPUUID_Click(object sender, EventArgs e)
        {
            //validate no empty strings
            if (String.IsNullOrEmpty(txtPlayer1Name.Text)) { MessageBox.Show("Summoner Name empty"); return; }
            if (String.IsNullOrEmpty(txtPlayer1Tag.Text)) { MessageBox.Show("Summoner Name empty"); return; }
            if (String.IsNullOrEmpty(apiKey)) { MessageBox.Show("Api Key Not set"); return; }
            txtPlayer1PUUID.Text = await GetPlayerPUUIDAsync(txtPlayer1Name.Text, txtPlayer1Tag.Text, apiKey);
        }

        private async void btnPlayer2GetPUUID_Click(object sender, EventArgs e)
        {
            //validate no empty strings
            if (String.IsNullOrEmpty(txtPlayer2Name.Text)) { MessageBox.Show("Summoner Name empty"); return; }
            if (String.IsNullOrEmpty(txtPlayer2Tag.Text)) { MessageBox.Show("Summoner Name empty"); return; }
            if (String.IsNullOrEmpty(apiKey)) { MessageBox.Show("Api Key Not set"); return; }
            txtPlayer2PUUID.Text = await GetPlayerPUUIDAsync(txtPlayer2Name.Text, txtPlayer2Tag.Text, apiKey);
        }
        private async Task<string> GetPlayerPUUIDAsync(string playerName, string playerTag, string apiKey)
        {
            string response = await GetSummonerPUUID.RiotAPIAccount(playerName, playerTag, httpClient, apiKey);
            return response;
        }

        private async void btnCalculateWinrate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(apiKey)) { MessageBox.Show("Api Key Not set"); return; }
            if (String.IsNullOrEmpty(txtNumOfGames.Text)) { MessageBox.Show("Num Of Games empty"); return; }
            numOfGames = txtNumOfGames.Text;

            WinRateObject winRateObject = new WinRateObject();
            await CalculateWinRate.CalculateWinRateAsync(txtPlayer1PUUID.Text, txtPlayer2PUUID.Text, httpClient, winRateObject, apiKey, numOfGames);

            txtNumOfTimesOnSameTeam.Text = winRateObject.numOfTimes_WithPlayer2_OnSameTeam.ToString();
            txtLosesOnSameTeam.Text = winRateObject.numOfTimes_LostWithPlayer2_OnSameTeam.ToString();
            txtWinsOnSameTeam.Text = winRateObject.numOfTimes_WonWithPlayer2_OnSameTeam.ToString();

            txtNumOfTimesOnEnemyTeam.Text = winRateObject.numOfTimes_WithPlayer2_OnEnemyTeam.ToString();
            txtLosesOnEnemyTeam.Text = winRateObject.numOfTimes_LostWithPlayer2_OnEnemyTeam.ToString();
            txtWinsOnEnemyTeam.Text = winRateObject.numOfTimes_WonWithPlayer2_OnEnemyTeam.ToString();
        }

        public void updateProgress(int num, string numOfGames)
        {
            txtStatus.Text = numOfGames + " out of " + num + " Completed";
        }

        private void btnLockAPIKey_Click(object sender, EventArgs e)
        {
            txtAPIKey.ReadOnly = true;
            apiKey = txtAPIKey.Text;
        }

        private void btnClearAPIKey_Click(object sender, EventArgs e)
        {
            txtAPIKey.Text = string.Empty;
            apiKey = string.Empty;
            txtAPIKey.ReadOnly = false;
        }

        private void txtNumOfGames_Validated(object sender, EventArgs e)
        {
            int i;
            if (!Int32.TryParse(txtNumOfGames.Text.ToString(),out i)) { MessageBox.Show("Numbers only for Num Of Games");txtNumOfGames.Text = "0";return; }
            if (i > 100) { MessageBox.Show("Max Num of matches is 100");    txtNumOfGames.Text = "100";  return; }
            if (i < 1)   { MessageBox.Show("Min Num of matches is 1");        txtNumOfGames.Text = "1";    return; }

        }
    }
}
