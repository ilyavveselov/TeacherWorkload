using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramWithBD.Change
{
    public partial class WorkloadChange : Form
    {
        private Workloads Workload;
        public WorkloadChange()
        {
            InitializeComponent();
        }
        public WorkloadChange(Workloads workload):this()
        {
            this.Workload = workload;
        }

        private void WorkloadChange_Load(object sender, EventArgs e)
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
                var subjects = db.Subjects.FirstOrDefault(x=>x.Id == Workload.SubjectId);
                var groups = db.Groups.FirstOrDefault(x=>x.Id == Workload.GroupId);
                    cbSubjects.SelectedItem = subjects.SubjectName;
                    cbGroups.SelectedItem = groups.GroupName;
                }
                tbHLectures.Text = Workload.HoursLectures.ToString();
                tbHPractice.Text = Workload.HoursPractice.ToString();
                tbYear.Text = Workload.WorkloadYear.ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var workloadToChange = db.Workloads.FirstOrDefault(w => w.Id == Workload.Id);
                    if (tbHLectures.Text != String.Empty && tbHPractice.Text != String.Empty && tbYear.Text != String.Empty && cbGroups.SelectedIndex>0 && cbSubjects.SelectedIndex>0)
                    {
                        int subject = db.Subjects.Where(s => s.SubjectName == cbSubjects.Text).FirstOrDefault().Id;
                        int group = db.Groups.Where(s => s.GroupName == cbGroups.Text).FirstOrDefault().Id;
                        bool hp = int.TryParse(tbHLectures.Text, out int hoursPractice);
                        bool hl = int.TryParse(tbHPractice.Text, out int hoursLectures);
                        bool y = int.TryParse(tbYear.Text, out int year);
                        workloadToChange.HoursPractice = hoursPractice;
                        workloadToChange.HoursLectures = hoursLectures;
                        workloadToChange.WorkloadYear = year;
                        workloadToChange.SubjectId = subject;
                        workloadToChange.GroupId = group;
                        db.SubmitChanges();
                        MessageBox.Show("Запись изменена");
                        Close();
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
