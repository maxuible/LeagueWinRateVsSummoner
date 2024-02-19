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
        public static HttpClient httpClient = new();

        public MainForm()
        {

            InitializeComponent();

            txtPlayer1PUUID.ReadOnly = true;
            txtPlayer2PUUID.ReadOnly = true;

            txtPlayer1Name.Text = "duoking1";
            txtPlayer1Tag.Text = "234";
            txtPlayer1PUUID.Text = "Z_cUCRLzm17VIfe0bfdxIuZkIuYsQzNJ52EotIKVh5YVpxKQAveo2WgV3CsHjNMuemEYSzF_9nt3WQ";


            txtPlayer2Name.Text = "KatEvolved";
            txtPlayer2Tag.Text = "666";
            txtPlayer2PUUID.Text = "VHpcw-Az_E27_IiNsKZZxsf3KaDh-oy0Uhntnq509TKVcrxxP2ITMW2upN9B8cOJ04jZ0nXkiWn4Og";
        }

        private async void btnPlayer1GetPUUID_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPlayer1Name.Text))
            {
                MessageBox.Show("Summoner Name empty");
                return;
            }

            if (String.IsNullOrEmpty(txtPlayer1Tag.Text))
            {
                MessageBox.Show("Summoner Name empty");
                return;
            }

            txtPlayer1PUUID.Text = await GetPlayerPUUIDAsync(txtPlayer1Name.Text, txtPlayer1Tag.Text);

        }

        private async void btnPlayer2GetPUUID_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPlayer2Name.Text))
            {
                MessageBox.Show("Summoner Name empty");
                return;
            }

            if (String.IsNullOrEmpty(txtPlayer2Tag.Text))
            {
                MessageBox.Show("Summoner Name empty");
                return;
            }
            txtPlayer2PUUID.Text = await GetPlayerPUUIDAsync(txtPlayer2Name.Text, txtPlayer2Tag.Text);

        }
        private async Task<string> GetPlayerPUUIDAsync(string playerName, string playerTag)
        {
            string response = await GetSummonerPUUID.RiotAPIAccount(playerName, playerTag, httpClient);
            return response;
        }

        private async void btnCalculateWinrate_Click(object sender, EventArgs e)
        {

            WinRateObject winRateObject = new WinRateObject();
            await CalculateWinRate.CalculateWinRateAsync(txtPlayer1PUUID.Text, txtPlayer2PUUID.Text, httpClient, winRateObject);


            txtNumOfTimesOnSameTeam.Text = winRateObject.numOfTimes_WithPlayer2_OnSameTeam.ToString();
            txtLosesOnSameTeam.Text = winRateObject.numOfTimes_LostWithPlayer2_OnSameTeam.ToString();
            txtWinsOnSameTeam.Text = winRateObject.numOfTimes_WonWithPlayer2_OnSameTeam.ToString();


            txtNumOfTimesOnEnemyTeam.Text = winRateObject.numOfTimes_WithPlayer2_OnEnemyTeam.ToString();
            txtLosesOnEnemyTeam.Text = winRateObject.numOfTimes_LostWithPlayer2_OnEnemyTeam.ToString();
            txtWinsOnEnemyTeam.Text = winRateObject.numOfTimes_WonWithPlayer2_OnEnemyTeam.ToString();




        }

        public void updateProgress(int num)
        { 

            txtStatus.Text = "100 out of "+num+" Completed";

        }

    }
}
