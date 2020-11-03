using System;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Guild guild = new Guild("Weekend Raiders", 20);
            Player player = new Player("Mark", "Rogue");

            Console.WriteLine(player);
            guild.AddPlayer(player);
            guild.PromotePlayer("PESHO");
            guild.DemotePlayer("PeshOO");
            Console.WriteLine(guild.Count); //1
            Console.WriteLine(guild.RemovePlayer("Gosho"));
            Player firstPlayer = new Player("Pep", "Warrior");
            Player secondPlayer = new Player("Lizzy", "Priest");
            Player thirdPlayer = new Player("Mike", "Rogue");
            Player fourthPlayer = new Player("Marlin", "Mage");
            secondPlayer.Description = "Best healer EU";
            guild.AddPlayer(firstPlayer);
            guild.AddPlayer(secondPlayer);
            guild.AddPlayer(thirdPlayer);
            guild.AddPlayer(fourthPlayer);
            guild.PromotePlayer("Lizzy");
            Console.WriteLine(guild.RemovePlayer("Pep"));
            Console.WriteLine(guild.Count
                );
            Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");
            Console.WriteLine(string.Join(", ", kickedPlayers.Select(p => p.Name)));
            Console.WriteLine(guild.Report());

        }
    }
}
