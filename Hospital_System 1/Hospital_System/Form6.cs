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
        public Form6()
        {
            InitializeComponent();
            Patients();
        }

        List<Patient> patients = new List<Patient>();
        private void Patients()
        {
            string filePath = @"C:\Users\User\Patients.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] data = line.Split(',');

                    if (data.Length >= 6)
                    {
                        var patient = new Patient(Guid.Parse(data[0].Trim()), data[1].Trim(), data[2].Trim(), data[3].Trim(), data[4].Trim(), data[5].Trim());

                        if (data.Length > 6) patient.Treatment = data[6].Trim();
                        if (data.Length > 7) patient.Nurse = data[7].Trim();
                        patients.Add(patient);
                        SearchMetod.Add(patient);
                    }
                }
            }

            for (int i = 0; i < patients.Count; i++)
            {
                listBox1.Items.Add(patients[i].Name);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {

                Patient selectedPatient = patients[listBox1.SelectedIndex];

                textBox1.Text = $"{selectedPatient.Name}, {selectedPatient.Age}, {selectedPatient.Gender}, {selectedPatient.Number}, {selectedPatient.Name_Doctor}";
                textBox2.Text = selectedPatient.Treatment;
                textBox3.Text = selectedPatient.Nurse;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Patient selectedPatient = patients[listBox1.SelectedIndex];

                selectedPatient.Treatment = textBox2.Text;
                selectedPatient.Nurse = textBox3.Text;

                listBox1.Items[listBox1.SelectedIndex] = $"{selectedPatient.Id} - {selectedPatient.Treatment}";

                SavePatientsToFile();

                MessageBox.Show("Data was saved!");
            }
        }

        private void SavePatientsToFile()
        {
            string newFilePath = @"C:\Users\User\Patients.txt";
            using (StreamWriter writer = new StreamWriter(newFilePath, false))
            {
                for (int i = 0; i < patients.Count; i++)
                {
                    Patient patient = patients[i];
                    string dataPatient = $"{patient.Id}, {patient.Name}, {patient.Age}, {patient.Gender}, {patient.Number}, {patient.Name_Doctor}, {patient.Treatment}, {patient.Nurse}";
                    writer.WriteLine(dataPatient);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Enter data");
                    return;
                }

                IEnumerable<IEntity> foundEntities = SearchMetod.Search(textBox4.Text);

                listBox1.Items.Clear();

                bool found = false;

                foreach (IEntity entity in foundEntities)
                {
                    var patientEntity = entity as Patient;

                    if (patientEntity != null)
                    {
                        listBox1.Items.Add(patientEntity.Name);
                        found = true;
                    }
                }

                if (!found)
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
        
    
