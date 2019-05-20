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

        int? WORKTIME;
        string WORKTIMESTRING;

        List<Cardholder> Lista;
        List<AccessLog> Lista1;
        List<Card> Lista2;
        List<LogException> Lista3;

        public int CARDHOLDERID;        

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

        private void CreateQuery (object sender, EventArgs e)
        {
            if (cboxCARDHOLDER.Text == "")
            {

            }
            else
            {
                Lista1 = _context.AccessLogs.ToList();

                Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime >= dateTimePicker1.Value.Date)
                                           && (i.LocalTime <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                Lista3 = Lista3.Where(i => ((CARDHOLDERID == 0) ? true : (i.LogExceptionDate >= dateTimePicker1.Value.Date)
                           && (i.LogExceptionDate <= dateTimePicker2.Value.Date)
                           && (i.CardholderID == CARDHOLDERID))).ToList();

                accessLogBindingSource.DataSource = Lista1;
                dgCHECKLIST.DataSource = Lista1;
            }
            

            if (_context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID).Select(s => s.Worktime).Count() == 0)
            {

            }
            else
            {
                if (_context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).Count() == 0)
                {
                    txtWORKTIME.Text = "";
                }
                else
                {
                    WORKTIME = _context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).First();
                    WORKTIMESTRING = (WORKTIME / 60 + ":" + WORKTIME % 60).ToString();

                    txtWORKTIME.Text = WORKTIMESTRING;
                }
                
            }
        }
        private void dgCHECKLIST_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e)
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

            if (dgCHECKLIST.Columns[e.ColumnIndex].Name.Equals("TotalWorktime")) {
                var a= dgCHECKLIST["localTime", e.RowIndex].Value ;
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

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
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
                if (_context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).Count() == 0)
                {

                }
                else
                {

                    Lista3 = Lista3.Where(i => ((CARDHOLDERID == 0) ? true : (i.LogExceptionDate >= dateTimePicker1.Value.Date)
                               && (i.LogExceptionDate <= dateTimePicker2.Value.Date)
                               && (i.CardholderID == CARDHOLDERID))).ToList();

                    WORKTIME = _context.LogExceptions.Where(w => w.CardholderID == CARDHOLDERID && w.LogExceptionDate == dateTimePicker1.Value.Date).Select(s => s.Worktime).First();
                    WORKTIMESTRING = (WORKTIME / 60 + ":" + WORKTIME % 60).ToString();

                    txtWORKTIME.Text = WORKTIMESTRING;
                }
            }            
        }

        public class AccessLogReport
        {
            public int cardholderid { get; set; }
            public string name { get; set; }
            public string worktime { get; set; }
            public string date { get; set; }
            public int? IN { get; set; }
            public int? OUT { get; set; }
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            //List<AccessLog> ListaREP = _context.AccessLogs.Where(w => w.CardholderID == CARDHOLDERID && w.LocalTime >= dateTimePicker1.Value.Date && w.LocalTime <= dateTimePicker2.Value.Date).Select(s =>
            //new AccessLogReport
            //{
            //    name = s.Cardholder.Name,
            //    IN = s.Direction,
            //    OUT = s.Direction,
            //    date = Convert.ToString(s.LocalTime),
            //    worktime = WORKTIMESTRING,
            //}).ToList();

            //frmREPORT frmREPORT = new frmREPORT(ListaREP, "Nesto12345", "Nesto1234567890");
            //frmREPORT.ShowDialog();

        }
    }
}
