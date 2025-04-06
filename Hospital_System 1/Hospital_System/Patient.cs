using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital_System.Form2;

namespace Hospital_System
{
    public class Patient : Entity, IEntity, IFiles
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string Name_Doctor { get; set; }
        public string Treatment { get; set; }
        public string Nurse { get; set; }

        public Patient()
        {
            Name = string.Empty;
            Age = string.Empty;
            Gender = string.Empty;
            Number = string.Empty;
            Name_Doctor = string.Empty;
            Treatment = string.Empty;
            Nurse = string.Empty;
        }

        public Patient(Guid id, string name, string age, string gender, string number, string name_doctor)
        {
            this.Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Number = number;
            Name_Doctor = name_doctor;
            Treatment = "";
            Nurse = "";
        }

        public new bool IsValid()
        {
            return
                   base.IsValid() &&
                   !string.IsNullOrEmpty(Name) &&
                   !string.IsNullOrEmpty(Age) &&
                   !string.IsNullOrEmpty(Gender) &&
                   !string.IsNullOrEmpty(Number) &&
                   !string.IsNullOrEmpty(Name_Doctor);
        }

        public string DataString()
        {
            return $"{Id}, {Name}, {Age}, {Gender}, {Number}, {Name_Doctor}, {Treatment}, {Nurse}";
        }

        public override string Format()
        {
            return $"{base.Format()}[{Name}][{Age}][{Gender}][{Number}][{Name_Doctor}]";
        }

        public bool Search(string searchString)
        {
            return Name!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                   Name_Doctor!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }

    }
}
