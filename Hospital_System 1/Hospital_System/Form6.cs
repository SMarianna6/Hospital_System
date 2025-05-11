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
using static Hospital_System.Form2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Principal;

namespace Hospital_System
{
    public partial class Form6 : MaterialForm
    {
        private List<Patient> patients = new List<Patient>();
        private List<Patient> searchResults = new List<Patient>();

        public Form6()
        {
            InitializeComponent();
            Patients();
            comboBox2.Items.Add("Procedures");
            comboBox2.Items.Add("Medication");
            comboBox2.Items.Add("Surgeries");
        }

        private void Patients()
        {
            string filePath = @"C:\Users\User\Patients.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 6)
                    {
                        var patient = new Patient(
                            Guid.Parse(data[0].Trim()),
                            data[1].Trim(),
                            data[2].Trim(),
                            data[3].Trim(),
                            data[4].Trim(),
                            data[5].Trim()
                        );

                        if (data.Length > 6) patient.Treatment = data[6].Trim();
                        if (data.Length > 7) patient.Nurse = data[7].Trim();

                        patients.Add(patient);
                        SearchMetod<Patient>.Add(patient);
                    }
                }
            }

            listBox1.Items.Clear();
            foreach (var patient in patients)
            {
                if (string.IsNullOrEmpty(patient.Treatment) && string.IsNullOrEmpty(patient.Nurse))
                {
                    listBox1.Items.Add(patient.Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Patient selectedPatient;

                if (searchResults.Count > 0)
                    selectedPatient = searchResults[listBox1.SelectedIndex];
                else
                    selectedPatient = patients[listBox1.SelectedIndex];

                //Task 3
                textBox1.Text = string.Join(",", new List<string>
                { selectedPatient.Name, selectedPatient.Age, selectedPatient.Gender, selectedPatient.Number, selectedPatient.Name_Doctor }
                .Select(s => s));

                comboBox2.Text = selectedPatient.Treatment;
                textBox3.Text = selectedPatient.Nurse;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Patient selectedPatient;

                if (searchResults.Count > 0)
                    selectedPatient = searchResults[listBox1.SelectedIndex];
                else
                    selectedPatient = patients[listBox1.SelectedIndex];

                selectedPatient.Treatment = comboBox2.Text;
                selectedPatient.Nurse = textBox3.Text;

                SavePatientsToFile();

                MessageBox.Show("Data was saved!");
            }
        }

        private void SavePatientsToFile()
        {
            string filePath = @"C:\Users\User\Patients.txt";
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var patient in patients)
                {
                    writer.WriteLine(patient.DataString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Enter data");
                    return;
                }

                searchResults = SearchMetod<Patient>.Search(textBox4.Text).ToList();
                listBox1.Items.Clear();

                if (searchResults.Any())
                {
                    foreach (var patient in searchResults)
                    {
                        listBox1.Items.Add(patient.Name);
                    }
                }
                else
                {
                    MessageBox.Show("No patients found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
        
    
