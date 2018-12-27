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
    public partial class DataFlightBookingFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        MainForm frm;
        int tot;
        public DataFlightBookingFrm()
        {
            InitializeComponent();
        }

        public DataFlightBookingFrm(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void usArrayDetail_Click(object sender, EventArgs e)
        {
            var current = sender as Button;
            new DataSchedulingDetailFrm(current.Name).ShowDialog();
        }

        private void usArrayBooking_Click(object sender, EventArgs e)
        {
            var current = sender as Button;
            //new DataBookingDetailFrm(current.Name).ShowDialog();
        }

        private void dataSchedule()
        {
            cbDepartorigin.DataSource = from b in db.tbl_Places orderby b.name_place ascending select b;
            cbDepartorigin.DisplayMember = "name_place";
            cbDepartorigin.ValueMember = "id_place";

            cbArrivalorigin.DataSource = from b in db.tbl_Places orderby b.name_place ascending select b;
            cbArrivalorigin.DisplayMember = "name_place";
            cbArrivalorigin.ValueMember = "id_place";
            dtpDate.MinDate = DateTime.Now;
        }

        private void DataFlightBookingFrm_Load(object sender, EventArgs e)
        {
            dataSchedule();
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            int i = 0;
            var query = from d in db.tbl_Schedules
                        join p in db.tbl_Planes
                        on d.id_plane equals p.id_plane

                        join pl1 in db.tbl_Places
                        on d.departure_origin equals pl1.id_place

                        join pl2 in db.tbl_Places
                        on d.arrival_origin equals pl2.id_place
                        where d.departure_origin == int.Parse(cbDepartorigin.SelectedValue.ToString()) && d.arrival_origin == int.Parse(cbArrivalorigin.SelectedValue.ToString()) && d.date > dtpDate.Value
                        select new
                        {
                            IDSchedule = d.id_schedule,
                            Planename = p.name_plane,
                            DepartOrigin = pl1.name_place,
                            ArrivalOrigin = pl2.name_place,
                            Price = d.price,
                            DepartureDate = d.date,
                            ArrivalDate = d.arrival_date,
                        };


            tot = query.Count();
            UserControl1[] usArray = new UserControl1[tot];
            foreach (var b in query)
            {
                usArray[i] = new UserControl1(this.frm);
                usArray[i].Width = flowLayoutPanel1.Width - 5;
                usArray[i].groupBox1.Text = b.IDSchedule;
                usArray[i].lblplane.Text = b.Planename;
                usArray[i].lblDepartureArrival.Text = b.DepartOrigin + " - " + b.ArrivalOrigin;
                usArray[i].lblPrice.Text = String.Format("{0:C}", b.Price);
                usArray[i].lblDate.Text = b.DepartureDate.ToString() + " - " + b.ArrivalDate.ToString();
                usArray[i].btnBooking.Name = b.IDSchedule;
                usArray[i].btnDetail.Name = b.IDSchedule;
                usArray[i].btnBooking.Click += new EventHandler(this.usArrayBooking_Click);
                usArray[i].btnDetail.Click += new EventHandler(this.usArrayDetail_Click);
                this.flowLayoutPanel1.Controls.Add(usArray[i]);
                i++;
            }

        }

    }
}
