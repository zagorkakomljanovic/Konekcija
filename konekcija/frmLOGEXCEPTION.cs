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
        
        List<LogException> ListaLOGEXCEPTION;
        List<AccessLog> Lista1, ListaACCESSLOG;
        int? DIRECT;
        DateTime DATUM1;
        DateTime DATUM2;
        int WORKTIMESUM;
        int indikator;


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

            dgLogDetails.Visible = false;

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
            Lista1 = _context.AccessLogs.ToList();
            //dgLogDetails.DataSource = Lista1;
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
                DataGridViewRow row = this.dgLOGEXCEPTION.Rows[e.RowIndex];
                var b = Convert.ToInt16(row.Cells["ExcIN_OUT"].Value);

                if ((a < 480 && a>0 && b==0)||(b==1))
                {
                    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if(b==2)
                {
                    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(255, 0, 0);
                }
                else
                    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(0, 255, 0);

            }

            //if (dgLOGEXCEPTION.Columns[e.ColumnIndex].Name.Equals("worktimeDataGridViewTextBoxColumn") &&
            //    e.RowIndex >= 0 &&
            //    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value is null)
            //{
            //    string a = (string)dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Value;
            //    e.Value = "ERROR";
            //    dgLOGEXCEPTION["worktimeDataGridViewTextBoxColumn", e.RowIndex].Style.BackColor = Color.FromArgb(255, 0, 0);
            //}

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
        

        private void dgLOGEXCEPTION_CellClick(object sender, DataGridViewCellEventArgs e) {
            
            if (dgLOGEXCEPTION.CurrentCell == null ||  e.RowIndex == -1) return;


            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgLOGEXCEPTION.Rows[e.RowIndex];

                   
                    var a = row.Cells["LogExceptionDate"].Value;
                    string c = a.ToString();
                    DateTime x = Convert.ToDateTime(c);
                    dgLogDetails.DataSource = null;
                    Lista1.Clear();
                    Lista1 = _context.AccessLogs.ToList();
                    Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime.Value.Date == x.Date) && (i.CardholderID == CARDHOLDERID))).ToList();
                    dgLogDetails.DataSource = Lista1;
                    dgLogDetails.Visible = true;
            }

        }
        private void dgLogDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgLogDetails.Columns[e.ColumnIndex].Name.Equals("direction") && e.RowIndex >= 0 && dgLogDetails["direction", e.RowIndex].Value is int)
            {

                switch ((int)dgLogDetails["direction", e.RowIndex].Value)
                {
                    case 2:

                        e.Value = "OUT";
                        e.FormattingApplied = true;
                        break;
                    case 1:
                        e.Value = "IN";
                        e.FormattingApplied = true;
                        break;
                }
            }
            if (dgLogDetails.Columns[e.ColumnIndex].Name.Equals("localTime") &&
                e.RowIndex >= 0 )
            {
                var a = dgLogDetails["localTime", e.RowIndex].Value;
                string c = a.ToString();
                DateTime x = Convert.ToDateTime(c);
                e.Value = x.ToLongTimeString();

            }

        }

        private void btnWorkerpresence_Click(object sender, EventArgs e)
        {
            Form frm = new frmCARDHOLDER();
            frm.ShowDialog();
        }

        private void LogDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // RACUNANJE AKTIVNOG VREMENA NA POSLU

            WORKTIMESUM = 0;
            DIRECT = _context.AccessLogs.Where(w => w.LocalTime >= dateTimePicker1.Value.Date && w.LocalTime <= dateTimePicker2.Value.Date && w.CardholderID == CARDHOLDERID).Select(s => s.Direction).First();

            if (DIRECT == 1)
            {

                ListaACCESSLOG = _context.AccessLogs.Where(w => w.LocalTime >= dateTimePicker1.Value.Date && w.LocalTime <= dateTimePicker2.Value.Date && w.CardholderID == CARDHOLDERID).ToList();

                foreach (var item in ListaACCESSLOG)
                {
                    //   DIRECT = item.Direction;
                    if (item.Direction == 1)
                    {
                        indikator = 0;
                        DATUM1 = item.LocalTime.Value;
                    }
                    else
                    {
                        if (indikator == 1)
                        {

                        }
                        else
                        {
                            DATUM2 = item.LocalTime.Value;
                            TimeSpan timeSpan = DATUM2 - DATUM1;

                            WORKTIMESUM += Convert.ToInt32(timeSpan.TotalMinutes);

                            var queryLogException = _context.LogExceptions.Where(w => w.LogExceptionDate == dateTimePicker1.Value.Date && w.CardholderID == CARDHOLDERID).ToList();
                            var i = queryLogException[0];
                            i.Worktime = WORKTIMESUM;

                            _context.SaveChanges();

                            indikator = 1;
                        }
                    }
                }
            }
        }
    }
    
}
