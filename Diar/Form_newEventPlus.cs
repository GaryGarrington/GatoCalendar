using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoCalendar
{
    public partial class Form_newEventPlus : Form
    {
        public string desc;
        public DateTime start;

        public Form_newEventPlus()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txb_desc.Text == "") desc = "Nová událost";
            else desc = txb_desc.Text;
            start = dttm_date.Value.Date;
            start = start.AddHours(dttm_time.Value.Hour);
            start = start.AddMinutes(dttm_time.Value.Minute);
            start = start.AddSeconds(dttm_time.Value.Second);
        }

        private void Form_newEventPlus_Load(object sender, EventArgs e)
        {
            dttm_date.Value = DateTime.Now;
            dttm_date.Value = DateTime.Now;
        }
    }
}
