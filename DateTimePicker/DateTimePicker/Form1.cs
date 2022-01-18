using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            DateTime datum = dtpDatum.Value;
            DateTime vrijeme = dtpVrijeme.Value;

            StringBuilder ispis = new StringBuilder();
            ispis.Append("Vaš datum leta je: ");
            ispis.Append(datum.ToShortDateString()+Environment.NewLine);
            ispis.Append("Vaše vrijeme polaska je: ");
            ispis.Append(vrijeme.ToShortTimeString());

            string ispis2 = "Vaš datum leta je: "
                + datum.ToShortDateString()
                + Environment.NewLine + "Vaše vrijeme polaska je: "
                + vrijeme.ToShortTimeString();

            txtIspis.Text = ispis.ToString();
            txtIspis.AppendText(Environment.NewLine + ispis2);
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
