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
    public partial class DataPlaceFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Place pl;
        int id;
        public DataPlaceFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }
        public DataPlaceFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvPlace.DataSource = db.tbl_Places.ToList();
            var idplace = db.ExecuteQuery<decimal>(@"SELECT IDENT_CURRENT('tbl_Place');", new object[0]).First();
            if (idplace < 1)
            {
                idplace = 1;
            }

            else
            {
                idplace += 1;
            }

            tbIdplace.Text = idplace.ToString();
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdplace.Text))
            {
                pl = db.tbl_Places.FirstOrDefault(x => x.id_place == int.Parse(tbIdplace.Text));
                if(pl != null)
                {
                    tbIdplace.Text = pl.id_place.ToString();
                    tbNameplace.Text = pl.name_place;
                    btnAdd.Text = "UPDATE";
                }

                else
                {
                    btnAdd.Text = "ADD";
                    va.clear("tbIdplace", 0);
                }
            }
        }

        private void aksi(String aksinya)
        {
            pl = aksinya == "insert" ? new tbl_Place() : db.tbl_Places.FirstOrDefault(x => x.id_place == int.Parse(tbIdplace.Text));
            pl.name_place = tbNameplace.Text;
            if(aksinya == "insert")
            {
                pl.id_place = int.Parse(tbIdplace.Text);
                db.tbl_Places.InsertOnSubmit(pl);
            }

            db.SubmitChanges();
        }

        private void dgvPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvPlace[0, e.RowIndex].Value.ToString());
        }

        private void dgvPlace_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdplace.Text = dgvPlace[0, e.RowIndex].Value.ToString();
        }

        private void tbIdplace_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdplace.Text = id.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Places.Where(x => x.id_place == id).Single();
            db.tbl_Places.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdplace", 0);
        }

        private void DataPlaceFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            pl = db.tbl_Places.FirstOrDefault(x => x.id_place == int.Parse(tbIdplace.Text));
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
            va.clear("tbIdplace", 0);
        }
    }
}
