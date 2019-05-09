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
    public partial class frmSHIFT : Form
    {
        konekcija.MojaEntities _context { get; set; }

        int SHIFTID;
        int SHIFTIDW;
        int CARDHOLDERID;
        int CARDHOLDERSHIFTID;        

        List<Cardholder> ListCARDHOLDER;
        List<Shift> ListSHIFT;

        public frmSHIFT()
        {
            InitializeComponent();

            _context = new MojaEntities();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back)//&& e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void frmSHIFT_Load(object sender, EventArgs e)
        {

            ListCARDHOLDER = _context.Cardholders.ToList();
            ListSHIFT = _context.Shifts.ToList();

            cboxCARDHOLDER.DataSource = _context.Cardholders.ToList();
            cboxSHIFTNAME.DataSource = _context.Shifts.ToList();
            cboxSHIFTNAMEW.DataSource = _context.Shifts.ToList();
            
            
            cboxCARDHOLDER.Text = "";
            cboxSHIFTNAME.Text = "";
            cboxSHIFTNAMEW.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).Count() == 0)
            {
                SHIFTID = 0;
            }

            if (cboxBREAKTIME.Text == "" || cboxSHIFTNAME.Text == "" || txtWORKINGHOURS.Text == "" || SHIFTID != 0)
            {
                MessageBox.Show("You have missed some info or shift name already exists.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                var i = new Shift();
                i.BreakTime = Convert.ToDecimal(cboxBREAKTIME.Text);
                i.WorkingHours = Convert.ToInt32(txtWORKINGHOURS.Text);
                i.ShiftName = cboxSHIFTNAME.Text;
                i.ShiftMonday = chkMODAY.Checked;
                i.ShiftTuesday = chkTUESDAY.Checked;
                i.ShiftWednesday = chkWEDNESDAY.Checked;
                i.ShiftThuersday = chkTHUERSDAY.Checked;
                i.ShiftFriday = chkFRIDAY.Checked;
                i.ShiftSaturday = chkSATURDAY.Checked;
                i.ShiftSunday = chkSUNDAY.Checked;

                _context.Shifts.AddObject(i);
                _context.SaveChanges();

                MessageBox.Show("New shift has been successfully added", "Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                ListSHIFT = _context.Shifts.ToList();
                shiftBindingSource.DataSource = ListSHIFT;
                workershiftBindingSource.DataSource = ListSHIFT;

                SHIFTID = 0;
                cboxSHIFTNAME.Text = "";
                txtWORKINGHOURS.Text = "";
                cboxBREAKTIME.Text = "";
                chkMODAY.Checked = false;
                chkTUESDAY.Checked = false;
                chkWEDNESDAY.Checked = false;
                chkTHUERSDAY.Checked = false;
                chkFRIDAY.Checked = false;
                chkSATURDAY.Checked = false;
                chkSUNDAY.Checked = false;


            }

        }

        private void cboxSHIFTNAME_SelectedIndexChanged(object sender, EventArgs e)
        {

            var shift = from s in _context.Shifts
                        where s.ShiftName == cboxSHIFTNAME.Text
                        select new
                        {
                            s.ShiftMonday,
                            s.ShiftTuesday,
                            s.ShiftWednesday,
                            s.ShiftThuersday,
                            s.ShiftFriday,
                            s.ShiftSaturday,
                            s.ShiftSunday,
                            s.ShiftID,
                            s.WorkingHours,
                            s.BreakTime
                        };
            foreach (var i in shift)
            {
                chkMODAY.Checked = i.ShiftMonday;
                chkTUESDAY.Checked = i.ShiftTuesday;
                chkWEDNESDAY.Checked = i.ShiftWednesday;
                chkTHUERSDAY.Checked = i.ShiftThuersday;
                chkFRIDAY.Checked = i.ShiftFriday;
                chkSATURDAY.Checked = i.ShiftSaturday;
                chkSUNDAY.Checked = i.ShiftSunday;
                txtWORKINGHOURS.Text = i.WorkingHours.ToString();
                cboxBREAKTIME.Text = (Convert.ToInt32(i.BreakTime)).ToString();
            }

            //var sastavQuery = from s in _context.SASTAVs
            //                  where s.PAMUK == pamuk & s.POLIESTER == poliester & s.POLYACRIL == polyacril & s.LAN == lan & s.VISKOZA == viskoza & s.KOZA == koza & s.VUNA == vuna
            //                  select new { s.IDSASTAV };
            //foreach (var i in sastavQuery)
            //{
            //    IDSASTAV = i.IDSASTAV.ToString();
            //}
        }

        private void btnSAVECHANGE_Click(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).Count() == 0)
            {

            }
            else
            {
                SHIFTID = _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).First();

                try
                {
                    var shiftQuery = _context.Shifts.Where(w => w.ShiftID == SHIFTID).ToList();
                    var shift = shiftQuery[0];

                    shift.ShiftMonday = chkMODAY.Checked;
                    shift.ShiftTuesday = chkTUESDAY.Checked;
                    shift.ShiftWednesday = chkWEDNESDAY.Checked;
                    shift.ShiftThuersday = chkTHUERSDAY.Checked;
                    shift.ShiftFriday = chkFRIDAY.Checked;
                    shift.ShiftSaturday = chkSATURDAY.Checked;
                    shift.ShiftSunday = chkSUNDAY.Checked;
                    shift.ShiftName = cboxSHIFTNAME.Text;
                    shift.WorkingHours = Convert.ToInt32(txtWORKINGHOURS.Text);
                    shift.BreakTime = Convert.ToDecimal(cboxBREAKTIME.Text);

                    _context.SaveChanges();

                    //ListSHIFT = null;
                    //ListSHIFT = _context.Shifts.ToList();

                    MessageBox.Show("Changes are seuccesffully saved!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Changes are not saved. please, contact your administrator.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            //try
            //{
            //    var klijQuery = _context.KLIJENTIs.Where(w => w.IDKLIJENT == IDKLIJENT).ToList();
            //    var klijent = klijQuery[0];

            //    klijent.IMEKLIJENTA = comboBoxNAZIVKLIJENTA.Text.ToString();
            //    klijent.ADRESA = textBoxADRESA.Text.ToString();
            //    klijent.KONTAKT = textBoxKONTAKT.Text.ToString();
            //    klijent.IDTIPKLIJENTA = IDTIPKLIJENTA;
            //    klijent.PDVFIRME = textBoxPDV.Text;
            //    klijent.PIB = textBoxPIB.Text;

            //    _context.SaveChanges();

            //    MessageBox.Show("Uspesno ste sacuvali promene!", "USPESNO",
            //                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //catch
            //{
            //    MessageBox.Show("Promene nisu sacuvane. Molim obratite se administratoru.", "Sacuvaj",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void cboxSHIFTNAME_TextChanged(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).Count() == 0)
            {
                chkMODAY.Checked = false;
                chkTUESDAY.Checked = false;
                chkWEDNESDAY.Checked = false;
                chkTHUERSDAY.Checked = false;
                chkFRIDAY.Checked = false;
                chkSATURDAY.Checked = false;
                chkSUNDAY.Checked = false;
                txtWORKINGHOURS.Text = "";
                cboxBREAKTIME.Text = "";
                cboxSHIFTNAMEW.Text = "";
            }
            else
            {
                var shift = from s in _context.Shifts
                            where s.ShiftName == cboxSHIFTNAME.Text
                            select new
                            {
                                s.ShiftMonday,
                                s.ShiftTuesday,
                                s.ShiftWednesday,
                                s.ShiftThuersday,
                                s.ShiftFriday,
                                s.ShiftSaturday,
                                s.ShiftSunday,
                                s.ShiftID,
                                s.WorkingHours,
                                s.BreakTime
                            };
                foreach (var i in shift)
                {
                    chkMODAY.Checked = i.ShiftMonday;
                    chkTUESDAY.Checked = i.ShiftTuesday;
                    chkWEDNESDAY.Checked = i.ShiftWednesday;
                    chkTHUERSDAY.Checked = i.ShiftThuersday;
                    chkFRIDAY.Checked = i.ShiftFriday;
                    chkSATURDAY.Checked = i.ShiftSaturday;
                    chkSUNDAY.Checked = i.ShiftSunday;
                    txtWORKINGHOURS.Text = i.WorkingHours.ToString();
                    cboxBREAKTIME.Text = (Convert.ToInt32(i.BreakTime)).ToString();
                }

                cboxSHIFTNAMEW.Text = "";
            }
        }

        private void cboxSHIFTNAMEW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).Count() == 0)
            {

            }
            else
            {
                SHIFTIDW = _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).First();
            }
        }

        private void btnASSIGN_Click(object sender, EventArgs e)
        {
            if (_context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).Count() == 0
                || _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).Count() == 0)
            {

            }
            else
            {
                try
                {
                    CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();
                    SHIFTIDW = _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).First();

                    var choldshift = new CardholderShift();

                    choldshift.CardholderID = CARDHOLDERID;
                    choldshift.ShiftID = SHIFTIDW;

                    _context.CardholderShifts.AddObject(choldshift);
                    _context.SaveChanges();


                    MessageBox.Show("You have successfully assigned shift!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Shift is not assigned. Please, contact your administrator.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARDHOLDERSHIFTID = _context.CardholderShifts.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.CardholderShiftID).First();
            if (_context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).Count() == 0)
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();
                string SHIFTNAMEW;
                if (_context.CardholderShifts.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.Shift.ShiftName).Count() == 0)
                {
                    cboxSHIFTNAMEW.Text = "";
                }
                else
                {
                    SHIFTNAMEW = _context.CardholderShifts.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.Shift.ShiftName).First();
                    cboxSHIFTNAMEW.Text = SHIFTNAMEW;
                }

            }

        }
        private void Combo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).Count() == 0)
            {

            }
            else
            {
                SHIFTID = _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAME.Text).Select(s => s.ShiftID).First();


                try
                {
                    var shiftQuery = from i in _context.Shifts
                                     where i.ShiftName == cboxSHIFTNAME.Text
                                     select new { i.ShiftID };
                    foreach (var item in shiftQuery)
                    {
                        SHIFTID = item.ShiftID;
                    }
                    if (SHIFTID == 0)
                    {


                    }
                    else
                    {
                        if (MessageBox.Show("Do you really want to delete shift?", "Delete",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            System.Data.EntityKey shiftsKey = new System.Data.EntityKey("MojaEntities.Shifts", "ShiftID", SHIFTID);
                            var shiftDelete = _context.GetObjectByKey(shiftsKey);
                            _context.DeleteObject(shiftDelete);
                            _context.SaveChanges();


                            MessageBox.Show("You have successfully deleted assigned shift!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            ListSHIFT = null;
                            ListSHIFT = _context.Shifts.ToList();
                            cboxSHIFTNAME.DataSource = _context.Shifts.ToList();
                            cboxSHIFTNAMEW.DataSource = _context.Shifts.ToList();
                            cboxSHIFTNAME.Text = "";
                            cboxSHIFTNAMEW.Text = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Delete operation was not successful. Please, contact your administrator.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            if (_context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).Count() == 0 ||
                _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).Count() == 0)
            {
                
            }
            else
            {
                SHIFTID = _context.Shifts.Where(w => w.ShiftName == cboxSHIFTNAMEW.Text).Select(s => s.ShiftID).First();
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();
                CARDHOLDERSHIFTID = _context.CardholderShifts.Where(w => w.CardholderID == CARDHOLDERID && w.ShiftID == SHIFTIDW).Select(s => s.CardholderShiftID).First();

                try
                {
                    //var shiftQuery = from i in _context.Shifts
                    //                 where i.ShiftName == cboxSHIFTNAME.Text
                    //                 select new { i.ShiftID };
                    //foreach (var item in shiftQuery)
                    //{
                    //    SHIFTID = item.ShiftID;
                    //}
                    if (SHIFTID == 0)
                    {


                    }
                    else
                    {
                        if (MessageBox.Show("Do you really want to remove shift from selected worker?", "Delete",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            
                                CARDHOLDERSHIFTID = _context.CardholderShifts.Where(w => w.CardholderID == CARDHOLDERID && w.ShiftID == SHIFTIDW).Select(s => s.CardholderShiftID).First();

                                System.Data.EntityKey cardholdershiftKey = new System.Data.EntityKey("MojaEntities.CardholderShifts", "CardholderShiftID", CARDHOLDERSHIFTID);
                                var cardholdershiftDelete = _context.GetObjectByKey(cardholdershiftKey);
                                _context.DeleteObject(cardholdershiftDelete);
                                _context.SaveChanges();


                                MessageBox.Show("You have successfully removed shift from selected worker!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                            if (cboxSHIFTNAME.Text != "")
                            {
                                cboxSHIFTNAME.DataSource = _context.Shifts.ToList();
                            }

                                ListSHIFT = null;
                                ListSHIFT = _context.Shifts.ToList();
                               
                                cboxSHIFTNAMEW.DataSource = _context.Shifts.ToList();
                                cboxSHIFTNAME.Text = "";
                                cboxSHIFTNAMEW.Text = "";
                                cboxCARDHOLDER.Text = "";
                            

                            
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Delete operation was not successful. Please, contact your administrator.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxCARDHOLDER_TextChanged(object sender, EventArgs e)
        {
            if (cboxCARDHOLDER.Text == "")
            {
                cboxSHIFTNAMEW.Text = "";
            }
           
        }
    }
}
