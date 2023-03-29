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
    public partial class Form_bin : Form
    {

        public List<Event> odstranene = new List<Event>();
        public List<Event> obnovene = new List<Event>();

        public Form_bin()
        {
            InitializeComponent();
        }

        private void Form_bin_Load(object sender, EventArgs e)
        {
            obnovene.Clear();
            txb_event.Text = "";
            if (odstranene.Count != 0 && odstranene.Count != list_udalosti.Items.Count)
            {
                for (int i = 0; i < odstranene.Count; i++)
                {
                    list_udalosti.Items.Add(odstranene[i].Desc);
                }
            }
        }

        private void list_udalosti_Click(object sender, EventArgs e)
        {
            if (list_udalosti.SelectedIndex == -1) return;
            odstranene[list_udalosti.SelectedIndex].vypsat(txb_event);
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            if (list_udalosti.SelectedIndex == -1) return;
            obnovene.Add(odstranene[list_udalosti.SelectedIndex]);
            odstranene.RemoveAt(list_udalosti.SelectedIndex);
            list_udalosti.Items.RemoveAt(list_udalosti.SelectedIndex);
        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {
            odstranene.Clear();
            list_udalosti.Items.Clear();
            txb_event.Text = "";
        }
    }
}
