using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    public class MedWatchModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public string Time { get; set; }

        public string Description;

        public MedWatchModel(string name, int doctorId, string time, string description)
        {
            Name = name;
            DoctorId = doctorId;
            Time = time;
            Description = description;
        }

        public MedWatchModel(int id, string name, int doctorId, string time, string description)
        {
            Id = id;
            Name = name;
            DoctorId = doctorId;
            Time = time;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id:{this.Id}, Name:{this.Name}, DoctorId:{this.DoctorId}, Time:{this.Time}, Description:{this.Description}.";
        }
    }
}
