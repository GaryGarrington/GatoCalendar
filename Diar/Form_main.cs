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
    public partial class Form_main : Form
    {
        public List<Day> dny = new List<Day>();
        Form_bin bin = new Form_bin();

        public Form_main()
        {
            InitializeComponent();
        }
        private void novaUdalost_click(object sender, EventArgs e)
        {
            Event udalost = new Event();
            if(!udalost.priradit(dny)) // Pokud funkce vrátí false, událost nebyla přiřazena a musí se vytvořit nový den
            {
                Day den = new Day(udalost.Start.Date);
                dny.Add(den);
                den.Events.Add(udalost);
                list_days.Items.Add(den.Date);
            }
            if (list_days.SelectedIndex != -1) dny[list_days.SelectedIndex].vypsat(list_events);
        }

        private void list_events_click(object sender, EventArgs e)
        {
            if (list_events.SelectedIndex == -1) return;
            dny[list_days.SelectedIndex].Events[list_events.SelectedIndex].vypsat(txb_event);
        }

        private void btn_newEventPlus_Click(object sender, EventArgs e)
        {
            Form_newEventPlus form = new Form_newEventPlus();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Event udalost = new Event(form.desc, form.start);
                if(!udalost.priradit(dny)) // Pokud funkce vrátí false, událost nebyla přiřazena a musí se vytvořit nový den
                {
                    Day den = new Day(udalost.Start.Date);
                    dny.Add(den);
                    den.Events.Add(udalost);
                    list_days.Items.Add(den.Date);
                }
                if (list_days.SelectedIndex != -1) dny[list_days.SelectedIndex].vypsat(list_events);
            }
        }

        private void btn_newEventPro_Click(object sender, EventArgs e)
        {
            Form_newEventPro form = new Form_newEventPro();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Event udalost = new Event(form.desc, form.start, form.end, form.priority, form.allday);
                if(!udalost.priradit(dny)) // Pokud funkce vrátí false, událost nebyla přiřazena a musí se vytvořit nový den
                {
                    Day den = new Day(udalost.Start.Date);
                    dny.Add(den);
                    den.Events.Add(udalost);
                    list_days.Items.Add(den.Date);
                }
                if (list_days.SelectedIndex != -1) dny[list_days.SelectedIndex].vypsat(list_events);
            }
        }

        private void list_events_DoubleClick(object sender, EventArgs e)
        {
            if (list_events.SelectedIndex == -1) return;
            Event udalost = dny[list_days.SelectedIndex].Events[list_events.SelectedIndex];
            Form_newEventPro form = new Form_newEventPro(udalost);
            if(form.ShowDialog() == DialogResult.OK)
            {
                udalost.Desc = form.desc;
                udalost.Start = form.start;
                udalost.End = form.end;
                udalost.AllDay = form.allday;
                udalost.Priority = form.priority;
                list_events.Items[dny[list_days.SelectedIndex].Events.IndexOf(udalost)] = form.desc;
                udalost.vypsat(txb_event);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_events.SelectedIndex == -1 || list_days.SelectedIndex == -1) return;
            dny[list_days.SelectedIndex].Events[list_events.SelectedIndex].Deleted = true;
            bin.odstranene.Add(dny[list_days.SelectedIndex].Events[list_events.SelectedIndex]);
            dny[list_days.SelectedIndex].Events.RemoveAt(list_events.SelectedIndex);
            list_events.Items.RemoveAt(list_events.SelectedIndex);
            txb_event.Text = "";
            if(dny[list_days.SelectedIndex].Events.Count == 0)
            {
                dny.RemoveAt(list_days.SelectedIndex);
                list_days.Items.RemoveAt(list_days.SelectedIndex);
            }
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            bin.ShowDialog();
            if (bin.obnovene.Count != 0)
            {
                for (int i = 0; i < bin.obnovene.Count; i++)
                {
                    bin.obnovene[i].Deleted = false;
                    if (!bin.obnovene[i].priradit(dny))
                    {
                        Day den = new Day(bin.obnovene[i].Start.Date);
                        dny.Add(den);
                        den.Events.Add(bin.obnovene[i]);
                        list_days.Items.Add(den.Date);
                    }
                }
                if (list_days.SelectedIndex != -1) dny[list_days.SelectedIndex].vypsat(list_events);
            }
        }

        private void list_days_Click(object sender, EventArgs e)
        {
            if (list_days.SelectedIndex == -1) return;
            list_events.Items.Clear();
            dny[list_days.SelectedIndex].vypsat(list_events);
        }
    }
}
