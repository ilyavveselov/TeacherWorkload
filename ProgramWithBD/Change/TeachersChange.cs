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
    public partial class TeachersChange : Form
    {
        private Teachers Teacher;
        public TeachersChange()
        {
            InitializeComponent();
        }
        public TeachersChange(Teachers teacherChange) : this()
        {
            this.Teacher = teacherChange;
        }

        private void TeachersChange_Load(object sender, EventArgs e)
        {
            tbLastname.Text = Teacher.Lastname;
            tbFirstname.Text = Teacher.Firstname;
            tbMiddlename.Text = Teacher.Middlename;
            tbPost.Text = Teacher.Post;
            tbDegree.Text = Teacher.Degree;
            tbExp.Text = Teacher.Expirience.ToString();
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var tChange = db.Teachers.FirstOrDefault(t=>t.Id == Teacher.Id);
                    tChange.Lastname = tbLastname.Text;
                    tChange.Firstname = tbFirstname.Text;
                    tChange.Middlename = tbMiddlename.Text;
                    tChange.Post = tbPost.Text;
                    tChange.Degree = tbDegree.Text;
                    tChange.Expirience = int.Parse(tbExp.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Изменения подтверджены");
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Повторите ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
