using Sport.Interfaces;

namespace Sport.Models
{
    public class Club : IActive
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public Adress? Adress { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        private Active Active { get; set; }

        //parameterless constructor for EF migration
        private Club() : this("") { }

        public Club(string name)
        {
            Name = name;
            Teams = new List<Team>();
            Active = new Active();
        }

        public Club(string name, Adress? adress) :this (name)
        {
            Adress = adress;
        }

        public void Activate()
        {
            //activate all teams if club is active
            Teams.ToList().ForEach(x => x.Activate());
            Active.Activate();
        }

        public void Inactivate()
        {
            //inactivate all teams if club is inactive
            Teams.ToList().ForEach(x => x.Inactivate());
            Active.Inactivate();
        }

        public bool IsActive()
        {
            return Active.IsActive;
        }
    }
}
