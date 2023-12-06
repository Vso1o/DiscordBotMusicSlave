using Discord;

namespace MusicSlave.Bot.Services
{
    public class LogService
    {
        private readonly SemaphoreSlim _semaphoreSlim;

        public LogService()
        {
            _semaphoreSlim = new SemaphoreSlim(1);
        }

        internal async Task LogAsync(LogMessage arg)
        {
            await _semaphoreSlim.WaitAsync();

            var timeStamp = DateTime.UtcNow.ToString("hh:mm");

            Console.WriteLine($"[{timeStamp}] ({arg.Source} : {arg.Message})");

            _semaphoreSlim.Release();
        }
    }
}
