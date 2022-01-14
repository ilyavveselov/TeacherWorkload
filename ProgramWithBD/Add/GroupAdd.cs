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
    public partial class GroupAdd : Form
    {
        public GroupAdd()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (tbGroup.Text != String.Empty)
                    {
                        Groups groups = new Groups { GroupName = tbGroup.Text };
                        db.Groups.InsertOnSubmit(groups);
                        db.SubmitChanges();
                        MessageBox.Show("Группа добавлен");
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
