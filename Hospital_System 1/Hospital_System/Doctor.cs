using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class Doctor : Entity, IFiles
    {
        public string Gmail { get; set; }
        public string Name_Doctor { get; set; }
        public string Birth_Doctor { get; set; }
        public string Gender_Doctor { get; set; }
        public string Number_Doctor { get; set; }
        public string Specialization_Doctor { get; set; }
        public string Password { get; set; }

        public Doctor()
        {
            Gmail = string.Empty;
            Name_Doctor = string.Empty;
            Birth_Doctor = string.Empty;
            Gender_Doctor = string.Empty;
            Number_Doctor = string.Empty;
            Specialization_Doctor = string.Empty;
            Password = string.Empty;
        }

        public Doctor(string gmail, string name_doctor, string birth_doctor, string gender_doctor, string number_doctor)
        {
            Gmail = gmail;
            Name_Doctor = name_doctor;
            Birth_Doctor = birth_doctor;
            Gender_Doctor = gender_doctor;
            Number_Doctor = number_doctor;
            Specialization_Doctor = "Doctor";
            Password = "";

        }

        public new bool IsValid()
        {
            return !string.IsNullOrEmpty(Gmail) &&
                   !string.IsNullOrEmpty(Name_Doctor) &&
                   !string.IsNullOrEmpty(Birth_Doctor) &&
                   !string.IsNullOrEmpty(Gender_Doctor) &&
                   !string.IsNullOrEmpty(Number_Doctor) &&
                   !string.IsNullOrEmpty(Specialization_Doctor);
        }

        public override string Format()
        {
            return $"{base.Format()}[{Gmail}][{Name_Doctor}][{Birth_Doctor}][{Gender_Doctor}][{Number_Doctor}][{Specialization_Doctor}]";
        }
        public string DataString()
        {
            return $"{Id}, {Gmail}, {Name_Doctor}, {Birth_Doctor}, {Gender_Doctor}, {Number_Doctor}, {Password}";
        }
    }
}
