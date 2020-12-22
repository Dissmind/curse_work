using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    public class DoctorModel
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

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Type: {this.Type}.";
        }
    }
}
