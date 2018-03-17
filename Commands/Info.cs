using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PBot.Commands
{
    public class Info : BaseCommandModule
    {
		[Command("Info")]
		public async Task InfoCMD(CommandContext ctx)
		{
			var embed = new DiscordEmbedBuilder();
            embed.WithColor(DiscordColor.Cyan);
            embed.WithTitle("Info");
            embed.AddField("Name", "Some Name");
            embed.AddField("Author", "romangraef89ಜ್ಞಾ#0998 & HurricanKai#9999");

            await ctx.RespondAsync(embed: embed);
		}
    }
}
