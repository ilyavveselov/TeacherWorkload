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
    public partial class GroupChange : Form
    {
        private Groups Group;
        public GroupChange()
        {
            InitializeComponent();
        }
        public GroupChange(Groups groups):this()
        {
            Group = groups;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    if (tbGroup.Text != String.Empty)
                    {
                        var groupToChange = db.Groups.FirstOrDefault(s => s.Id == Group.Id);
                        if (groupToChange != null)
                        {
                            groupToChange.GroupName = tbGroup.Text;
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

        private void GroupChange_Load(object sender, EventArgs e)
        {
            tbGroup.Text = Group.GroupName;
        }
    }
}
