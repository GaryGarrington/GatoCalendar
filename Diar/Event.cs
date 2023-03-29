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
    public class Event
    {
        public string Desc;
        public DateTime Start;
        public DateTime End;
        public int Priority;
        public bool AllDay;
        public bool Deleted;

        public Event()
        {
            Desc = "Nová událost";
            Start = DateTime.Now;
            End = Start + TimeSpan.FromHours(1);
            Priority = 1;
            AllDay = false;
            Deleted = false;
        }

        public Event(string User_desc, DateTime User_start)
        {
            Desc = User_desc;
            Start = User_start;
            End = Start + TimeSpan.FromHours(1);
            Priority = 1;
            AllDay = false;
            Deleted = false;
        }

        public Event(string User_desc, DateTime User_start, DateTime User_end, int User_priority, bool User_allday)
        {
            Desc = User_desc;
            Start = User_start;
            End = User_end;
            Priority = User_priority;
            AllDay = User_allday;
            Deleted = false;
        }
        /// <summary>
        /// Vypíše vlastnosti do textboxu
        /// </summary>
        /// <param name="txb">
        /// Textbox, do kterého se vlastnosti vypíší
        /// </param>
        public void vypsat(TextBox txb)
        {
            List<string> list = new List<string>
            {
                "nízká", "střední", "vysoká"
            };
            string text;
            string priorita = list[Priority];
            string celodenni = (AllDay) ? "ano" : "ne";
            text = $"{Desc}\r\nZačátek: {Start}\r\nKonec: {End}\r\nPriorita: {priorita}\r\nCelodenní: {celodenni}";
            txb.Text = text;
        }

        /// <summary>
        /// Pokusí se přiřadit událost k odpovídajícímu dni
        /// </summary>
        /// <param name="list">
        /// list dní, ve kterých se hledá odpovídající den
        /// </param>
        /// <returns>
        /// true: Událost byla přiřazena ke dni
        /// false: Den nebyl nalezen, událost nebyla přiřazena
        /// </returns>
        public bool priradit(List<Day> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Start.Date == list[i].Date)
                {
                    list[i].Events.Add(this);
                    return true;
                }
            }
            return false;
        }
    }
}
