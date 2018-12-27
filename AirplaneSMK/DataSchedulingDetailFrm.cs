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
    public partial class DataSchedulingDetailFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        String idSchedule;
        public MainForm frm;
        public DataSchedulingDetailFrm(String idSchedule)
        {
            InitializeComponent();
            this.idSchedule = idSchedule;
        }

        public DataSchedulingDetailFrm(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void loadGrid()
        {
            var query = from d in db.tbl_Schedules
                        join p in db.tbl_Planes
                        on d.id_plane equals p.id_plane

                        join pl1 in db.tbl_Places
                        on d.departure_origin equals pl1.id_place

                        join pl2 in db.tbl_Places
                        on d.arrival_origin equals pl2.id_place
                        where d.id_schedule == idSchedule
                        select new
                        {
                            IDSchedule = d.id_schedule,
                            Planename = p.name_plane,
                            DepartOrigin = pl1.name_place,
                            ArrivalOrigin = pl2.name_place,
                            Price = d.price,
                            Date = d.date,
                            ArrivalDate = d.arrival_date
                        };


            foreach (var b in query)
            {
                this.groupBox1.Text = b.IDSchedule;
                this.lblplane.Text = b.Planename;
                this.lblDate.Text += "\n" + b.Date.ToString();
                this.lblArrivaldate.Text += "\n" + b.ArrivalDate.ToString();
                this.lblDepartureArrival.Text = b.DepartOrigin + " - " + b.ArrivalOrigin;
                this.lblPrice.Text = String.Format("{0:C}", b.Price);
                this.lblDate.Text = b.Date.ToString();

                var det = (from m in db.tbl_Schedules
                           join n in db.tbl_ScheduleDetails
                               on m.id_schedule equals n.id_schedule

                           join r in db.tbl_Routes
                           on n.id_route equals r.id_route

                           join pl1 in db.tbl_Places
                           on r.departure_place equals pl1.id_place

                           join pl2 in db.tbl_Places
                           on r.arrival_place equals pl2.id_place
                           where m.id_schedule == b.IDSchedule
                           select new
                           {
                               Departure = pl1.name_place,
                               Arrival = pl2.name_place
                           });
                foreach (var t in det)
                {
                    this.lblTransit.Text += "\n" + t.Departure + " - " + t.Arrival;
                }
            }
        }

        private void DataSchedulingDetailFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.frm.body.Controls.Clear();
            DataBookingDetailFrm fr = new DataBookingDetailFrm(this.groupBox1.Text);
            fr.frm = this.frm;
            fr.Show();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.frm.body.Controls.Add(fr);
        }
    }
}
