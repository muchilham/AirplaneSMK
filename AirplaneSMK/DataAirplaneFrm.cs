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
    public partial class DataAirplaneFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        tbl_Plane pl;
        tbl_Class cl;
        MainForm frm;
        int id, idclass;
        public DataAirplaneFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataAirplaneFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvAirplane.DataSource = from d in db.tbl_Planes
                                     join b in db.tbl_Classes
                                     on d.id_class equals b.id_class
                                     select new
                                     {
                                         d.id_plane,
                                         d.name_plane,
                                         d.seat_plane,
                                         b.name_class
                                     };
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbAirplane.Text))
            {
                pl = db.tbl_Planes.FirstOrDefault(x => x.id_plane == int.Parse(tbAirplane.Text));
                if(pl != null)
                {
                    tbNameplane.Text = pl.name_plane;
                    nupdSeatplane.Value = pl.seat_plane;
                    cl = db.tbl_Classes.FirstOrDefault(x => x.id_class == pl.id_class);
                    tbClassname.Text = cl.name_class;
                    idclass = (int)pl.id_class;
                    btnAdd.Text = "UPDATE";
                }

                else
                {
                    va.clear("tbAirplane", 100);
                    btnAdd.Text = "ADD";
                }
            }
        }

        private void aksi(String aksinya)
        {
            pl = aksinya == "insert" ? new tbl_Plane() : db.tbl_Planes.FirstOrDefault(x => x.id_plane == int.Parse(tbAirplane.Text));
            pl.name_plane = tbNameplane.Text;
            pl.seat_plane = (int)nupdSeatplane.Value;
            pl.id_class = idclass;
            if(aksinya == "insert")
            {
                pl.id_plane = int.Parse(tbAirplane.Text);
                db.tbl_Planes.InsertOnSubmit(pl);
            }

            db.SubmitChanges();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Class", null, 0).ShowDialog() == DialogResult.OK)
            {
                idclass = session.primary;
                this.tbClassname.Text = session.nameprim;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            pl = db.tbl_Planes.FirstOrDefault(x => x.id_plane == int.Parse(tbAirplane.Text));
            if(pl != null)
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
            va.clear("", 100);
        }

        private void tbAirplane_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void DataAirplaneFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvAirplane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvAirplane[0, e.RowIndex].Value.ToString());
        }

        private void tbAirplane_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbAirplane.Text = id.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Planes.Where(x => x.id_plane == id).Single();
            db.tbl_Planes.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void dgvAirplane_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAirplane.Text = dgvAirplane[0, e.RowIndex].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            va.clear("", 100);
        }
    }
}
