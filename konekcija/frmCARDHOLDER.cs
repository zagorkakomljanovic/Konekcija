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
    public partial class frmCARDHOLDER : Form
    {


        konekcija.MojaEntities _context { get; set; }

        List<Cardholder> Lista;
        List<AccessLog> Lista1;
        List<Card> Lista2;
        List<LogException> Lista3;

        int CARDHOLDERID;
        int? WORKTIMEINT;
        string WORKTIME;


        public frmCARDHOLDER()
        {
            InitializeComponent();

            _context = new konekcija.MojaEntities();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _context = new konekcija.MojaEntities();

            cboxCARDHOLDER.DataSource = _context.Cardholders.ToList();
            cboxCARDHOLDER.Text = "";

            // dgCHECKLIST.DataSource = _context.AccessLogs.ToList();           

            Lista2 = _context.Cards.ToList();
            Lista1 = _context.AccessLogs.ToList();
            Lista = _context.Cardholders.ToList();
            Lista3 = _context.LogExceptions.ToList();

            //cardholderBindingSource.DataSource = Lista;
        }

        private void CreateQuery()
        {
            if (cboxCARDHOLDER.Text == ""
                || dateTimePicker1.Value.Date >= System.DateTime.Now.Date)
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();

                Lista1 = _context.AccessLogs.ToList();

                Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime >= dateTimePicker1.Value.Date)
                                           && (i.LocalTime <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                accessLogBindingSource.DataSource = Lista1;
                dgCHECKLIST.DataSource = Lista1;

            }
        }
        private void QueryButtonEnable()
        {
            if (cboxCARDHOLDER.Text == "" || CARDHOLDERID == 0)
            {
                btnPRINT.Enabled = false;
            }
            else
            {
                btnPRINT.Enabled = true;
            }

        }

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
            CreateQuery();

        }

        public class AccessLogReport
        {
            public int? cardholderid { get; set; }
            public string name { get; set; }
            public string worktime { get; set; }
            public DateTime date { get; set; }
            public int? checkIN { get; set; }
            public int? checkOUT { get; set; }
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            if (CARDHOLDERID == 0 || cboxCARDHOLDER.Text == "" || cboxCARDHOLDER.Text == "All")
            {

            }
            else
            {
                WORKTIMEINT = _context.LogExceptions.Where(j => j.LogExceptionDate >= dateTimePicker1.Value.Date && j.LogExceptionDate <= dateTimePicker2.Value.Date && j.CardholderID == CARDHOLDERID).Select(s => s.Worktime).First();
                WORKTIME = (WORKTIMEINT / 60 + ":" + WORKTIMEINT % 60).ToString();



                List<AccessLogReport> ListaREP = _context.AccessLogs.Where(w => w.CardholderID == CARDHOLDERID && w.LocalTime >= dateTimePicker1.Value.Date && w.LocalTime <= dateTimePicker2.Value.Date).Select(s =>
                new AccessLogReport
                {
                    name = s.Cardholder.Name,
                    checkIN = s.Direction,
                    checkOUT = s.Direction,
                    date = s.LocalTime.Value,
                    worktime = WORKTIME

                }).ToList();

//                frmREPORT frmREPORT = new frmREPORT(ListaREP, "Check IN/OUT report");
//                frmREPORT.ShowDialog();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CreateQuery();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CreateQuery();

        }

        private void dgCHECKLIST_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgCHECKLIST.Columns[e.ColumnIndex].Name.Equals("direction") &&
               e.RowIndex >= 0 &&
               dgCHECKLIST["direction", e.RowIndex].Value is int)
            {

                switch ((int)dgCHECKLIST["direction", e.RowIndex].Value)
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

            if (dgCHECKLIST.Columns[e.ColumnIndex].Name.Equals("TotalWorktime"))
            {
                var a = dgCHECKLIST["localTime", e.RowIndex].Value;
                string c = a.ToString();
                DateTime x = Convert.ToDateTime(c);
                if (_context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == x.Date).Select(s => s.Worktime).Count() == 0)
                {

                }
                else
                {
                    int? b = _context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == x.Date).Select(s => s.Worktime).First();
                    string z = (b / 60 + ":" + b % 60).ToString();
                    e.Value = z;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFIRM_Click(object sender, EventArgs e)
        {
            //            Form frmCARDHOLDERFIRM = new frmCARDHOLDERFIRM();
            //            frmCARDHOLDERFIRM.ShowDialog();
        }

    }
}
