using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ledenkaart_Verzender
{
   class Importer
    {

        readonly Logger log = new Logger();
        readonly FileChecker checkIt = new FileChecker();

        public int numberOfMainMember; // used to store the main insured member
        public int numberOfMembers; // used to count the number of members
        public int maxCountMembers; // used to store the biggest count of members 

        public int ImportedMembers = 0;
        public int ImportedMembersSkipped = 0;
        public int ImportedMainMembers = 0;
        public int ImportedMainMembersSkipped = 0;

        public String Adres = "";
        public String location = "";
        public DataTableCollection tableCollection;

        public static List<AdresCard> adresList;
        public static List<Member> memberList;
        public static List<AdresCard> adresSkippedList;
        public static List<Member> memberSkippedList;

        private int NumberOfSkippedMemberInList = 0;
        private int NumberOfImportedMemberInList = 0;


        public bool SetFileToDataGrid()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })

            {
                if (checkIt.FileNotInUse(openFileDialog))
                {

                    if (openFileDialog.FileName != "")
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                            }
                        }
                        log.LogMessageToFile("Bestand wordt ingelezen.\n");
                        return true;
                    }

                    return false;
                }

                else
                {
                    return false;
                }
            }
        }

        public Tuple<int, int> DataGridToArray()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            maxCountMembers = 0;
            int i = 0;

            if (checkIt.AreAllCollumnsPresent(tableCollection))
            {

                adresList = new List<AdresCard>();
                memberList = new List<Member>();
                adresSkippedList = new List<AdresCard>();
                memberSkippedList = new List<Member>();


                foreach (DataRow row in tableCollection[0].Rows)
                {
                    Adres = "";
                    location = "";

                    if (row["Hoofdbewoner"].ToString() == "ja")
                    {

                        numberOfMembers = 0;
                        numberOfMainMember = int.Parse(row["LidNummer"].ToString());

                        // add data to the "Good" list if data is correct
                        if (checkIt.IsNothingMissing(tableCollection, numberOfMainMember))
                        {

                            Adres = row["Adres"].ToString();
                            location = row["Plaats"].ToString();

                            foreach (DataRow row1 in tableCollection[0].Rows)
                            {
                                if (row1["Adres"].ToString() == Adres &&
                                    row1["Plaats"].ToString() == location)
                                {
                                    memberList.Add(new Member()
                                    {
                                        MainMemberNr = numberOfMainMember,
                                        MemberNr = int.Parse(row1["LidNummer"].ToString()),
                                        Gender = row1["Geslacht"].ToString(),
                                        Initials = row1["Voorletters"].ToString(),
                                        FirstName = row1["Voornaam"].ToString(),
                                        SurName = row1["Naam"].ToString(),
                                        Infix = row1["Tussenvoegsel"].ToString(),
                                        BirthDay = DateTime.Parse(row1["Geboortedatum"].ToString()),
                                        DiscountPercentage = int.Parse(row1["Percentage Ledenkorting"].ToString()),
                                        IBAN = row1["IBAN"].ToString(),
                                        TypeOfMember = row1["Soort lid"].ToString(),
                                        AddresIndex = i,
                                    });

                                    numberOfMembers++;

                                }
                            }

                            adresList.Add(new AdresCard()
                            {
                                MainMemberNr = numberOfMainMember,
                                Adres = Adres,
                                Initials = row["Voorletters"].ToString(),
                                Infix = row["Tussenvoegsel"].ToString(),
                                SurName = row["Naam"].ToString(),
                                Location = location,
                                Postcode = row["Postcode"].ToString(),
                                EmailAdres = row["E-Mail"].ToString(),
                                PhoneNumber = row["Telefoon"].ToString(),
                                MobileNumber = row["Mobiel"].ToString(),
                                Gender = row["Geslacht"].ToString(),
                                TotalMembersOnAdres = numberOfMembers
                            });

                        }

                        // add data to the Skipped Lists
                        else
                        {

                            Adres = row["Adres"].ToString();
                            location = row["Plaats"].ToString();

                            foreach (DataRow row1 in tableCollection[0].Rows)
                            {
                                if (row1["Adres"].ToString() == Adres &&
                                    row1["Plaats"].ToString() == location)
                                {

                                    memberSkippedList.Add(new Member()
                                    {
                                        MainMemberNr = numberOfMainMember,
                                        MemberNr = int.Parse(row1["LidNummer"].ToString()),
                                        Gender = row1["Geslacht"].ToString(),
                                        Initials = row1["Voorletters"].ToString(),
                                        FirstName = row1["Voornaam"].ToString(),
                                        SurName = row1["Naam"].ToString(),
                                        Infix = row1["Tussenvoegsel"].ToString(),
                                        BirthDay = DateTime.Parse(row1["Geboortedatum"].ToString()),
                                        DiscountPercentage = int.Parse(row1["Percentage Ledenkorting"].ToString()),
                                        IBAN = row1["IBAN"].ToString(),
                                        TypeOfMember = row1["Soort lid"].ToString(),
                                        AddresIndex = i,
                                    });

                                }
                            }

                            adresSkippedList.Add(new AdresCard()
                            {
                                MainMemberNr = numberOfMainMember,
                                Adres = Adres,
                                Initials = row["Voorletters"].ToString(),
                                Infix = row["Tussenvoegsel"].ToString(),
                                SurName = row["Naam"].ToString(),
                                Location = location,
                                Postcode = row["Postcode"].ToString(),
                                EmailAdres = row["E-Mail"].ToString(),
                                PhoneNumber = row["Telefoon"].ToString(),
                                MobileNumber = row["Mobiel"].ToString(),
                                Gender = row["Geslacht"].ToString(),
                                TotalMembersOnAdres = numberOfMembers
                            });
                        }

                    }
                }

                memberList.Sort((x, y) => x.BirthDay.CompareTo(y.BirthDay));
                ImportedMembers = memberList.Count;
                ImportedMembersSkipped = memberSkippedList.Count;
                ImportedMainMembers = adresList.Count;
                ImportedMainMembersSkipped = adresSkippedList.Count;
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Stopwatch.StartNew();

            MessageBox.Show("In totaal zijn/is er " + ImportedMembers + " lid/leden ingelezen.\nIn totaal worden er " + ImportedMainMembers + " mail(s) verzonden.", "Importeer resultaat");

            if (ImportedMainMembersSkipped > 0)
            {

                MessageBox.Show("Let op!, niet alle leden zijn ingelezen.","Attentie");

            }

            log.LogMessageToFile(ImportedMainMembers + " hoofdbewonders ingelezen.");
            log.LogMessageToFile(ImportedMembers + " gezinsleden ingelezen.");
            log.LogMessageToFile(ImportedMainMembersSkipped + " hoofdbewoners niet ingelezen.");
            log.LogMessageToFile(ImportedMembersSkipped + " gezinsleden niet ingelezen.");
            log.LogMessageToFile("Importeren duurde: " + ts + ".\n\n");

            return Tuple.Create(ImportedMainMembers, ImportedMembers);
        }

        public int ShowSkippedMembers(bool next)
        {

            if (next)
            {
                if ((adresSkippedList.Count - 1) == NumberOfSkippedMemberInList)
                { NumberOfSkippedMemberInList = 0; }
                else
                    NumberOfSkippedMemberInList++;
            }

            else
            {

                if (NumberOfSkippedMemberInList != 0)
                {
                    NumberOfSkippedMemberInList--;
                }

                else { NumberOfSkippedMemberInList = (adresSkippedList.Count - 1); }

            }


            return NumberOfSkippedMemberInList;


        }
        public int ShowImportedMembers(bool next)
        {

            if (next)
            {
                if ((adresList.Count - 1) == NumberOfImportedMemberInList)
                { NumberOfImportedMemberInList = 0; }
                else
                    NumberOfImportedMemberInList++;
            }

            else
            {

                if (NumberOfImportedMemberInList != 0)
                {
                    NumberOfImportedMemberInList--;
                }

                else { NumberOfImportedMemberInList = adresList.Count - 1; }

            }


            return NumberOfImportedMemberInList;


        }
        public static DataTable ConvertToDatatable(List<Member> list, int a)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Lidnummer");
            dt.Columns.Add("Naam");
            dt.Columns.Add("Geboortedatum");
            dt.Columns.Add("M/V");
            dt.Columns.Add("IBAN");
            dt.Columns.Add("Ledenkorting");
            dt.Columns.Add("Soort Lid");

            foreach (var item in list)
            {
                if (a == item.MainMemberNr)
                {

                    var row = dt.NewRow();

                    row["Lidnummer"] = item.MemberNr;
                    row["Naam"] = (item.Initials +" ("+item.FirstName+") "+ item.Infix + " "+ item.SurName);
                    row["Geboortedatum"] = item.BirthDay.ToString("dd-MM-yyyy");
                    row["M/V"] = item.Gender;
                    row["IBAN"] = item.IBAN;
                    row["Ledenkorting"] = item.DiscountPercentage;
                    row["Soort Lid"] = item.TypeOfMember;

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
}

