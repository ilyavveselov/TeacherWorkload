using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramWithBD.Add;
using ProgramWithBD.Change;
using ProgramWithBD.Functions;
namespace ProgramWithBD
{
    public partial class Main : Form
    {
        private TeacherWorkloads TeacherWorkload;
        private Teachers Teacher;
        private Workloads Workload;
        private Subjects Subject;
        private Groups Group;

        public Main()
        {
            InitializeComponent();
        }

        private void twUpdate()
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_TeacherWorkloadView.DataSource = db.TeacherWorkloadsView;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка обновления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tUpdate()
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_Teachers.DataSource = db.Teachers.Where(t=>t.Id>0);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка обновления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sUpdate()
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_Subjects.DataSource = db.Subjects;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка обновления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wUpdate()
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_Workloads.DataSource = db.WorkloadView;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка обновления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gUpdate()
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_Groups.DataSource = db.Groups;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка обновления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new WorkloadsDataContext())
            {
                if (tabControl.SelectedTab == tpMain) bs_TeacherWorkloadView.DataSource = db.TeacherWorkloadsView;
                if (tabControl.SelectedTab == tpTeachers) bs_Teachers.DataSource = db.Teachers;
                if (tabControl.SelectedTab == tpSubjects) bs_Subjects.DataSource = db.Subjects;
                if (tabControl.SelectedTab == tpWorkloads) bs_Workloads.DataSource = db.WorkloadView;
                if (tabControl.SelectedTab == tpGroups) bs_Groups.DataSource = db.Groups;
            }
        }
        private void bs_TeacherWorkloadView_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (bs_TeacherWorkloadView.Count == 0) return;
                    else
                    {
                        var tw = bs_TeacherWorkloadView.Current as TeacherWorkloadsView;
                        TeacherWorkload = db.TeacherWorkloads.FirstOrDefault(t_w => t_w.Id == tw.Id);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка выбора данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bs_Subjects_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (bs_Subjects.Count == 0) return;
                    else
                    {
                        var sub = bs_Subjects.Current as Subjects;
                        Subject = db.Subjects.FirstOrDefault(s => s.Id == sub.Id);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка выбора данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bs_Teachers_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (bs_Teachers.Count == 0) return;
                    else
                    {
                        var t = bs_Teachers.Current as Teachers;
                        Teacher = db.Teachers.FirstOrDefault(x => x.Id == t.Id);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка выбора данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bs_Workloads_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (bs_Workloads.Count == 0) return;
                    else
                    {
                        var w = bs_Workloads.Current as WorkloadView;
                        Workload = db.Workloads.FirstOrDefault(x => x.Id == w.Id);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка выбора данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bs_Groups_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (bs_Groups.Count == 0) return;
                    else
                    {
                        var g = bs_Groups.Current as Groups;
                        Group = db.Groups.FirstOrDefault(x => x.Id == g.Id);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка выбора данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Сделал для теста новой ветки в git (feature)");
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    bs_TeacherWorkloadView.DataSource = db.TeacherWorkloadsView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подгрузки главных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsAdd_TW_Click(object sender, EventArgs e)
        {
            TeacherWorkloadsAdd teacherWorkloadsAdd = new TeacherWorkloadsAdd();
            teacherWorkloadsAdd.ShowDialog();
            twUpdate();
            
        }

        private void tsChange_TW_Click(object sender, EventArgs e)
        {
            TeacherWorkloadsChange teacherWorkloadsChange = new TeacherWorkloadsChange(TeacherWorkload);
            teacherWorkloadsChange.ShowDialog();
            twUpdate();

        }

        private void tsDelete_TW_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var teacherWorkloadDelete = db.TeacherWorkloads.FirstOrDefault(tw => tw.Id == TeacherWorkload.Id);
                    DialogResult twDialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (twDialogResult == DialogResult.Yes)
                    {
                        db.TeacherWorkloads.DeleteOnSubmit(teacherWorkloadDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Нагрузка преподавателя удалена");
                        twUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Удаление отменено");
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void tsAdd_T_Click(object sender, EventArgs e)
        {
            TeacherAdd teacherAdd = new TeacherAdd();
            teacherAdd.ShowDialog();
            tUpdate();

        }

        private void tsDelete_T_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {

                    DialogResult tDialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись? Это удалит ВООБЩЕ ВСЕ связанные записи", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tDialogResult == DialogResult.Yes)
                    {
                        bool teacherDeleteFlag = false;
                        var teacherDelete = db.Teachers.FirstOrDefault(t => t.Id == Teacher.Id);
                        while (teacherDeleteFlag == false)
                        {
                            var teacherDeleteInTW = db.TeacherWorkloads.FirstOrDefault(tw => tw.TeacherId == teacherDelete.Id);
                            if (teacherDeleteInTW != null)
                            {
                                db.TeacherWorkloads.DeleteOnSubmit(teacherDeleteInTW);
                                db.SubmitChanges();
                            }
                            else
                            {
                                teacherDeleteFlag = true;
                            }
                        }
                        db.Teachers.DeleteOnSubmit(teacherDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Запись удалена");
                        tUpdate();
                    }
                    else
                    {
                        MessageBox.Show("Удаление отменено");
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void tsChange_T_Click(object sender, EventArgs e)
        {
            TeachersChange teachersChange = new TeachersChange(Teacher);
            teachersChange.ShowDialog();
            tUpdate();
        }

        private void tsGetTeacherWorkload_Click(object sender, EventArgs e)
        {
            GetAllWorkloadByYear result = new GetAllWorkloadByYear();
            result.Show();

        }

        private void tsGetTeacherWorkload_Click_1(object sender, EventArgs e)
        {
            GetTeacherWorkload getTeacherWorkload = new GetTeacherWorkload();
            getTeacherWorkload.Show();
            
        }

        private void tsAdd_S_Click(object sender, EventArgs e)
        {
            SubjectAdd subjectAdd = new SubjectAdd();
            subjectAdd.ShowDialog();
            sUpdate();

        }

        private void tsChange_S_Click(object sender, EventArgs e)
        {
            SubjectsChange subjectsChange = new SubjectsChange(Subject);
            subjectsChange.ShowDialog();
            sUpdate();
        }

        private void tsDelete_S_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult tDialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tDialogResult == DialogResult.Yes)
                {
                    using (var db = new WorkloadsDataContext())
                    {
                        bool checkTeacherWorkloads = false;
                        bool checkWorkloads = false;
                        var subjectToDelete = db.Subjects.FirstOrDefault(s => s.Id == Subject.Id);
                        while (checkWorkloads == false)
                        {
                            var workloadToDelete = db.Workloads.FirstOrDefault(w => w.SubjectId == subjectToDelete.Id);
                            if (workloadToDelete != null)
                            {
                                checkTeacherWorkloads = false;
                                if (workloadToDelete != null)
                                {
                                    while (checkTeacherWorkloads == false)
                                    {
                                        var teacherWorkloadToDelete = db.TeacherWorkloads.FirstOrDefault(tw => tw.WorkloadId == workloadToDelete.Id);
                                        if (teacherWorkloadToDelete != null)
                                        {
                                            db.TeacherWorkloads.DeleteOnSubmit(teacherWorkloadToDelete);
                                            db.SubmitChanges();
                                        }
                                        else
                                        {
                                            checkTeacherWorkloads = true;
                                        }
                                    }
                                }
                                db.Workloads.DeleteOnSubmit(workloadToDelete);
                                db.SubmitChanges();
                            }
                            else
                            {
                                checkWorkloads = true;
                            }
                        }
                        db.Subjects.DeleteOnSubmit(subjectToDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Удалено");
                        sUpdate();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void tsAdd_W_Click(object sender, EventArgs e)
        {
            WorkloadAdd workloadAdd = new WorkloadAdd();
            workloadAdd.ShowDialog();
            wUpdate();

        }

        private void tsChange_W_Click(object sender, EventArgs e)
        {
            WorkloadChange workloadChange = new WorkloadChange(Workload);
            workloadChange.ShowDialog();
            wUpdate();
        }

        private void tsDelete_W_Click(object sender, EventArgs e)
        {
            DialogResult tDialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tDialogResult == DialogResult.Yes)
            {
                try
                {
                    using (var db = new WorkloadsDataContext())
                    {
                        bool checkTeacherWorkloads = false;
                        var workloadToDelete = db.Workloads.FirstOrDefault(w => w.Id == Workload.Id);
                        if (workloadToDelete != null)
                        {
                            while (checkTeacherWorkloads == false)
                            {
                                var teacherWorkloadToDelete = db.TeacherWorkloads.FirstOrDefault(tw => tw.WorkloadId == workloadToDelete.Id);
                                if (teacherWorkloadToDelete != null)
                                {
                                    db.TeacherWorkloads.DeleteOnSubmit(teacherWorkloadToDelete);
                                    db.SubmitChanges();
                                }
                                else
                                {
                                    checkTeacherWorkloads = true;
                                }
                            }
                        }
                        db.Workloads.DeleteOnSubmit(workloadToDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Удалено");
                        wUpdate();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsAdd_G_Click(object sender, EventArgs e)
        {
            GroupAdd groupAdd = new GroupAdd();
            groupAdd.ShowDialog();
            gUpdate();
        }

        private void tsChange_G_Click(object sender, EventArgs e)
        {
            GroupChange groupChange = new GroupChange(Group);
            groupChange.ShowDialog();
            gUpdate();
        }

        private void tsDelete_G_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult tDialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tDialogResult == DialogResult.Yes)
                {
                    using (var db = new WorkloadsDataContext())
                    {
                        bool checkTeacherWorkloads = false;
                        bool checkWorkloads = false;
                        var groupToDelete = db.Groups.FirstOrDefault(s => s.Id == Group.Id);
                        while (checkWorkloads == false)
                        {
                            var workloadToDelete = db.Workloads.FirstOrDefault(w => w.GroupId == groupToDelete.Id);
                            if (workloadToDelete != null)
                            {
                                checkTeacherWorkloads = false;
                                if (workloadToDelete != null)
                                {
                                    while (checkTeacherWorkloads == false)
                                    {
                                        var teacherWorkloadToDelete = db.TeacherWorkloads.FirstOrDefault(tw => tw.WorkloadId == workloadToDelete.Id);
                                        if (teacherWorkloadToDelete != null)
                                        {
                                            db.TeacherWorkloads.DeleteOnSubmit(teacherWorkloadToDelete);
                                            db.SubmitChanges();
                                        }
                                        else
                                        {
                                            checkTeacherWorkloads = true;
                                        }
                                    }
                                }
                                db.Workloads.DeleteOnSubmit(workloadToDelete);
                                db.SubmitChanges();
                            }
                            else
                            {
                                checkWorkloads = true;
                            }
                        }
                        db.Groups.DeleteOnSubmit(groupToDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Удалено");
                        gUpdate();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
