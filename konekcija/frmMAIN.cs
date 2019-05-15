using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.IO;

namespace konekcija
{
    public partial class frmMAIN : Form
    {
        //lokacija Access baze
        //ova lokacija se kooristi u fji GetTableNames() kao argumetn OleDbConnection() fje
        //ovdje je trebalo instalirati microsoft Access Database Engine 2010 ali za 32bitni sistem tacnije sa ovog linka :https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255
        const string connectionStringConf = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\ASManager\\ASRes\\ASConfig.mdb;Persist Security Info = False;";
        const string connectionStringLog = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\ASManager\\ASRes\\ASLog.mdb;Persist Security Info = False;";
        const string connectionStringDest = "Data Source = PD1; Initial Catalog=Moja;Integrated Security=SSPI; MultipleActiveResultSets=true;";

        // lista(spisak) tabela u Access bazi, ova lista je nadalje vidljiva i u funkciji koja sakuplja imena tabela GetTableNames();
        List<string> tables = new List<string>();
        SqlConnection destinationConnection;
        OleDbConnection sourceConnection;

        public frmMAIN()
        {
            // inicijalizacija same Forme, svih komponenata
            InitializeComponent();
            //dodavanje Event handlera na klik dugmeta button1
            Button1.Click += new EventHandler(Button1_Click);
        }
        //akcije na klik dugmeta
        private void Button1_Click(object sender, EventArgs e)
        {
            //kada se klikne laabela mjenja ime na Hello, a pojavljuje se poruka sa sadrzajem "zdravo"
            //ovo je radjeno samo zbog testiranja
            //  labela.Text = "Hello ";
            //  labela.Refresh();
            //  MessageBox.Show("zdravo");
            //sakupljanje imena tabela
            tables.Clear();
            GetTableNames(connectionStringConf);
            //komunikacija izmedju dvije baze
            //lokacija za SQL server

            using (sourceConnection = new OleDbConnection(connectionStringConf))
            {
                //otvaranje izvorne baze Access
                sourceConnection.Open();
                //konektovanje na SQL bazu
                using (destinationConnection = new SqlConnection(connectionStringDest))
                {
                    //otvaranje SQL baze
                    destinationConnection.Open();

                    //MessageBox.Show("SQL baza otvorena");
                    foreach (string tbl in tables)
                    {
                        switch (tbl)
                        {
                            case "Cardholder":
                                Cardholder_update(sourceConnection, destinationConnection, tbl);
                                break;
                            case "Card":
                                Card_update(sourceConnection, destinationConnection, tbl);
                                break;
                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                    }
                    sourceConnection.Close();
                    destinationConnection.Close();
                }
            }

            tables.Clear();
            GetTableNames(connectionStringLog);

            using (sourceConnection = new OleDbConnection(connectionStringLog))
            {
                //otvaranje izvorne baze Access
                sourceConnection.Open();
                //konektovanje na SQL bazu
                using (destinationConnection = new SqlConnection(connectionStringDest))
                {
                    //otvaranje SQL baze
                    destinationConnection.Open();

                    MessageBox.Show("SQL baza otvorena");
                    foreach (string tbl in tables)
                    {
                        switch (tbl)
                        {
                            case "AccessLog":
                                Logs_update(sourceConnection, destinationConnection, tbl);
                                MessageBox.Show("AccessLog");
                                break;
                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                    }
                    sourceConnection.Close();
                    destinationConnection.Close();
                }
            }
            InsertAllTables();


        }



        public void InsertAllTables()
        {
            using (destinationConnection = new SqlConnection(connectionStringDest))
            {
                destinationConnection.Open();


                MessageBox.Show("SQL baza otvorena za popunjavanje tabele LogNum");
                var commandDestinationData8 = new SqlCommand("INSERT INTO LogNum (CardholderID,  SumDirection, LogNum, LogDate) SELECT CardholderID, Sum(Direction), Count(CardholderID), CAST(LocalTime AS DATE) FROM AccessLog where CardholderID in (select CardholderId from Cardholder) and not exists(select CardholderID, LogDate from LogNum where LogNum.CardholderID = AccessLog.CardholderID and LogNum.LogDate = Cast(AccessLog.LocalTime As date)) and CAST(AccessLog.LocalTime AS DATE) != CAST(GETDATE() As date) group by CardholderID , CAST(LocalTime AS DATE) order by CAST(LocalTime AS DATE)", destinationConnection);
                commandDestinationData8.ExecuteScalar();

                MessageBox.Show("SQL baza otvorena za popunjavanje tabele TotalTime");
                var commandDestinationData9 = new SqlCommand("Insert Into TotalTime (CardholderID, TotalTime, ActivityDate) Select AccessLog.CardholderID, CAST(MAX(LocalTime) - Min(LocalTime)  AS Time) TotalTime, Cast(LocalTime as Date) from AccessLog where CardholderID in (Select CardholderID from Cardholder) and not exists(select CardholderID, ActivityDate from TotalTime where TotalTime.CardholderID = AccessLog.CardholderID and TotalTime.ActivityDate = Cast(AccessLog.LocalTime As date)) group by CardholderID, CAST(LocalTime As date) Order by CAST(LocalTime As date)", destinationConnection);
                commandDestinationData9.ExecuteScalar();

                MessageBox.Show("SQL baza otvorena za popunjavanje tabele BreakTime");
                var commandDestinationData10 = new SqlCommand("; WITH UserActivityWPairedTimes AS (SELECT Direction, ActivityDate = CAST(LocalTime As DATE), LogOnUser = CardholderID, LogOffUser = Lag(CardholderID, 1) OVER(ORDER BY CardholderID, LocalTime), LogOnActivityTime = LocalTime, LogOffActivityTime = Lag(LocalTime, 1) OVER(ORDER BY CardholderID, LocalTime), LogOnActivityDate = CAST(LocalTime AS DATE), LogOffActivityDate = CAST(Lag(LocalTime, 1) OVER(ORDER BY CardholderID, LocalTime) AS DATE) FROM AccessLog)" +
                    "Insert Into BreakTime(CardholderID, ActivityDate, LogOff, LogOn, BreakTime, LogNum, SumDirection)" +
                    "SELECT LogOnUser CardholderID, ActivityDate, LogOffActivityTime LogOff, LogOnActivityTime LogOn, CONVERT(varchar(12), DATEADD(minute, DATEDIFF(minute, LogOffActivityTime, LogOnActivityTime), 0), 114) BreakTime, LogNum, SumDirection FROM UserActivityWPairedTimes JOIN LogNum On LogOnUser = CardholderID and ActivityDate = LogDate WHERE Direction = 1 AND LogOffActivityTime Is Not Null AND LogOnUser = LogOffUser AND LogOnActivityDate = LogOffActivityDate AND not exists(Select CardholderID, ActivityDate, LogOff, LogOn, BreakTime, LogNum, SumDirection from BreakTime " +
                    "where BreakTime.CardholderID = UserActivityWPairedTimes.LogOnUser and BreakTime.ActivityDate = UserActivityWPairedTimes.ActivityDate and BreakTime.LogOff = UserActivityWPairedTimes.LogOffActivityTime and BreakTime.LogOn = UserActivityWPairedTimes.LogOnActivityTime) ORDER BY CardholderID, ActivityDate", destinationConnection);
                commandDestinationData10.ExecuteScalar();


                var fileContent = File.ReadAllText(@"C:\share\INSERTI.sql");
                var sqlqueries = fileContent.Split(new[] { " GO " }, StringSplitOptions.RemoveEmptyEntries);
                var cmd = new SqlCommand("query", destinationConnection);

                foreach (var query in sqlqueries)
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Unijeto LogException");
                }

                destinationConnection.Close();
                MessageBox.Show("numLog izlaz");

            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frmCARDHOLDER();
            form.ShowDialog();
        }

        private void btnTimeReport_Click(object sender, EventArgs e)
        {
            Form form = new frmLOGEXCEPTION();
            form.ShowDialog();
        }
        public List<string> GetTableNames(string connectionString)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    //shema koja sadrzi imena tabela u Access bazi ,
                    foreach (DataRow r in con.GetSchema("Tables").Select("TABLE_TYPE = 'TABLE'"))
                    {
                        tables.Add(r["TABLE_NAME"].ToString());
                    }
                    con.Close();
                    return tables;

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return tables;
        }

        public void Logs_update(OleDbConnection sourceConnectionLog, SqlConnection destinationConnection, string tbl)
        {

            MessageBox.Show("Logs ulaz");
            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandSourceData1 = new OleDbCommand("Select MAX(LogID) from " + tbl, sourceConnectionLog);
            var commandSourceData2 = new OleDbCommand("Select COUNT(LogID) from " + tbl, sourceConnectionLog);
            int m1 = (int)commandSourceData1.ExecuteScalar();
            int n1 = (int)commandSourceData2.ExecuteScalar();
            //MessageBox.Show("maksimalni " + m1 + " ,broj redova " + n1);

            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandDestinationData1 = new SqlCommand("Select MAX(LogID) from " + tbl, destinationConnection);
            var commandDestinationData2 = new SqlCommand("Select COUNT(LogID) from " + tbl, destinationConnection);
            int n2 = (int)commandDestinationData2.ExecuteScalar();

            //kopiranje
            using (var bulkCopy = new SqlBulkCopy(destinationConnection))
            {
                //ako je tabela u SQL-u NIJE prazna
                //problem -----> ako je prazna ne moze da se nadje maximalni CardholderID
                if (n2 != 0)
                {
                    //ako je prazna ne moze da se nadje maximalni CardholderID , pa se tek sada racuna
                    int m2 = (int)commandDestinationData1.ExecuteScalar();
                    //MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);

                    // ako broj redova NIJE isti i ako je m1 u accessu veci od m2u SQL kopiraju se oni koji su novi
                    if (n1 != n2 && m1 > m2)
                    {
                        //  MessageBox.Show("ima novih logova, kopira se");
                        // iz  access tablel izvlace se podaci(korisnici) koji su novi
                        var commandSourceData = new OleDbCommand("Select LogID, CardCode, CardType  , ControllerID , Direction , LocalTime, CardholderID from " + tbl + " where LogID <=" + @m1 + " and LogID >" + @m2, sourceConnectionLog);

                        // ispisuje se CardholderID koji se dodaje u tabelu
                        var commandSourceData3 = new OleDbCommand("Select LogID from " + tbl + " where LogID <=" + @m1 + "and LogID >" + @m2, sourceConnectionLog);
                        int c = (int)commandSourceData3.ExecuteScalar();
                        MessageBox.Show(" Ubacje se LogID " + c);

                        //cita se iz izvorne Access tabele
                        var reader = commandSourceData.ExecuteReader();
                        //ime tabele u SQL bazi
                        bulkCopy.DestinationTableName = "dbo." + tbl;
                        //pisanje u tabelu
                        try
                        {
                            MessageBox.Show("");
                            bulkCopy.WriteToServer(reader);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally { reader.Close(); }
                    }
                    //brisanje ovdje nije potrebno. ali treba razmotriti slucaj kada vise ne psotji cardholderID,tj kada je izbrisan, zbog relacija
                    // ili podestiri automacko brisanje ili modifikovanje tabele prilikom brisanja Cardholdera
                    else
                    { }
                }
                else
                {
                    //ako je tabela SQL prazna sve kopiramo
                    var commandSourceData = new OleDbCommand("Select LogID, CardCode, CardType, ControllerID, Direction, LocalTime, CardholderID from " + tbl, sourceConnectionLog);
                    var reader = commandSourceData.ExecuteReader();
                    MessageBox.Show("tabela prazna ----> ima novih logova,kopira se");
                    bulkCopy.DestinationTableName = "dbo." + tbl;
                    try { bulkCopy.WriteToServer(reader); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { reader.Close(); }
                }
            }

            MessageBox.Show("Logs izlaz");
            return;

        }

        public void Cardholder_update(OleDbConnection sourceConnection, SqlConnection destinationConnection, string tbl)
        {

            MessageBox.Show("Cardholder ulaz");
            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandSourceData1 = new OleDbCommand("Select MAX(CardholderID) from " + tbl, sourceConnection);
            var commandSourceData2 = new OleDbCommand("Select COUNT(CardholderID) from " + tbl, sourceConnection);
            int m1 = (int)commandSourceData1.ExecuteScalar();
            int n1 = (int)commandSourceData2.ExecuteScalar();
            //MessageBox.Show(" maksimalni " + m1 + " ,broj redova " + n1);

            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandDestinationData1 = new SqlCommand("Select MAX(CardholderID) from " + tbl, destinationConnection);
            var commandDestinationData2 = new SqlCommand("Select COUNT(CardholderID) from " + tbl, destinationConnection);
            int n2 = (int)commandDestinationData2.ExecuteScalar();

            //kopiranje
            using (var bulkCopy = new SqlBulkCopy(destinationConnection))
            {
                //ako je tabela u SQL-u NIJE prazna
                //problem -----> ako je prazna ne moze da se nadje maximalni CardholderID
                if (n2 > 2)
                {
                    //ako je prazna ne moze da se nadje maximalni CardholderID , pa se tek sada racuna
                    int m2 = (int)commandDestinationData1.ExecuteScalar();
                    //MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);

                    // ako broj redova NIJE isti i ako je m1 u accessu veci od m2u SQL kopiraju se oni koji su novi
                    if (m1 > m2)
                    {
                        //MessageBox.Show("ima novih kardholdera,kopira se");
                        // iz  access tablel izvlace se podaci(korisnici) koji su novi
                        var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl + " where CardholderID <=" + @m1 + " and CardholderID >" + @m2, sourceConnection);

                        // ispisuje se CardholderID koji se dodaje u tabelu
                        var commandSourceData3 = new OleDbCommand("Select CardholderID from " + tbl + " where CardholderID <=" + @m1 + "and CardholderID >" + @m2, sourceConnection);
                        int c = (int)commandSourceData3.ExecuteScalar();
                        MessageBox.Show(" Ubacje se CardholderID " + c);

                        //cita se iz izvorne Access tabele
                        var reader = commandSourceData3.ExecuteReader();
                        //ime tabele u SQL bazi
                        bulkCopy.DestinationTableName = "dbo." + tbl;
                        //pisanje u tabelu
                        try { bulkCopy.WriteToServer(reader); }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally { reader.Close(); }
                    }
                    //brisanje
                    else
                    { }
                }
                else
                {
                    //ako je tabela SQL prazna sve kopiramo
                    var commandSourceData = new OleDbCommand("Select CardholderID, Name, FirstName, LastName, Gender from " + tbl, sourceConnection);
                    var reader = commandSourceData.ExecuteReader();
                    MessageBox.Show("tabela prazna ----> ima novih kardholdera,kopira se");
                    bulkCopy.DestinationTableName = "dbo." + tbl;
                    try { bulkCopy.WriteToServer(reader); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { reader.Close(); }
                }
            }

            if (n2 != 0)
            {
                int m2 = (int)commandDestinationData1.ExecuteScalar();
                //MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);
                if (n1 < n2)
                {
                    // lista  je lista cardholderID-a iz SQL baze
                    SqlDataReader rdr = null;
                    List<int> lista = new List<int>();
                    var commandDestinationData3 = new SqlCommand("Select CardholderID from " + tbl, destinationConnection);
                    rdr = commandDestinationData3.ExecuteReader();
                    while (rdr.Read())
                    {
                        // MessageBox.Show(" "+rdr[0]);
                        lista.Add(rdr.GetInt32(0));
                    }
                    // sourceLista je lista  CardholderId iz Access baze
                    OleDbDataReader Sourcerdr = null;
                    List<int> sourceLista = new List<int>();
                    var commandSourceData3 = new OleDbCommand("Select CardholderID from " + tbl, sourceConnection);
                    Sourcerdr = commandSourceData3.ExecuteReader();
                    while (Sourcerdr.Read())
                    {
                        // MessageBox.Show(" "+rdr[0]);
                        sourceLista.Add(Sourcerdr.GetInt32(0));
                    }
                    //for (int i = 0; i < sourceLista.Count; i++)
                    //MessageBox.Show(" " + sourceLista[i]);

                    //svi oni koji su izbrisani iz access baze, tj oni kojih ima u sql ali ne u access,oni se posle brisu, izuzetak je CardholderID=-1 i CardholderID=0 jer on je za neregistrovane korisnike kartica
                    var firstNotSecond = lista.Except(sourceLista).ToList();
                    //MessageBox.Show(" proslo");
                    //var commandDestinationData4= new SqlCommand("Select * from "+tbl, destinationConnection);
                    Sourcerdr.Close();

                    //MessageBox.Show(" proslo");
                    SqlDataReader rdr1 = null;
                    for (int i = 0; i < firstNotSecond.Count; i++)
                    {
                        if (firstNotSecond[i] != -1 && firstNotSecond[i] != 0)
                        {
                            MessageBox.Show(" " + firstNotSecond[i]);
                            int n = (int)firstNotSecond[i];
                            var command = new SqlCommand("Delete from " + tbl + " where CardholderID=" + @firstNotSecond[i], destinationConnection);
                            try
                            {
                                rdr1 = command.ExecuteReader();
                                MessageBox.Show("successfully data Deleted", "user information");
                                while (rdr1.Read())
                                { }
                            }
                            catch (Exception ec)
                            {
                                MessageBox.Show(ec.Message);
                            }
                        }
                        else { }
                    }
                }
                else { }
            }
            else { }

            MessageBox.Show("Cardholder izlaz");
            return;
        }

        public void Card_update(OleDbConnection sourceConnection, SqlConnection destinationConnection, string tbl)
        {

            MessageBox.Show("Card ulaz");
            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandSourceData1 = new OleDbCommand("Select MAX(CardID) from " + tbl, sourceConnection);
            var commandSourceData2 = new OleDbCommand("Select COUNT(CardID) from " + tbl, sourceConnection);
            int m1 = (int)commandSourceData1.ExecuteScalar();
            int n1 = (int)commandSourceData2.ExecuteScalar();
            //MessageBox.Show(" maksimalni " + m1 + " ,broj redova " + n1);

            // m1 je maximalni CardholderID a n1 je broj redova u Access tabeli Cardholder
            var commandDestinationData1 = new SqlCommand("Select MAX(CardID) from " + tbl, destinationConnection);
            var commandDestinationData2 = new SqlCommand("Select COUNT(CardID) from " + tbl, destinationConnection);
            int n2 = (int)commandDestinationData2.ExecuteScalar();

            //kopiranje
            using (var bulkCopy = new SqlBulkCopy(destinationConnection))
            {
                //ako je tabela u SQL-u NIJE prazna
                //problem -----> ako je prazna ne moze da se nadje maximalni CardholderID
                if (n2 != 0)
                {
                    //ako je prazna ne moze da se nadje maximalni CardholderID , pa se tek sada racuna
                    int m2 = (int)commandDestinationData1.ExecuteScalar();
                    //MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);

                    // ako broj redova NIJE isti i ako je m1 u accessu veci od m2u SQL kopiraju se oni koji su novi
                    if (n1 != n2 && m1 > m2)
                    {
                        MessageBox.Show("ima novih kartica, kopira se");
                        // iz  access tablel izvlace se podaci(korisnici) koji su novi
                        var commandSourceData = new OleDbCommand("Select CardID, CardholderID, CardNo, CardNoInt from" + tbl + " where CardID <=" + @m1 + " and CardID >" + @m2, sourceConnection);

                        // ispisuje se CardholderID koji se dodaje u tabelu
                        var commandSourceData3 = new OleDbCommand("Select CardID from " + tbl + " where CardID <=" + @m1 + "and CardID >" + @m2, sourceConnection);
                        int c = (int)commandSourceData3.ExecuteScalar();
                        MessageBox.Show(" Ubacje se CardID " + c);

                        //cita se iz izvorne Access tabele
                        var reader = commandSourceData3.ExecuteReader();
                        //ime tabele u SQL bazi
                        bulkCopy.DestinationTableName = "dbo." + tbl;
                        //pisanje u tabelu
                        try { bulkCopy.WriteToServer(reader); }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally { reader.Close(); }
                    }
                    //brisanje
                    else
                    { }
                }
                else
                {
                    //ako je tabela SQL prazna sve kopiramo
                    var commandSourceData = new OleDbCommand("Select CardID, CardNo, CardNoIntCode, CardholderID from " + tbl, sourceConnection);
                    var reader = commandSourceData.ExecuteReader();
                    MessageBox.Show("tabela prazna ----> ima novih kartica,kopira se");
                    bulkCopy.DestinationTableName = "dbo." + tbl;
                    try { bulkCopy.WriteToServer(reader); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { reader.Close(); }
                }
            }

            if (n2 != 0)
            {
                int m2 = (int)commandDestinationData1.ExecuteScalar();
                MessageBox.Show(" maksimalni " + m2 + " ,broj redova " + n2);
                if (n1 < n2)
                {
                    // lista  je lista cardholderID-a iz SQL baze
                    SqlDataReader rdr = null;
                    List<int> lista = new List<int>();
                    var commandDestinationData3 = new SqlCommand("Select CardID from " + tbl, destinationConnection);
                    rdr = commandDestinationData3.ExecuteReader();
                    while (rdr.Read())
                    {
                        // MessageBox.Show(" "+rdr[0]);
                        lista.Add(rdr.GetInt32(0));
                    }
                    // sourceLista je lista  CardholderId iz Access baze
                    OleDbDataReader Sourcerdr = null;
                    List<int> sourceLista = new List<int>();
                    var commandSourceData3 = new OleDbCommand("Select Card from " + tbl, sourceConnection);
                    Sourcerdr = commandSourceData3.ExecuteReader();
                    while (Sourcerdr.Read())
                    {
                        // MessageBox.Show(" "+rdr[0]);
                        sourceLista.Add(Sourcerdr.GetInt32(0));
                    }
                    //for (int i = 0; i < sourceLista.Count; i++)
                    //MessageBox.Show(" " + sourceLista[i]);

                    //svi oni koji su izbrisani iz access baze, tj oni kojih ima u sql ali ne u access,oni se posle brisu, izuzetak je CardholderID=-1 jer on je za neregistrovane korisnike kartica
                    var firstNotSecond = lista.Except(sourceLista).ToList();
                    MessageBox.Show(" proslo");
                    //var commandDestinationData4= new SqlCommand("Select * from "+tbl, destinationConnection);
                    Sourcerdr.Close();

                    MessageBox.Show(" proslo");
                    SqlDataReader rdr1 = null;
                    for (int i = 0; i < firstNotSecond.Count; i++)
                    {
                        if (firstNotSecond[i] != -1)
                        {
                            MessageBox.Show(" " + firstNotSecond[i]);
                            int n = (int)firstNotSecond[i];
                            var command = new SqlCommand("Delete from " + tbl + " where CardID=" + @firstNotSecond[i], destinationConnection);
                            try
                            {
                                rdr1 = command.ExecuteReader();
                                MessageBox.Show("successfully data Deleted", "user information");
                                while (rdr1.Read())
                                { }
                            }
                            catch (Exception ec)
                            {
                                MessageBox.Show(ec.Message);
                            }
                        }
                        else { }
                    }
                }
                else { }
            }
            else { }

            MessageBox.Show("Card izlaz");
            return;
        }

        private void btnLEAVEREQUEST_Click(object sender, EventArgs e)
        {
            Form form = new frmHOLIDAY();
            form.ShowDialog();
        }

        private void btnSHIFT_Click(object sender, EventArgs e)
        {
            Form frm = new frmSHIFT();
            frm.ShowDialog();
        }
    }
}
