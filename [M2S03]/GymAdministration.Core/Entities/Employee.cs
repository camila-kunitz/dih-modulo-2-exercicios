using GymAdministration.Core.Enums;
using System;

namespace GymAdministration.Core
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public StatusEnum Status { get; set; }


        public Employee(string name)
        {
            Name = name;
            Status = StatusEnum.Active;
        }
    }
}
