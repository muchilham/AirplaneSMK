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
    public partial class DataClassFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Class cl;
        int id;
        public DataClassFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataClassFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvClass.DataSource = db.tbl_Classes.ToList();
            var idclass = db.ExecuteQuery<decimal>(@"SELECT IDENT_CURRENT('tbl_Class');", new object[0]).First();
            if (idclass == 0)
            {
                idclass = 1;
            }

            else
            {
                idclass += 1;
            }
            tbIdclass.Text = idclass.ToString();
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdclass.Text))
            {
                cl = db.tbl_Classes.FirstOrDefault(x => x.id_class == int.Parse(tbIdclass.Text));
                if(cl != null)
                {
                    tbIdclass.Text = cl.id_class.ToString();
                    tbNameclass.Text = cl.name_class;
                    tbPriceclass.Text = cl.price_class.ToString();
                    btnAdd.Text = "UPDATE";
                }

                else
                {
                    va.clear("tbIdclass", 0);
                    btnAdd.Text = "ADD";
                }
            }
        }

        private void aksi(String aksinya)
        {
            cl = aksinya == "insert" ? new tbl_Class() : db.tbl_Classes.FirstOrDefault(x => x.id_class == int.Parse(tbIdclass.Text));
            cl.name_class = tbNameclass.Text;
            cl.price_class = int.Parse(tbPriceclass.Text);
            if(aksinya == "insert")
            {
                cl.id_class = int.Parse(tbIdclass.Text);
                db.tbl_Classes.InsertOnSubmit(cl);
            }

            db.SubmitChanges();
        }

        private void tbPriceclass_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbIdclass_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            cl = db.tbl_Classes.FirstOrDefault(x => x.id_class == int.Parse(tbIdclass.Text));
            if(cl != null)
            {
                aksi("Update");
                message = "Update";
            }

            else
            {
                aksi("insert");
                message = "Insert";
            }

            MessageBox.Show(message + " data success!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadGrid();
            va.clear("tbIdclass", 0);
        }

        private void DataClassFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdclass.Text = dgvClass[0, e.RowIndex].Value.ToString();
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvClass[0, e.RowIndex].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Classes.Where(x => x.id_class == id).Single();
            db.tbl_Classes.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdclass.Text = id.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdclass", 0);
        }


    }
}
