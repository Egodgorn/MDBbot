using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.EventArgs;
using MDBbot.DataBase;

namespace MDBbot.Commands
{
    public class br : BaseCommandModule
    {
        [Command("br")]
        public async Task GreetCommand(CommandContext ctx)
        {
            await ctx.RespondAsync("\n```1 неделя мах БР 10.7 (01.09 — 06.09)" +
                                   "\n2 неделя мах БР 9.0(07.09 — 13.09)" +
                                   "\n3 неделя мах БР 8.0(14.09 — 20.09)" +
                                   "\n4 неделя мах БР 7.0(21.09 — 27.09)" +
                                   "\n5 неделя мах БР 6.3(28.09 — 04.10)" +
                                   "\n6 неделя мах БР 5.7(05.10 — 11.10)" +
                                   "\n7 неделя мах БР 5.0(12.10 — 18.10)" +
                                   "\n8 неделя мах БР 4.3(19.10 — 25.10)" +
                                   "\n9 неделя мах БР 3.7(26.10 — 31.10)```");
        }
        [Command("roll")]
        public async Task RollCommand(CommandContext ctx)
        {
            Random rnd = new Random();
            await ctx.RespondAsync( $"{rnd.Next(1000)}");
        }
        [Command("lvl")]
        public async Task Lvl(CommandContext ctx)
        {

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    if (db.Users.Any(o => o.ID == (int)ctx.User.Id))
            //    {
            //        var user = db.Users.FirstOrDefault(x => x.Name.StartsWith($"{ctx.User.Username}"));
            //        db.SaveChanges();
            //    }
            //    else
            //    {
            //       db.Users.Add(new MDB_user { Exp = 0, Name = ctx.User.Username });
            //       db.SaveChanges();
            //    }
            //}
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(new MDB_user { ID = 1, Exp = 0, Name = "Test" });
                db.SaveChanges();
            }
            await ctx.RespondAsync($"{ctx.User.Username}") ;
        }
    }
}
