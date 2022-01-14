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
    public partial class TeacherWorkloadsAdd : Form
    {
        public TeacherWorkloadsAdd()
        {
            InitializeComponent();
        }
        

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (cbTeacherLastname.Text!=String.Empty && cbWorkloadId.Text!=String.Empty)
                    {
                        int tid = db.Teachers.Where(x => (x.Lastname.ToString() + " " + x.Firstname.ToString() + " " + x.Middlename.ToString()) == cbTeacherLastname.Text).FirstOrDefault().Id;
                        string[] sName = cbWorkloadId.Text.Split(' ');
                        int sid = db.Subjects.Where(x => x.SubjectName == sName[0]).FirstOrDefault().Id;
                        int gid = db.Groups.Where(x => x.GroupName == sName[1]).FirstOrDefault().Id;
                        bool y = int.TryParse(sName[2], out int year);
                        int wid = db.Workloads.Where(x => (x.SubjectId == sid && x.GroupId == gid && x.WorkloadYear == year)).FirstOrDefault().Id;
                        TeacherWorkloads teacherWorkloads = new TeacherWorkloads { TeacherId = tid, WorkloadId = wid};
                        db.TeacherWorkloads.InsertOnSubmit(teacherWorkloads);
                        db.SubmitChanges();
                        MessageBox.Show("Добавление прошло успешно");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ввод неверен, переделывайте");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TeacherWorkloadsAdd_Load(object sender, EventArgs e)
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
                        cbTeacherLastname.Items.Add(nlm);
                    }
                    string subjectName = String.Empty;
                    string groupName = String.Empty;
                    string year = String.Empty;
                    string sgy = String.Empty;
                    foreach (var item in db.Workloads)
                    {
                        subjectName = db.Subjects.Where(x => x.Id == item.SubjectId).FirstOrDefault().SubjectName;
                        groupName = db.Groups.Where(x=>x.Id == item.GroupId).FirstOrDefault().GroupName;
                        year = item.WorkloadYear.ToString();
                        sgy = subjectName + " " + groupName + " " + year;
                        cbWorkloadId.Items.Add(sgy);
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
