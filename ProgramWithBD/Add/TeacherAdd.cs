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
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var lastName = tbLastname.Text;
                    var firstName = tbFirstname.Text;
                    var middleName = tbMiddlename.Text;
                    var post = tbPost.Text;
                    var degree = tbDegree.Text;
                    var exp = int.TryParse(tbExp.Text, out int expirience);
                    if (lastName != "" && firstName != "" && middleName != "" && post != "" && degree != "" && exp == true)
                    {
                        Teachers teacher = new Teachers
                        {
                            Lastname = lastName,
                            Firstname = firstName,
                            Middlename = middleName,
                            Degree = degree,
                            Post = post,
                            Expirience = expirience
                        };
                        db.Teachers.InsertOnSubmit(teacher);
                        db.SubmitChanges();
                        MessageBox.Show("Добавление прошло успешно.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Данные введены неверно. Повторите ввод");
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
