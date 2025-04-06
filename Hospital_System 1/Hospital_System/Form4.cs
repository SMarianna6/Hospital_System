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
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        private bool UpdatePassword(string FileName, string gmail, string name_doctor, string newpassword)
        {
            string[] lines = File.ReadAllLines(FileName);
            bool userFound = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] employee = lines[i].Split(',');
                if (employee[1].Trim() == gmail && employee[2].Trim() == name_doctor)
                {
                    employee[6] = newpassword;
                    lines[i] = string.Join(",", employee);
                    userFound = true;
                    break;
                }
            }
            if (userFound)
            {
                File.WriteAllLines(FileName, lines);
            }
            return userFound;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gmail = textBox1.Text;
            string Name_Doctor = textBox2.Text;
            string Password = textBox3.Text;

            bool userFound = false;

            string doctorsFile = @"C:\Users\User\Doctors.txt";
            string nursesFile = @"C:\Users\User\Nurses.txt";

            userFound = UpdatePassword(doctorsFile, Gmail, Name_Doctor, Password);
            if (!userFound)
            {
                userFound = UpdatePassword(nursesFile, Gmail, Name_Doctor, Password);
            }
            if (userFound)
            {
                MessageBox.Show("Password was saved!");
            }
            else
            {
                MessageBox.Show("No data!");
            }
        }
    }
}

