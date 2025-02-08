using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DiscordLoginWinForms
{
    public static class Utils
    {
        private static readonly string tokenFile = "tokens.json";

        public static void SaveTokens(AccessTokenData tokens)
        {
            if (tokens == null) return;
            File.WriteAllText(tokenFile, JsonSerializer.Serialize(tokens, new JsonSerializerOptions { WriteIndented = true }));
        }

        public static AccessTokenData LoadTokens()
        {
            if (!File.Exists(tokenFile)) return null;
            string json = File.ReadAllText(tokenFile);
            return string.IsNullOrWhiteSpace(json) ? null : JsonSerializer.Deserialize<AccessTokenData>(json);
        }

        public static bool IsTokenExpired(DateTime expiresAt) => DateTime.UtcNow >= expiresAt;
    }
}
