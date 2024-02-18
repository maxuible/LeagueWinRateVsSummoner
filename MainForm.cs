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

            txtPlayer1Name.Text = "duoking1";
            txtPlayer1Tag.Text = "234";
            txtPlayer1PUUID.Text = "Z_cUCRLzm17VIfe0bfdxIuZkIuYsQzNJ52EotIKVh5YVpxKQAveo2WgV3CsHjNMuemEYSzF_9nt3WQ";


            txtPlayer2Name.Text = "Focus";
            txtPlayer2Tag.Text = "heyge";
            txtPlayer2PUUID.Text = "eFRW0hHs1Q7-lI4sxxjijohrNwJfImp99eqDbQvBZIvbMoLXdpMCpp8BqT-19xz_g6NDZWk5U_A58w";
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
            
            CalculateWinRate.CalculateWinRateAsync(txtPlayer1PUUID.Text,txtPlayer2PUUID.Text, httpClient);


        }
    }
}
