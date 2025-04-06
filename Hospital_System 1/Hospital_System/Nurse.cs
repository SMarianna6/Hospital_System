using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    sealed class Nurse : Doctor, IFiles
    {
        public Nurse()
        {
            Gmail = string.Empty;
            Name_Doctor = string.Empty;
            Birth_Doctor = string.Empty;
            Gender_Doctor = string.Empty;
            Number_Doctor = string.Empty;
            Specialization_Doctor = string.Empty;
            Password = string.Empty;
        }

        public Nurse(string gmail, string name_doctor, string birth_doctor, string gender_doctor, string number_doctor)
        {
            Gmail = gmail;
            Name_Doctor = name_doctor;
            Birth_Doctor = birth_doctor;
            Gender_Doctor = gender_doctor;
            Number_Doctor = number_doctor;
            Specialization_Doctor = "Nurse";
            Password = "";
        }

        public string DataString()
        {
            return $"{Id}, {Gmail}, {Name_Doctor}, {Birth_Doctor}, {Gender_Doctor}, {Number_Doctor}, {Password}";
        }
    }
}
