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
    public partial class SubjectsChange : Form
    {
        private Subjects Subject;
        public SubjectsChange()
        {
            InitializeComponent();
        }
        public SubjectsChange(Subjects subject):this()
        {
            this.Subject = subject;
        }

        private void SubjectsChange_Load(object sender, EventArgs e)
        {
            tbSubject.Text = Subject.SubjectName;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (tbSubject.Text != String.Empty)
                    {
                        var subjectToChange = db.Subjects.FirstOrDefault(s => s.Id == Subject.Id);
                        if (subjectToChange != null)
                        {
                            subjectToChange.SubjectName = tbSubject.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Запись изменена");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Повторите ввод");
                        }
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
