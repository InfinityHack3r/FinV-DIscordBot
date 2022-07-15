using Discord;
using Discord.Commands;

namespace FinV_DIscordBot.Modules

{
    public class PrefixModule : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task HandlePingCommand()
        {
            await Context.Message.ReplyAsync("Pong!");
        }
    }
}
