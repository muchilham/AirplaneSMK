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
    public partial class DataBookingDetailFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        tbl_BookingMaster bkm;
        tbl_BookingDetail bkd;
        validasi va;
        String idSchedule;
        public MainForm frm;
        float price;
        double seat2, hargatot;
        int seat, harga, idPlane;

        public DataBookingDetailFrm(String idSchedule)
        {
            InitializeComponent();
            this.idSchedule = idSchedule;
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataBookingDetailFrm(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void load()
        {
            var query = (from b in db.tbl_Schedules
                         where b.id_schedule == idSchedule
                         select b).FirstOrDefault();
            var idBooking = db.ExecuteQuery<decimal>(@"SELECT IDENT_CURRENT('tbl_BookingMaster');", new object[0]).First();
            if (idBooking == 0)
            {
                idBooking = 1;
            }

            else
            {
                idBooking += 1;
            }

            tbIdbooking.Text = idBooking.ToString();
            tbIdschedule.Text = idSchedule;
            tbBookingdate.Text = DateTime.Now.ToString();
            lblTotal.Text = String.Format("{0:C}", query.price);
            hargatot = query.price;

            var query2 = (from s in db.tbl_Schedules
                          join p in db.tbl_Planes
                          on s.id_plane equals p.id_plane
                          where s.id_schedule == tbIdschedule.Text
                          select p.id_plane).FirstOrDefault();
            idPlane = query2;
        }

        private void createButton()
        {
            var query = (from s in db.tbl_Schedules
                         join p in db.tbl_Planes
                             on s.id_plane equals p.id_plane
                         where s.id_schedule == idSchedule
                         select p).FirstOrDefault();
            seat = query.seat_plane / 5;
            //seat2 = Math.Sqrt(seat);
            Button[,] btnArray = new Button[5, seat];
            String[] huruf = new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i < 5; i++)
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel();
                //pnl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                pnl.Dock = DockStyle.Top;
                pnl.Width = this.flowLayoutPanel1.Width - 5;
                pnl.Height = 40;
                this.flowLayoutPanel1.Controls.Add(pnl);
                for (int j = 0; j < seat; j++)
                {
                    btnArray[i, j] = new Button();
                    btnArray[i, j].Name = huruf[i] + "" + (j + 1);
                    btnArray[i, j].Text = huruf[i] + "" + (j + 1);
                    btnArray[i, j].Width = 40;
                    btnArray[i, j].Height = 40;
                    btnArray[i, j].FlatStyle = FlatStyle.Flat;
                    btnArray[i, j].FlatAppearance.BorderSize = 0;
                    btnArray[i, j].Tag = i + "," + j;
                    bkd = db.tbl_BookingDetails.FirstOrDefault(x => x.no_seat == btnArray[i, j].Name);
                    if (bkd == null)
                    {
                        for (int h = 0; h < dgvBookingdetail.RowCount; h++)
                        {
                            if (dgvBookingdetail[5, h].Value.ToString() != btnArray[i, j].Name)
                            {
                                btnArray[i, j].Enabled = true;
                                btnArray[i, j].BackColor = Color.Green;
                            }
                        }
                        btnArray[i, j].BackColor = Color.Green;
                    }

                    else
                    {
                        btnArray[i, j].BackColor = Color.Red;
                        btnArray[i, j].Enabled = false;
                    }

                    pnl.Controls.Add(btnArray[i, j]);
                    btnArray[i, j].Click += new EventHandler(btnArray_Click);
                }
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            Button current = sender as Button;
            String pos = current.Tag.ToString().Split(',')[0];
            bkd = db.tbl_BookingDetails.FirstOrDefault(i => i.no_seat == current.Name);
            if (bkd != null)
            {
                current.BackColor = Color.Red;
                current.Enabled = false;
            }

            else
            {
                if (current.BackColor == Color.Yellow)
                {
                    current.Enabled = false;
                }

                else
                {
                    current.BackColor = Color.Yellow;
                    
                    if (new DataLookUpBooking(tbIdbooking.Text, tbIdschedule.Text, idPlane).ShowDialog() == DialogResult.OK)
                    {
                        dgvBookingdetail.Rows.Add(session.idCustomer, session.customerName, session.idConsumption, session.consumptionName, session.quantity, session.quantity * session.priceConsumption, current.Name);
                        harga = (int)hargatot;
                        for (int i = 0; i < dgvBookingdetail.RowCount; i++)
                        {
                            harga += int.Parse(dgvBookingdetail[5, i].Value.ToString());
                        }

                        lblTotal.Text = String.Format("{0:C}", harga);
                        price = harga;
                    }

                    else
                    {
                        current.BackColor = Color.Green;
                    }
                }
            }
        }

        private void ChooseSeatFrm_Load(object sender, EventArgs e)
        {
            load();
            createButton();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            harga = (int)hargatot;
            int erow = dgvBookingdetail.CurrentCell.RowIndex;
            dgvBookingdetail.Rows.RemoveAt(erow);
            for (int i = 0; i < dgvBookingdetail.RowCount; i++)
            {
                harga += int.Parse(dgvBookingdetail[5, i].Value.ToString());
            }
            createButton();

            lblTotal.Text = String.Format("{0:C}", harga);
            price = harga;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bkm = new tbl_BookingMaster
            {
                date_booking = DateTime.Now,
                id_schedule = tbIdschedule.Text,
                total_price = price
            };

            db.tbl_BookingMasters.InsertOnSubmit(bkm);
            db.SubmitChanges();

            for(int i = 0; i < dgvBookingdetail.RowCount; i++)
            {
                bkd = new tbl_BookingDetail
                {
                    id_booking = bkm.id_booking,
                    id_customer = int.Parse(dgvBookingdetail[0, i].Value.ToString()),
                    no_seat = dgvBookingdetail[6, i].Value.ToString(),
                    id_consumption = int.Parse(dgvBookingdetail[2, i].Value.ToString()),
                    quantity = int.Parse(dgvBookingdetail[4, i].Value.ToString())
                };

                db.tbl_BookingDetails.InsertOnSubmit(bkd);
                db.SubmitChanges();
            }

            MessageBox.Show("Thanks for your booking!\n Happy Fligh", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
