using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guild
{
     public class Guild
    {
        private List<Player> roster;
        private int count;
        public string GuildName { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.roster.Count(); } }
         
        
        public Guild(string guildName,int capacity)
        {
            this.Capacity = capacity;
            this.GuildName = guildName;
           this.roster = new List<Player>();
        
        }
        public void AddPlayer(Player player)
        {
            if (this.roster.Count<this.Capacity)
            {
               this.roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            
            if (this.roster.Any(x=>x.Name==name))
            {
                this.roster.Remove(roster.Find(x => x.Name == name));
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {
            if (this.roster.Any(x => x.Name == name))
            {
                var currPlayer = this.roster.Find(x => x.Name == name);
                if (currPlayer.Rank != "Member")
                {
                    currPlayer.Rank = "Member";
                }
            }
            
        }
        public void DemotePlayer(string name)
        {
            if (this.roster.Any(x => x.Name == name))
            {
                var currPlayer = this.roster.Find(x => x.Name == name);
                if (currPlayer.Rank != "Trial")
                {
                    currPlayer.Rank = "Trial";
                }
            }
        }
        public  Player[] KickPlayersByClass(string class1)
        {
            var list = this.roster.Where(x => x.Class == class1).ToList();
            this.roster.RemoveAll(x => x.Class == class1);
            return list.ToArray();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.GuildName}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
                 
        }


    }
}
