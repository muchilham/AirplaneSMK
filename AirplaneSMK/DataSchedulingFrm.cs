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
    public partial class DataSchedulingFrm: Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Schedule sch;
        tbl_ScheduleDetail schd;
        UserControl2[] us = new UserControl2[3];
        string primary, id;
        public DataSchedulingFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }
        public DataSchedulingFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvSchedule.DataSource = (from b in db.tbl_Schedules
                                      join r in db.tbl_Places
                                      on b.departure_origin equals r.id_place

                                      join d in db.tbl_Places
                                      on b.arrival_origin equals d.id_place

                                      join p in db.tbl_Planes
                                      on b.id_plane equals p.id_plane

                                      select new
                                      {
                                          IDSchedule = b.id_schedule,
                                          NamePlane = p.name_plane,
                                          DepartureOrigin = r.name_place,
                                          ArrivalOrigin = d.name_place,
                                          TotalSeat = b.total_seat,
                                          DepartureDate = b.date,
                                          ArrivalDate = b.arrival_date,
                                          Price = b.price
                                      }).ToList();
            if (db.tbl_Schedules.Count() > 0)
            {
                var setPrimary = from d in
                                     (from d in db.tbl_Schedules
                                      select new
                                      {
                                          Column1 = (int?)Convert.ToInt32(d.id_schedule.Substring(4, (int)d.id_schedule.Length)),
                                          Dummy = "x"
                                      })
                                 group d by new { d.Dummy } into g
                                 select new
                                 {
                                     kode = (int?)g.Max(p => p.Column1 + 1)
                                 };
                foreach (var v in setPrimary)
                {
                    primary = "0000" + v.kode.ToString();
                    primary = primary.Substring(primary.Length - 5, 5);
                    primary = "SCH-" + primary;
                }
            }

            else
            {
                primary = "SCH-00001";
            }

            tbIdschedule.Text = primary;

            nupTotalseat.Minimum = 100;
        }

        private void setTextbox()
        {
            int i = 0;
            var set = (from b in db.tbl_Schedules
                           join r in db.tbl_Places
                           on b.departure_origin equals r.id_place

                           join d in db.tbl_Places
                           on b.arrival_origin equals d.id_place

                           join p in db.tbl_Planes
                           on b.id_plane equals p.id_plane

                           where b.id_schedule == tbIdschedule.Text
                           select new
                           {
                               b.id_schedule,
                               p.id_plane,
                               p.name_plane,
                               IDDepart = r.id_place,
                               DepartureOrigin = r.name_place,
                               IDArriv = d.id_place,
                               ArrivalOrigin = d.name_place,
                               b.total_seat,
                               b.date,
                               ArrivalDate = b.arrival_date,
                               b.price
                           }).FirstOrDefault();

            var det = (from y in db.tbl_Schedules
                      join g in db.tbl_ScheduleDetails
                      on y.id_schedule equals g.id_schedule

                      join t in db.tbl_Routes
                      on g.id_route equals t.id_route

                      join p in db.tbl_Places
                      on t.departure_place equals p.id_place

                      join u in db.tbl_Places
                      on t.arrival_place equals u.id_place
                      where y.id_schedule == set.id_schedule
                      select new
                      {
                          Transit = t.id_route,
                          TransiName = p.name_place + " - " + u.name_place
                      });

            if(set != null)
            {
                tbIdschedule.Text = set.id_schedule;
                tbIdplane.Text = set.id_plane.ToString();
                tbNameplane.Text = set.name_plane;
                tbDepartureorigin.Text = set.IDDepart.ToString();
                tbDeparturename.Text = set.DepartureOrigin;
                tbArrivalorigin.Text = set.IDArriv.ToString();
                tbArrivalname.Text = set.ArrivalOrigin;
                dtpDeparturedate.Value = set.date;
                tbPrice.Text = set.price.ToString();
                foreach(var tr in det)
                {
                    us[i].textBox1.Text = tr.Transit.ToString();
                    us[i].textBox2.Text = tr.TransiName.ToString();
                    i++;
                }

                btnAdd.Text = "UPDATE";
            }

            else
            {
                va.clear("tbIdschedule", 100);
                btnAdd.Text = "ADD";


                //for (int g = 0; g < 3; i++)
                //{
                //    us[g].textBox1.Text = "";
                //    us[g].textBox2.Text = "";
                //}
            }
        }

        private void aksi(String aksinya)
        {
            sch = aksinya == "insert" ? new tbl_Schedule() : db.tbl_Schedules.FirstOrDefault(x => x.id_schedule == tbIdschedule.Text);
            sch.price = float.Parse(tbPrice.Text);
            sch.total_seat = (int)nupTotalseat.Value;
            sch.date = dtpDeparturedate.Value;
            sch.id_plane = int.Parse(tbIdplane.Text);
            sch.departure_origin = int.Parse(tbDepartureorigin.Text);
            sch.arrival_origin = int.Parse(tbArrivalorigin.Text);
            sch.arrival_date = dtpArrivaldate.Value;
            if(aksinya == "insert")
            {
                sch.id_schedule = tbIdschedule.Text;
                db.tbl_Schedules.InsertOnSubmit(sch);
                db.SubmitChanges();
            }

            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrEmpty(us[i].textBox1.Text))
                {
                    schd = db.tbl_ScheduleDetails.FirstOrDefault(x => x.id_schedule == tbIdschedule.Text && x.id_route == int.Parse(us[i].textBox1.Text));
                    if(schd != null)
                    {
                        schd.id_route = int.Parse(us[i].textBox1.Text);
                        db.SubmitChanges();
                    }
                }
            }

            db.SubmitChanges();

        }
        private void us_Click(object sender, EventArgs e)
        {
            var current = sender as UserControl2;
            if (current.btnTransit1.Name == "1")
            {
                if (new DataLookup("tbl_Transit" + current.btnTransit1.Name, null, 0).ShowDialog() == DialogResult.OK)
                {
                    current.textBox1.Text = session.transit1.ToString();
                    current.textBox2.Text = session.transit1name;
                    
                }
            }

            else if (current.btnTransit1.Name == "2")
            {
                if (new DataLookup("tbl_Transit" + current.btnTransit1.Name, null, 0).ShowDialog() == DialogResult.OK)
                {
                    current.textBox1.Text = session.transit2.ToString();
                    current.textBox2.Text = session.transit2name;
                }
            }

            else
            {
                if (new DataLookup("tbl_Transit" + current.btnTransit1.Name, null, 0).ShowDialog() == DialogResult.OK)
                {
                    current.textBox1.Text = session.transit3.ToString();
                    current.textBox2.Text = session.transit3name;
                }
            }

        }

        private void createTextbox()
        {
            for(int i = 0; i < 3; i++)
            {
                us[i] = new UserControl2();
                us[i].label1.Text = "Transit" + (i + 1);
                us[i].label1.Name = "Transit" + (i + 1);
                us[i].label2.Text = "Name Airpot";
                us[i].label2.Name = "Airpot" + (i + 1);
                us[i].textBox1.Name = "tbTransit" + (i + 1);
                us[i].textBox1.ReadOnly = true;
                us[i].textBox2.Name = "Airpot" + (i + 1);
                us[i].textBox2.Enabled = false;
                us[i].btnTransit1.Name = (i + 1).ToString();
                us[i].ButtonClick += new EventHandler(us_Click); 
                this.flowLayoutPanel2.Controls.Add(us[i]);
            }

        }
        private void DataSchedulingFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
            createTextbox();
        }

        private void btnPlane_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Plane", null,0).ShowDialog() == DialogResult.OK)
            {
                tbIdplane.Text = session.idplane.ToString();
                tbNameplane.Text = session.nameplane;
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Place1", null, 0).ShowDialog() == DialogResult.OK)
            {
                tbDepartureorigin.Text = session.departorigin.ToString();
                tbDeparturename.Text = session.namedepart;
            }
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Place2", null, 0).ShowDialog() == DialogResult.OK)
            {
                tbArrivalorigin.Text = session.arrivorigin.ToString();
                tbArrivalname.Text = session.namearriv;
            }
        }

        private void tbIdplane_TextChanged(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(tbIdplane.Text))
            //{
            //    var q = (from b in db.tbl_Planes
            //             join c in db.tbl_Classes
            //             on b.id_class equals c.id_class
            //             where b.id_plane == int.Parse(tbIdplane.Text)
            //             select new
            //             {
            //                 Seat = b.seat_plane,
            //                 Price = c.price_class
            //             }).FirstOrDefault();
            //    nupTotalseat.Value = q.Seat;
            //    tbPrice.Text = q.Price.ToString();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            sch = db.tbl_Schedules.FirstOrDefault(x => x.id_schedule == tbIdschedule.Text);
            if(sch != null)
            {
                aksi("update");
                message = "Update";
            }

            else
            {
                aksi("insert");
                message = "Insert";
            }

            MessageBox.Show(message + " data success!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadGrid();
            va.clear("tbIdschedule", 100);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdschedule.Text = id;
            nupTotalseat.Enabled = true;
        }

        private void tbIdschedule_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvSchedule[0, e.RowIndex].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdschedule", 100);

            for(int i = 0; i < 3; i++)
            {
                us[i].textBox1.Text = "";
                us[i].textBox2.Text = "";
            }
        }

        private void dgvSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdschedule.Text = dgvSchedule[0, e.RowIndex].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Schedules.Where(x => x.id_schedule == id).Single();
            db.tbl_Schedules.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }
    }
}
