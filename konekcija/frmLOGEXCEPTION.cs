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
    public partial class frmLOGEXCEPTION : Form
    {
        konekcija.MojaEntities _context;
        
        //List<AccessLog> Lista1;
        //List<Card> Lista2;
        List<LogException> ListaLOGEXCEPTION;


        int CARDHOLDERID;
        // int brojac;
        int? WORKTIME;
        string WORKTIMESTRING;

        public frmLOGEXCEPTION()
        {
            InitializeComponent();
        }

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {

            CARDHOLDERID = 0;
            ListaLOGEXCEPTION = null;


            if (cboxCARDHOLDER.Text == "" || cboxCARDHOLDER.Text == "AccessLog")
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();

                createQueryLOGEXCEPTION();
            }

            // RACUNANJE VREMENA IZ INT

            if (_context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).Count() == 0)
            {

            }
            else
            {
                WORKTIME = _context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).First();
                WORKTIMESTRING = (WORKTIME / 60 + ":" + WORKTIME % 60).ToString();
            }

            createQueryCHKINOUTTRUE();
            createQueryCHKWORKTIMETRUE();

        }

        private void frmEXCEPTION_Load(object sender, EventArgs e)
        {
            _context = new konekcija.MojaEntities();
            cboxCARDHOLDER.DataSource = _context.Cardholders.ToList();
            cboxCARDHOLDER.Text = "";

            ListaLOGEXCEPTION = _context.LogExceptions.ToList();
        }

        private void dgLOGEXCEPTION_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (cboxCARDHOLDER.Text != "")
            {
                var dgridView = (DataGridView)sender;
                foreach (DataGridViewRow row in dgridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var card = (konekcija.LogException)(row.DataBoundItem);
                        var imer = card.Cardholder;

                        row.Cells[gvCARDHOLDER.Index].Value = imer.Name;
                    }
                }
            }
        }
        private void CreateQuery(object sender, EventArgs e)
        {
            if (cboxCARDHOLDER.Text == "")
            {

            }
            else
            {
                if (CARDHOLDERID == 0)
                {
                    ListaLOGEXCEPTION = _context.LogExceptions.ToList();

                    ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(i => ((i.LogExceptionDate >= dateTimePicker1.Value.Date)
                                               && (i.LogExceptionDate <= dateTimePicker2.Value.Date))).ToList();

                    logExceptionBindingSource.DataSource = ListaLOGEXCEPTION;
                    dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                }
                else
                {
                    ListaLOGEXCEPTION = _context.LogExceptions.ToList();

                    ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(i => ((CARDHOLDERID == 0) ? true : (i.LogExceptionDate >= dateTimePicker1.Value.Date)
                                               && (i.LogExceptionDate <= dateTimePicker2.Value.Date)
                                               && (i.CardholderID == CARDHOLDERID))).ToList();

                    logExceptionBindingSource.DataSource = ListaLOGEXCEPTION;
                    dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;                    

                }

                createQueryCHKINOUTTRUE();
                createQueryCHKWORKTIMETRUE();
            }
        }

        private void dgLOGEXCEPTION_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgLOGEXCEPTION.Columns[e.ColumnIndex].Name.Equals("worktimeDataGridViewTextBoxColumn") &&
                e.RowIndex >= 0 &&
                dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value is int)
            {
                int a = (int)dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value;
                e.Value = (a / 60 + ":" + a % 60).ToString();

                if (a < 480)
                {
                    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(255, 255, 0);
                }
            }



            if (dgLOGEXCEPTION.Columns[e.ColumnIndex].Name.Equals("worktimeDataGridViewTextBoxColumn") &&
                e.RowIndex >= 0 &&
                dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value is null)
            {
                string a = (string)dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value;
                e.Value = "ERROR";
                dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(255, 0, 0);
            }
            
        }

        private void chkWORKTIME_CheckedChanged(object sender, EventArgs e)
        {
            // DOBIJANJE PODATAKA IZ BAZE ZA ZADATI EXCEPTION

            if (chkWORKTIME.Checked == true)
            {
                chkIN_OUT.Checked = false;

                if (CARDHOLDERID != -1)
                {
                    if (CARDHOLDERID == 0)
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime < 480).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                    else
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime < 480 && w.CardholderID == CARDHOLDERID).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                }

            }
            else
            {
                createQueryLOGEXCEPTION();
            }

        }

        private void chkIN_OUT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIN_OUT.Checked == true)
            {
                chkWORKTIME.Checked = false;

                if (CARDHOLDERID != -1)
                {
                    if (CARDHOLDERID == 0)
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime == null).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                    else
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime == null && w.CardholderID == CARDHOLDERID).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                }
            }
            else
            {
                createQueryLOGEXCEPTION();
            }
        }
        public void createQueryLOGEXCEPTION ()
        {
            if (CARDHOLDERID == 0)
            {
                ListaLOGEXCEPTION = _context.LogExceptions.ToList();

                ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(i => ((i.LogExceptionDate >= dateTimePicker1.Value.Date)
                                           && (i.LogExceptionDate <= dateTimePicker2.Value.Date))).ToList();

                logExceptionBindingSource.DataSource = ListaLOGEXCEPTION;
                dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;

            }
            else
            {
                ListaLOGEXCEPTION = _context.LogExceptions.ToList();

                ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(i => ((CARDHOLDERID == 0) ? true : (i.LogExceptionDate >= dateTimePicker1.Value.Date)
                                           && (i.LogExceptionDate <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                logExceptionBindingSource.DataSource = ListaLOGEXCEPTION;
                dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
            }
        }

        public void createQueryCHKWORKTIMETRUE()
        {
            if (chkWORKTIME.Checked == true)
            {                
                if (CARDHOLDERID != -1)
                {
                    if (CARDHOLDERID == 0)
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime < 480).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                    else
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime < 480 && w.CardholderID == CARDHOLDERID).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                }

            }
        }
        public void createQueryCHKINOUTTRUE()
        {
            if (chkIN_OUT.Checked == true)
            {                
                if (CARDHOLDERID != -1)
                {
                    if (CARDHOLDERID == 0)
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime == null).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                    else
                    {
                        ListaLOGEXCEPTION = _context.LogExceptions.ToList();
                        ListaLOGEXCEPTION = ListaLOGEXCEPTION.Where(w => w.LogExceptionDate >= dateTimePicker1.Value.Date && w.LogExceptionDate <= dateTimePicker2.Value.Date && w.Worktime == null && w.CardholderID == CARDHOLDERID).ToList();

                        dgLOGEXCEPTION.DataSource = ListaLOGEXCEPTION;
                    }
                }
            }
        }

        private void btnWorkerpresence_Click(object sender, EventArgs e)
        {
            Form frm = new frmCARDHOLDER();
            frm.ShowDialog();
        }
    }
    
}
