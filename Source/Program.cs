using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using MDBbot.DataBase;
using Microsoft.Extensions.Logging;

namespace MDBbot
{
    class Program
    {
        static string path = @"token.txt";
        static string _token;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(path))//read token in file
            {
                _token = sr.ReadToEnd();
            }

            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            DiscordClient discord = new DiscordClient(new DiscordConfiguration()
            {

                Token = _token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
                MinimumLogLevel = LogLevel.Debug
            });

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration() { StringPrefixes = new[] { "!" } });
            commands.RegisterCommands(Assembly.GetExecutingAssembly());


            await discord.ConnectAsync();
            await Task.Delay(-1);

        }

    }
}
