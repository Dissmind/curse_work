using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    class MedWatchModel
    {
        public int Id;
        public string Name;
        public DoctorModel Doctor;
        public string Description;

        public MedWatchModel(int id, string name, DoctorModel doctor, string description)
        {
            Id = id;
            Name = name;
            Doctor = doctor;
            Description = description;
        }
    }
}
