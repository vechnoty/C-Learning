using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_регистрации_и_БД
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Params.DaySchedule = String.Format("{0}", e.Start.Date.ToString("yyyy-MM-dd"));
            FormRecords fm = new FormRecords();
            fm.Show();
        }
    }
}
