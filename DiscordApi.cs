using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordLoginWinForms
{
    public static class DiscordApi
    {
        private static readonly string tokenEndpoint = "https://discord.com/api/oauth2/token";

        public static async Task ExchangeCodeForToken(string code, MainForm mainForm)
        {
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", "CLIENT_ID_HERE"),
                    new KeyValuePair<string, string>("client_secret", "CLIENT_SECRET_HERE"),
                    new KeyValuePair<string, string>("grant_type", "authorization_code"),
                    new KeyValuePair<string, string>("code", code),
                    new KeyValuePair<string, string>("redirect_uri", "http://localhost:5000/callback")
                });

                var response = await client.PostAsync(tokenEndpoint, content);
                var responseString = await response.Content.ReadAsStringAsync();

                var tokenData = JsonSerializer.Deserialize<AccessTokenData>(responseString);

                if (tokenData != null && !string.IsNullOrEmpty(tokenData.AccessToken))
                {
                    mainForm.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("Logged in");
                    }));
                }
                else
                {
                    mainForm.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("Failed to login!");
                    }));
                }
            }
        }
    }
}
