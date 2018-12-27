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
    public partial class DataConsumptionFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Consumption cons;
        int id;
        public DataConsumptionFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataConsumptionFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvConsumption.DataSource = db.tbl_Consumptions.ToList();
            var idconsumption = db.ExecuteQuery<decimal>(@"SELECT IDENT_CURRENT('tbl_Consumption');", new object[0]).First();
            if(idconsumption == 0)
            {
                idconsumption = 1;
            }

            else
            {
                idconsumption += 1;
            }
            tbIdconsumption.Text = idconsumption.ToString();
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdconsumption.Text))
            {
                cons = db.tbl_Consumptions.FirstOrDefault(x => x.id_consumption == int.Parse(tbIdconsumption.Text));
                if(cons != null)
                {
                    tbIdconsumption.Text = cons.id_consumption.ToString();
                    tbNameconsumption.Text = cons.name_consumption;
                    tbPriceconsumption.Text = cons.price_consumption.ToString();
                    btnAdd.Text = "UPDATE";
                }

                else
                {
                    va.clear("tbIdconsumption", 0);
                    btnAdd.Text = "ADD";
                }
            }
        }

        private void aksi(String aksinya)
        {
            cons = aksinya == "insert" ? new tbl_Consumption() : db.tbl_Consumptions.FirstOrDefault(x => x.id_consumption == int.Parse(tbIdconsumption.Text));
            cons.name_consumption = tbNameconsumption.Text;
            cons.price_consumption = int.Parse(tbPriceconsumption.Text);
            if(aksinya == "insert")
            {
                cons.id_consumption = int.Parse(tbIdconsumption.Text);
                db.tbl_Consumptions.InsertOnSubmit(cons);
            }

            db.SubmitChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdconsumption", 0);
        }

        private void tbPriceconsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void dgvConsumption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvConsumption[0, e.RowIndex].Value.ToString());
        }

        private void tbIdconsumption_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void dgvConsumption_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdconsumption.Text = dgvConsumption[0,e.RowIndex].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdconsumption.Text = id.ToString();
        }

        private void DataConsumptionFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Consumptions.Where(x => x.id_consumption == id).Single();
            db.tbl_Consumptions.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            cons = db.tbl_Consumptions.FirstOrDefault(x => x.id_consumption == int.Parse(tbIdconsumption.Text));
            if(cons != null)
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
            va.clear("tbIdconsumption", 0);
        }
    }
}
