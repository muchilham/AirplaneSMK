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
    public partial class DataManageRouteFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Route ro;
        int id, departid, arrivid;
        public DataManageRouteFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataManageRouteFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvManageroute.DataSource = from b in db.tbl_Routes
                                        join c in db.tbl_Places
                                        on b.departure_place equals c.id_place

                                        join d in db.tbl_Places
                                        on b.arrival_place equals d.id_place

                                        select new
                                        {
                                            b.id_route,
                                            DeparturePlace = c.name_place,
                                            ArrivalPlace = d.name_place
                                        };

            var idRoute = db.ExecuteQuery<decimal>(@"SELECT IDENT_CURRENT('tbl_Route');", new object[0]).First();
            if(idRoute == 0)
            {
                idRoute = 1;
            }

            else
            {
                idRoute += 1;
            }

            tbIdroute.Text = idRoute.ToString();
        }

        private void setTextbox()
        {
            ro = db.tbl_Routes.FirstOrDefault(x => x.id_route == int.Parse(tbIdroute.Text));
            if(ro != null)
            {
                tbIdroute.Text = ro.id_route.ToString();

                var depart = (from d in db.tbl_Places where d.id_place == ro.departure_place select d).First();
                tbAirportdeparture.Text = depart.name_place;
                departid = depart.id_place;


                var arriv = (from d in db.tbl_Places where d.id_place == ro.arrival_place select d).First();
                tbAirportarrival.Text = arriv.name_place;
                arrivid = arriv.id_place;

                btnAdd.Text = "UPDATE";
            }

            else
            {
                va.clear("tbIdroute", 0);
                btnAdd.Text = "ADD";
            }
        }

        private void aksi(String aksinya)
        {
            ro = aksinya == "insert" ? new tbl_Route() : db.tbl_Routes.FirstOrDefault(x => x.id_route == int.Parse(tbIdroute.Text));
            ro.departure_place = departid;
            ro.arrival_place = arrivid;

            if(aksinya == "insert")
            {
                ro.id_route = int.Parse(tbIdroute.Text);
                db.tbl_Routes.InsertOnSubmit(ro);
            }

            db.SubmitChanges();
        }

        private void DataManageRouteFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdroute", 0);
        }

        private void dgvManageroute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvManageroute[0, e.RowIndex].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdroute.Text = id.ToString();
        }

        private void dgvManageroute_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdroute.Text = dgvManageroute[0, e.RowIndex].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            ro = db.tbl_Routes.FirstOrDefault(x => x.id_route == int.Parse(tbIdroute.Text));
            if(ro != null)
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
            va.clear("tbIdroute", 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Routes.Where(x => x.id_route == id).Single();
            db.tbl_Routes.InsertOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void btnLookUpdeparture_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Place1", null, 0).ShowDialog() == DialogResult.OK)
            {
                departid = session.departorigin;
                this.tbAirportdeparture.Text = session.namedepart;
            }
        }

        private void btnLookUparrival_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Place2", null, 0).ShowDialog() == DialogResult.OK)
            {
                arrivid = session.arrivorigin;
                this.tbAirportarrival.Text = session.namearriv;
            }
        }
    }
}
