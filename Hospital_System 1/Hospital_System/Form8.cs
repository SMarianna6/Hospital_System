using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System
{
    public partial class Form8 : MaterialForm
    {
        // Task 4
        private const int PAGE_LIMIT = 5;
        private int currentPage = 0;

        public Form8()
        {
            InitializeComponent();

            listView1.Columns.Add("Gmail", 155);
            listView1.Columns.Add("Name", 155);
            listView1.Columns.Add("Age", 155);
            listView1.Columns.Add("Gender", 155);
            listView1.Columns.Add("Number", 155);

            Paginate();
            CalculateAge();
        }

        private void Paginate()
        {
            listView1.Items.Clear();

            var doctors = Admin.GetEntities<Doctor>(@"C:\Users\User\Doctors.txt")
                 .OrderBy(x => x.Name_Doctor)
                 .ThenByDescending(x => x.Gmail)
                 .Skip(currentPage * PAGE_LIMIT)
                 .Take(PAGE_LIMIT)
                 .ToList();

            doctors.ForEach(d =>
            {
                var item = new ListViewItem(d.Gmail);
                item.SubItems.Add(d.Name_Doctor);
                item.SubItems.Add(d.Birth_Doctor);
                item.SubItems.Add(d.Gender_Doctor);
                item.SubItems.Add(d.Number_Doctor);

                listView1.Items.Add(item);
            });

            this.textBox1.Text = (currentPage + 1).ToString();
        }

        // Task 2 
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var doctors = Admin.GetEntities<Doctor>(@"C:\Users\User\Doctors.txt")
                .OrderBy(x => x.Name_Doctor)
                .ThenByDescending(x => x.Gmail)
                .ToList();

            //var doctors = Admin.GetEntities<Doctor>(@"C:\Users\User\Doctors.txt");
            //IEnumerable<Doctor> orderedDoc =
            //from doc in doctors
            //orderby doc.Name_Doctor ascending, doc.Gmail descending
            //select doc;

            foreach (var doctor in doctors)
            {
                var item = new ListViewItem(doctor.Gmail);
                item.SubItems.Add(doctor.Name_Doctor);
                item.SubItems.Add(doctor.Birth_Doctor);
                item.SubItems.Add(doctor.Gender_Doctor);
                item.SubItems.Add(doctor.Number_Doctor);

                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                Paginate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var totalDoctors = Admin.GetEntities<Doctor>(@"C:\Users\User\Doctors.txt").Count();
            if ((currentPage + 1) * PAGE_LIMIT < totalDoctors)
            {
                currentPage++;
                Paginate();
            }
        }

        // Task 5
        private void CalculateAge()
        {
            var doctors = Admin.GetEntities<Doctor>(@"C:\Users\User\Doctors.txt");

            int maxAge = doctors.Max(d => int.Parse(d.Birth_Doctor));
            textBox2.Text = maxAge.ToString();

            int minAge = doctors.Min(d => int.Parse(d.Birth_Doctor));
            textBox3.Text = minAge.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
