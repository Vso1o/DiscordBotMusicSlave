using MusicSlave.Bot.Models;
using Newtonsoft.Json;

namespace MusicSlave.Bot.Services
{
    public class ConfigService
    {
        public Config GetConfig()
        {
            var file = "Config.json";
            var data = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<Config>(data)!;
        }
    }
}
