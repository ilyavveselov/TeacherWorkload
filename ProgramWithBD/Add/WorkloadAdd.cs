using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramWithBD.Add
{
    public partial class WorkloadAdd : Form
    {
        public WorkloadAdd()
        {
            InitializeComponent();
        }

        private void WorkloadAdd_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    foreach (var subject in db.Subjects)
                    { 
                        cbSubjects.Items.Add(subject.SubjectName);
                    }
                    foreach (var group in db.Groups)
                    {
                        cbGroups.Items.Add(group.GroupName);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var subject = db.Subjects.Where(s => s.SubjectName == cbSubjects.Text).FirstOrDefault();
                    var group = db.Groups.Where(s => s.GroupName == cbGroups.Text).FirstOrDefault();
                    bool hl = int.TryParse(tbHLectures.Text, out int hoursLectures);
                    bool hp = int.TryParse(tbHPractice.Text, out int hoursPractice);
                    bool wYear = int.TryParse(tbYear.Text, out int workloadYear);
                    if (subject!=null && group!=null && hl == true && hp == true && wYear == true && workloadYear > 1970)
                    {
                        Workloads workloads = new Workloads { SubjectId = subject.Id, HoursLectures = hoursLectures, HoursPractice = hoursPractice, GroupId = group.Id, WorkloadYear = workloadYear};
                        db.Workloads.InsertOnSubmit(workloads);
                        db.SubmitChanges();
                        MessageBox.Show("Добавлено");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Повторите ввод");
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
