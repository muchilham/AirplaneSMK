using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneSMK
{
    public partial class UserControl1 : UserControl
    {
        public MainForm frm;


        public UserControl1(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.frm.body.Controls.Clear();
            DataBookingDetailFrm fr = new DataBookingDetailFrm(this.groupBox1.Text);
            fr.Show();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.frm.body.Controls.Add(fr);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DataSchedulingDetailFrm fr = new DataSchedulingDetailFrm(this.groupBox1.Text);
            fr.ShowDialog();
        }
    }
}
