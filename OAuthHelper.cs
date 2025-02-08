using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordLoginWinForms
{
    public class OAuthHelper
    {
        private readonly MainForm mainForm;
        private static readonly string clientId = "CLIENT_ID_HERE";
        private static readonly string clientSecret = "CLIENT_SECRET_HERE";
        private static readonly string redirectUri = "http://localhost:5000/callback";

        public OAuthHelper(MainForm form)
        {
            this.mainForm = form;
        }

        public async Task LoginWithDiscord()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://discord.com/api/oauth2/authorize?client_id={clientId}&redirect_uri={Uri.EscapeDataString(redirectUri)}&response_type=code&scope=identify%20email%20guilds%20connections",
                UseShellExecute = true
            });

            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:5000/");
            httpListener.Start();
            var context = await httpListener.GetContextAsync();
            var response = context.Response;
            string responseString = "<html><body><h2>You can close this tab now.</h2></body></html>";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();

            string code = context.Request.QueryString["code"];
            httpListener.Stop();

            if (!string.IsNullOrEmpty(code))
            {
                await DiscordApi.ExchangeCodeForToken(code, mainForm);
            }
        }
    }
}
