using System;

namespace GymAdministration.Core
{
    public class Equipament
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime AcquiredDate { get; private set; }
        

        public Equipament(int id, string name, string description, DateTime acquiredDate)
        {
            Name = name;
            Id = id;
            Description = description;
            AcquiredDate = acquiredDate;
        }
    }
}
