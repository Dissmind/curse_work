using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    class DoctorModel
    {
        public int Id;
        public string Name;
        public string Type;

        public DoctorModel(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public DoctorModel(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
