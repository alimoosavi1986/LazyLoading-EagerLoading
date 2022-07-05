using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyLoading_EagerLoading
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            students.Add(new Student { FirstName = "A", LastName = "A", Grade = 20 });
            students.Add(new Student { FirstName = "B", LastName = "B", Grade = 18 });
            students.Add(new Student { FirstName = "C", LastName = "C", Grade = 22 });
            students.Add(new Student { FirstName = "D", LastName = "D", Grade = 19 });
            students.Add(new Student { FirstName = "E", LastName = "E", Grade = 16 });
            students.Add(new Student { FirstName = "F", LastName = "F", Grade = 8 });
            students.Add(new Student { FirstName = "G", LastName = "G", Grade = 6 });
        }

        private List<Student> GetAcceptedStudentsEagerLoading()
        {
            List<Student> ResultSet = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Grade > 10)
                {
                    ResultSet.Add(students[i]);
                }
            }
            return ResultSet;
        }

        private void btnEagerLoading_Click(object sender, EventArgs e)
        {
            var lst = GetAcceptedStudentsEagerLoading();
            foreach (var st in lst)
            {
                listBox1.Items.Add(st.FirstName + "   " + st.LastName);
            }
        }

        private IEnumerable<Student> GetAcceptedStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Grade > 10)
                {
                    yield return students[i];
                }
            }
        }

        private void btnLazyLoading_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> lst = GetAcceptedStudents();
            foreach (var st in lst)
            {
                listBox1.Items.Add(st.FirstName + "   " + st.LastName);
            }
        }
    }
}
