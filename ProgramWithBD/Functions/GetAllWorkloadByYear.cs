using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramWithBD.Functions
{
    public partial class GetAllWorkloadByYear : Form
    {
        public GetAllWorkloadByYear()
        {
            InitializeComponent();
        }


        private void tsAddYear_Click(object sender, EventArgs e)
        {
            var tryYear = int.TryParse(tsTBYear.Text, out int year);
            try
            {
                using (var db = new WorkloadsDataContext())
                {
                    var get = from Lastname in db.GetAllWorkloadByYear(year) select Lastname;
                    foreach (var item in get)
                    {
                        dataGridView1.Rows.Add(item.Lastname,item.Firstname,item.Middlename,item.Post,item.Expirience,item.HoursLections_HoursPractice);
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
