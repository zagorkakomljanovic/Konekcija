using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konekcija
{
    public partial class frmNONWORKINGDAYS : Form
    {

        konekcija.MojaEntities _context;

        int CARDHOLDERID;
        int bud;

        List<Cardholder> Lista;


        public frmNONWORKINGDAYS()
        {
            InitializeComponent();
        }

        private void frmNONWORKINGDAYS_Load(object sender, EventArgs e)
        {
            _context = new konekcija.MojaEntities();            

            Lista = _context.Cardholders.ToList();

            cardholderBindingSource.DataSource = Lista;
            cboxCARDHOLDER.Text = "";

        }

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
            if (cboxCARDHOLDER.Text == "")
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();
               

                if (_context.NonWorkingDays.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.TotalNWD).Count() == 0)
                {
                    txtTOTAL.Text = "";
                }
                else
                {                                     
                    txtTOTAL.Text = _context.NonWorkingDays.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.TotalNWD).First().ToString();
                }

            }
        }

        private void txtTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back)//&& e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (cboxCARDHOLDER.Text =="")
            {

            }
            else
            {
                try
                {
                    bud = _context.Cardholders.Where(w => w.Name == txtTOTAL.Text).Select(s => s.CardholderID).First();

                    var i = new NonWorkingDay();
                    i.CardholderID = CARDHOLDERID;
                    i.TotalNWD = Convert.ToInt32(txtTOTAL.Text);
                    _context.NonWorkingDays.AddObject(i);
                    _context.SaveChanges();
                    

                    MessageBox.Show("Number of non-working days are successfully added.", "Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please try again.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }              
                

                cboxCARDHOLDER.Text = "";
                txtTOTAL.Text = "";

            }
        }
    }
}
