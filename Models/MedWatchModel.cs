using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    class MedWatchModel
    {
        public int Id;
        public string Name;
        public int DoctorId;
        public string Time;

        public string Description;

        public MedWatchModel(string name, int doctorId, string time, string description)
        {
            Name = name;
            DoctorId = doctorId;
            Time = time;
            Description = description;
        }
    }
}
