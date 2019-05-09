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

            //cardholderBindingSource.DataSource = Lista;
        }
//        void radGridView1_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e) 
//{ 
//    this.radGridView1.GridElement.BeginUpdate(); 
//    foreach (GridViewRowInfo row in this.radGridView1.Rows) 
//    { 
//        row.Cells["Value"].Value = 10; 
//    } 
//    this.radGridView1.GridElement.EndUpdate(); 
//} 
        private void CreateQuery (object sender, EventArgs e)
        {


            Lista1 = _context.AccessLogs.ToList();

            Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime >= dateTimePicker1.Value.Date)
                                       && (i.LocalTime <= dateTimePicker2.Value.Date)
                                       && (i.CardholderID == CARDHOLDERID))).ToList();
            accessLogBindingSource.DataSource = Lista1;
            dgCHECKLIST.DataSource = Lista1;
            

        }
        private void dgCHECKLIST_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e)
        {

            if (dgCHECKLIST.Columns[e.ColumnIndex].Name.Equals("directionDataGridViewTextBoxColumn") &&
                e.RowIndex >= 0 &&
                dgCHECKLIST["directionDataGridViewTextBoxColumn", e.RowIndex].Value is int)
            {
 
                switch ((int)dgCHECKLIST["directionDataGridViewTextBoxColumn", e.RowIndex].Value)
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

                Lista1 = _context.AccessLogs.ToList();

                Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime >= dateTimePicker1.Value.Date)
                                           && (i.LocalTime <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                accessLogBindingSource.DataSource = Lista1;
                dgCHECKLIST.DataSource = Lista1;

            }
            
        }


    }
}
