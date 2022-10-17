using Sport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Models
{
    public class Team : IActive
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Coach> Coach { get; set; }
        public Active Active { get; private set; }

        //parameterless constructor for EF migration
        internal Team() : this("") { }

        public Team(string teamName)
        {
            TeamName = teamName;
            Players = new List<Player>();
            Coach = new List<Coach>();
            Active = new Active();
        }

        public Team(string teamName, IEnumerable<Player> players) : this(teamName)
        {
            Players = players;
        }

        public Team(string teamName, IEnumerable<Player> players, IEnumerable<Coach> coaches) : this(teamName, players)
        {
            Coach = coaches;
        }

        public void Activate()
        {
            Active.Activate();
        }

        public void Inactivate()
        {
            Active.Inactivate();
        }

        public bool IsActive()
        {
            return Active.IsActive;
        }
    }


}
