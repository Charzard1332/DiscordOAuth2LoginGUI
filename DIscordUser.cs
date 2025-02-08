using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiscordLoginWinForms
{
    public class DIscordUser
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("discriminator")]
        public string Discriminator { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("premium_type")]
        public int PremiumType { get; set; }

        [JsonPropertyName("flags")]
        public int Flags { get; set; }

        public string GetAvatarUrl()
        {
            return $"https://cdn.discordapp.com/avatars/{Id}/{Avatar}.png";
        }
    }
}
