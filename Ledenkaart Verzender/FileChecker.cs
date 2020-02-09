using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ledenkaart_Verzender
{
    class FileChecker
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();


        Logger log = new Logger();
        int errors;

        public bool FileNotInUse(OpenFileDialog openFileDialog)
        {

            errors = 0;
               {
                   if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (FileStream stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            log.LogMessageToFile("Proberen bestand --> " + openFileDialog.FileName + " in te lezen");
                            stream.Close();
                        }
                    }
                    catch (IOException)
                    {
                        //the file is unavailable because it is:
                        //still being written to
                        //or being processed by another thread
                        //or does not exist (has already been processed)

                        MessageBox.Show("Bestand is al in gebruik. Graag eerst bestand afsluiten");

                        log.LogMessageToFile("Bestand is reeds in gebruik");

                        errors++;
                    }
                }
            }

            if (errors == 0) { return true; }
            else return false;
        }

        public bool AreAllCollumnsPresent(DataTableCollection tableCollection) {

            string[] columnNames = {"Lidnummer","Naam","Tussenvoegsel","Voorletters","Voornaam","Geslacht","Aanhef","Adres","Postcode"
                                        ,"Plaats","Telefoon","Mobiel","E-mail","IBAN","Geboortedatum","Percentage Ledenkorting","Soort lid"};

            foreach (var item in columnNames)
            {

                if (!tableCollection[0].Columns.Contains(item.ToString())) {

                    MessageBox.Show("Kolom: " + item.ToString() + " ontbreekt!" );

                    log.LogMessageToFile("Kolom: " + item.ToString() + " ontbreekt!");
                    errors++;

                } ;

            }

            if (errors == 0) {

                log.LogMessageToFile("Alle kolommen aanwezig");
                
                return true; }

            return false;
        }

        public bool IsNothingMissing(DataTableCollection tableCollection, int MainMember)
        {

            errors = 0;
            foreach (DataRow row1 in tableCollection[0].Rows)
            {
                if (int.Parse(row1["LidNummer"].ToString()) == MainMember)
                {
                    if (row1["E-Mail"].ToString().Equals(""))
                    {
                        errors++;
                        log.LogMessageToFile("Email adres van lidnummer: " + MainMember + " ontbreekt");
                    }
                }
            }
            if (errors == 0) return true;
            else return false;
        }
    }
}
