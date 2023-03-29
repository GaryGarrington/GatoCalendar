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
    public partial class Form_newEventPro : Form
    {
        public string desc;
        public DateTime start;
        public DateTime end;
        public bool allday = false;
        public int priority;

        public Form_newEventPro()
        {

            InitializeComponent();

            dttm_start_date.Value = DateTime.Now.Date;
            dttm_start_time.Value = DateTime.Now;
            dttm_end_date.Value = DateTime.Now.Date;
            dttm_end_time.Value = DateTime.Now.AddHours(1);

        }

        public Form_newEventPro(Event ud)
        {
            InitializeComponent();

            txb_desc.Text = ud.Desc;
            dttm_start_date.Value = ud.Start.Date;
            dttm_start_time.Value = ud.Start;
            dttm_end_date.Value = ud.End.Date;
            dttm_end_time.Value = ud.End;
            if (ud.AllDay) chck_allday.Checked = true;
            cmb_priority.SelectedIndex = ud.Priority;
            this.Text = ud.Desc;
            btn_create.Text = "Uložit";
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txb_desc.Text == "") desc = "Nová událost";
            else desc = txb_desc.Text;

            if (chck_allday.Checked) start = dttm_start_date.Value.Date;
            else start = dttm_start_date.Value.AddHours(dttm_start_time.Value.Hour).AddMinutes(dttm_start_time.Value.Minute).AddSeconds(dttm_start_time.Value.Second);

            if (chck_allday.Checked) end = start.AddHours(23).AddMinutes(59).AddSeconds(59);
            else end = dttm_end_date.Value.AddHours(dttm_end_time.Value.Hour).AddMinutes(dttm_end_time.Value.Minute).AddSeconds(dttm_end_time.Value.Second);

            if (cmb_priority.SelectedIndex == -1) priority = 1;
            else priority = cmb_priority.SelectedIndex;
        }

        private void chck_allday_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_allday.Checked)
            {
                dttm_end_date.Enabled = false;
                dttm_end_time.Enabled = false;
                dttm_start_time.Enabled = false;
                allday = true;
            }
            else
            {
                dttm_end_date.Enabled = true;
                dttm_end_time.Enabled = true;
                dttm_start_time.Enabled = true;
                allday = false;
            }
        }
    }
}
