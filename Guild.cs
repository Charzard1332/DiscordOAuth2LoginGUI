using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiscordLoginWinForms
{
    public class Guild
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("owner")]
        public bool IsOwner { get; set; }

        [JsonPropertyName("permissions")]
        public int Permissions { get; set; }

        [JsonPropertyName("premium_tier")]
        public int PremiumTier { get; set; }

        public string GetIconUrl()
        {
            return $"https://cdn.discordapp.com/icons/{Id}/{Icon}.png";
        }
    }
}
