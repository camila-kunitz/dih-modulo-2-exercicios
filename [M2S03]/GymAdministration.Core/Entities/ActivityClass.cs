using GymAdministration.Core.Enums;
using System;

namespace GymAdministration.Core
{
    public class ActivityClass
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartedActivity { get; private set; }
        public DateTime? FinishedActivity { get; set; }
        public StatusEnum Status { get; set; }
        public Employee Employee { get; set; }
        public List<Student> Students { get; set; }


        public ActivityClass(string name, string description, DateTime startedActivity)
        {
            Name = name;
            Description = description;
            StartedActivity = startedActivity;  
            Status = StatusEnum.Active;
        }
    }
}
