using Discord.Interactions;
using Discord;

namespace FinV_DIscordBot.Modules

{
    public class InteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        [SlashCommand("ping", "Ping the bot to test if the bot hears you")]
        public async Task HandlePingCommand()
        {
            await RespondAsync("Pong!");
        }
    }
}
