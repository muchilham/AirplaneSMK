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
    public partial class DataLookup : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        string tbl, idSchedule;
        int idPlane;
        public DataLookup(string tbl, string idSchedule, int idPlane)
        {
            InitializeComponent();
            this.tbl = tbl;
            this.idSchedule = idSchedule;
            this.idPlane = idPlane;
        }

        private void loadGrid()
        {
            if (tbl == "tbl_Customer")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Customers
                                where d.id_customer.ToString().Contains(tbSearch.Text) || d.name_customer.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Customer2")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = (from d in db.tbl_Schedules
                                 join b in db.tbl_BookingMasters
                                 on d.id_schedule equals b.id_schedule

                                 join bd in db.tbl_BookingDetails
                                 on b.id_booking equals bd.id_booking

                                 join c in db.tbl_Customers
                                 on bd.id_customer equals c.id_customer
                                 where b.id_schedule == idSchedule && d.id_plane == idPlane
                                 select c.id_customer).ToList();

                    var query2 = from c in db.tbl_Customers
                                 where c.id_customer.ToString().Contains(tbSearch.Text)
                                 select c;
                    var data = query2.Where(x => !query.Contains(x.id_customer)).ToList();
                    dgvLookup.DataSource = data;
                }
            }

            if (tbl == "tbl_Consumption")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Consumptions
                                where d.id_consumption.ToString().Contains(tbSearch.Text) || d.name_consumption.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Class")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Classes
                                where d.name_class.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Place1")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Places
                                where d.name_place.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Place2")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Places
                                where d.name_place.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Plane")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Planes
                                where d.name_plane.Contains(tbSearch.Text)
                                select d;
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Transit1")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Routes
                                join p in db.tbl_Places
                                on d.departure_place equals p.id_place

                                join t in db.tbl_Places
                                on d.arrival_place equals t.id_place

                                where p.name_place.Contains(tbSearch.Text) || t.name_place.Contains(tbSearch.Text)
                                select new
                                {
                                    d.id_route,
                                    Departure = p.name_place,
                                    Arrival = t.name_place
                                };
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Transit2")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Routes
                                join p in db.tbl_Places
                                on d.departure_place equals p.id_place

                                join t in db.tbl_Places
                                on d.arrival_place equals t.id_place

                                where p.name_place.Contains(tbSearch.Text) || t.name_place.Contains(tbSearch.Text)
                                select new
                                {
                                    d.id_route,
                                    Departure = p.name_place,
                                    Arrival = t.name_place
                                };
                    dgvLookup.DataSource = query.ToList();
                }
            }

            if (tbl == "tbl_Transit3")
            {
                if (!String.IsNullOrEmpty(tbSearch.Text))
                {
                    var query = from d in db.tbl_Routes
                                join p in db.tbl_Places
                                on d.departure_place equals p.id_place

                                join t in db.tbl_Places
                                on d.arrival_place equals t.id_place

                                where p.name_place.Contains(tbSearch.Text) || t.name_place.Contains(tbSearch.Text)
                                select new
                                {
                                    d.id_route,
                                    Departure = p.name_place,
                                    Arrival = t.name_place
                                };
                    dgvLookup.DataSource = query.ToList();
                }
            }
        }
           
        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvLookup_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tbl == "tbl_Customer")
            {
                session.idCustomer = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.customerName = this.dgvLookup[1, e.RowIndex].Value.ToString();
            }

            if (tbl == "tbl_Customer2")
            {
                session.idCustomer = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.customerName = this.dgvLookup[1, e.RowIndex].Value.ToString();
            }

            if (tbl == "tbl_Consumption")
            {
                session.idConsumption = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.consumptionName = this.dgvLookup[1, e.RowIndex].Value.ToString();
                session.priceConsumption = float.Parse(this.dgvLookup[2, e.RowIndex].Value.ToString());
            }

            if (tbl == "tbl_Place1")
            {
                session.departorigin = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.namedepart = this.dgvLookup[1, e.RowIndex].Value.ToString();
            }

            if (tbl == "tbl_Place2")
            {
                session.arrivorigin = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.namearriv = this.dgvLookup[1, e.RowIndex].Value.ToString();
            }

            if(tbl == "tbl_Plane")
            {
                session.idplane = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.nameplane = this.dgvLookup[1, e.RowIndex].Value.ToString();
            }

            if(tbl == "tbl_Transit1")
            {
                session.transit1 = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.transit1name = this.dgvLookup[1, e.RowIndex].Value.ToString() + " - " + this.dgvLookup[2, e.RowIndex].Value.ToString();
            }

            if (tbl == "tbl_Transit2")
            {
                session.transit2 = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.transit2name = this.dgvLookup[1, e.RowIndex].Value.ToString() + " - " + this.dgvLookup[2, e.RowIndex].Value.ToString();
            }

            if (tbl == "tbl_Transit3")
            {
                session.transit3 = int.Parse(this.dgvLookup[0, e.RowIndex].Value.ToString());
                session.transit3name = this.dgvLookup[1, e.RowIndex].Value.ToString() + " - " + this.dgvLookup[2, e.RowIndex].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
        }

        private void DataLookup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
