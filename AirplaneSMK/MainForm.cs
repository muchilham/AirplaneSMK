using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneSMK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void dataCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataCustomerFrm frm = new DataCustomerFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void dataClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataClassFrm frm = new DataClassFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void dataAirplaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataAirplaneFrm frm = new DataAirplaneFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void dataConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataConsumptionFrm frm = new DataConsumptionFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void flightScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataSchedulingFrm frm = new DataSchedulingFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void flightBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataFlightBookingFrm frm = new DataFlightBookingFrm(this);
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void flightPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            //frmUser frm = new frmUser();
            //frm.Show();
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //this.body.Controls.Add(frm);
        }

        private void dataPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataPlaceFrm frm = new DataPlaceFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void manageRouteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.body.Controls.Clear();
            DataManageRouteFrm frm = new DataManageRouteFrm();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }
    }
}
