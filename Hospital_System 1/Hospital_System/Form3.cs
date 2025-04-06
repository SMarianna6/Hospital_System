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

namespace Hospital_System
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Nurse");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = textBox1.Text;
            string name_doctor = textBox2.Text;
            string birth_doctor = textBox3.Text;
            string gender_d = textBox4.Text;
            string number_d = textBox5.Text;

            if (comboBox1.SelectedItem.ToString() == "Doctor")
            {
                Doctor doctor = new Doctor(gmail, name_doctor, birth_doctor, gender_d, number_d);
                SaveDelegate save = SaveToFile;
                save(doctor, @"C:\Users\User\Doctors.txt");
                MessageBox.Show("Doctor in Base");
            }
            else if (comboBox1.SelectedItem.ToString() == "Nurse")
            {
                Nurse nurse = new Nurse(gmail, name_doctor, birth_doctor, gender_d, number_d);
                SaveDelegate save = SaveToFile;
                save(nurse, @"C:\Users\User\Nurses.txt");
                MessageBox.Show("Nurse in Base");
            }
        }
    }
}

