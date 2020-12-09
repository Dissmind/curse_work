using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    class MedWatchModel
    {
        public int Id;
        public DoctorModel Doctor;
        public string Age;
        public string Description;

        public MedWatchModel(int id, DoctorModel doctor, string age, string description)
        {
            Id = id;
            Doctor = doctor;
            Age = age;
            Description = description;
        }
    }
}
