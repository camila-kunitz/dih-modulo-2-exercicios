using GymAdministration.Core.Enums;
using System;


namespace GymAdministration.Core
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string MedicalObservation { get; private set; }
        public DateTime BirthdayDate { get; private set; }
        public StatusEnum Status { get; private set; }


        public Student(string name, string medicalobservation, DateTime birthdaydate)
        {
            Name = name;
            MedicalObservation = medicalobservation;
            BirthdayDate = birthdaydate;
            Status = StatusEnum.Active;
        }
    }
}
