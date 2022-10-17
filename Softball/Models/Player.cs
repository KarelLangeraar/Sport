﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Sport.Interfaces;

namespace Sport.Models
{
    public class Player : Person, IActive
    {
        public int PlayerID { get; set; }
        public int? PlayerNumber { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Training> Training { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public Active Active { get; private set; }


        //parameterless constructor for EF migration
        private Player() : this(0, "", "", DateOnly.FromDateTime(DateTime.Now)) { }

        Player(int? playerNumber, Person person) : this(playerNumber,person.FirstName, person.LastName, (DateOnly)person.BirthDate)
        {
        }

        Player(int? playerNumber, string firstName, string lastName, DateOnly birthDate) : base(firstName, lastName, birthDate)
        {
            PlayerNumber = playerNumber;
            Active = new Active();
            Teams = new List<Team>();
            Training = new List<Training>();
            Games = new List<Game>();
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
