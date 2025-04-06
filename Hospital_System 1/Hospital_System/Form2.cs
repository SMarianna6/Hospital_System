using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Hospital_System
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static void SaveToFile(IFiles obj, string filePath)
        {
            File.AppendAllText(filePath, obj.DataString() + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;
            string gender = textBoxGender.Text;
            string number = textBoxNumber.Text;
            string name_doctor = textBoxDoctorName.Text;

            Patient patient = new Patient(Guid.NewGuid(), name, age, gender, number, name_doctor);
            SaveDelegate save = SaveToFile;
            save(patient, @"C:\Users\User\Patients.txt");

            MessageBox.Show("RECORD IS MADE");
        }
    }
}

