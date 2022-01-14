using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramWithBD.Functions
{
    public partial class GetTeacherWorkload : Form
    {
        public GetTeacherWorkload()
        {
            InitializeComponent();
        }

        private void tsBStartFunc_Click(object sender, EventArgs e)
        {
            var tryYear = int.TryParse(tsTBYear.Text, out var year);

            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var teacherId = db.Teachers.Where(x => (x.Lastname + " " + x.Firstname + " " + x.Middlename) == cbTeacher.Text).FirstOrDefault().Id;
                    var get = from SubjectName in db.GetTeacherWorkload(teacherId, year) select SubjectName;
                    foreach (var item in get)
                    {
                        dataGridView1.Rows.Add(item.SubjectName, item.GroupName, item.HoursLectures, item.HoursPractice, item.Sum);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetTeacherWorkload_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    foreach (var teacher in db.Teachers)
                    {
                        cbTeacher.Items.Add(teacher.Lastname + " " + teacher.Firstname + " " + teacher.Middlename);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
