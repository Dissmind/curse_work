using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

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
