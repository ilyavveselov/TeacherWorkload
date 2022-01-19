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
    public partial class TeacherWorkloadsChange : Form
    {
        private TeacherWorkloads TeacherWorkload;
        public TeacherWorkloadsChange()
        {
            InitializeComponent();
        }
        public TeacherWorkloadsChange(TeacherWorkloads teacherWorkloads) : this()
        {
            this.TeacherWorkload = teacherWorkloads;
        }
        private void TeacherWorkloadsChange_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    string name = String.Empty;
                    string lastname = String.Empty;
                    string middlename = String.Empty;
                    string nlm = String.Empty;

                    foreach (var item in db.Teachers)
                    {
                        lastname = item.Lastname;
                        name = item.Firstname;
                        middlename = item.Middlename;
                        nlm = lastname + " " + name + " " + middlename;
                        cbTeacherId.Items.Add(nlm);
                    }
                    var teacherName = db.Teachers.FirstOrDefault(x => x.Id == TeacherWorkload.TeacherId); 
                    cbTeacherId.SelectedItem = teacherName.Lastname + " " + teacherName.Firstname + " " + teacherName.Middlename;
                    string subjectName = String.Empty;
                    string groupName = String.Empty;
                    string year = String.Empty;
                    string sgy = String.Empty;
                    foreach (var item in db.Workloads)
                    {
                        subjectName = db.Subjects.Where(x => x.Id == item.SubjectId).FirstOrDefault().SubjectName;
                        groupName = db.Groups.Where(x => x.Id == item.GroupId).FirstOrDefault().GroupName;
                        year = item.WorkloadYear.ToString();
                        sgy = subjectName + " " + groupName + " " + year;
                        cbWorkloadId.Items.Add(sgy);
                    }
                    var workload = db.Workloads.FirstOrDefault(x => x.Id == TeacherWorkload.WorkloadId);
                    var subject = db.Subjects.FirstOrDefault(x => x.Id == workload.SubjectId);
                    var group = db.Groups.FirstOrDefault(x=>x.Id == workload.GroupId);
                    cbWorkloadId.SelectedItem = subject.SubjectName +" " + group.GroupName + " " + workload.WorkloadYear;

                }
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

                    var tid = db.Teachers.Where(x => (x.Lastname.ToString() + " " + x.Firstname.ToString() + " " + x.Middlename.ToString()) == cbTeacherId.Text).FirstOrDefault();
                    string[] sName = cbWorkloadId.Text.Split(' ');
                    var sid = db.Subjects.Where(x => x.SubjectName == sName[0]).FirstOrDefault();
                    var gid = db.Groups.Where(x => x.GroupName == sName[1]).FirstOrDefault();
                    bool y = int.TryParse(sName[2], out int year);
                    var wid = db.Workloads.Where(x => (x.SubjectId == sid.Id && x.GroupId == gid.Id && x.WorkloadYear == year)).FirstOrDefault();
                    var twChange = db.TeacherWorkloads.Where(x => (x.Id == TeacherWorkload.Id)).FirstOrDefault();
                    if (tid != null && wid != null)
                    {
                        twChange.WorkloadId = wid.Id;
                        twChange.TeacherId = tid.Id;
                        db.SubmitChanges();
                        MessageBox.Show("Изменения приняты!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод");
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
