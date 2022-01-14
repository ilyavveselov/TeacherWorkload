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
    public partial class SubjectAdd : Form
    {
        public SubjectAdd()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (tbSubject.Text != String.Empty)
                    {
                        Subjects subject = new Subjects { SubjectName = tbSubject.Text };
                        db.Subjects.InsertOnSubmit(subject);
                        db.SubmitChanges();
                        MessageBox.Show("Предмет добавлен");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пусто, введите данные");
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
