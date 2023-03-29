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
    public class Day
    {
        public DateTime Date;
        public List<Event> Events = new List<Event>();

        public Day(DateTime date)
        {
            Date = date;
        }
        /// <summary>
        /// Vypíše všechny přiřazené události
        /// </summary>
        /// <param name="lsb">
        /// Listbox, do kterého se události vypíší
        /// </param>
        public void vypsat(ListBox lsb)
        {
            lsb.Items.Clear();
            for (int i = 0; i < Events.Count; i++)
            {
                lsb.Items.Add(Events[i].Desc);
            }

        }
    }
}
